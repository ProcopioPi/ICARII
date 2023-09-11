namespace MasterHound
{
    partial class frMAIN
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frMAIN));
            this.GRID = new System.Windows.Forms.DataGridView();
            this.ColumnINDEX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTITLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUSER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnChecked = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.MAIN_PNL = new System.Windows.Forms.Panel();
            this.LBL_STATUS = new System.Windows.Forms.Label();
            this.PNL_PAGE_TURNER = new System.Windows.Forms.Panel();
            this.PNL_INDEXES = new System.Windows.Forms.Panel();
            this.PNL_INDEXES_BUTTONS = new System.Windows.Forms.Panel();
            this.TXT_PROJECT_NAME = new System.Windows.Forms.TextBox();
            this.LBL_EVENTS = new System.Windows.Forms.Label();
            this.MENU_STRIP = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.PNL_HEAD = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LBL_RET_INDEX = new System.Windows.Forms.Label();
            this.TXT_INDEX = new System.Windows.Forms.TextBox();
            this.TXT_MAX_INDEX = new System.Windows.Forms.TextBox();
            this.LBL_RET_MAX = new System.Windows.Forms.Label();
            this.BTN_SEARCH = new System.Windows.Forms.Button();
            this.CHK_AUTO_SORT = new System.Windows.Forms.CheckBox();
            this.BTN_EVALUATE = new System.Windows.Forms.Button();
            this.TREE = new System.Windows.Forms.TreeView();
            this.PNL_RIGHT = new System.Windows.Forms.Panel();
            this.TXT_MAX_DOWNLOAD = new System.Windows.Forms.TextBox();
            this.LBL_ARTINFO = new System.Windows.Forms.Label();
            this.BTN_DOWNLOAD_PAPERS = new System.Windows.Forms.Button();
            this.CMB_BOX = new System.Windows.Forms.ComboBox();
            this.CHK_FREE_FULLTEXT = new System.Windows.Forms.CheckBox();
            this.BTN_CLEAR_SEARCH = new System.Windows.Forms.Button();
            this.PCT_CANVAS = new System.Windows.Forms.PictureBox();
            this.OFD = new System.Windows.Forms.OpenFileDialog();
            this.TIMER = new System.Windows.Forms.Timer(this.components);
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GRID)).BeginInit();
            this.MAIN_PNL.SuspendLayout();
            this.PNL_PAGE_TURNER.SuspendLayout();
            this.PNL_INDEXES.SuspendLayout();
            this.MENU_STRIP.SuspendLayout();
            this.PNL_HEAD.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.PNL_RIGHT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PCT_CANVAS)).BeginInit();
            this.SuspendLayout();
            // 
            // GRID
            // 
            this.GRID.AllowUserToOrderColumns = true;
            this.GRID.AllowUserToResizeRows = false;
            this.GRID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.GRID.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GRID.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GRID.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GRID.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GRID.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.GRID.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GRID.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GRID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GRID.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnINDEX,
            this.ColumnID,
            this.ColumnTITLE,
            this.ColumnUSER,
            this.ColumnAI,
            this.ColumnChecked});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GRID.DefaultCellStyle = dataGridViewCellStyle8;
            this.GRID.EnableHeadersVisualStyles = false;
            this.GRID.GridColor = System.Drawing.Color.Red;
            this.GRID.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.GRID.Location = new System.Drawing.Point(0, 153);
            this.GRID.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.GRID.MultiSelect = false;
            this.GRID.Name = "GRID";
            this.GRID.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GRID.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.GRID.RowHeadersWidth = 20;
            this.GRID.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GRID.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.GRID.RowTemplate.DividerHeight = 1;
            this.GRID.RowTemplate.Height = 100;
            this.GRID.RowTemplate.ReadOnly = true;
            this.GRID.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.GRID.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.GRID.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GRID.ShowRowErrors = false;
            this.GRID.Size = new System.Drawing.Size(1547, 314);
            this.GRID.TabIndex = 0;
            this.GRID.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DATA_GRID_VIEW_CellContentClick);
            this.GRID.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DATA_GRID_VIEW_CellDoubleClick);
            this.GRID.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DATA_GRID_VIEW_ColumnHeaderMouseClick);
            // 
            // ColumnINDEX
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnINDEX.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColumnINDEX.HeaderText = "DATE";
            this.ColumnINDEX.Name = "ColumnINDEX";
            this.ColumnINDEX.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnID
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnID.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColumnID.HeaderText = "ID";
            this.ColumnID.MaxInputLength = 300;
            this.ColumnID.Name = "ColumnID";
            this.ColumnID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnTITLE
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ColumnTITLE.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColumnTITLE.HeaderText = "TITLE";
            this.ColumnTITLE.Name = "ColumnTITLE";
            this.ColumnTITLE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnUSER
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnUSER.DefaultCellStyle = dataGridViewCellStyle5;
            this.ColumnUSER.HeaderText = "USER SCORE";
            this.ColumnUSER.Name = "ColumnUSER";
            this.ColumnUSER.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnAI
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = null;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnAI.DefaultCellStyle = dataGridViewCellStyle6;
            this.ColumnAI.HeaderText = "AI SCORE";
            this.ColumnAI.Name = "ColumnAI";
            this.ColumnAI.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnChecked
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.NullValue = false;
            this.ColumnChecked.DefaultCellStyle = dataGridViewCellStyle7;
            this.ColumnChecked.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ColumnChecked.HeaderText = "CHECKED";
            this.ColumnChecked.Name = "ColumnChecked";
            // 
            // MAIN_PNL
            // 
            this.MAIN_PNL.BackColor = System.Drawing.Color.Gray;
            this.MAIN_PNL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MAIN_PNL.Controls.Add(this.LBL_STATUS);
            this.MAIN_PNL.Controls.Add(this.PNL_PAGE_TURNER);
            this.MAIN_PNL.Controls.Add(this.TXT_PROJECT_NAME);
            this.MAIN_PNL.Controls.Add(this.LBL_EVENTS);
            this.MAIN_PNL.Controls.Add(this.GRID);
            this.MAIN_PNL.Controls.Add(this.MENU_STRIP);
            this.MAIN_PNL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MAIN_PNL.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MAIN_PNL.ForeColor = System.Drawing.Color.Black;
            this.MAIN_PNL.Location = new System.Drawing.Point(0, 0);
            this.MAIN_PNL.Name = "MAIN_PNL";
            this.MAIN_PNL.Size = new System.Drawing.Size(1549, 560);
            this.MAIN_PNL.TabIndex = 1;
            // 
            // LBL_STATUS
            // 
            this.LBL_STATUS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LBL_STATUS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LBL_STATUS.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_STATUS.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.LBL_STATUS.Location = new System.Drawing.Point(915, 535);
            this.LBL_STATUS.Name = "LBL_STATUS";
            this.LBL_STATUS.Size = new System.Drawing.Size(630, 23);
            this.LBL_STATUS.TabIndex = 19;
            this.LBL_STATUS.Text = "      WELCOME   ";
            this.LBL_STATUS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PNL_PAGE_TURNER
            // 
            this.PNL_PAGE_TURNER.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.PNL_PAGE_TURNER.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.PNL_PAGE_TURNER.Controls.Add(this.PNL_INDEXES);
            this.PNL_PAGE_TURNER.Location = new System.Drawing.Point(0, 466);
            this.PNL_PAGE_TURNER.Name = "PNL_PAGE_TURNER";
            this.PNL_PAGE_TURNER.Size = new System.Drawing.Size(1546, 59);
            this.PNL_PAGE_TURNER.TabIndex = 3;
            // 
            // PNL_INDEXES
            // 
            this.PNL_INDEXES.AutoScroll = true;
            this.PNL_INDEXES.BackColor = System.Drawing.Color.Silver;
            this.PNL_INDEXES.Controls.Add(this.PNL_INDEXES_BUTTONS);
            this.PNL_INDEXES.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PNL_INDEXES.ForeColor = System.Drawing.Color.Transparent;
            this.PNL_INDEXES.Location = new System.Drawing.Point(0, 0);
            this.PNL_INDEXES.Name = "PNL_INDEXES";
            this.PNL_INDEXES.Size = new System.Drawing.Size(1546, 59);
            this.PNL_INDEXES.TabIndex = 26;
            // 
            // PNL_INDEXES_BUTTONS
            // 
            this.PNL_INDEXES_BUTTONS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.PNL_INDEXES_BUTTONS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PNL_INDEXES_BUTTONS.Location = new System.Drawing.Point(0, 0);
            this.PNL_INDEXES_BUTTONS.Name = "PNL_INDEXES_BUTTONS";
            this.PNL_INDEXES_BUTTONS.Size = new System.Drawing.Size(1, 1);
            this.PNL_INDEXES_BUTTONS.TabIndex = 0;
            // 
            // TXT_PROJECT_NAME
            // 
            this.TXT_PROJECT_NAME.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.TXT_PROJECT_NAME.BackColor = System.Drawing.SystemColors.Window;
            this.TXT_PROJECT_NAME.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXT_PROJECT_NAME.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_PROJECT_NAME.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TXT_PROJECT_NAME.Location = new System.Drawing.Point(53, 3);
            this.TXT_PROJECT_NAME.Name = "TXT_PROJECT_NAME";
            this.TXT_PROJECT_NAME.Size = new System.Drawing.Size(1488, 20);
            this.TXT_PROJECT_NAME.TabIndex = 18;
            this.TXT_PROJECT_NAME.Text = "PROJECT NAME";
            this.TXT_PROJECT_NAME.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXT_PROJECT_NAME.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TXT_PROJECT_NAME_MouseClick);
            this.TXT_PROJECT_NAME.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXT_PROJECT_NAME_KeyDown);
            this.TXT_PROJECT_NAME.MouseEnter += new System.EventHandler(this.CTRL_MouseEnter);
            this.TXT_PROJECT_NAME.MouseLeave += new System.EventHandler(this.CTRL_MouseLeave);
            // 
            // LBL_EVENTS
            // 
            this.LBL_EVENTS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LBL_EVENTS.AutoSize = true;
            this.LBL_EVENTS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LBL_EVENTS.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_EVENTS.ForeColor = System.Drawing.Color.LightGray;
            this.LBL_EVENTS.Location = new System.Drawing.Point(11, 536);
            this.LBL_EVENTS.Name = "LBL_EVENTS";
            this.LBL_EVENTS.Size = new System.Drawing.Size(71, 18);
            this.LBL_EVENTS.TabIndex = 1;
            this.LBL_EVENTS.Text = "WELCOME";
            // 
            // MENU_STRIP
            // 
            this.MENU_STRIP.BackColor = System.Drawing.Color.DimGray;
            this.MENU_STRIP.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MENU_STRIP.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.MENU_STRIP.Location = new System.Drawing.Point(0, 0);
            this.MENU_STRIP.Name = "MENU_STRIP";
            this.MENU_STRIP.Size = new System.Drawing.Size(1547, 27);
            this.MENU_STRIP.TabIndex = 4;
            this.MENU_STRIP.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.openToolStripMenuItem,
            this.quitToolStripMenuItem1});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 23);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.Silver;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.toolStripMenuItem1.Size = new System.Drawing.Size(164, 24);
            this.toolStripMenuItem1.Text = "New";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.NewtoolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.openToolStripMenuItem.ForeColor = System.Drawing.Color.Silver;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(164, 24);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem1
            // 
            this.quitToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.quitToolStripMenuItem1.ForeColor = System.Drawing.Color.Silver;
            this.quitToolStripMenuItem1.Name = "quitToolStripMenuItem1";
            this.quitToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.quitToolStripMenuItem1.Size = new System.Drawing.Size(164, 24);
            this.quitToolStripMenuItem1.Text = "Quit";
            this.quitToolStripMenuItem1.Click += new System.EventHandler(this.QuitToolStripMenuItem_Click);
            // 
            // PNL_HEAD
            // 
            this.PNL_HEAD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.PNL_HEAD.BackColor = System.Drawing.Color.LightGray;
            this.PNL_HEAD.Controls.Add(this.groupBox1);
            this.PNL_HEAD.Controls.Add(this.BTN_SEARCH);
            this.PNL_HEAD.Controls.Add(this.CHK_AUTO_SORT);
            this.PNL_HEAD.Controls.Add(this.BTN_EVALUATE);
            this.PNL_HEAD.Controls.Add(this.TREE);
            this.PNL_HEAD.Controls.Add(this.PNL_RIGHT);
            this.PNL_HEAD.Controls.Add(this.CMB_BOX);
            this.PNL_HEAD.Controls.Add(this.CHK_FREE_FULLTEXT);
            this.PNL_HEAD.Controls.Add(this.BTN_CLEAR_SEARCH);
            this.PNL_HEAD.Controls.Add(this.PCT_CANVAS);
            this.PNL_HEAD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PNL_HEAD.ForeColor = System.Drawing.Color.Black;
            this.PNL_HEAD.Location = new System.Drawing.Point(0, 27);
            this.PNL_HEAD.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.PNL_HEAD.Name = "PNL_HEAD";
            this.PNL_HEAD.Size = new System.Drawing.Size(1549, 128);
            this.PNL_HEAD.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.LBL_RET_INDEX);
            this.groupBox1.Controls.Add(this.TXT_INDEX);
            this.groupBox1.Controls.Add(this.TXT_MAX_INDEX);
            this.groupBox1.Controls.Add(this.LBL_RET_MAX);
            this.groupBox1.Location = new System.Drawing.Point(802, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 45);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "IDs";
            // 
            // LBL_RET_INDEX
            // 
            this.LBL_RET_INDEX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LBL_RET_INDEX.AutoSize = true;
            this.LBL_RET_INDEX.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_RET_INDEX.Location = new System.Drawing.Point(10, 20);
            this.LBL_RET_INDEX.Name = "LBL_RET_INDEX";
            this.LBL_RET_INDEX.Size = new System.Drawing.Size(78, 19);
            this.LBL_RET_INDEX.TabIndex = 26;
            this.LBL_RET_INDEX.Text = "Start Index";
            // 
            // TXT_INDEX
            // 
            this.TXT_INDEX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TXT_INDEX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.TXT_INDEX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXT_INDEX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_INDEX.ForeColor = System.Drawing.Color.Silver;
            this.TXT_INDEX.Location = new System.Drawing.Point(91, 21);
            this.TXT_INDEX.Name = "TXT_INDEX";
            this.TXT_INDEX.Size = new System.Drawing.Size(70, 19);
            this.TXT_INDEX.TabIndex = 25;
            this.TXT_INDEX.Text = "0";
            this.TXT_INDEX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXT_INDEX.TextChanged += new System.EventHandler(this.TXT_INDEX_TextChanged);
            this.TXT_INDEX.MouseEnter += new System.EventHandler(this.CTRL_MouseEnter);
            this.TXT_INDEX.MouseLeave += new System.EventHandler(this.CTRL_MouseLeave);
            // 
            // TXT_MAX_INDEX
            // 
            this.TXT_MAX_INDEX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TXT_MAX_INDEX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.TXT_MAX_INDEX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXT_MAX_INDEX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_MAX_INDEX.ForeColor = System.Drawing.Color.Silver;
            this.TXT_MAX_INDEX.Location = new System.Drawing.Point(312, 21);
            this.TXT_MAX_INDEX.Name = "TXT_MAX_INDEX";
            this.TXT_MAX_INDEX.Size = new System.Drawing.Size(70, 19);
            this.TXT_MAX_INDEX.TabIndex = 23;
            this.TXT_MAX_INDEX.Text = "1000";
            this.TXT_MAX_INDEX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXT_MAX_INDEX.TextChanged += new System.EventHandler(this.TXT_MAX_INDEX_TextChanged);
            this.TXT_MAX_INDEX.MouseEnter += new System.EventHandler(this.CTRL_MouseEnter);
            this.TXT_MAX_INDEX.MouseLeave += new System.EventHandler(this.CTRL_MouseLeave);
            // 
            // LBL_RET_MAX
            // 
            this.LBL_RET_MAX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LBL_RET_MAX.AutoSize = true;
            this.LBL_RET_MAX.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_RET_MAX.Location = new System.Drawing.Point(194, 20);
            this.LBL_RET_MAX.Name = "LBL_RET_MAX";
            this.LBL_RET_MAX.Size = new System.Drawing.Size(112, 19);
            this.LBL_RET_MAX.TabIndex = 24;
            this.LBL_RET_MAX.Text = "Indexes amount";
            // 
            // BTN_SEARCH
            // 
            this.BTN_SEARCH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.BTN_SEARCH.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.BTN_SEARCH.FlatAppearance.BorderSize = 0;
            this.BTN_SEARCH.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.BTN_SEARCH.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.BTN_SEARCH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_SEARCH.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_SEARCH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BTN_SEARCH.Location = new System.Drawing.Point(562, 9);
            this.BTN_SEARCH.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_SEARCH.Name = "BTN_SEARCH";
            this.BTN_SEARCH.Size = new System.Drawing.Size(68, 37);
            this.BTN_SEARCH.TabIndex = 32;
            this.BTN_SEARCH.Text = "SEARCH";
            this.BTN_SEARCH.UseVisualStyleBackColor = false;
            this.BTN_SEARCH.Click += new System.EventHandler(this.BTN_SEARCH_Click);
            // 
            // CHK_AUTO_SORT
            // 
            this.CHK_AUTO_SORT.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.CHK_AUTO_SORT.FlatAppearance.BorderSize = 0;
            this.CHK_AUTO_SORT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CHK_AUTO_SORT.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHK_AUTO_SORT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CHK_AUTO_SORT.Location = new System.Drawing.Point(578, 98);
            this.CHK_AUTO_SORT.Name = "CHK_AUTO_SORT";
            this.CHK_AUTO_SORT.Size = new System.Drawing.Size(134, 23);
            this.CHK_AUTO_SORT.TabIndex = 31;
            this.CHK_AUTO_SORT.Text = "Auto sort";
            this.CHK_AUTO_SORT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CHK_AUTO_SORT.UseVisualStyleBackColor = true;
            this.CHK_AUTO_SORT.Visible = false;
            this.CHK_AUTO_SORT.CheckedChanged += new System.EventHandler(this.CHK_AUTO_SORT_CheckedChanged);
            // 
            // BTN_EVALUATE
            // 
            this.BTN_EVALUATE.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BTN_EVALUATE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.BTN_EVALUATE.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.BTN_EVALUATE.FlatAppearance.BorderSize = 0;
            this.BTN_EVALUATE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.BTN_EVALUATE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.BTN_EVALUATE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_EVALUATE.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_EVALUATE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BTN_EVALUATE.Location = new System.Drawing.Point(717, 96);
            this.BTN_EVALUATE.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_EVALUATE.Name = "BTN_EVALUATE";
            this.BTN_EVALUATE.Size = new System.Drawing.Size(155, 26);
            this.BTN_EVALUATE.TabIndex = 29;
            this.BTN_EVALUATE.Text = "EVALUATE";
            this.BTN_EVALUATE.UseVisualStyleBackColor = false;
            this.BTN_EVALUATE.Click += new System.EventHandler(this.BTN_EVALUATE_Click);
            // 
            // TREE
            // 
            this.TREE.BackColor = System.Drawing.Color.LightGray;
            this.TREE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TREE.CheckBoxes = true;
            this.TREE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TREE.FullRowSelect = true;
            this.TREE.Location = new System.Drawing.Point(0, -1);
            this.TREE.Name = "TREE";
            this.TREE.PathSeparator = "";
            this.TREE.ShowLines = false;
            this.TREE.ShowPlusMinus = false;
            this.TREE.ShowRootLines = false;
            this.TREE.Size = new System.Drawing.Size(557, 130);
            this.TREE.TabIndex = 30;
            this.TREE.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.TREE_AfterCheck);
            this.TREE.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TREE_AfterSelect);
            // 
            // PNL_RIGHT
            // 
            this.PNL_RIGHT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PNL_RIGHT.BackColor = System.Drawing.Color.LightGray;
            this.PNL_RIGHT.Controls.Add(this.TXT_MAX_DOWNLOAD);
            this.PNL_RIGHT.Controls.Add(this.LBL_ARTINFO);
            this.PNL_RIGHT.Controls.Add(this.BTN_DOWNLOAD_PAPERS);
            this.PNL_RIGHT.Location = new System.Drawing.Point(1327, 0);
            this.PNL_RIGHT.Name = "PNL_RIGHT";
            this.PNL_RIGHT.Size = new System.Drawing.Size(218, 97);
            this.PNL_RIGHT.TabIndex = 29;
            // 
            // TXT_MAX_DOWNLOAD
            // 
            this.TXT_MAX_DOWNLOAD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TXT_MAX_DOWNLOAD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.TXT_MAX_DOWNLOAD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXT_MAX_DOWNLOAD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_MAX_DOWNLOAD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TXT_MAX_DOWNLOAD.Location = new System.Drawing.Point(150, 22);
            this.TXT_MAX_DOWNLOAD.Name = "TXT_MAX_DOWNLOAD";
            this.TXT_MAX_DOWNLOAD.Size = new System.Drawing.Size(57, 19);
            this.TXT_MAX_DOWNLOAD.TabIndex = 20;
            this.TXT_MAX_DOWNLOAD.Text = "5";
            this.TXT_MAX_DOWNLOAD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXT_MAX_DOWNLOAD.TextChanged += new System.EventHandler(this.TXT_MAX_TextChanged);
            this.TXT_MAX_DOWNLOAD.MouseEnter += new System.EventHandler(this.CTRL_MouseEnter);
            this.TXT_MAX_DOWNLOAD.MouseLeave += new System.EventHandler(this.CTRL_MouseLeave);
            // 
            // LBL_ARTINFO
            // 
            this.LBL_ARTINFO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LBL_ARTINFO.AutoSize = true;
            this.LBL_ARTINFO.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_ARTINFO.Location = new System.Drawing.Point(6, 23);
            this.LBL_ARTINFO.Name = "LBL_ARTINFO";
            this.LBL_ARTINFO.Size = new System.Drawing.Size(141, 19);
            this.LBL_ARTINFO.TabIndex = 28;
            this.LBL_ARTINFO.Text = "Articles to download";
            // 
            // BTN_DOWNLOAD_PAPERS
            // 
            this.BTN_DOWNLOAD_PAPERS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_DOWNLOAD_PAPERS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.BTN_DOWNLOAD_PAPERS.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.BTN_DOWNLOAD_PAPERS.FlatAppearance.BorderSize = 0;
            this.BTN_DOWNLOAD_PAPERS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.BTN_DOWNLOAD_PAPERS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.BTN_DOWNLOAD_PAPERS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_DOWNLOAD_PAPERS.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_DOWNLOAD_PAPERS.ForeColor = System.Drawing.Color.Silver;
            this.BTN_DOWNLOAD_PAPERS.Location = new System.Drawing.Point(7, 47);
            this.BTN_DOWNLOAD_PAPERS.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_DOWNLOAD_PAPERS.Name = "BTN_DOWNLOAD_PAPERS";
            this.BTN_DOWNLOAD_PAPERS.Size = new System.Drawing.Size(204, 30);
            this.BTN_DOWNLOAD_PAPERS.TabIndex = 22;
            this.BTN_DOWNLOAD_PAPERS.Text = "DOWNLOAD";
            this.BTN_DOWNLOAD_PAPERS.UseVisualStyleBackColor = false;
            this.BTN_DOWNLOAD_PAPERS.Click += new System.EventHandler(this.BTN_DOWNLOAD_PAPERS_Click);
            // 
            // CMB_BOX
            // 
            this.CMB_BOX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.CMB_BOX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CMB_BOX.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMB_BOX.FormattingEnabled = true;
            this.CMB_BOX.Location = new System.Drawing.Point(636, 12);
            this.CMB_BOX.Margin = new System.Windows.Forms.Padding(5, 2, 2, 2);
            this.CMB_BOX.Name = "CMB_BOX";
            this.CMB_BOX.Size = new System.Drawing.Size(553, 31);
            this.CMB_BOX.TabIndex = 27;
            this.CMB_BOX.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CMB_BOX_KeyDown);
            this.CMB_BOX.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CMB_BOX_MouseClick);
            this.CMB_BOX.MouseEnter += new System.EventHandler(this.CTRL_MouseEnter);
            this.CMB_BOX.MouseLeave += new System.EventHandler(this.CTRL_MouseLeave);
            // 
            // CHK_FREE_FULLTEXT
            // 
            this.CHK_FREE_FULLTEXT.Checked = true;
            this.CHK_FREE_FULLTEXT.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CHK_FREE_FULLTEXT.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.CHK_FREE_FULLTEXT.FlatAppearance.BorderSize = 0;
            this.CHK_FREE_FULLTEXT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CHK_FREE_FULLTEXT.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHK_FREE_FULLTEXT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CHK_FREE_FULLTEXT.Location = new System.Drawing.Point(578, 62);
            this.CHK_FREE_FULLTEXT.Name = "CHK_FREE_FULLTEXT";
            this.CHK_FREE_FULLTEXT.Size = new System.Drawing.Size(134, 23);
            this.CHK_FREE_FULLTEXT.TabIndex = 19;
            this.CHK_FREE_FULLTEXT.Text = " Free Fulltext";
            this.CHK_FREE_FULLTEXT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CHK_FREE_FULLTEXT.UseVisualStyleBackColor = true;
            // 
            // BTN_CLEAR_SEARCH
            // 
            this.BTN_CLEAR_SEARCH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_CLEAR_SEARCH.BackColor = System.Drawing.Color.LightGray;
            this.BTN_CLEAR_SEARCH.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.BTN_CLEAR_SEARCH.FlatAppearance.BorderSize = 0;
            this.BTN_CLEAR_SEARCH.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BTN_CLEAR_SEARCH.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.BTN_CLEAR_SEARCH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_CLEAR_SEARCH.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_CLEAR_SEARCH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BTN_CLEAR_SEARCH.Location = new System.Drawing.Point(1193, 11);
            this.BTN_CLEAR_SEARCH.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_CLEAR_SEARCH.Name = "BTN_CLEAR_SEARCH";
            this.BTN_CLEAR_SEARCH.Size = new System.Drawing.Size(26, 32);
            this.BTN_CLEAR_SEARCH.TabIndex = 17;
            this.BTN_CLEAR_SEARCH.Text = "X";
            this.BTN_CLEAR_SEARCH.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BTN_CLEAR_SEARCH.UseVisualStyleBackColor = false;
            this.BTN_CLEAR_SEARCH.Click += new System.EventHandler(this.BTN_CLEAR_SEARCH_Click);
            // 
            // PCT_CANVAS
            // 
            this.PCT_CANVAS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PCT_CANVAS.Location = new System.Drawing.Point(1224, 5);
            this.PCT_CANVAS.Name = "PCT_CANVAS";
            this.PCT_CANVAS.Size = new System.Drawing.Size(97, 92);
            this.PCT_CANVAS.TabIndex = 16;
            this.PCT_CANVAS.TabStop = false;
            // 
            // OFD
            // 
            this.OFD.RestoreDirectory = true;
            // 
            // TIMER
            // 
            this.TIMER.Tick += new System.EventHandler(this.TIMER_Tick);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle11.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle11.NullValue")));
            this.dataGridViewImageColumn1.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewImageColumn1.DividerWidth = 1;
            this.dataGridViewImageColumn1.HeaderText = "PROCESS";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Visible = false;
            // 
            // frMAIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1549, 560);
            this.Controls.Add(this.PNL_HEAD);
            this.Controls.Add(this.MAIN_PNL);
            this.Name = "frMAIN";
            this.Text = "AUTO SEARCH V0.5";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frMAIN_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.GRID)).EndInit();
            this.MAIN_PNL.ResumeLayout(false);
            this.MAIN_PNL.PerformLayout();
            this.PNL_PAGE_TURNER.ResumeLayout(false);
            this.PNL_INDEXES.ResumeLayout(false);
            this.MENU_STRIP.ResumeLayout(false);
            this.MENU_STRIP.PerformLayout();
            this.PNL_HEAD.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.PNL_RIGHT.ResumeLayout(false);
            this.PNL_RIGHT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PCT_CANVAS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GRID;
        private System.Windows.Forms.Panel MAIN_PNL;
        private System.Windows.Forms.Panel PNL_HEAD;
        private System.Windows.Forms.Button BTN_CLEAR_SEARCH;
        private System.Windows.Forms.PictureBox PCT_CANVAS;
        private System.Windows.Forms.TextBox TXT_PROJECT_NAME;
        private System.Windows.Forms.Label LBL_EVENTS;
        private System.Windows.Forms.OpenFileDialog OFD;
        private System.Windows.Forms.CheckBox CHK_FREE_FULLTEXT;
        private System.Windows.Forms.Timer TIMER;
        private System.Windows.Forms.TextBox TXT_MAX_DOWNLOAD;
        private System.Windows.Forms.Button BTN_DOWNLOAD_PAPERS;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Panel PNL_PAGE_TURNER;
        private System.Windows.Forms.Panel PNL_INDEXES;
        private System.Windows.Forms.Label LBL_RET_INDEX;
        private System.Windows.Forms.TextBox TXT_INDEX;
        private System.Windows.Forms.Label LBL_RET_MAX;
        private System.Windows.Forms.TextBox TXT_MAX_INDEX;
        private System.Windows.Forms.MenuStrip MENU_STRIP;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem1;
        private System.Windows.Forms.Panel PNL_INDEXES_BUTTONS;
        private System.Windows.Forms.ComboBox CMB_BOX;
        private System.Windows.Forms.Label LBL_ARTINFO;
        private System.Windows.Forms.Label LBL_STATUS;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Panel PNL_RIGHT;
        private System.Windows.Forms.TreeView TREE;
        private System.Windows.Forms.Button BTN_EVALUATE;
        private System.Windows.Forms.CheckBox CHK_AUTO_SORT;
        private System.Windows.Forms.Button BTN_SEARCH;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnINDEX;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTITLE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUSER;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAI;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnChecked;
    }
}

