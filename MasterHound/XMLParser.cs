using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Xml;

namespace MasterHound
{
    public class XMLParser
    {
        public static XElement RetrieveElement(XElement element, string name, XElement solution)
        {
            if (element.Name == name)
            {
                return element;
            }
            else
            {
                foreach (XNode child in element.Nodes())
                {
                    if (child.NodeType == XmlNodeType.Element)
                    {
                        solution = RetrieveElement(child as XElement, name, solution);

                        if (solution != null)
                            if (solution.Name == name)
                                return solution;
                    }
                }
            }
            return null;
        }

        public static ArticleInfo RetrieveArticleInfo(string id, XElement element)
        {
            ArticleInfo info;
            XElement article;
            XElement tmp;
            // if info is not available it can fail everything, that is why it receives id
                        
            info    = new ArticleInfo(int.Parse(id));
            article = RetrieveElement(element, "Article", null);

            if (element.Value != "" && article != null)
            {
                tmp = RetrieveElement(article, K.ARTICLE_TITLE, null);
                if (tmp != null)
                {
                    info.Title          = tmp.Value;
                    info.User_Score    = 0.0f;
                    info.AI_score       = 0.0f;
                }
                tmp = RetrieveElement(article, K.JOURNAL, null);
                if (tmp != null)
                    info.Journal = tmp.Value;
                tmp = RetrieveElement(article, K.ABSTRACT_TEXT, null);
                if (tmp != null)
                    info.Abstract = tmp.Value;
                tmp = RetrieveElement(article, K.DOI, null);
                if (tmp != null)
                    info.DOI = tmp.Value;
                tmp = RetrieveElement(article, K.YEAR, null);
                if (tmp != null)
                    info.Date = tmp.Value;              
                else
                {
                    tmp         = RetrieveElement(article, K.MEDLINE_DATE, null);
                    info.Date   = tmp.Value;
                }
            }

            if (info.Title != "")
            {
                info.ArticleStatus = ARTICLE_STATUS.LOADED;
                info.User_Score = 0.0f;
                info.AI_score = 0.0f;
            }
            else
                info.ArticleStatus = ARTICLE_STATUS.NOT_LOADED;

            info.User_Score = 0.0f;
            info.AI_score = 0.0f;

            return info;
        }
    }
}
