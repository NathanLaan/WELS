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


        private Search lastSearch;

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnAddSearch_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm();
            if (this.lastSearch != null)
            {
                //
                // TODO: set if not null
                //
                searchForm.SearchParameters = this.lastSearch;
            }
            if (searchForm.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                this.lastSearch = searchForm.SearchParameters;
                //
                // TODO: Add search to search collection.
                // TODO: Create search results controls. 
                // TODO: Start search.
                //
                this.lsvSearchList.Items.Add(new ListViewItem(this.lastSearch.GetItems()));
            }
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




    }
}
