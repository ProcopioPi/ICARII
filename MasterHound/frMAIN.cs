using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Linq;
using System.Text;

namespace MasterHound
{
    public partial class frMAIN : Form
    {
        public static int ViewPage;
        private static HashSet<string> treeQueries;
        public static int row;
        static FolderBrowserDialog diag;
        static frPaperHound PaperViewer;
        static frCancel cancelDownloads;
        static string folder;
        static int maxIndex, index;
        static DirectoryInfo di;
        static DirectoryInfo sub;
        static DirectoryInfo[] dirInfo;
        static bool UserScores, IDxes, Titles, Checked, isMessageBoxShown;
        public static bool AIScore, autoSort;

        public frMAIN()
        {
            InitializeComponent();
            Init();      
        }

        #region INIT
        public void Init()
        {
            InstancesInit();
            GridInit();
            UserUX();

            GRID.EnableHeadersVisualStyles = false;
            autoSort = false;
            treeQueries = new HashSet<string>();

            TXT_PROJECT_NAME.Text = FileManager.StartProject();

            CMB_BOX.Select();
            Logger.Instance.Log(K.INIT + EndOfEvent());            
        }

        private void InstancesInit()
        {
            PaperViewer     = new frPaperHound();
            cancelDownloads = new frCancel();
            diag            = new FolderBrowserDialog();
            sub             = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);
            dirInfo         = sub.GetDirectories();
            OFD.Filter      = K.ICA_FILES;

            maxIndex    = 1000;
            index       = 0;
            ViewPage    = 0;

            UserScores = IDxes = AIScore = Titles = Checked = false;
        }

        public void GridInit()
        {
            GRID.Rows.Clear();
            GRID.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.EnableResizing;
            // or even better, use .DisableResizing. Most time consuming enum is DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
            // set it to false if not needed
            GRID.RowHeadersVisible      = false;
            this.GRID.AutoSizeRowsMode  = DataGridViewAutoSizeRowsMode.AllCells;
            List<DataGridViewRow> rows  = new List<DataGridViewRow>();

            int i = 0;
            while (i++ < 99)
            {
                //rows.Add(InsertEmptyRow(i));//-------------------------------
                GRID.Rows.Add();
            }

            
        
            //GRID.Rows.AddRange(rows.ToArray());///---------------------------
            //GRID.Refresh();    
        }

        public void UserUX()
        {
            LBL_EVENTS.ForeColor            = K.k2;
            CHK_FREE_FULLTEXT.ForeColor     = K.k8;
            TXT_PROJECT_NAME.ForeColor      = K.k8;

            fileToolStripMenuItem.ForeColor = K.k1;
            
            TXT_INDEX.ForeColor = TXT_MAX_DOWNLOAD.ForeColor = TXT_MAX_INDEX.ForeColor = K.k8; 
            TXT_INDEX.BackColor = TXT_MAX_DOWNLOAD.BackColor = TXT_MAX_INDEX.BackColor = K.k2;     
            
            MAIN_PNL.BackColor = PNL_INDEXES_BUTTONS.BackColor = PNL_INDEXES.BackColor = K.k1;

            TREE.BackColor = PNL_PAGE_TURNER.BackColor = PNL_HEAD.BackColor = PNL_RIGHT.BackColor = K.k1;
            
            TXT_PROJECT_NAME.BackColor = K.k1;
            BTN_CLEAR_SEARCH.BackColor = BTN_DOWNLOAD_PAPERS.BackColor = K.k1;

            MENU_STRIP.BackColor = K.k6;
            GRID.BackgroundColor  = K.k1;
            MAIN_PNL.BackColor = K.k6;

            int value = 220;

            TXT_INDEX.BackColor             = Color.FromArgb(value, value, value);
            TXT_MAX_DOWNLOAD.BackColor      = Color.FromArgb(value, value, value);
            TXT_MAX_INDEX.BackColor         = Color.FromArgb(value, value, value);
            TXT_PROJECT_NAME.BackColor      = Color.FromArgb(value, value, value);
            BTN_DOWNLOAD_PAPERS.BackColor   = Color.FromArgb(value, value, value);
            CMB_BOX.BackColor               = Color.FromArgb(value, value, value);            
            BTN_DOWNLOAD_PAPERS.ForeColor   = K.k8;

            toolStripMenuItem1.BackColor    = Color.FromArgb(value, value, value);
            openToolStripMenuItem.BackColor = Color.FromArgb(value, value, value);
            quitToolStripMenuItem1.BackColor = Color.FromArgb(value, value, value);

            value = 100;
            toolStripMenuItem1.ForeColor    = Color.FromArgb(value, value, value);
            openToolStripMenuItem.ForeColor = Color.FromArgb(value, value, value);
            quitToolStripMenuItem1.ForeColor = Color.FromArgb(value, value, value);
        }

