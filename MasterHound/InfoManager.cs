using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Xml.Linq;
using MasterHound.Naive;
using System.Windows.Forms;

namespace MasterHound
{
    public class InfoManager
    {
        private Bayes bayes;
        private static InfoManager instance;
        private static int MaxDownload;
        static WebCrawler crawler;
        public List<ArticleInfo> Articles;
        public static List<string> IDs;
        static int nextDownloads;
        public static string query;
        public string[] KeyWords;
        public static int ArticleIndex;
        public static bool FreeFullText;
       
        public int tmpIndex;
        public int tmpMax;
        static Thread thread;
        public bool IsLoadingIndexes;

        public static InfoManager Instance
        {
            get {
                if (instance == null)
                    instance = new InfoManager();

                return InfoManager.instance; 
            }
            set { InfoManager.instance = value; }
        }
        
        public InfoManager()
        {
            Init();
        }

        private void Init()
        {
            crawler             = new WebCrawler(this);
            IDs                 = new List<string>();
            Articles            = new List<ArticleInfo>();
            MaxDownload         = 100;
            this.tmpIndex       = 0;
            IsLoadingIndexes    = false;
            bayes               = new Bayes();
        }

        public int CountMissingEvaluations()
        {
            return InfoManager.Instance.Articles.Count(x => x.ArticleStatus != ARTICLE_STATUS.EVALUATED); 
        }

        public void ProcessIDsRetrieval(string query,int index, int maxDownload, bool freeFullText)
        {            
            InfoManager.query       = query;
            KeyWords                = InfoManager.query.Split(new string[] { K.SPACE }, StringSplitOptions.RemoveEmptyEntries);
            FreeFullText            = freeFullText;
            tmpIndex                = index;
            MaxDownload             = maxDownload;
            ArticleIndex            = 0;

            FileManager.SaveQuery(query);//saves the query into the text file
            if (KeyWords.Length > 0)
            {
                thread = new Thread(RunIDQuery);
                thread.Start();
            }
        }

        private void RunIDQuery()
        {
            if (!WebCrawler.client.IsBusy)
            {
                LoadAnimation.IsRunning     = true;
                IsLoadingIndexes            = true;
                nextDownloads               = 0;

                crawler.WebQuery(QueryCreator.PubMedIDsQuery(KeyWords, tmpIndex, K.MAX_ID_RETRIEVER, FreeFullText));
            }
        }

        public List<string> CleanIDs(List<string> IDs)
        {
            HashSet<string> uniqueID;

            uniqueID    = new HashSet<string>(IDs);                    // eliminates redundancy of ids

            return new List<string>(uniqueID.ToArray());
        }
        
        private void ProcessPUBMED_IDS(XDocument doc, string hashQuery)
        {
            XElement tmp;
            StringBuilder sb;
            List<XElement> ID_List;
            List<string> queryIDList;

            queryIDList = new List<string>();
            sb          = new StringBuilder();
            tmp         = XMLParser.RetrieveElement(doc.Root, K.COUNT_ID, null);    //  retrieved total of IDs for query
            ID_List     = doc.Root.Element(K.ID_LIST).Elements(K.ID).ToList();      //  retrieved ID list

            if (int.Parse(tmp.Value) < K.MAX_ID_RETRIEVER)                          //  less than max allowed to retrieve
            {
                if (ID_List.Count > 0)
                {
                    for (int r = 0; r < ID_List.Count; r++)
                    {               
                        queryIDList.Add(ID_List[r].Value);                          // each ID in the xml
                    }

                    IDs = CleanIDs(queryIDList);                                    // make global available 

                    if (IDs.Count < MaxDownload)
                        MaxDownload = IDs.Count;

                    FileManager.SaveQueryIDs(hashQuery, IDs);                       //  HERE WE SAVE IDs for EACH QUERY

                    crawler.WebQuery(QueryCreator.PubMedArticleInfoQuery(IDs[ArticleIndex]));  //  Start processing IDs
                                                                                               //  lets start one by one
                }
                else
                    LoadAnimation.IsRunning = false;
            }

            IsLoadingIndexes = false;
        }

