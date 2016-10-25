using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Widget;

namespace GuidR.Droid
{
    [Activity(Label = "Aalborg Zoo", Theme = "@style/NoTitle.splash")]
    class FacilitiesMenuActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.FacilitiesMenu);

            Button button1 = FindViewById<Button>(Resource.Id.toiletButton1);
            Button button2 = FindViewById<Button>(Resource.Id.toiletButton2);

            button1.Click += delegate
            {
                Console.WriteLine("hej! :3");
            };

            button2.Click += delegate
            {
                Console.WriteLine("HEJ2");
            };
        }

    }
}