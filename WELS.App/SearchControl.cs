﻿using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace WELS.App
{
    public partial class SearchControl : UserControl
    {

        public class LogTypeItem
        {

            public LogTypeItem(EventLogEntryType type)
            {
                this.Type = type;
            }

            public EventLogEntryType Type { get; set; }

            public override string ToString()
            {
                return Type.ToString();
            }
        }

        public SearchControl()
        {
            InitializeComponent();
            this.cboEventLogType.Items.Add(new LogTypeItem(EventLogEntryType.Error));
            this.cboEventLogType.Items.Add(new LogTypeItem(EventLogEntryType.FailureAudit));
            this.cboEventLogType.Items.Add(new LogTypeItem(EventLogEntryType.Information));
            this.cboEventLogType.Items.Add(new LogTypeItem(EventLogEntryType.SuccessAudit));
            this.cboEventLogType.Items.Add(new LogTypeItem(EventLogEntryType.Warning));
            this.cboEventLogType.SelectedIndex = 0;
        }

        internal Search SearchParameters
        {
            set
            {
                this.txtSearchText.Text = value.SearchText;
                this.txtComputerName.Text = value.ServerName;
                this.cboEventLogName.Text = value.ServerName;
                //search.LogType = ((LogTypeItem)this.cboEventLogType.SelectedItem).Type;
                this.dtpStart.Value = value.StartTime;
                this.dtpEnd.Value = value.EndTime;
            }
            get
            {
                Search search = new Search();
                search.SearchText = this.txtSearchText.Text;
                search.ServerName = this.txtComputerName.Text;
                search.EventLogName = this.cboEventLogName.Text;
                search.LogType = ((LogTypeItem)this.cboEventLogType.SelectedItem).Type;
                search.StartTime = this.dtpStart.Value;
                search.EndTime = this.dtpEnd.Value;

                return search;
            }
        }

        private void btnGetEventLogList_Click(object sender, EventArgs e)
        {
            string computerName = this.txtComputerName.Text;
            if (!string.IsNullOrEmpty(computerName))
            {
                EventLog[] list = EventLog.GetEventLogs(computerName);
                foreach (EventLog log in list)
                {
                    this.cboEventLogName.Items.Add(log.LogDisplayName);
                }
            }
        }

    }
}
