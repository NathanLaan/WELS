using System;
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
        }

        internal Search SearchParameters
        {
            set
            {
                this.txtServerName.Text = value.ServerName;
                this.txtEventLogName.Text = value.ServerName;
                //search.LogType = ((LogTypeItem)this.cboEventLogType.SelectedItem).Type;
                this.dtpStart.Value = value.StartTime;
                this.dtpEnd.Value = value.EndTime;
            }
            get
            {
                Search search = new Search();
                search.Text = this.txtSearchText.Text;
                search.ServerName = this.txtServerName.Text;
                search.LogName = this.txtEventLogName.Text;
                search.LogType = ((LogTypeItem)this.cboEventLogType.SelectedItem).Type;
                search.StartTime = this.dtpStart.Value;
                search.EndTime = this.dtpEnd.Value;

                return search;
            }
        }

        private void SearchControl_Load(object sender, EventArgs e)
        {
            this.ActiveControl = this.txtSearchText;
            this.txtSearchText.Focus();
        }

    }
}