        public void ContinueDownload(int maxDownload)
        {
            nextDownloads           = 0;
            MaxDownload             = maxDownload;
            LoadAnimation.IsRunning = true;

            thread = new Thread(FindNextArticleToDownload);
            thread.Start();
        }

        private void FindNextArticleToDownload()
        {
            //POPS next missing article
            while (Articles.Exists(x => x.ID == IDs[ArticleIndex]))
            {
                if (ArticleIndex < IDs.Count - 1)
                    ArticleIndex++;
                else
                    break;
            }

            //2.- Generate and execute next query only if id hasn´t been downloaded
            if (ArticleIndex < IDs.Count-1 && nextDownloads < MaxDownload) //
            {
                Thread.Sleep(200);// Manual says no more than 5 queries per second
                crawler.WebQuery(QueryCreator.PubMedArticleInfoQuery(IDs[ArticleIndex]));
            }
            else
            {//quizás agregar mensaje estático dado el thread para avisar errores
                LoadAnimation.IsRunning = false;
                Articles = Articles.OrderByDescending(o => o.id).ToList();
            }
        }
                        
        private void ProcessArticleInfo(XDocument doc)// -------------------------------------
        {
            //1.- Retrieve all about the ArticleInfo
            ArticleInfo tmp;
            
            tmp = XMLParser.RetrieveArticleInfo(IDs[ArticleIndex], doc.Root);

            if (!Articles.Exists(x => x.id == tmp.id))//for now it WONT OVER write it if exists
            {
                AddArticleInfo(tmp);
                FileManager.SaveAbstract(tmp);
                nextDownloads++;
            }

            FindNextArticleToDownload();
        }

        // To control any increment in the info list 
        public void AddArticleInfo(ArticleInfo tmp)
        {
            tmp.Doc = new Document(tmp.id, Article2Words(tmp), -1);
            Articles.Add(tmp);            
        }

        public string[] Article2Words(ArticleInfo tmp)
        {
            List<string> words;
            string str = tmp.Title+" "+tmp.Abstract;// to lower case
            
            str = str.ToLower();
                  
            str = str.Replace("(", " ");
            str = str.Replace(")", " ");
            str = str.Replace(".", " ");
            str = str.Replace("=", " ");
            str = str.Replace(",", " ");
            str = str.Replace("-", " ");
            str = str.Replace("/", " ");
            str = str.Replace("±", " ");
            str = str.Replace("+", " ");
            str = str.Replace(">", " ");
            str = str.Replace("<", " ");

            words = new List<string>(str.Split(new string[] { " ", "\r\n" }, StringSplitOptions.RemoveEmptyEntries));
            words.RemoveAll(word => bayes.StopWords.Contains(word));
            
            return words.ToArray();
        }

        public void AddDocument(ArticleInfo tmp, float eval)
        {   
            bayes.AddDocument(new Document(tmp.id, Article2Words(tmp), eval));            
        }

        public void Train()
        {
            if (Articles.Count < 1)
                return;
            
            bayes.ResetVariables();

            for (int d = 0; d < Articles.Count; d++)
            {
                bayes.FillBagOfWords(Articles[d].Doc);
            }            
            
            bayes.ComputeWordProbabilities();

            for (int d = 0; d < Articles.Count; d++)
            {
                Articles[d].AI_score = bayes.ClassifyDocument(Articles[d].Doc);
            }
        }

        public void client_RetrievePubMedIDs(object sender, DownloadStringCompletedEventArgs e)
        {
            XDocument doc;
            try
            {
                doc = XDocument.Parse(e.Result);
            }
            catch (Exception)
            {
                LoadAnimation.IsRunning = false;
                return;
            }

            if (QueryCreator.queryType == QUERY_TYPE.PUBMED_IDS)
            {
                ProcessPUBMED_IDS(doc, K.HashString(query));
            }
            else 
                if (QueryCreator.queryType == QUERY_TYPE.PUBMED_ARTICLE_INFO)
                {
                    ProcessArticleInfo(doc);
                }
        }
    }
}
