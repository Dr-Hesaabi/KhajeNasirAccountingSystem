﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KhajeNasirAccountingSystemReportClient.Compoents
{
    public partial class RexaLabel : Label
    {
        public RexaLabel()
        {
            InitializeComponent();
        }

        public RexaLabel(IContainer container)
        {
            container.Add(this);
            InitializeComponent();


        }
    }
}