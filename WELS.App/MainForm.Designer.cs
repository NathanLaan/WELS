namespace WELS.App
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mnu = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.sts = new System.Windows.Forms.StatusStrip();
            this.tsc = new System.Windows.Forms.ToolStripContainer();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tscSearch = new System.Windows.Forms.ToolStripContainer();
            this.lsvSearchList = new System.Windows.Forms.ListView();
            this.lsvSearchText = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tscSearch1 = new System.Windows.Forms.ToolStrip();
            this.btnAddSearch = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.lsvServer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lsvEventLog = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mnu.SuspendLayout();
            this.tsc.ContentPanel.SuspendLayout();
            this.tsc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tscSearch.ContentPanel.SuspendLayout();
            this.tscSearch.TopToolStripPanel.SuspendLayout();
            this.tscSearch.SuspendLayout();
            this.tscSearch1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnu
            // 
            this.mnu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile});
            this.mnu.Location = new System.Drawing.Point(0, 0);
            this.mnu.Name = "mnu";
            this.mnu.Size = new System.Drawing.Size(466, 24);
            this.mnu.TabIndex = 0;
            this.mnu.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(35, 20);
            this.mnuFile.Text = "&File";
            // 
            // mnuFileExit
            // 
            this.mnuFileExit.Name = "mnuFileExit";
            this.mnuFileExit.Size = new System.Drawing.Size(92, 22);
            this.mnuFileExit.Text = "E&xit";
            // 
            // sts
            // 
            this.sts.Location = new System.Drawing.Point(0, 330);
            this.sts.Name = "sts";
            this.sts.Size = new System.Drawing.Size(466, 22);
            this.sts.TabIndex = 1;
            this.sts.Text = "statusStrip1";
            // 
            // tsc
            // 
            // 
            // tsc.ContentPanel
            // 
            this.tsc.ContentPanel.Controls.Add(this.splitContainer1);
            this.tsc.ContentPanel.Size = new System.Drawing.Size(466, 286);
            this.tsc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tsc.Location = new System.Drawing.Point(0, 24);
            this.tsc.Name = "tsc";
            this.tsc.Size = new System.Drawing.Size(466, 306);
            this.tsc.TabIndex = 2;
            this.tsc.Text = "toolStripContainer1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tscSearch);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(466, 286);
            this.splitContainer1.SplitterDistance = 154;
            this.splitContainer1.TabIndex = 0;
            // 
            // tscSearch
            // 
            // 
            // tscSearch.ContentPanel
            // 
            this.tscSearch.ContentPanel.Controls.Add(this.lsvSearchList);
            this.tscSearch.ContentPanel.Size = new System.Drawing.Size(154, 261);
            this.tscSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tscSearch.Location = new System.Drawing.Point(0, 0);
            this.tscSearch.Name = "tscSearch";
            this.tscSearch.Size = new System.Drawing.Size(154, 286);
            this.tscSearch.TabIndex = 0;
            this.tscSearch.Text = "toolStripContainer1";
            // 
            // tscSearch.TopToolStripPanel
            // 
            this.tscSearch.TopToolStripPanel.Controls.Add(this.tscSearch1);
            // 
            // lsvSearchList
            // 
            this.lsvSearchList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lsvSearchText,
            this.lsvServer,
            this.lsvEventLog});
            this.lsvSearchList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvSearchList.Location = new System.Drawing.Point(0, 0);
            this.lsvSearchList.Name = "lsvSearchList";
            this.lsvSearchList.Size = new System.Drawing.Size(154, 261);
            this.lsvSearchList.TabIndex = 0;
            this.lsvSearchList.UseCompatibleStateImageBehavior = false;
            this.lsvSearchList.View = System.Windows.Forms.View.Details;
            // 
            // lsvSearchText
            // 
            this.lsvSearchText.Text = "Search";
            // 
            // tscSearch1
            // 
            this.tscSearch1.Dock = System.Windows.Forms.DockStyle.None;
            this.tscSearch1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddSearch,
            this.btnSave});
            this.tscSearch1.Location = new System.Drawing.Point(3, 0);
            this.tscSearch1.Name = "tscSearch1";
            this.tscSearch1.Size = new System.Drawing.Size(151, 25);
            this.tscSearch1.TabIndex = 0;
            // 
            // btnAddSearch
            // 
            this.btnAddSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnAddSearch.Image")));
            this.btnAddSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddSearch.Name = "btnAddSearch";
            this.btnAddSearch.Size = new System.Drawing.Size(96, 22);
            this.btnAddSearch.Text = "New Search...";
            this.btnAddSearch.Click += new System.EventHandler(this.btnAddSearch_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(51, 20);
            this.btnSave.Text = "Save";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.txtOutput);
            this.splitContainer2.Size = new System.Drawing.Size(308, 286);
            this.splitContainer2.SplitterDistance = 101;
            this.splitContainer2.TabIndex = 0;
            // 
            // txtOutput
            // 
            this.txtOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOutput.Location = new System.Drawing.Point(0, 0);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(203, 286);
            this.txtOutput.TabIndex = 0;
            // 
            // lsvServer
            // 
            this.lsvServer.Text = "Server";
            // 
            // lsvEventLog
            // 
            this.lsvEventLog.Text = "Event Log";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 352);
            this.Controls.Add(this.tsc);
            this.Controls.Add(this.sts);
            this.Controls.Add(this.mnu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnu;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Windows Event Log Search";
            this.mnu.ResumeLayout(false);
            this.mnu.PerformLayout();
            this.tsc.ContentPanel.ResumeLayout(false);
            this.tsc.ResumeLayout(false);
            this.tsc.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tscSearch.ContentPanel.ResumeLayout(false);
            this.tscSearch.TopToolStripPanel.ResumeLayout(false);
            this.tscSearch.TopToolStripPanel.PerformLayout();
            this.tscSearch.ResumeLayout(false);
            this.tscSearch.PerformLayout();
            this.tscSearch1.ResumeLayout(false);
            this.tscSearch1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnu;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuFileExit;
        private System.Windows.Forms.StatusStrip sts;
        private System.Windows.Forms.ToolStripContainer tsc;
        private System.Windows.Forms.ToolStripContainer tscSearch;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ToolStrip tscSearch1;
        private System.Windows.Forms.ToolStripButton btnAddSearch;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ListView lsvSearchList;
        private System.Windows.Forms.ColumnHeader lsvSearchText;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.ColumnHeader lsvServer;
        private System.Windows.Forms.ColumnHeader lsvEventLog;
    }
}