        #endregion

        #region EVENTS
        
        private void TXT_MAX_INDEX_TextChanged(object sender, EventArgs e)
        {
            try
            {
                MaxIndexTextChange();
                Logger.Instance.Log(TXT.MAX_INDEX_TextChanged + EndOfEvent());
            }
            catch (Exception ex) { Logger.Instance.Log(K.EXCEPTION + TXT.MAX_INDEX_TextChanged + EventError(ex.Message)); }
        }

        private void TXT_INDEX_TextChanged(object sender, EventArgs e)
        {
            try
            {
                IndexTextChange();
                Logger.Instance.Log(TXT.INDEX_TextChanged + EndOfEvent());
            }
            catch (Exception ex) { Logger.Instance.Log(K.EXCEPTION + TXT.INDEX_TextChanged + EventError(ex.Message)); }
        }

        private void TXT_MAX_TextChanged(object sender, EventArgs e)
        {
            try
            {
                MaxDownload();
                Logger.Instance.Log(TXT.MAX_TextChanged + EndOfEvent());
            }
            catch (Exception ex) { Logger.Instance.Log(K.EXCEPTION + TXT.MAX_TextChanged + EventError(ex.Message)); }
        }
        
        private void BTN_CLEAR_SEARCH_Click(object sender, EventArgs e)
        {
            try
            {
                ClearSearchBox();
                Logger.Instance.Log(BTN.CLEAR_SEARCH_Click + EndOfEvent());
            }
            catch (Exception ex) { Logger.Instance.Log(K.EXCEPTION + BTN.CLEAR_SEARCH_Click + EventError(ex.Message)); }
        }

