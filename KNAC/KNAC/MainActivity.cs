using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace KNAC
{
    [Activity(Label = "صندوق امین", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            
            SetContentView(Resource.Layout.Main);

            try
            {
                About.About b = new About.About();
                b.Hello();
                Toast.MakeText(this,"Server Online" , ToastLength.Long).Show();
            }
            catch {
                Toast.MakeText(this, "Server Offline", ToastLength.Long).Show();
            }

            Button btn = FindViewById<Button>(Resource.Id.button1);
            btn.Click += Btn_Click;
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            EditText Username = FindViewById<EditText>(Resource.Id.editText1);
            EditText Password = FindViewById<EditText>(Resource.Id.editText2);
            if (Username.Text=="" || Password.Text=="")
            {
                var ms = new AlertDialog.Builder(this);
                ms.SetMessage("لطفا همه فیلد ها رو پر کنید");
                ms.SetNeutralButton("ok", delegate { });
                ms.Show();
            }
            else
            {
                PeopleService.PeopleService a = new PeopleService.PeopleService();
                var login = a.Login(Username.Text, Password.Text);
                if(login.Success)
                {
                    var activity2 = new Intent(this, typeof(First));
                    activity2.PutExtra("NationalCode", Username.Text);
                    StartActivity(activity2);
                    Finish();
                }
                else
                {
                    var ms = new AlertDialog.Builder(this);
                    ms.SetMessage("کاربری با این مشخصات وجود ندارد");
                    ms.SetNeutralButton("ok", delegate { });
                    ms.Show();
                }
            }
        }
    }
}

