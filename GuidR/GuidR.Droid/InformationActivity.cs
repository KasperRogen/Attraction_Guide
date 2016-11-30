using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace GuidR.Droid
{
    [Activity(Label = "Aalborg Zoo", Theme = "@style/NoTitle.splash")]
    class InformationActivity : Activity
    {

        protected override void OnCreate(Bundle bundle)
        {

            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Information);



            Button openingHoursButton = FindViewById<Button>(Resource.Id.openingHoursButton);
            Button webpageButton = FindViewById<Button>(Resource.Id.webpageButton);
            Button ticketsButton = FindViewById<Button>(Resource.Id.ticketsButton);
            Button zoomapButton = FindViewById<Button>(Resource.Id.zoomapButton);


            openingHoursButton.Click += delegate
            {
                var uri = Android.Net.Uri.Parse("http://aalborgzoo.dk/aabningstider.aspx");
                var intent = new Intent(Intent.ActionView, uri);
                StartActivity(intent);
            };

            webpageButton.Click += delegate
            {
                var uri = Android.Net.Uri.Parse("http://aalborgzoo.dk/forside.aspx");
                var intent = new Intent(Intent.ActionView, uri);
                StartActivity(intent);
            };

            ticketsButton.Click += delegate
            {
                var uri = Android.Net.Uri.Parse("http://shop.aalborgzoo.dk/da/category/5/Entr%C3%A9");
                var intent = new Intent(Intent.ActionView, uri);
                StartActivity(intent);
            };

            zoomapButton.Click += delegate
            {
                var uri = Android.Net.Uri.Parse("http://aalborgzoo.dk/UserFiles/image/zookort-m-ikoner-2015-2.jpg");
                var intent = new Intent(Intent.ActionView, uri);
                StartActivity(intent);

                // MÅSKE INDLEJRE BILLEDET I PROGRAMMET I STEDET FOR AT SE DET GENNEM EN HJEMMESIDE?
            };
        }
    }
}