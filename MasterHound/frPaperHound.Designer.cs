namespace MasterHound
{
    partial class frPaperHound
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frPaperHound));
            this.PNL_HEAD = new System.Windows.Forms.Panel();
            this.TXT_PROJECT_NAME = new System.Windows.Forms.TextBox();
            this.RICH_TXT = new System.Windows.Forms.RichTextBox();
            this.PCT_BOX = new System.Windows.Forms.PictureBox();
            this.PNL_BOTTOM = new System.Windows.Forms.Panel();
            this.LBL_SCREEN = new System.Windows.Forms.Label();
            this.BTN_DOWN = new System.Windows.Forms.Button();
            this.BTN_UP = new System.Windows.Forms.Button();
            this.PNL_MAIN = new System.Windows.Forms.Panel();
            this.TXT_ID = new System.Windows.Forms.TextBox();
            this.TXT_JOURNAL = new System.Windows.Forms.TextBox();
            this.TXT_DATE = new System.Windows.Forms.TextBox();
            this.BTN_RIGHT = new System.Windows.Forms.Button();
            this.BTN_LEFT = new System.Windows.Forms.Button();
            this.PNL_HEADER = new System.Windows.Forms.Panel();
            this.BTN_CLOSE_WINDOW = new System.Windows.Forms.Button();
            this.PNL_HEAD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PCT_BOX)).BeginInit();
            this.PNL_BOTTOM.SuspendLayout();
            this.PNL_MAIN.SuspendLayout();
            this.SuspendLayout();
            // 
            // PNL_HEAD
            // 
            this.PNL_HEAD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.PNL_HEAD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PNL_HEAD.Controls.Add(this.TXT_PROJECT_NAME);
            this.PNL_HEAD.Dock = System.Windows.Forms.DockStyle.Top;
            this.PNL_HEAD.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PNL_HEAD.ForeColor = System.Drawing.Color.Silver;
            this.PNL_HEAD.Location = new System.Drawing.Point(0, 28);
            this.PNL_HEAD.Name = "PNL_HEAD";
            this.PNL_HEAD.Size = new System.Drawing.Size(1561, 31);
            this.PNL_HEAD.TabIndex = 10;
            // 
            // TXT_PROJECT_NAME
            // 
            this.TXT_PROJECT_NAME.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TXT_PROJECT_NAME.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.TXT_PROJECT_NAME.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXT_PROJECT_NAME.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TXT_PROJECT_NAME.Location = new System.Drawing.Point(503, 4);
            this.TXT_PROJECT_NAME.Name = "TXT_PROJECT_NAME";
            this.TXT_PROJECT_NAME.Size = new System.Drawing.Size(541, 20);
            this.TXT_PROJECT_NAME.TabIndex = 12;
            this.TXT_PROJECT_NAME.Text = "PROJECT NAME";
            this.TXT_PROJECT_NAME.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RICH_TXT
            // 
            this.RICH_TXT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.RICH_TXT.BackColor = System.Drawing.Color.LightGray;
            this.RICH_TXT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RICH_TXT.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RICH_TXT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.RICH_TXT.Location = new System.Drawing.Point(138, 92);
            this.RICH_TXT.Name = "RICH_TXT";
            this.RICH_TXT.ReadOnly = true;
            this.RICH_TXT.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RICH_TXT.Size = new System.Drawing.Size(1285, 524);
            this.RICH_TXT.TabIndex = 20;
            this.RICH_TXT.Text = "";
            // 
            // PCT_BOX
            // 
            this.PCT_BOX.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PCT_BOX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.PCT_BOX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PCT_BOX.Location = new System.Drawing.Point(726, 67);
            this.PCT_BOX.Name = "PCT_BOX";
            this.PCT_BOX.Size = new System.Drawing.Size(108, 9);
            this.PCT_BOX.TabIndex = 12;
            this.PCT_BOX.TabStop = false;
            // 
            // PNL_BOTTOM
            // 
            this.PNL_BOTTOM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.PNL_BOTTOM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PNL_BOTTOM.Controls.Add(this.LBL_SCREEN);
            this.PNL_BOTTOM.Controls.Add(this.BTN_DOWN);
            this.PNL_BOTTOM.Controls.Add(this.BTN_UP);
            this.PNL_BOTTOM.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PNL_BOTTOM.ForeColor = System.Drawing.Color.Silver;
            this.PNL_BOTTOM.Location = new System.Drawing.Point(0, 650);
            this.PNL_BOTTOM.Name = "PNL_BOTTOM";
            this.PNL_BOTTOM.Size = new System.Drawing.Size(1561, 76);
            this.PNL_BOTTOM.TabIndex = 13;
            // 
            // LBL_SCREEN
            // 
            this.LBL_SCREEN.AutoSize = true;
            this.LBL_SCREEN.BackColor = System.Drawing.Color.Transparent;
            this.LBL_SCREEN.Font = new System.Drawing.Font("Calibri", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_SCREEN.Location = new System.Drawing.Point(19, 15);
            this.LBL_SCREEN.Name = "LBL_SCREEN";
            this.LBL_SCREEN.Size = new System.Drawing.Size(0, 42);
            this.LBL_SCREEN.TabIndex = 12;
            this.LBL_SCREEN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BTN_DOWN
            // 
            this.BTN_DOWN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTN_DOWN.BackColor = System.Drawing.Color.Transparent;
            this.BTN_DOWN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTN_DOWN.BackgroundImage")));
            this.BTN_DOWN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BTN_DOWN.FlatAppearance.BorderSize = 0;
            this.BTN_DOWN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.BTN_DOWN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.BTN_DOWN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_DOWN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.BTN_DOWN.Location = new System.Drawing.Point(798, 2);
            this.BTN_DOWN.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_DOWN.Name = "BTN_DOWN";
            this.BTN_DOWN.Size = new System.Drawing.Size(70, 71);
            this.BTN_DOWN.TabIndex = 8;
            this.BTN_DOWN.UseVisualStyleBackColor = false;
            this.BTN_DOWN.Click += new System.EventHandler(this.BTN_DOWN_Click);
            // 
            // BTN_UP
            // 
            this.BTN_UP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTN_UP.BackColor = System.Drawing.Color.Transparent;
            this.BTN_UP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTN_UP.BackgroundImage")));
            this.BTN_UP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BTN_UP.FlatAppearance.BorderSize = 0;
            this.BTN_UP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(200)))), ((int)(((byte)(180)))));
            this.BTN_UP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(65)))));
            this.BTN_UP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_UP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
            this.BTN_UP.Location = new System.Drawing.Point(690, 1);
            this.BTN_UP.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_UP.Name = "BTN_UP";
            this.BTN_UP.Size = new System.Drawing.Size(70, 71);
            this.BTN_UP.TabIndex = 7;
            this.BTN_UP.UseVisualStyleBackColor = false;
            this.BTN_UP.Click += new System.EventHandler(this.BTN_UP_Click);
            // 
            // PNL_MAIN
            // 
            this.PNL_MAIN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.PNL_MAIN.Controls.Add(this.TXT_ID);
            this.PNL_MAIN.Controls.Add(this.TXT_JOURNAL);
            this.PNL_MAIN.Controls.Add(this.TXT_DATE);
            this.PNL_MAIN.Controls.Add(this.BTN_RIGHT);
            this.PNL_MAIN.Controls.Add(this.BTN_LEFT);
            this.PNL_MAIN.Controls.Add(this.PNL_HEAD);
            this.PNL_MAIN.Controls.Add(this.BTN_CLOSE_WINDOW);
            this.PNL_MAIN.Controls.Add(this.PNL_BOTTOM);
            this.PNL_MAIN.Controls.Add(this.PCT_BOX);
            this.PNL_MAIN.Controls.Add(this.RICH_TXT);
            this.PNL_MAIN.Controls.Add(this.PNL_HEADER);
            this.PNL_MAIN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PNL_MAIN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PNL_MAIN.Location = new System.Drawing.Point(0, 0);
            this.PNL_MAIN.Name = "PNL_MAIN";
            this.PNL_MAIN.Size = new System.Drawing.Size(1561, 726);
            this.PNL_MAIN.TabIndex = 3;
            // 
            // TXT_ID
            // 
            this.TXT_ID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TXT_ID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.TXT_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXT_ID.Font = new System.Drawing.Font("Courier New", 12F);
            this.TXT_ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TXT_ID.Location = new System.Drawing.Point(138, 67);
            this.TXT_ID.Name = "TXT_ID";
            this.TXT_ID.Size = new System.Drawing.Size(164, 19);
            this.TXT_ID.TabIndex = 34;
            this.TXT_ID.Text = "ID";
            // 
            // TXT_JOURNAL
            // 
            this.TXT_JOURNAL.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.TXT_JOURNAL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.TXT_JOURNAL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXT_JOURNAL.Font = new System.Drawing.Font("Courier New", 12F);
            this.TXT_JOURNAL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TXT_JOURNAL.Location = new System.Drawing.Point(279, 625);
            this.TXT_JOURNAL.Name = "TXT_JOURNAL";
            this.TXT_JOURNAL.Size = new System.Drawing.Size(1144, 19);
            this.TXT_JOURNAL.TabIndex = 33;
            this.TXT_JOURNAL.Text = "JOURNAL";
            this.TXT_JOURNAL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TXT_DATE
            // 
            this.TXT_DATE.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.TXT_DATE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.TXT_DATE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXT_DATE.Font = new System.Drawing.Font("Courier New", 12F);
            this.TXT_DATE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TXT_DATE.Location = new System.Drawing.Point(138, 625);
            this.TXT_DATE.Name = "TXT_DATE";
            this.TXT_DATE.Size = new System.Drawing.Size(164, 19);
            this.TXT_DATE.TabIndex = 32;
            this.TXT_DATE.Text = "DATE";
            // 
            // BTN_RIGHT
            // 
            this.BTN_RIGHT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.BTN_RIGHT.Dock = System.Windows.Forms.DockStyle.Right;
            this.BTN_RIGHT.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.BTN_RIGHT.FlatAppearance.BorderSize = 0;
            this.BTN_RIGHT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.BTN_RIGHT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.BTN_RIGHT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_RIGHT.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_RIGHT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BTN_RIGHT.Image = ((System.Drawing.Image)(resources.GetObject("BTN_RIGHT.Image")));
            this.BTN_RIGHT.Location = new System.Drawing.Point(1476, 59);
            this.BTN_RIGHT.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_RIGHT.Name = "BTN_RIGHT";
            this.BTN_RIGHT.Size = new System.Drawing.Size(85, 591);
            this.BTN_RIGHT.TabIndex = 31;
            this.BTN_RIGHT.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BTN_RIGHT.UseVisualStyleBackColor = false;
            this.BTN_RIGHT.Click += new System.EventHandler(this.BTN_RIGHT_Click);
            // 
            // BTN_LEFT
            // 
            this.BTN_LEFT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.BTN_LEFT.Dock = System.Windows.Forms.DockStyle.Left;
            this.BTN_LEFT.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.BTN_LEFT.FlatAppearance.BorderSize = 0;
            this.BTN_LEFT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.BTN_LEFT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.BTN_LEFT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_LEFT.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_LEFT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BTN_LEFT.Image = ((System.Drawing.Image)(resources.GetObject("BTN_LEFT.Image")));
            this.BTN_LEFT.Location = new System.Drawing.Point(0, 59);
            this.BTN_LEFT.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_LEFT.Name = "BTN_LEFT";
            this.BTN_LEFT.Size = new System.Drawing.Size(85, 591);
            this.BTN_LEFT.TabIndex = 30;
            this.BTN_LEFT.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BTN_LEFT.UseVisualStyleBackColor = false;
            this.BTN_LEFT.Click += new System.EventHandler(this.BTN_LEFT_Click);
            // 
            // PNL_HEADER
            // 
            this.PNL_HEADER.Dock = System.Windows.Forms.DockStyle.Top;
            this.PNL_HEADER.Location = new System.Drawing.Point(0, 0);
            this.PNL_HEADER.Name = "PNL_HEADER";
            this.PNL_HEADER.Size = new System.Drawing.Size(1561, 28);
            this.PNL_HEADER.TabIndex = 27;
            // 
            // BTN_CLOSE_WINDOW
            // 
            this.BTN_CLOSE_WINDOW.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_CLOSE_WINDOW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BTN_CLOSE_WINDOW.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.BTN_CLOSE_WINDOW.FlatAppearance.BorderSize = 0;
            this.BTN_CLOSE_WINDOW.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BTN_CLOSE_WINDOW.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.BTN_CLOSE_WINDOW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_CLOSE_WINDOW.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_CLOSE_WINDOW.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BTN_CLOSE_WINDOW.Location = new System.Drawing.Point(1521, -1);
            this.BTN_CLOSE_WINDOW.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_CLOSE_WINDOW.Name = "BTN_CLOSE_WINDOW";
            this.BTN_CLOSE_WINDOW.Size = new System.Drawing.Size(42, 39);
            this.BTN_CLOSE_WINDOW.TabIndex = 22;
            this.BTN_CLOSE_WINDOW.Text = "X";
            this.BTN_CLOSE_WINDOW.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BTN_CLOSE_WINDOW.UseVisualStyleBackColor = false;
            this.BTN_CLOSE_WINDOW.Click += new System.EventHandler(this.BTN_CLOSE_WINDOW_Click);
            // 
            // frPaperHound
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1561, 726);
            this.Controls.Add(this.PNL_MAIN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frPaperHound";
            this.Text = "PaperHound";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.PNL_HEAD.ResumeLayout(false);
            this.PNL_HEAD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PCT_BOX)).EndInit();
            this.PNL_BOTTOM.ResumeLayout(false);
            this.PNL_BOTTOM.PerformLayout();
            this.PNL_MAIN.ResumeLayout(false);
            this.PNL_MAIN.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PNL_HEAD;
        private System.Windows.Forms.TextBox TXT_PROJECT_NAME;
        private System.Windows.Forms.RichTextBox RICH_TXT;
        private System.Windows.Forms.PictureBox PCT_BOX;
        private System.Windows.Forms.Panel PNL_BOTTOM;
        private System.Windows.Forms.Label LBL_SCREEN;
        private System.Windows.Forms.Button BTN_DOWN;
        private System.Windows.Forms.Button BTN_UP;
        private System.Windows.Forms.Panel PNL_MAIN;
        private System.Windows.Forms.Panel PNL_HEADER;
        private System.Windows.Forms.Button BTN_RIGHT;
        private System.Windows.Forms.Button BTN_LEFT;
        private System.Windows.Forms.TextBox TXT_DATE;
        private System.Windows.Forms.TextBox TXT_JOURNAL;
        private System.Windows.Forms.TextBox TXT_ID;
        private System.Windows.Forms.Button BTN_CLOSE_WINDOW;

    }
}