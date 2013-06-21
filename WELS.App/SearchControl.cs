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

        Search SearchParameters
        {
            get
            {
                Search search = new Search();
                search.ServerName = this.txtServerName.Text;
                search.LogName = this.txtEventLogName.Text;
                search.LogType = ((LogTypeItem)this.cboEventLogType.SelectedItem).Type;
                search.StartTime = this.dtpStart.Value;
                search.EndTime = this.dtpEnd.Value;

                return search;
            }
        }

    }
}
