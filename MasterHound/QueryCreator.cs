namespace MasterHound
{
    public class QueryCreator
    {
        public static QUERY_TYPE queryType;

        public QueryCreator()
        {
        }
        
        public static string PubMedArticleInfoQuery(string id)
        {
            queryType = QUERY_TYPE.PUBMED_ARTICLE_INFO;
            return "http://eutils.ncbi.nlm.nih.gov/entrez/eutils/efetch.fcgi?db=pubmed&id=" + id + "&rettype=xml";//&sort=date
        }
               
        public static string PubMedArticleInfoQuery(string[] id)
        {
            string totalIDs;

            totalIDs = id[0];
            for (int i = 0; i < id.Length; i++)
            {
                totalIDs += "," + id;
            }

            queryType = QUERY_TYPE.PUBMED_ARTICLE_INFO;
            return "http://eutils.ncbi.nlm.nih.gov/entrez/eutils/efetch.fcgi?db=pubmed&id=" + totalIDs + "&rettype=xml";//&sort=date
        }

        public static string PubMedIDsQuery(string[] words, int startIndex, int max, bool freeFullText)
        {
            string url;

            queryType = QUERY_TYPE.PUBMED_IDS;
            url = K.PUB_MED_BASE;

            url += words[0];
            for (int l = 1; l < words.Length; l++)
            {
               // url += K.AND + words[l];// ELIMINATE AND TO JUST PASTE QUERY DIRECTLY FOR COMPOUND QUERIES
                url += K.SPACE+ words[l];
            }
        
            if (freeFullText)
                url += K.FREE_FULLTEXT;

            url += K.RET_START + startIndex + K.RET_MAX + max;
            url += "&" + K.API_KEY;

            return url;
        }

        public static string ScopusIDsQuery(string[] words, int startIndex, int max)
        {
            string str;

            str = string.Empty;
            queryType = QUERY_TYPE.SCOPUS_IDS;

            str += K.SCOPUS_BASE;
            for (int q = 0; q < words.Length; q++)
            {
                str += words[q] + "&";
            }
            str += "&" + K.START + startIndex;
            str += "&" + K.COUNT + max;
            str += "&" + K.API_KEY;
            str += "&" + K.XML_APP;

            return str;
        }
    }
}
