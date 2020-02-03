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
    public partial class PayedInstallment : DefaultPopUp
    {
        
        public Guid InsId { get; set; }
        public PayedInstallment()
        {
            InitializeComponent();
        }

        private void PayedInstallment_Load(object sender, EventArgs e)
        {
            InstallementsService.InstallementsServiceClient a = new InstallementsService.InstallementsServiceClient();
            var b = a.GetPeopleInstallements().Select(x => new { x.InstallementId, x.Fullname, x.NationalCode, x.Amount, x.PaymentDate, x.InstallementIsPayed }).Where(x => x.InstallementIsPayed == false && x.PaymentDate <= System.DateTime.Now).ToList();


            
            NationalCode.Text = b[0].NationalCode;            
            LastName.Text = b[0].Fullname;
            Phone.Text = new PeopleService.PeopleServiceClient().GetPerson(b[0].NationalCode).Mobile;
            Amount.Text = b[0].Amount.ToString();
            Status.StatusClient c = new Status.StatusClient();
            Mojododi.Text = c.GetPeopleBank().Amount.ToString();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(decimal.Parse(Mojododi.Text)>=decimal.Parse(Amount.Text))
            {
                InstallementsService.InstallementsServiceClient a = new InstallementsService.InstallementsServiceClient();
                a.PayInstallement(InsId, true);
                MessageBox.Show("با موفقیت وصول شد");
                this.Close();
            }
            else
            {
                MessageBox.Show("موجودی کاربر کافی نیست");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
