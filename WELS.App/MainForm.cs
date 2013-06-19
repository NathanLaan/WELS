using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

using System.Threading;
using System.Diagnostics;

namespace WELS.App
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnAddSearch_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm();
            searchForm.Show(this);
            this.lsvSearchList.Items.Add(new ListViewItem(Guid.NewGuid().ToString()));
        }

        #region Threading

        private Thread eventLogThread;
        private bool threadRunning = false;


        private class ThreadSafeInt
        {
            public Control Control { get; set; }
            public int Count { get; set; }
            private delegate void InternalDelegate();
            public ThreadSafeInt(Control control)
            {
                this.Control = control;
            }
            public void Increment()
            {
                if (this.Control.InvokeRequired)
                {
                    this.Control.Invoke(new InternalDelegate(Increment), new object[] { });
                }
                else
                {
                    this.Count++;
                }
            }
        }

        #endregion



        private void ProcessEventLog()
        {
            try
            {
                var log = new EventLog(this.txtEventLogName.Text, this.txtServerName.Text);
                int count = 0;
                foreach (EventLogEntry entry in log.Entries)
                {
                    if (!threadRunning)
                    {
                        break;
                    }
                    UpdateProgress(log.Entries.Count, count++);
                    
                }
            }
            catch (Exception e)
            {
                this.AppendText(e.ToString());
            }
        }


    }
}
