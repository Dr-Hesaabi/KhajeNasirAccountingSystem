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
    public partial class RexaLabel : Label
    {
        public RexaLabel()
        {
            InitializeComponent();
        }

        public RexaLabel(IContainer container)
        {
            container.Add(this);

            Color defaultFore;
            defaultFore = DefaultForeColor;


            Timer t = new Timer();
            t.Interval = 100;
            t.Tick += delegate
            {
                int r, g, b;

                r = ForeColor.R;
                g = ForeColor.G;
                b = ForeColor.B;

                r += 25;
                g += 25;
                b += 25;

                if (r > 255)
                    r = 255;
                if (g > 255)
                    g = 255;
                if (b > 255)
                    b = 255;

                ForeColor = Color.FromArgb(r, g, b);

                if (r + g + b == 255 * 3)
                    t.Stop();

            };


            MouseHover += delegate
            {
                t.Start();
            };
            MouseLeave += delegate
            {
                ForeColor = defaultFore;
                t.Stop();
            };


            InitializeComponent();
        }
    }
}
