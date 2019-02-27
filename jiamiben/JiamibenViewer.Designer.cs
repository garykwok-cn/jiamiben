namespace Jiamiben
{
    partial class DesViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DesViewer));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开加密文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.另存为RToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tabs = new System.Windows.Forms.TabControl();
            this.filterPanel = new System.Windows.Forms.Panel();
            this.lblMatch = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chbIgnoreCase = new System.Windows.Forms.CheckBox();
            this.btnPre = new System.Windows.Forms.Button();
            this.filterPanel_title = new System.Windows.Forms.Panel();
            this.closebtn = new System.Windows.Forms.PictureBox();
            this.minbtn = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.filterPanel.SuspendLayout();
            this.filterPanel_title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closebtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minbtn)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1002, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建文件ToolStripMenuItem,
            this.打开加密文件ToolStripMenuItem,
            this.保存文件ToolStripMenuItem,
            this.另存为RToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(58, 21);
            this.文件ToolStripMenuItem.Text = "文件(&F)";
            // 
            // 新建文件ToolStripMenuItem
            // 
            this.新建文件ToolStripMenuItem.Name = "新建文件ToolStripMenuItem";
            this.新建文件ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.新建文件ToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.新建文件ToolStripMenuItem.Text = "新建文件(&N)";
            this.新建文件ToolStripMenuItem.Click += new System.EventHandler(this.新建文件ToolStripMenuItem_Click);
            // 
            // 打开加密文件ToolStripMenuItem
            // 
            this.打开加密文件ToolStripMenuItem.Name = "打开加密文件ToolStripMenuItem";
            this.打开加密文件ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.打开加密文件ToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.打开加密文件ToolStripMenuItem.Text = "打开加密文件(&O)";
            this.打开加密文件ToolStripMenuItem.Click += new System.EventHandler(this.打开加密文件ToolStripMenuItem_Click);
            // 
            // 保存文件ToolStripMenuItem
            // 
            this.保存文件ToolStripMenuItem.Name = "保存文件ToolStripMenuItem";
            this.保存文件ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.保存文件ToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.保存文件ToolStripMenuItem.Text = "保存(&S)";
            this.保存文件ToolStripMenuItem.Click += new System.EventHandler(this.保存文件ToolStripMenuItem_Click);
            // 
            // 另存为RToolStripMenuItem
            // 
            this.另存为RToolStripMenuItem.Name = "另存为RToolStripMenuItem";
            this.另存为RToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
                        | System.Windows.Forms.Keys.S)));
            this.另存为RToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.另存为RToolStripMenuItem.Text = "另存为(&R)";
            this.另存为RToolStripMenuItem.Click += new System.EventHandler(this.另存为RToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.filterPanel);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1002, 745);
            this.panel1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tabs);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1002, 745);
            this.panel3.TabIndex = 3;
            // 
            // tabs
            // 
            this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabs.Location = new System.Drawing.Point(0, 0);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(1002, 745);
            this.tabs.TabIndex = 1;
            this.tabs.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tabs_KeyDown);
            this.tabs.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tabs_MouseDoubleClick);
            // 
            // filterPanel
            // 
            this.filterPanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.filterPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filterPanel.Controls.Add(this.closebtn);
            this.filterPanel.Controls.Add(this.chbIgnoreCase);
            this.filterPanel.Controls.Add(this.lblMatch);
            this.filterPanel.Controls.Add(this.btnPre);
            this.filterPanel.Controls.Add(this.btnSearch);
            this.filterPanel.Controls.Add(this.txtSearch);
            this.filterPanel.Controls.Add(this.label1);
            this.filterPanel.Controls.Add(this.filterPanel_title);
            this.filterPanel.Location = new System.Drawing.Point(4, 596);
            this.filterPanel.Name = "filterPanel";
            this.filterPanel.Size = new System.Drawing.Size(323, 145);
            this.filterPanel.TabIndex = 2;
            this.filterPanel.Visible = false;
            // 
            // lblMatch
            // 
            this.lblMatch.AutoSize = true;
            this.lblMatch.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblMatch.Location = new System.Drawing.Point(25, 126);
            this.lblMatch.Name = "lblMatch";
            this.lblMatch.Size = new System.Drawing.Size(0, 12);
            this.lblMatch.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(22, 91);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "查找";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(79, 38);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(227, 21);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "查找内容：";
            // 
            // chbIgnoreCase
            // 
            this.chbIgnoreCase.AutoSize = true;
            this.chbIgnoreCase.Location = new System.Drawing.Point(23, 69);
            this.chbIgnoreCase.Name = "chbIgnoreCase";
            this.chbIgnoreCase.Size = new System.Drawing.Size(84, 16);
            this.chbIgnoreCase.TabIndex = 4;
            this.chbIgnoreCase.Text = "忽略大小写";
            this.chbIgnoreCase.UseVisualStyleBackColor = true;
            this.chbIgnoreCase.CheckedChanged += new System.EventHandler(this.chbIgnoreCase_CheckedChanged);
            // 
            // btnPre
            // 
            this.btnPre.Location = new System.Drawing.Point(127, 91);
            this.btnPre.Name = "btnPre";
            this.btnPre.Size = new System.Drawing.Size(75, 23);
            this.btnPre.TabIndex = 2;
            this.btnPre.Text = "上一个";
            this.btnPre.UseVisualStyleBackColor = true;
            this.btnPre.Visible = false;
            this.btnPre.Click += new System.EventHandler(this.btnPre_Click);
            // 
            // filterPanel_title
            // 
            this.filterPanel_title.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.filterPanel_title.Controls.Add(this.minbtn);
            this.filterPanel_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.filterPanel_title.Location = new System.Drawing.Point(0, 0);
            this.filterPanel_title.Name = "filterPanel_title";
            this.filterPanel_title.Size = new System.Drawing.Size(321, 28);
            this.filterPanel_title.TabIndex = 6;
            // 
            // closebtn
            // 
            this.closebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closebtn.Image = global::YPassword.Properties.Resources.close;
            this.closebtn.Location = new System.Drawing.Point(292, 6);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(16, 16);
            this.closebtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.closebtn.TabIndex = 5;
            this.closebtn.TabStop = false;
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // minbtn
            // 
            this.minbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minbtn.BackColor = System.Drawing.Color.White;
            this.minbtn.Image = global::YPassword.Properties.Resources.min;
            this.minbtn.Location = new System.Drawing.Point(270, 6);
            this.minbtn.Name = "minbtn";
            this.minbtn.Size = new System.Drawing.Size(16, 16);
            this.minbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.minbtn.TabIndex = 5;
            this.minbtn.TabStop = false;
            this.minbtn.Click += new System.EventHandler(this.minbtn_Click);
            // 
            // DesViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 770);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DesViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "加密本";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DesViewer_FormClosing);
            this.Load += new System.EventHandler(this.DesViewer_Load);
            this.Shown += new System.EventHandler(this.DesViewer_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.filterPanel.ResumeLayout(false);
            this.filterPanel.PerformLayout();
            this.filterPanel_title.ResumeLayout(false);
            this.filterPanel_title.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closebtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minbtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开加密文件ToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem 新建文件ToolStripMenuItem;
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.ToolStripMenuItem 保存文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 另存为RToolStripMenuItem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel filterPanel;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblMatch;
        private System.Windows.Forms.CheckBox chbIgnoreCase;
        private System.Windows.Forms.PictureBox closebtn;
        private System.Windows.Forms.Button btnPre;
        private System.Windows.Forms.Panel filterPanel_title;
        private System.Windows.Forms.PictureBox minbtn;

    }
}