        private void CMB_BOX_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                CmbBoxClick();
                Logger.Instance.Log(CMB.MouseClick + EndOfEvent());
            }
            catch (Exception ex) { Logger.Instance.Log(K.EXCEPTION + CMB.MouseClick + EventError(ex.Message)); }
        }
         
        private void CMB_BOX_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                CmbBoxKeyDown(e.KeyValue);            
            }
            catch (Exception ex) { Logger.Instance.Log(K.EXCEPTION + CMB.KeyDown + EventError(ex.Message)); }
        }

        private void BTN_SEARCH_Click(object sender, EventArgs e)
        {   
            try
            {
                CmbBoxKeyDown(K.ENTER_VALUE);
            }
            catch (Exception ex) { Logger.Instance.Log(K.EXCEPTION + CMB.KeyDown + EventError(ex.Message)); }
        }

        private void TIMER_Tick(object sender, EventArgs e)
        {
            try
            {
                TimerTick();
            }
            catch (Exception ex) { Logger.Instance.Log(K.EXCEPTION + TIMER_TICK.TimerTick + EventError(ex.Message)); }
        }

        private void BTN_PAGE_TURNER_Click(object sender, EventArgs e)
        {
            try
            {
                TurnPage((Button)sender);
                Logger.Instance.Log(BTN.PAGE_TURNER_Click + EndOfEvent());
            }
            catch (Exception ex) { Logger.Instance.Log(K.EXCEPTION + BTN.PAGE_TURNER_Click + EventError(ex.Message)); }
        }
      
        private void DATA_GRID_VIEW_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (InfoManager.Instance.CountMissingEvaluations() > 0)
                {
                    DataGridDoubleClick((DataGridView)sender, e.RowIndex);
                    Logger.Instance.Log(DATA_GRID_VIEW.CellDoubleClick + EndOfEvent());
                }
            }
            catch (Exception ex) { Logger.Instance.Log(K.EXCEPTION + DATA_GRID_VIEW.CellDoubleClick + EventError(ex.Message)); }
        }
        
        private void DATA_GRID_VIEW_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridCheckClick(e.RowIndex, e.ColumnIndex);
                Logger.Instance.Log(DATA_GRID_VIEW.CellContentClick + EndOfEvent());
            }
            catch (Exception ex) { Logger.Instance.Log(K.EXCEPTION + DATA_GRID_VIEW.CellContentClick + EventError(ex.Message)); }
        }

        private void DATA_GRID_VIEW_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {

                SortInfoinDataGrid((CELL)e.ColumnIndex);
                Logger.Instance.Log(DATA_GRID_VIEW.ColumnHeaderMouseClick+ EndOfEvent());
            }
            catch (Exception ex) {
                Logger.Instance.Log(K.EXCEPTION + DATA_GRID_VIEW.ColumnHeaderMouseClick + EventError(ex.Message));
            } 
        }

        private void frMAIN_FormClosing(object sender, FormClosedEventArgs e)
        {
            try
            {                
                BeforeFormClosing();
                Logger.Instance.Log("frMAIN_FormClosing-----" + EndOfEvent());
            }
            catch (Exception ex) { Logger.Instance.Log(K.EXCEPTION + "frMAIN_FormClosing" + EventError(ex.Message)); }
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenProject();
                Logger.Instance.Log("OpenToolStripMenuItem_Click" + EndOfEvent());
            }
            catch (Exception ex) { Logger.Instance.Log(K.EXCEPTION + "OpenToolStripMenuItem_Click" + EventError(ex.Message)); }
        }

        private void QuitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Logger.Instance.Log("QuitToolStripMenuItem_Click" + EndOfEvent());
                Application.Exit();
               
            }
            catch (Exception ex) { Logger.Instance.Log(K.EXCEPTION + "QuitToolStripMenuItem_Click" + EventError(ex.Message)); }
        }

        private void NewtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                NewProject();
                Logger.Instance.Log("NewtoolStripMenuItem_Click" + EndOfEvent());
            }
            catch (Exception ex) { Logger.Instance.Log(K.EXCEPTION + "NewtoolStripMenuItem_Click" + EventError(ex.Message)); }
        }

        private void TXT_PROJECT_NAME_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                TXT_PROJECT_NAME.SelectAll();
                Logger.Instance.Log(TXT.PROJECT_NAME_MouseClick + EndOfEvent());
            }
            catch (Exception ex) { Logger.Instance.Log(K.EXCEPTION + TXT.PROJECT_NAME_MouseClick + EventError(ex.Message)); }
        }

        private void TXT_PROJECT_NAME_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                ChangeProjectName(e.KeyValue);
                Logger.Instance.Log( TXT.TXT_PROJECT_NAME_KeyDown + EndOfEvent());
            }
            catch (Exception ex) { Logger.Instance.Log(K.EXCEPTION + TXT.TXT_PROJECT_NAME_KeyDown + EventError(ex.Message)); }
        }

        //----
        private void TREE_AfterCheck(object sender, TreeViewEventArgs e)
        {
            UpdateFromFiles();
        }

        private void BTN_EVALUATE_Click(object sender, EventArgs e)
        {
            InfoManager.Instance.Train();   // UPDATE DOCS
            AIScore = false;
            UpdateInfo();
            SortInfoinDataGrid(CELL.AI_SCORE);  // SORT DOCS BY EVALUATION
        }

        private void CHK_AUTO_SORT_CheckedChanged(object sender, EventArgs e)
        {
            autoSort = CHK_AUTO_SORT.Checked;
        }

        private void TREE_AfterSelect(object sender, TreeViewEventArgs e)
        {
            CMB_BOX.Text = TREE.SelectedNode.Text;
        }

        #endregion

        #region RESPONSE METHODS

        private string EndOfEvent()
        {
            return K.SPACE + DateTime.Now + K.RETURN;
        }

        private string EventError(string message)
        {
            return K.SPACE + DateTime.Now + K.SPACE + message + K.RETURN;
        }

        private void ChangeProjectName(int KeyValue)
        {
            if (KeyValue == K.ENTER_VALUE)// IF ENTER-------------------------------------------------------------------------------
            {
                if (TXT_PROJECT_NAME.Text != K.EMPTY)
                {
                    FileManager.ChangeProjectFolderName(TXT_PROJECT_NAME.Text);
                }
            }
        }

        private void CmbBoxKeyDown(int KeyValue)
        {
            if (KeyValue == K.ENTER_VALUE)// IF ENTER-------------------------------------------------------------------------------
            {                
                PrepareSearchData(CMB_BOX.Text, int.Parse(TXT_INDEX.Text), int.Parse(TXT_MAX_INDEX.Text), CHK_FREE_FULLTEXT.Checked);
             
                LBL_EVENTS.Text = K.ENTER;
                Logger.Instance.Log(CMB.KeyDown + EndOfEvent());
            }
        }

        private void DownLoadPapers()
        {
            InfoManager.Instance.ContinueDownload(int.Parse(TXT_MAX_DOWNLOAD.Text));
            this.Enabled = false;

            TIMER.Start();
        }

        private void MaxIndexTextChange()
        {
            int mI;
            mI = maxIndex;
            try
            {
                mI = int.Parse(TXT_MAX_INDEX.Text);
                maxIndex = mI;
            }
            catch (Exception)
            {
                mI = maxIndex;
            }
            TXT_MAX_INDEX.Text = mI.ToString();
        }

        private void IndexTextChange()
        {
            int i;
            i = index;
            try
            {
                i = int.Parse(TXT_INDEX.Text);
                index = i;
            }
            catch (Exception)
            {
                i = index;
            }
            TXT_INDEX.Text = i.ToString();
        }

        private void MaxDownload()
        {
            int val;

            val = InfoManager.Instance.tmpMax;
            try
            {
                val = int.Parse(TXT_MAX_DOWNLOAD.Text);
                InfoManager.Instance.tmpMax = val;
            }
            catch (Exception)
            {
                MessageBox.Show(TXT_MAX_DOWNLOAD.Text + K.NOT_VALID_NUMBER);
                TXT_MAX_DOWNLOAD.Text = InfoManager.Instance.tmpMax.ToString();
            }
        }
        
        private void OpenProject()
        {
            List<string> projectFiles;
            string fileName;
            string[] qys;

            if (sub.GetDirectories().Length > 0)
                sub = sub.GetDirectories()[0];

            diag.SelectedPath = sub.FullName;

            if (diag.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                folder  = diag.SelectedPath;
                di      = new DirectoryInfo(folder);

                InfoManager.Instance.Articles   = new List<ArticleInfo>();
                string[] fileEntries            = Directory.GetFiles(folder);
                
                projectFiles                    = new List<string>(fileEntries);
                TXT_PROJECT_NAME.Text           = di.Name;
                FileManager.projectFolder       = di.FullName;
                for (int i = 0; i < fileEntries.Length; i++)
                {
                    fileName = Path.GetFileName(fileEntries[i]);
                    if(fileName[0]=='_')
                    if (fileName != K.QUERIES_FILE)
                    {                        
                        InfoManager.Instance.AddArticleInfo(FileManager.OpenFile(fileEntries[i]));
                    }
                }
                fileName    = projectFiles.Find(x => x.Contains(K.QUERIES_FILE));
                qys         = File.ReadAllLines(fileName);

                TREE.Nodes.Clear();
                for (int q = 0; q < qys.Length; q++)
                {
                    fileName = projectFiles.Find(x => x.Contains(K.HashString(qys[q])));
                    AddQuery(qys[q]);
                    InfoManager.IDs.AddRange(File.ReadAllLines(fileName));
                }

                //UpdateInfo();//update visual info
                UpdateFromFiles();
            }
        }
        
        private void ClearSearchBox()
        {
            CMB_BOX.Text = K.EMPTY;
            LBL_EVENTS.Text = K.CLEAR_SEARCH_BAR;            
        }

        private void CmbBoxClick()
        {
            /*
            string[] options = FileManager.ReadQueryLines();
            CMB_BOX.Text = K.EMPTY;

            if (options.Length > 0)
            {
                CMB_BOX.Items.Clear();
                CMB_BOX.Items.AddRange(options);
                CMB_BOX.DroppedDown = true;
            }//*/

            LBL_EVENTS.Text = K.MOUSE_CLICK;
        }
        
        private void TimerTick()
        {
            if (LoadAnimation.IsRunning)
            {
                MyHandlers.SetCTREnableValue(this, false);
                                
                if (InfoManager.Instance.IsLoadingIndexes)
                    MyHandlers.SetPCTValue(PCT_CANVAS, LoadAnimation.Instance.AnimateLoadingIndexes());
                else
                    MyHandlers.SetPCTValue(PCT_CANVAS, LoadAnimation.Instance.AnimateLoadingNextFrame(InfoManager.ArticleIndex));
            }
            else
            {
                MyHandlers.SetCTREnableValue(this, true);
                MyHandlers.SetPCTValue(PCT_CANVAS, LoadAnimation.Instance.FinishAnimation());
              
                TIMER.Stop();
                
                UpdateFromFiles();
                Logger.Instance.Log(TIMER_TICK.TimerTick_End + EndOfEvent());                
            }
        }

        private void ShowMessageBox(bool show)
        {
            if (!isMessageBoxShown)
            {
                MyHandlers.SetPCTValue(cancelDownloads._CANVAS, LoadAnimation.Instance.AnimateLoadingIndexes());
                if (show)
                {
                    isMessageBoxShown = true;
                    cancelDownloads.Show();
                }
            }
            else
            {
                MyHandlers.SetPCTValue(cancelDownloads._CANVAS, LoadAnimation.Instance.AnimateLoadingNextFrame(InfoManager.ArticleIndex));
            }

            if (!show)
            {
                cancelDownloads.Hide();
                isMessageBoxShown = false;
            }
        }

        private void TurnPage(Button btn)
        {
            ViewPage = int.Parse(btn.Text);
            UpdateViewPage(ViewPage);
            SetNormalButtonState(btn);
        }
 
        private void DataGridDoubleClick(DataGridView dataGridView, int row)
        {
            if (dataGridView == null)
                return;

            if (dataGridView.CurrentRow.Selected)
            {
                if (row > -1 && dataGridView.Rows[row].Cells[(int)CELL.ID].Value != null)
                    if (dataGridView.Rows[row].Cells[1].Value.ToString() != K.EMPTY)
                    {
                        int id = (int)dataGridView.Rows[row].Cells[(int)CELL.ID].Value;
                        int idx = row;// (int)dataGridView.Rows[row].Cells[(int)CELL.DATE].Value;//the actual index in the info array

                        ArticleInfo tmp = InfoManager.Instance.Articles[idx];

                        if (tmp.ArticleStatus != ARTICLE_STATUS.NOT_LOADED)
                        {
                            PaperViewer.LoadArticleInfo(this, idx, TXT_PROJECT_NAME.Text);// WE HAVE TO SEND VIEW_PAGE_INDEX
                        }
                    }
            }
        }

        private void DataGridCheckClick(int row, int column)
        {
            LBL_EVENTS.Text = K.COLUMN + column + K.ROW + row;
            if (column == (int)CELL.CHECKED && row > -1 && row < 100)
            {
                var value = Convert.ToBoolean(GRID[column, row].Value);
                GRID[column, row].Value = !value;

                int idx = (int)GRID.Rows[row].Cells[(int)CELL.DATE].Value;

                InfoManager.Instance.Articles[idx].Checked = Convert.ToBoolean(GRID[column, row].Value);
                FileManager.SaveAbstract(InfoManager.Instance.Articles[idx]);
            }
        }

        public void SortInfoinDataGrid(CELL cell)
        {
            GRID.Columns[(int)CELL.AI_SCORE].HeaderCell.Style.BackColor     = Color.Gray;
            GRID.Columns[(int)CELL.CHECKED].HeaderCell.Style.BackColor = Color.Gray;
            GRID.Columns[(int)CELL.ID].HeaderCell.Style.BackColor = Color.Gray;
            GRID.Columns[(int)CELL.DATE].HeaderCell.Style.BackColor = Color.Gray;
            GRID.Columns[(int)CELL.TITLE].HeaderCell.Style.BackColor = Color.Gray;
            GRID.Columns[(int)CELL.USER_SCORE].HeaderCell.Style.BackColor = Color.Gray;

            GRID.Columns[(int)cell].HeaderCell.Style.BackColor = Color.LightSlateGray;

            switch (cell)
            {
                case CELL.AI_SCORE:
                    if (AIScore)
                        InfoManager.Instance.Articles = InfoManager.Instance.Articles.OrderBy(o => o.AI_score).ToList();
                    else
                        InfoManager.Instance.Articles = InfoManager.Instance.Articles.OrderByDescending(o => o.AI_score).ToList();
                    AIScore = !AIScore;
                    break;
                case CELL.CHECKED:
                    if (Checked)
                        InfoManager.Instance.Articles = InfoManager.Instance.Articles.OrderBy(o => o.Checked).ToList();
                    else
                        InfoManager.Instance.Articles = InfoManager.Instance.Articles.OrderByDescending(o => o.Checked).ToList();
                    Checked = !Checked;
                    break;
                case CELL.ID:
                    if (IDxes)
                        InfoManager.Instance.Articles = InfoManager.Instance.Articles.OrderBy(o => o.id).ToList();
                    else
                        InfoManager.Instance.Articles = InfoManager.Instance.Articles.OrderByDescending(o => o.id).ToList();
                    IDxes = !IDxes;
                    break;
                case CELL.DATE:
                    break;
                case CELL.TITLE:
                    if (Titles)
                        InfoManager.Instance.Articles = InfoManager.Instance.Articles.OrderBy(o => o.Title).ToList();
                    else
                        InfoManager.Instance.Articles = InfoManager.Instance.Articles.OrderByDescending(o => o.Title).ToList();
                    Titles = !Titles;
                    break;
                case CELL.USER_SCORE:
                    if (UserScores)
                        InfoManager.Instance.Articles = InfoManager.Instance.Articles.OrderBy(o => o.User_Score).ToList();
                    else
                        InfoManager.Instance.Articles = InfoManager.Instance.Articles.OrderByDescending(o => o.User_Score).ToList();
                    UserScores = !UserScores;
                    break;
            }
            UpdateViewPage(ViewPage);
        }

        private void NewProject()
        {
            GridInit();
            FileManager.projectFolder       = null;
            FileManager.IsProjectStarted    = false;
            InfoManager.Instance            = new InfoManager();
            TXT_PROJECT_NAME.Text           = "PROJECT NAME";
            ClearSearchBox();
            TREE.Nodes.Clear();
            treeQueries.Clear();
            CMB_BOX.Select();
        }

        private void BeforeFormClosing()
        {
            TIMER.Stop();
            Logger.Instance.Log(K.MASTER_HOUND_EXIT + EndOfEvent());
            Application.Exit();
        }

        private void BTN_DOWNLOAD_PAPERS_Click(object sender, EventArgs e)
        {
            try
            {
                DownLoadPapers();
                Logger.Instance.Log(BTN.DOWNLOAD_PAPERS_Click + EndOfEvent());
            }
            catch (Exception ex) { Logger.Instance.Log(K.EXCEPTION + BTN.DOWNLOAD_PAPERS_Click + EventError(ex.Message)); }
        }

        private void CTRL_MouseEnter(object sender, EventArgs e)
        {
            Control CTRL = (Control)sender;
            CTRL.BackColor = Color.FromArgb(205, 205, 205);
        }

        private void CTRL_MouseLeave(object sender, EventArgs e)
        {
            Control CTRL = (Control)sender;
            CTRL.BackColor = Color.FromArgb(220, 220, 220);
        }

        #endregion

        #region COMMON METHODS
        public void UpdateInfo()
        {
            if (InfoManager.IDs != null)
            {
                LBL_STATUS.Text = K.TOTAL_IDS_PROJECT + InfoManager.IDs.Count + K.SPACE;
            }

            UpdateDataGrid();
        }

        private void PrepareSearchData(string query, int index, int max, bool freeFullText)
        {
            if (CMB_BOX.Text != K.EMPTY)
            {
                this.Enabled = false;
                ExecuteQuerySearch(query, max, index, freeFullText); 
            }
        }
        
        private void ExecuteQuerySearch(string query, int max, int index, bool freeFullText)
        {
            InfoManager.Instance.ProcessIDsRetrieval(query, index, int.Parse(TXT_MAX_DOWNLOAD.Text), freeFullText);            
            AddQuery(query);

            TIMER.Start();
        }

        private void AddQuery(string query)
        {
            if (!treeQueries.Contains(query))
            {
                treeQueries.Add(query);
                TreeNode node = new TreeNode(query);
                node.Checked = true;
                node.Tag = K.HashString(query);
                TREE.Nodes.Add(node);
            }
        }

        private void CreateButtonsBrowsers()
        {            
            Button btn;
            EventHandler vth;
            List<Button> buttons = new List<Button>();
            int totalButtons;

            totalButtons = InfoManager.Instance.Articles.Count / K.HUNDRED;

            if (InfoManager.Instance.Articles.Count % K.HUNDRED != 0)
                totalButtons++;

            PNL_INDEXES_BUTTONS.Width       = (totalButtons * 55) + 6;
            PNL_INDEXES_BUTTONS.Height      = 38;// HARD 
            PNL_INDEXES_BUTTONS.Location    = new Point(0, 7);
            vth                             = new EventHandler(BTN_PAGE_TURNER_Click);

            PNL_INDEXES_BUTTONS.Controls.Clear();
            for (int t = 0; t < totalButtons; t++)
            {
                btn             = new Button();
                btn.BackColor   = TXT_MAX_DOWNLOAD.BackColor;
                btn.ForeColor   = TXT_MAX_DOWNLOAD.ForeColor;
                btn.Text        = t.ToString();
                btn.Width       = 50;
                btn.Height      = 32;
                btn.Location    = new Point(4+(btn.Width+5) * t, 2);
                btn.FlatStyle   = FlatStyle.Flat;
                btn.Click      += vth;

                buttons.Add(btn);
            }

            if (PNL_INDEXES_BUTTONS.Controls.Count > 1)
            {
                PNL_INDEXES_BUTTONS.Controls.AddRange(buttons.ToArray());
                PNL_INDEXES_BUTTONS.Controls[0].BackColor = Color.Gray;
            }
        }

        private void SetNormalButtonState(Button btn)
        {
            for (int b = 0; b < PNL_INDEXES_BUTTONS.Controls.Count; b++)
            {
                PNL_INDEXES_BUTTONS.Controls[b].BackColor = TXT_MAX_DOWNLOAD.BackColor;
            }
            btn.BackColor = Color.Gray;
        }

        private DataGridViewRow InsertEmptyRow(int index)
        {
            DataGridViewRow row = (DataGridViewRow)GRID.Rows[0].Clone();
            
            row.Cells[(int)CELL.DATE].Value        = string.Empty;
            row.Cells[(int)CELL.ID].Value           = string.Empty;
            row.Cells[(int)CELL.TITLE].Value        = string.Empty;
            row.Cells[(int)CELL.USER_SCORE].Value   = string.Empty;
            row.Cells[(int)CELL.AI_SCORE].Value     = string.Empty;
            row.Cells[(int)CELL.CHECKED].Value      = false;

            row.Cells[(int)CELL.DATE].Style.BackColor          = K.C1;
            row.Cells[(int)CELL.ID].Style.BackColor             = K.C1;
            row.Cells[(int)CELL.TITLE].Style.BackColor          = K.C1;
            row.Cells[(int)CELL.USER_SCORE].Style.BackColor     = K.C1;
            row.Cells[(int)CELL.AI_SCORE].Style.BackColor       = K.C1;
            row.Cells[(int)CELL.CHECKED].Style.BackColor        = K.C1;

            row.MinimumHeight = 35;
            return row;
        }

        public void ClearRowValues(int index)
        {
            GRID[(int)CELL.DATE, index % K.HUNDRED].Value        = string.Empty;
            GRID[(int)CELL.ID, index % K.HUNDRED].Value           = string.Empty;
            GRID[(int)CELL.TITLE, index % K.HUNDRED].Value        = string.Empty;
            GRID[(int)CELL.USER_SCORE, index % K.HUNDRED].Value   = string.Empty;
            GRID[(int)CELL.AI_SCORE, index % K.HUNDRED].Value     = string.Empty;
            GRID[(int)CELL.CHECKED, index % K.HUNDRED].Value      = false;

            GRID[(int)CELL.DATE, index % K.HUNDRED].Style.BackColor          = K.C1;
            GRID[(int)CELL.ID, index % K.HUNDRED].Style.BackColor             = K.C1;
            GRID[(int)CELL.TITLE, index % K.HUNDRED].Style.BackColor          = K.C1;
            GRID[(int)CELL.USER_SCORE, index % K.HUNDRED].Style.BackColor     = K.C1;
            GRID[(int)CELL.AI_SCORE, index % K.HUNDRED].Style.BackColor       = K.C1;
            GRID[(int)CELL.CHECKED, index % K.HUNDRED].Style.BackColor        = K.C1;
        }

        public void UpdateDataGrid()
        {
            int pages = InfoManager.Instance.Articles.Count / K.HUNDRED;
            ViewPage = 0;

            CreateButtonsBrowsers();/// hay que revisar primero si hay botones que mostrar de acuerdo a la cantidad de articulos bajados con los de la vista
            UpdateViewPage(ViewPage);
        }

        public void UpdateViewPage(int page)
        {
            int total = page * K.HUNDRED;
            
            ((ISupportInitialize)GRID).BeginInit();
            for (int i = total; i < (K.HUNDRED + total); i++)
            {
                if (i < InfoManager.Instance.Articles.Count)
                {
                    if(InfoManager.IDs.Contains(InfoManager.Instance.Articles[i].ID))
                        UpdateRowValues(i, InfoManager.Instance.Articles[i]);//
                 }
                else//clean remaining rows
                {
                    ClearRowValues(i);
                }
            }

            ((ISupportInitialize)GRID).EndInit();

            GRID.Refresh();
            GRID.Select();

            LBL_EVENTS.Text = K.PAGE + page.ToString();
        }
        
        public void UpdateRowValues(int idx)
        {
            int row = idx % K.HUNDRED;
            int tempPage = idx / 100;
            if (tempPage == ViewPage)
            {
                ArticleInfo info = InfoManager.Instance.Articles[idx];//IDX is the index in the Info list
                UpdateRowValues((ViewPage * 100) + row, info);
            }
        }

        private void UpdateRowValues(int idx, ArticleInfo info)
        {
            GRID[(int)CELL.DATE, idx % K.HUNDRED].Value         = info.Date;
            GRID[(int)CELL.ID, idx % K.HUNDRED].Value           = info.id;
            GRID[(int)CELL.TITLE, idx % K.HUNDRED].Value        = info.Title;
            GRID[(int)CELL.USER_SCORE, idx % K.HUNDRED].Value   = info.User_Score;
            GRID[(int)CELL.AI_SCORE, idx % K.HUNDRED].Value     = info.AI_score;
            GRID[(int)CELL.CHECKED, idx % K.HUNDRED].Value      = info.Checked;
            
            switch (info.ArticleStatus)
            {
                case ARTICLE_STATUS.NOT_LOADED:
                    SetRowBackgroundColor(idx, K.C1);
                    break;
                case ARTICLE_STATUS.LOADED:
                    SetRowBackgroundColor(idx, K.C2);
                    break;
                case ARTICLE_STATUS.EVALUATED:
                    SetRowBackgroundColor(idx, K.C3);
                    break;
            }            
        }
  
        private void SetRowBackgroundColor(int row, Color c)
        {
            GRID[(int)CELL.DATE, row % K.HUNDRED].Style.BackColor        = c;
            GRID[(int)CELL.ID, row % K.HUNDRED].Style.BackColor           = c;
            GRID[(int)CELL.TITLE, row % K.HUNDRED].Style.BackColor        = c;
            GRID[(int)CELL.USER_SCORE, row % K.HUNDRED].Style.BackColor   = c;
            GRID[(int)CELL.AI_SCORE, row % K.HUNDRED].Style.BackColor     = c;
            GRID[(int)CELL.CHECKED, row % K.HUNDRED].Style.BackColor      = c;
        }
        #endregion
        
        

        private void UpdateFromFiles()
        {
            GridInit();
            UpdateIDs();
        }

        private void UpdateIDs()
        {
            string fileName, key;
            string[] ids;
            List<string> idsList;
            ArticleInfo info;
            InfoManager.IDs.Clear();
            InfoManager.Instance.Articles.Clear();//-******************************************

            ids = new string[0];
            idsList = new List<string>();
            for (int n = 0; n < TREE.Nodes.Count; n++)
            {
                if (TREE.Nodes[n].Checked)
                {
                    key = (string)TREE.Nodes[n].Tag;
                    fileName = @FileManager.projectFolder + "/" + key;// from each node to get the downloaded indexes
                    if (File.Exists(fileName))
                    {
                        ids = File.ReadAllLines(fileName);
                        idsList.AddRange(ids.ToList());
                        for (int i = 0; i < ids.Length; i++)
                        {
                            fileName = FileManager.projectFolder + "/_" + ids[i] + ".txt";
                            if (File.Exists(fileName))
                            {
                                info = FileManager.OpenFile(fileName);
                                if (!InfoManager.IDs.Contains(info.ID))
                                {
                                    InfoManager.Instance.AddArticleInfo(info);
                                    InfoManager.IDs.Add(ids[i]);
                                }
                            }
                        }
                    }
                }
            }

            InfoManager.IDs = InfoManager.Instance.CleanIDs(idsList);// clear out repetitions
            UpdateInfo();
        }

    }
}
