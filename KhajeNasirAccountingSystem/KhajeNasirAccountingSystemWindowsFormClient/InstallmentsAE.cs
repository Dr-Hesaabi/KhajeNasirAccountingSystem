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
    public partial class InstallmentsAE : DefaultPopUp
    {
        public InstallmentsAE()
        {
            InitializeComponent();
        }
       public int rol = -1;
        public Guid id { get; set; }
        public Guid idIns { get; set; }
        private void InstallmentsAE_Load(object sender, EventArgs e)
        {
            if(rol==1)//edit
            {
                InstallementsService.InstallementsServiceClient a = new InstallementsService.InstallementsServiceClient();
                var b =a.GetLoanInstallements(id).Where(x=>x.Id == idIns).FirstOrDefault();
                Amount.Text = b.Amount.ToString();
                dateTimePicker1.Value=b.PaymentDate.Value;
                
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InstallementsService.InstallementsServiceClient a = new InstallementsService.InstallementsServiceClient();
            if(rol==1)
            {
                a.UpdateInstallements(idIns, dateTimePicker1.Value.Date, decimal.Parse(Amount.Text), id);
                MessageBox.Show("قسط با موفقیت ویرایش شد");
                this.Close();
            }
            else if (rol==0)
            {
                a.InsertInstallements(Guid.NewGuid(), dateTimePicker1.Value.Date, decimal.Parse(Amount.Text), id);
                MessageBox.Show("قسط با موفقیت ثبت شد");
                this.Close();
            }
        }
    }
}
