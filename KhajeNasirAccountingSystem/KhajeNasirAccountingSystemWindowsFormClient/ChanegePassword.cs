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
    public partial class ChanegePassword : DefaultPopUp
    {
        public ChanegePassword()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="" || textBox2.Text=="")
            {
                MessageBox.Show("همه فیلد ها باید پر شود");
            }
            else
            {
                if(textBox1.Text==textBox2.Text)
                {
                    Form1 f = new Form1();
                    f.Username.Text = Data.NationalCode;
                    f.Username.ReadOnly = true;
                    if (f.ShowDialog() == DialogResult.OK)
                    {
                        PeopleService.PeopleServiceClient a = new PeopleService.PeopleServiceClient();
                        a.ChangePass(Data.NationalCode, textBox1.Text);
                        MessageBox.Show("رمز با موفقیت تغییر کرد");
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("رمز ورود با تکرار رمز ورود یکسان نیست");
                }
                
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
