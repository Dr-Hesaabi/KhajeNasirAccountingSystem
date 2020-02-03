using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KhajeNasirAccountingSystemWindowsFormClient
{
    public partial class Default : Form
    {
        public Default()
        {
            InitializeComponent();
        }

        private void MenuCoustomer_Click(object sender, EventArgs e)
        {
            AdminCustomer f = new AdminCustomer();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void MenuHome_Click(object sender, EventArgs e)
        {
            AdminHome f = new AdminHome();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void MenuCheck_Click(object sender, EventArgs e)
        {
            Cheque f = new Cheque();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void Default_Load(object sender, EventArgs e)
        {
            label2.Text = "امروز " + DateTime.Now.ToShortDateString() + " • " + DateTime.Now.ToString("MMMM");
        }

        private void MenuReport_Click(object sender, EventArgs e)
        {
            new Reports().ShowDialog();
        }

        private void MenuLoan_Click(object sender, EventArgs e)
        {
            LoanForAll f = new LoanForAll();
            f.ShowDialog();
        }

        private void تغییررمزورودToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChanegePassword f = new ChanegePassword();
            f.ShowDialog();
        }
    }
}
