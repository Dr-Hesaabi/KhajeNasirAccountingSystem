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
    public partial class AdminCustomerAE : DefaultPopUp
    {
        public int id { get; set; }
        public string NatinalCode { get; set; }
        public AdminCustomerAE()
        {
            InitializeComponent();
        }

        private void AdminCustomerAE_Load(object sender, EventArgs e)
        {
            if(id==0)//add
            {
                label1.Text = "افزودن مشتری";
            }
            else if(id==1)
            {
                label1.Text = "ویرایش مشتری";
                NationalCode.Enabled = false;
                PeopleService.PeopleServiceClient a = new PeopleService.PeopleServiceClient();
                var b = a.GetPerson(NatinalCode);
                NationalCode.Text = b.NationalCode;
                FirstName.Text = b.FirstName;
                LastName.Text = b.LastName;
                FathersName.Text = b.FathersName;
                BirthCity.Text = b.BirthCity;
                // b.BirthDate
                // Address.Text = b.Address;
                PostalCode.Text = b.PostalCode;
                Tel.Text = b.Tel;
                Mobile.Text = b.Mobile;
                sahm.Text =b.Contribution.ToString();


            }
            else if(id==2)
            {
                label1.Text = "مشاهده مشتری";
                FirstName.Enabled = false;
                LastName.Enabled = false;
                FathersName.Enabled = false;
                BirthCity.Enabled = false;
                
                PostalCode.Enabled = false;
                Tel.Enabled = false;
                Mobile.Enabled = false;
                Password.Enabled = false;
                PasswordAgain.Enabled = false;
                button1.Enabled = false;
                sahm.Enabled = false;
                NationalCode.Enabled = false;
                PeopleService.PeopleServiceClient a = new PeopleService.PeopleServiceClient();
                var b = a.GetPerson(NatinalCode);
                NationalCode.Text = b.NationalCode;
                FirstName.Text = b.FirstName;
                LastName.Text = b.LastName;
                FathersName.Text = b.FathersName;
                BirthCity.Text = b.BirthCity;
                // b.BirthDate
                // Address.Text = b.Address;
                PostalCode.Text = b.PostalCode;
                Tel.Text = b.Tel;
                sahm.Text = b.Contribution.ToString();
                Mobile.Text = b.Mobile;
                Password.Enabled = false;
                PasswordAgain.Enabled = false;


            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PeopleService.PeopleServiceClient a = new PeopleService.PeopleServiceClient();
            
            if(NationalCode.Text=="" ||LastName.Text=="" || Mobile.Text=="" || BirthCity.Text=="" ||  Password.Text=="" ||PasswordAgain.Text==""||sahm.Text=="")
            {
                MessageBox.Show("لطفا همه فیلد ها را پر کنید");
            }
            else
            {
               
                


                
                if (Password.Text==PasswordAgain.Text)
                {
                    
                    if (id == 0)
                    {
                            a.InsertPeople(NationalCode.Text, FirstName.Text, LastName.Text, FathersName.Text, Tel.Text, Mobile.Text, BirthCity.Text, PostalCode.Text, null, "Customer", DateTime.Now, Password.Text,decimal.Parse(sahm.Text));
                            MessageBox.Show("کاربر با موفقیت ثبت شد");
                            this.Close();
                          
                    
                        

                    }
                    else if(id==1)
                    {
                        
                            a.UpdatePeople(NationalCode.Text, FirstName.Text, LastName.Text, FathersName.Text, Tel.Text, Mobile.Text, BirthCity.Text, PostalCode.Text,null,DateTime.Now,Password.Text,decimal.Parse(sahm.Text));
                            MessageBox.Show("با موفقیت ویرایش شد");
                            this.Close();
                 
                    }
                    
                }
                else
                {
                    MessageBox.Show("رمز ورود و تکرار رمز ورود یکسان نیست");
                }
            }
        }
    }
}
