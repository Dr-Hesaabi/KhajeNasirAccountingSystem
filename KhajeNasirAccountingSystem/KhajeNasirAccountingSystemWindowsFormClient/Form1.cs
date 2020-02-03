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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {


            if (Username.Text != "" || Password.Text != "")
            {
                PeopleService.PeopleServiceClient a = new PeopleService.PeopleServiceClient();
                var myLogin = a.Login(Username.Text, Password.Text);
                if (myLogin.Success)
                {
                    if (myLogin.Role == "Admin")
                    {
                        Data.IsAdmin = true;
                        this.Hide();
                        DialogResult = DialogResult.OK;
                        if (!Username.ReadOnly)
                        {
                            Data.NationalCode = Username.Text;
                            AdminHome f = new AdminHome();
                            f.ShowDialog();

                        }
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("کاربری با این مشخصات وجود ندراد و یا حساب مسدود است");
                }
            }
            else
            {
                MessageBox.Show("لطفا همه فیلد ها رو پر کنید");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            About.AboutClient a = new About.AboutClient();

            if (a.Hello() == "Hello World! We are here.")
            {
                label3.Text = "Server Online";
                label3.BackColor = Color.Green;
            }
        }
    }
}
