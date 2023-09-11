using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using MasterHound.Naive;

namespace MasterHound
{
    public class ArticleInfo
    {
        public int id;
        public string DOI;
        public string ID;
        public string Title;
        public string Date;
        public string Journal;
        public string Abstract;
        public ARTICLE_STATUS ArticleStatus;
        public double AI_score;
        public float User_Score;
        public bool Checked;
        public Document Doc;

        public ArticleInfo(string ID, string Title, string Date, string Journal, string Abstract, string value, string aiV, string hV, string DOI, string Checked)
        {
            this.id                 = int.Parse(ID);
            //------------------------------------
            this.ID                 = ID.Replace(K.COLON, K.EMPTY);
            this.Title              = Title.Replace(K.COLON, K.EMPTY);
            this.Date               = Date.Replace(K.COLON, K.EMPTY);
            this.Journal            = Journal.Replace(K.COLON, K.EMPTY);
            this.Abstract           = Abstract.Replace(K.COLON, K.EMPTY);
            this.DOI                = DOI.Replace(K.COLON, K.EMPTY);
            this.Checked            = Boolean.Parse(Checked);            
            this.ArticleStatus      = (ARTICLE_STATUS)Enum.Parse(typeof(ARTICLE_STATUS), value);
            this.AI_score           = float.Parse(aiV);
            this.User_Score         = float.Parse(hV);            
        }

        // for memory instance
        public ArticleInfo(int ID)
        {
            this.id = ID;
            //------------------------------------
            this.ID             = ID.ToString();
            this.Title          = K.EMPTY;
            this.Date           = K.EMPTY;
            this.Journal        = K.EMPTY;
            this.Abstract       = K.EMPTY;
            this.AI_score       = -1.0f;
            this.User_Score    = -1.0f;
            this.DOI            = K.EMPTY;
            this.ArticleStatus  = ARTICLE_STATUS.NOT_LOADED;
            this.Checked        = false;
        }

        public override string ToString()
        {
            return  ID + K.RETURN + Title + K.RETURN + Date + K.RETURN + 
                    Journal + K.RETURN + Abstract + K.RETURN + ArticleStatus + K.RETURN + 
                    AI_score + K.RETURN + User_Score + K.RETURN + DOI + K.RETURN + Checked;
        }
    }
}
