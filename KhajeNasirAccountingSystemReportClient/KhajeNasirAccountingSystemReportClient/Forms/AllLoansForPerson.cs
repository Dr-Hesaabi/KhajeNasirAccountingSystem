﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KhajeNasirAccountingSystemReportClient.Forms
{
    public partial class AllLoansForPerson : MasterForm
    {
        public AllLoansForPerson(string PersonNationalCode)
        {
            NationalCode = PersonNationalCode;
            InitializeComponent();
        }
        public string NationalCode { get; set; }
        private void AllLoansForPerson_Load(object sender, EventArgs e)
        {
            Text += NationalCode;
            AllLoansForPersonModelBindingSource.DataSource = MVVM.AllLoansForPerson.Get(NationalCode);
            this.reportViewer1.RefreshReport();
        }
    }
}