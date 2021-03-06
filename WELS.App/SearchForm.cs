﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WELS.App
{
    public partial class SearchForm : Form
    {

        /// <summary>
        /// Pass-through property for the SearchControl.
        /// </summary>
        internal Search SearchParameters
        {
            set
            {
                this.searchControl1.SearchParameters = value;
            }
            get
            {
                return this.searchControl1.SearchParameters;
            }
        }

        public SearchForm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = this.searchControl1;
            this.searchControl1.Focus();
        }

    }
}
