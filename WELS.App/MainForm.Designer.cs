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
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tscSearch = new System.Windows.Forms.ToolStripContainer();
            this.tscSearch1 = new System.Windows.Forms.ToolStrip();
            this.btnAddSearch = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.mnu.SuspendLayout();
            this.tsc.ContentPanel.SuspendLayout();
            this.tsc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.SuspendLayout();
            this.tscSearch.TopToolStripPanel.SuspendLayout();
            this.tscSearch.SuspendLayout();
            this.tscSearch1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnu
            // 
            this.mnu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile});
            this.mnu.Location = new System.Drawing.Point(0, 0);
            this.mnu.Name = "mnu";
            this.mnu.Size = new System.Drawing.Size(472, 24);
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
            this.mnuFileExit.Size = new System.Drawing.Size(152, 22);
            this.mnuFileExit.Text = "E&xit";
            // 
            // sts
            // 
            this.sts.Location = new System.Drawing.Point(0, 271);
            this.sts.Name = "sts";
            this.sts.Size = new System.Drawing.Size(472, 22);
            this.sts.TabIndex = 1;
            this.sts.Text = "statusStrip1";
            // 
            // tsc
            // 
            // 
            // tsc.ContentPanel
            // 
            this.tsc.ContentPanel.Controls.Add(this.splitContainer1);
            this.tsc.ContentPanel.Size = new System.Drawing.Size(472, 222);
            this.tsc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tsc.Location = new System.Drawing.Point(0, 24);
            this.tsc.Name = "tsc";
            this.tsc.Size = new System.Drawing.Size(472, 247);
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
            this.splitContainer1.Size = new System.Drawing.Size(472, 222);
            this.splitContainer1.SplitterDistance = 157;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Size = new System.Drawing.Size(311, 222);
            this.splitContainer2.SplitterDistance = 103;
            this.splitContainer2.TabIndex = 0;
            // 
            // tscSearch
            // 
            // 
            // tscSearch.ContentPanel
            // 
            this.tscSearch.ContentPanel.Size = new System.Drawing.Size(157, 197);
            this.tscSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tscSearch.Location = new System.Drawing.Point(0, 0);
            this.tscSearch.Name = "tscSearch";
            this.tscSearch.Size = new System.Drawing.Size(157, 222);
            this.tscSearch.TabIndex = 0;
            this.tscSearch.Text = "toolStripContainer1";
            // 
            // tscSearch.TopToolStripPanel
            // 
            this.tscSearch.TopToolStripPanel.Controls.Add(this.tscSearch1);
            // 
            // tscSearch1
            // 
            this.tscSearch1.Dock = System.Windows.Forms.DockStyle.None;
            this.tscSearch1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddSearch,
            this.btnSave});
            this.tscSearch1.Location = new System.Drawing.Point(3, 0);
            this.tscSearch1.Name = "tscSearch1";
            this.tscSearch1.Size = new System.Drawing.Size(154, 25);
            this.tscSearch1.TabIndex = 0;
            // 
            // btnAddSearch
            // 
            this.btnAddSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnAddSearch.Image")));
            this.btnAddSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddSearch.Name = "btnAddSearch";
            this.btnAddSearch.Size = new System.Drawing.Size(96, 22);
            this.btnAddSearch.Text = "New Search...";
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(51, 20);
            this.btnSave.Text = "Save";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 293);
            this.Controls.Add(this.tsc);
            this.Controls.Add(this.sts);
            this.Controls.Add(this.mnu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnu;
            this.Name = "MainForm";
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
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tscSearch.TopToolStripPanel.ResumeLayout(false);
            this.tscSearch.TopToolStripPanel.PerformLayout();
            this.tscSearch.ResumeLayout(false);
            this.tscSearch.PerformLayout();
            this.tscSearch1.ResumeLayout(false);
            this.tscSearch1.PerformLayout();
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
    }
}

