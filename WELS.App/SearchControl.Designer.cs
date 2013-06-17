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
            this.txt = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblServerName = new System.Windows.Forms.Label();
            this.lblEventLogName = new System.Windows.Forms.Label();
            this.lblEventLogType = new System.Windows.Forms.Label();
            this.lblStartDateTime = new System.Windows.Forms.Label();
            this.lblEndDateTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt
            // 
            this.txt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt.Location = new System.Drawing.Point(129, 5);
            this.txt.Margin = new System.Windows.Forms.Padding(4);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(459, 22);
            this.txt.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(129, 37);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(459, 22);
            this.textBox1.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Location = new System.Drawing.Point(129, 102);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(459, 22);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker2.Location = new System.Drawing.Point(129, 134);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(459, 22);
            this.dateTimePicker2.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(129, 69);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(459, 24);
            this.comboBox1.TabIndex = 3;
            // 
            // lblServerName
            // 
            this.lblServerName.AutoSize = true;
            this.lblServerName.Location = new System.Drawing.Point(4, 9);
            this.lblServerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblServerName.Name = "lblServerName";
            this.lblServerName.Size = new System.Drawing.Size(95, 17);
            this.lblServerName.TabIndex = 4;
            this.lblServerName.Text = "Server Name:";
            // 
            // lblEventLogName
            // 
            this.lblEventLogName.AutoSize = true;
            this.lblEventLogName.Location = new System.Drawing.Point(4, 41);
            this.lblEventLogName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEventLogName.Name = "lblEventLogName";
            this.lblEventLogName.Size = new System.Drawing.Size(117, 17);
            this.lblEventLogName.TabIndex = 5;
            this.lblEventLogName.Text = "Event Log Name:";
            // 
            // lblEventLogType
            // 
            this.lblEventLogType.AutoSize = true;
            this.lblEventLogType.Location = new System.Drawing.Point(4, 73);
            this.lblEventLogType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEventLogType.Name = "lblEventLogType";
            this.lblEventLogType.Size = new System.Drawing.Size(112, 17);
            this.lblEventLogType.TabIndex = 6;
            this.lblEventLogType.Text = "Event Log Type:";
            // 
            // lblStartDateTime
            // 
            this.lblStartDateTime.AutoSize = true;
            this.lblStartDateTime.Location = new System.Drawing.Point(4, 110);
            this.lblStartDateTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStartDateTime.Name = "lblStartDateTime";
            this.lblStartDateTime.Size = new System.Drawing.Size(76, 17);
            this.lblStartDateTime.TabIndex = 7;
            this.lblStartDateTime.Text = "Start Date:";
            // 
            // lblEndDateTime
            // 
            this.lblEndDateTime.AutoSize = true;
            this.lblEndDateTime.Location = new System.Drawing.Point(4, 142);
            this.lblEndDateTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEndDateTime.Name = "lblEndDateTime";
            this.lblEndDateTime.Size = new System.Drawing.Size(71, 17);
            this.lblEndDateTime.TabIndex = 8;
            this.lblEndDateTime.Text = "End Date:";
            // 
            // SearchControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblEndDateTime);
            this.Controls.Add(this.lblStartDateTime);
            this.Controls.Add(this.lblEventLogType);
            this.Controls.Add(this.lblEventLogName);
            this.Controls.Add(this.lblServerName);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txt);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SearchControl";
            this.Size = new System.Drawing.Size(593, 170);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblServerName;
        private System.Windows.Forms.Label lblEventLogName;
        private System.Windows.Forms.Label lblEventLogType;
        private System.Windows.Forms.Label lblStartDateTime;
        private System.Windows.Forms.Label lblEndDateTime;
    }
}
