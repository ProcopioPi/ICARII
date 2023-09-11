using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MasterHound
{
    public partial class frPaperHound : Form
    {
        static frMAIN parent;
        static int infoIDx;

        public frPaperHound()
        {
            InitializeComponent();
        }

        #region Events

        private void BTN_CLOSE_WINDOW_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BTN_UP_Click(object sender, EventArgs e)
        {
            Evaluate(1f, InfoManager.Instance.Articles[infoIDx]);
        }

        private void BTN_DOWN_Click(object sender, EventArgs e)
        {
            Evaluate(-1f, InfoManager.Instance.Articles[infoIDx]);
        }

        private void BTN_RIGHT_Click(object sender, EventArgs e)
        {
            Forward();
        }

        private void BTN_LEFT_Click(object sender, EventArgs e)
        {
            Backward();
        }

        #endregion

        public void LoadArticleInfo(frMAIN parent, int idx, string projectName)
        {
            TXT_PROJECT_NAME.Text     = projectName; // to display at the window

            frPaperHound.infoIDx      = idx; // unique variable depending on what is being evaluated
            frPaperHound.parent       = parent;

            UpdateInfoInRichTxt(InfoManager.Instance.Articles[infoIDx]);
            this.Show();
        }

        private void UpdateInfoInRichTxt(ArticleInfo info)
        {
            RICH_TXT.Text       = K.EMPTY;
            TXT_JOURNAL.Text    = info.Journal;
            TXT_DATE.Text       = info.Date;
            TXT_ID.Text         = info.ID;

            RICH_TXT.Text += K.ALIGN_LEFT;
            RICH_TXT.Text += info.Title;
            RICH_TXT.Text += K.ALIGN_RIGHT;
            RICH_TXT.Text += info.Abstract;

            SearchTextAndAlign(info.Title, HorizontalAlignment.Center, new Font(K.EMPTY, 16, FontStyle.Bold));
            SearchTextAndAlign(info.Abstract, HorizontalAlignment.Left, new Font(K.EMPTY, 14, FontStyle.Regular));

            RICH_TXT.SelectAll();
            RICH_TXT.SelectionIndent += 120;//play with this values to match yours
            RICH_TXT.SelectionRightIndent += 120;//this too
            RICH_TXT.RightToLeft = RightToLeft.Yes;

            RICH_TXT.SelectionLength = 0;

            PCT_BOX.BackColor = K.NOT_EVAL_COLOR;

            if (info.ArticleStatus == ARTICLE_STATUS.EVALUATED)
                PCT_BOX.BackColor = K.EVAL_COLOR;
        }

        private void SearchTextAndAlign(string searchText, HorizontalAlignment alignment, Font font)
        {
            if (searchText != K.EMPTY)
            {
                int indexToText             = RICH_TXT.Find(searchText);
                RICH_TXT.Select(indexToText, searchText.Length);
                RICH_TXT.SelectionAlignment = alignment;
                RICH_TXT.SelectionFont      = font;
            }
        }

        private void Evaluate(float evaluation, ArticleInfo info)// here we should add this document to bayes
        {
            if (info.ArticleStatus == ARTICLE_STATUS.NOT_LOADED)
            {
                info.User_Score = -1; 
                return;
            }

            info.ArticleStatus                      = ARTICLE_STATUS.EVALUATED;
            info.User_Score                         = evaluation;            
            InfoManager.Instance.Articles[infoIDx]  = info;
            FileManager.SaveAbstract(info);         // save 2 disk
            PCT_BOX.Visible                         = true;
            PCT_BOX.BackColor                       = K.EVAL_COLOR;

            InfoManager.Instance.AddDocument(info, evaluation);// adding for evaluation in bayes
            
            if (frMAIN.autoSort)
            {
                //---------------
                InfoManager.Instance.Train();
                frMAIN.AIScore = false;
                parent.UpdateInfo();
                parent.SortInfoinDataGrid(CELL.AI_SCORE);//sort docs by AI eval
                //---------------
            }//*/

            //ROW INDEX IS USED ONLY HERE
            parent.UpdateRowValues(infoIDx);            // we send index of article and if it is in the viewPage it updates.
            parent.UpdateDataGrid();
        
            int nextArticleIndex = NextArticleToEvaluate();//this changes idx
            if (nextArticleIndex != -1)
            {
                infoIDx = nextArticleIndex;
                UpdateInfoInRichTxt(InfoManager.Instance.Articles[infoIDx]);
            }
            else
            {
                this.Hide();
            }
        }
        
        private void Backward()
        {
            if (infoIDx > 0)
            {
                infoIDx--;
                UpdateInfoInRichTxt(InfoManager.Instance.Articles[infoIDx]);
            }
        }

        private void Forward()
        {
            int missing          = InfoManager.Instance.CountMissingEvaluations();//CountMissingArticles();
            int nextArticleIndex = NextArticleToEvaluate();

            if (nextArticleIndex == -1 || 1 == missing)
                this.Hide();
            else
            {                          
                infoIDx++;
                infoIDx = (infoIDx % InfoManager.Instance.Articles.Count);
                UpdateInfoInRichTxt(InfoManager.Instance.Articles[infoIDx]);//*/
            }
        }
        private int NextArticleToEvaluate(int index)
        {
            ArticleInfo tmp, xID;
            xID =  InfoManager.Instance.Articles[index];
            tmp = InfoManager.Instance.Articles.Find(x => x.ArticleStatus != ARTICLE_STATUS.EVALUATED && xID.id != x.id);//AQUI ES DONDE QUEDA VACIO
            if (tmp != null)
            {
                return InfoManager.Instance.Articles.FindIndex(x => x.id == tmp.id);
            }
            else
            {
                return -1;
            }
        }

        private int NextArticleToEvaluate()
        {
            ArticleInfo tmp;

            tmp = InfoManager.Instance.Articles.Find(x => x.ArticleStatus != ARTICLE_STATUS.EVALUATED);//AQUI ES DONDE QUEDA VACIO                        
            if (tmp != null )//********************************************************************
            {
                return InfoManager.Instance.Articles.FindIndex(x => x.id == tmp.id);
            }
            else
            {

                return -1;
            }
        }

    }
}
