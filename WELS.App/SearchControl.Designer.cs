namespace WELS.App
{
    partial class SearchControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtServerName = new System.Windows.Forms.TextBox();
            this.txtEventLogName = new System.Windows.Forms.TextBox();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.cboEventLogType = new System.Windows.Forms.ComboBox();
            this.lblServerName = new System.Windows.Forms.Label();
            this.lblEventLogName = new System.Windows.Forms.Label();
            this.lblEventLogType = new System.Windows.Forms.Label();
            this.lblStartDateTime = new System.Windows.Forms.Label();
            this.lblEndDateTime = new System.Windows.Forms.Label();
            this.txtSearchText = new System.Windows.Forms.TextBox();
            this.lblSearchText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtServerName
            // 
            this.txtServerName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtServerName.Location = new System.Drawing.Point(129, 36);
            this.txtServerName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(239, 22);
            this.txtServerName.TabIndex = 1;
            // 
            // txtEventLogName
            // 
            this.txtEventLogName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEventLogName.Location = new System.Drawing.Point(129, 68);
            this.txtEventLogName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEventLogName.Name = "txtEventLogName";
            this.txtEventLogName.Size = new System.Drawing.Size(239, 22);
            this.txtEventLogName.TabIndex = 2;
            // 
            // dtpStart
            // 
            this.dtpStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpStart.Location = new System.Drawing.Point(129, 133);
            this.dtpStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(239, 22);
            this.dtpStart.TabIndex = 4;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpEnd.Location = new System.Drawing.Point(129, 165);
            this.dtpEnd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(239, 22);
            this.dtpEnd.TabIndex = 5;
            // 
            // cboEventLogType
            // 
            this.cboEventLogType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboEventLogType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEventLogType.FormattingEnabled = true;
            this.cboEventLogType.Location = new System.Drawing.Point(129, 100);
            this.cboEventLogType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboEventLogType.Name = "cboEventLogType";
            this.cboEventLogType.Size = new System.Drawing.Size(239, 24);
            this.cboEventLogType.TabIndex = 3;
            // 
            // lblServerName
            // 
            this.lblServerName.AutoSize = true;
            this.lblServerName.Location = new System.Drawing.Point(4, 39);
            this.lblServerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblServerName.Name = "lblServerName";
            this.lblServerName.Size = new System.Drawing.Size(95, 17);
            this.lblServerName.TabIndex = 11;
            this.lblServerName.Text = "Server Name:";
            // 
            // lblEventLogName
            // 
            this.lblEventLogName.AutoSize = true;
            this.lblEventLogName.Location = new System.Drawing.Point(4, 71);
            this.lblEventLogName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEventLogName.Name = "lblEventLogName";
            this.lblEventLogName.Size = new System.Drawing.Size(117, 17);
            this.lblEventLogName.TabIndex = 12;
            this.lblEventLogName.Text = "Event Log Name:";
            // 
            // lblEventLogType
            // 
            this.lblEventLogType.AutoSize = true;
            this.lblEventLogType.Location = new System.Drawing.Point(4, 103);
            this.lblEventLogType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEventLogType.Name = "lblEventLogType";
            this.lblEventLogType.Size = new System.Drawing.Size(112, 17);
            this.lblEventLogType.TabIndex = 13;
            this.lblEventLogType.Text = "Event Log Type:";
            // 
            // lblStartDateTime
            // 
            this.lblStartDateTime.AutoSize = true;
            this.lblStartDateTime.Location = new System.Drawing.Point(4, 140);
            this.lblStartDateTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStartDateTime.Name = "lblStartDateTime";
            this.lblStartDateTime.Size = new System.Drawing.Size(76, 17);
            this.lblStartDateTime.TabIndex = 14;
            this.lblStartDateTime.Text = "Start Date:";
            // 
            // lblEndDateTime
            // 
            this.lblEndDateTime.AutoSize = true;
            this.lblEndDateTime.Location = new System.Drawing.Point(4, 172);
            this.lblEndDateTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEndDateTime.Name = "lblEndDateTime";
            this.lblEndDateTime.Size = new System.Drawing.Size(71, 17);
            this.lblEndDateTime.TabIndex = 15;
            this.lblEndDateTime.Text = "End Date:";
            // 
            // txtSearchText
            // 
            this.txtSearchText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchText.Location = new System.Drawing.Point(129, 4);
            this.txtSearchText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearchText.Name = "txtSearchText";
            this.txtSearchText.Size = new System.Drawing.Size(239, 22);
            this.txtSearchText.TabIndex = 0;
            // 
            // lblSearchText
            // 
            this.lblSearchText.AutoSize = true;
            this.lblSearchText.Location = new System.Drawing.Point(4, 7);
            this.lblSearchText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearchText.Name = "lblSearchText";
            this.lblSearchText.Size = new System.Drawing.Size(88, 17);
            this.lblSearchText.TabIndex = 10;
            this.lblSearchText.Text = "Search Text:";
            // 
            // SearchControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblSearchText);
            this.Controls.Add(this.txtSearchText);
            this.Controls.Add(this.lblEndDateTime);
            this.Controls.Add(this.lblStartDateTime);
            this.Controls.Add(this.lblEventLogType);
            this.Controls.Add(this.lblEventLogName);
            this.Controls.Add(this.lblServerName);
            this.Controls.Add(this.cboEventLogType);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.txtEventLogName);
            this.Controls.Add(this.txtServerName);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SearchControl";
            this.Size = new System.Drawing.Size(373, 222);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtServerName;
        private System.Windows.Forms.TextBox txtEventLogName;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.ComboBox cboEventLogType;
        private System.Windows.Forms.Label lblServerName;
        private System.Windows.Forms.Label lblEventLogName;
        private System.Windows.Forms.Label lblEventLogType;
        private System.Windows.Forms.Label lblStartDateTime;
        private System.Windows.Forms.Label lblEndDateTime;
        private System.Windows.Forms.TextBox txtSearchText;
        private System.Windows.Forms.Label lblSearchText;
    }
}
