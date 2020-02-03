using System;
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
    public partial class RexaButton : Button
    {
        public RexaButton()
        {
            InitializeComponent();
        }

        public RexaButton(IContainer container)
        {



            container.Add(this);

            Color defaultBack, defaultFore;
            defaultBack = BackColor;
            defaultFore = DefaultForeColor;


            Timer t = new Timer();
            t.Interval = 50;
            t.Tick += delegate
            {
                ForeColor = Color.White;

                int r, g, b;

                r = BackColor.R;
                g = BackColor.G;
                b = BackColor.B;

                r -= 25;
                g -= 25;
                b -= 25;

                if (r < 0)
                    r = 0;
                if (g < 0)
                    g = 0;
                if (b < 0)
                    b = 0;

                BackColor = Color.FromArgb(r, g, b);

                if (r + g + b == 0)
                    t.Stop();

            };


            MouseHover += delegate
            {
                t.Start();
            };
            MouseLeave += delegate
            {
                BackColor = defaultBack;
                ForeColor = defaultFore;
                t.Stop();
            };

            InitializeComponent();
        }
    }
}
