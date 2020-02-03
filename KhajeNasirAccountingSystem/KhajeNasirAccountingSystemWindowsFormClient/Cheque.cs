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
    public partial class Cheque : Default
    {
        public Cheque()
        {
            InitializeComponent();
        }

        private void Cheque_Load(object sender, EventArgs e)
        {
            MyRefresh();
        }

        private void MyRefresh()
        {

            ChequeService.ChequeServiceClient a = new ChequeService.ChequeServiceClient();
            var query = a.GetCheque();
            var theList = query.Select(x => new { x.Description, x.Id, x.PayTo, x.Amount, x.IssuanceDateTime, x.ConsecutiveNumber });//.ToList();
            dataGridView1.DataSource = query;
        }

        private void label9_Click(object sender, EventArgs e)
        {
            InsertCheque f = new InsertCheque();
            f.ShowDialog();
            MyRefresh();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            ChequeReportForm f = new ChequeReportForm();
            f.Id = Guid.Parse(dataGridView1.SelectedRows[0].Cells["Id"].Value.ToString());
            f.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            InsertCheque f = new InsertCheque();
            f.MyId = Guid.Parse(dataGridView1.SelectedRows[0].Cells["Id"].Value.ToString());
            f.textBox1.Text = (dataGridView1.SelectedRows[0].Cells["Description"].Value ?? "").ToString();
            f.Amount.Text = dataGridView1.SelectedRows[0].Cells["Amount"].Value.ToString();
            f.dateTimePicker1.Text = dataGridView1.SelectedRows[0].Cells["IssuanceDateTime"].Value.ToString();
            f.PayTo.Text = dataGridView1.SelectedRows[0].Cells["PayTo"].Value.ToString();
            f.MyMode = "Edit";
            f.ShowDialog();
            MyRefresh();
        }
    }
}
