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
    public partial class AdminCustomer : Default
    {
        public AdminCustomer()
        {
            InitializeComponent();
        }
        PeopleService.PeopleServiceClient a;
        private void label9_Click(object sender, EventArgs e)
        {
            AdminCustomerAE f = new AdminCustomerAE();
            f.id = 0;//add
            f.ShowDialog();
            a = new PeopleService.PeopleServiceClient();
            dataGridView1.DataSource = a.GetPeople().Select(x => new { x.NationalCode, x.FirstName, x.LastName, x.FathersName, x.Tel, x.Mobile, x.IsActive }).ToList();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            AdminCustomerAE f = new AdminCustomerAE();
            f.id = 1;//edit
            f.NatinalCode = dataGridView1.SelectedRows[0].Cells["NatinalCode"].Value.ToString();
            f.ShowDialog();
            a = new PeopleService.PeopleServiceClient();
            var c= a.GetPeople().Select(x => new { x.NationalCode, x.FirstName, x.LastName, x.FathersName, x.Tel, x.Mobile, x.IsActive }).ToList();
            dataGridView1.DataSource = c;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            PeopleService.PeopleServiceClient a = new PeopleService.PeopleServiceClient();
            bool t = a.GetPerson(dataGridView1.SelectedRows[0].Cells["NatinalCode"].Value.ToString()).IsActive;
            if(t)
            {
                if (MessageBox.Show("آیا از بستن حساب اطمینان دارید؟", "خطا", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    
                        Status.StatusClient SC = new Status.StatusClient();
                        SC.SetActive(dataGridView1.SelectedRows[0].Cells["NatinalCode"].Value.ToString(), false);
                        a = new PeopleService.PeopleServiceClient();
                        dataGridView1.DataSource = a.GetPeople().Select(x => new { x.NationalCode, x.FirstName, x.LastName, x.FathersName, x.Tel, x.Mobile, x.IsActive }).ToList();
                   

                }
            }
            else
            {
                if (MessageBox.Show("آیا از بازکردن حساب اطمینان دارید؟", "خطا", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    
                        Status.StatusClient SC = new Status.StatusClient();
                        SC.SetActive(dataGridView1.SelectedRows[0].Cells["NatinalCode"].Value.ToString(), true);
                        a = new PeopleService.PeopleServiceClient();
                        dataGridView1.DataSource = a.GetPeople().Select(x => new { x.NationalCode, x.FirstName, x.LastName, x.FathersName, x.Tel, x.Mobile, x.IsActive }).ToList();
                    

                }
            }
            
        }

        private void AdminCustomer_Load(object sender, EventArgs e)
        {
            a = new PeopleService.PeopleServiceClient();
            dataGridView1.DataSource = a.GetPeople().Select(x=> new {x.NationalCode , x.FirstName,x.LastName,x.FathersName,x.Tel,x.Mobile,x.IsActive }).ToList();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            a = new PeopleService.PeopleServiceClient();
            dataGridView1.DataSource = a.GetPeople().Select(x => new { x.NationalCode, x.FirstName, x.LastName, x.FathersName, x.Tel, x.Mobile, x.IsActive }).Where(x=>x.FirstName.Contains(FirstName.Text) && x.LastName.Contains(LastName.Text) && x.NationalCode.Contains(NationalCode.Text)/*&& x.BirthCity=BirthDate.Value*/).ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            a = new PeopleService.PeopleServiceClient();
            dataGridView1.DataSource = a.GetPeople().Select(x => new { x.NationalCode, x.FirstName, x.LastName, x.FathersName, x.Tel, x.Mobile, x.IsActive }).ToList();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            AdminCustomerAE f = new AdminCustomerAE();
            f.id = 2;//demo
            f.NatinalCode = dataGridView1.SelectedRows[0].Cells["NatinalCode"].Value.ToString();
            f.ShowDialog();
            a = new PeopleService.PeopleServiceClient();
            dataGridView1.DataSource = a.GetPeople().Select(x => new { x.NationalCode, x.FirstName, x.LastName, x.FathersName, x.Tel, x.Mobile, x.IsActive }).ToList();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            ReceivedLoan f = new ReceivedLoan();
            f.NationalCode= dataGridView1.SelectedRows[0].Cells["NatinalCode"].Value.ToString();
            f.ShowDialog();
            a = new PeopleService.PeopleServiceClient();
            dataGridView1.DataSource = a.GetPeople().Select(x => new { x.NationalCode, x.FirstName, x.LastName, x.FathersName, x.Tel, x.Mobile, x.IsActive }).ToList();

        }

        private void label13_Click(object sender, EventArgs e)
        {
            PaymentAndLoan f = new PaymentAndLoan();
            f.NationalCode1= dataGridView1.SelectedRows[0].Cells["NatinalCode"].Value.ToString();
            f.ShowDialog();
            a = new PeopleService.PeopleServiceClient();
            dataGridView1.DataSource = a.GetPeople().Select(x => new { x.NationalCode, x.FirstName, x.LastName, x.FathersName, x.Tel, x.Mobile, x.IsActive }).ToList();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {
            InsertLoan f = new InsertLoan();
            f.NationalCode1 = dataGridView1.SelectedRows[0].Cells["NatinalCode"].Value.ToString();
            f.ShowDialog();
            a = new PeopleService.PeopleServiceClient();
            dataGridView1.DataSource = a.GetPeople().Select(x => new { x.NationalCode, x.FirstName, x.LastName, x.FathersName, x.Tel, x.Mobile, x.IsActive }).ToList();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Payment f = new Payment();
            f.NationalCode = dataGridView1.SelectedRows[0].Cells["NatinalCode"].Value.ToString();
            f.ShowDialog();
            a = new PeopleService.PeopleServiceClient();
            dataGridView1.DataSource = a.GetPeople().Select(x => new { x.NationalCode, x.FirstName, x.LastName, x.FathersName, x.Tel, x.Mobile, x.IsActive }).ToList();
        }
    }
}
