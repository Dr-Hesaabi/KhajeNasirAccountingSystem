using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace KNAC
{
    [Activity(Label = "صفحه اصلی", Icon = "@drawable/icon")]
    public class First : Activity
    {
   

        protected override void OnCreate(Bundle bundle)
        {
            
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.First);
            string r = string.Empty;
             Status.Status d = new Status.Status();
            PeopleService.PeopleService j = new PeopleService.PeopleService();
            var q = j.GetPerson(Intent.GetStringExtra("NationalCode"));
            r +=  "نام : " + q.FirstName + "\r\n";
            r += "نام خانوادگی : " + q.LastName + "\r\n";
            r += "کد ملی : " + q.NationalCode + "\r\n";
            r += "تاریخ افتتاح " + q.CreateDateTime + "\r\n";
            var bank = d.GetPeopleBank();
            r += "وام های گرفته شده : " + bank.Loan.ToString() + "\r\n";
            r += "مجموع پرداخت ها : " + bank.Deposit.ToString() + "\r\n";
            r += "قسط های پرداخت نشده : " + bank.NonPayedInstallements.ToString() + "\r\n";
            r += "قسط های پرداخت شده : " + bank.PayedInstallements.ToString() + "\r\n";
            r += "موجودی حساب : " + bank.Amount.ToString() + "\r\n";



            TextView tv = FindViewById<TextView>(Resource.Id.textView1);

            tv.Text = r;

        }

       
    }
}

