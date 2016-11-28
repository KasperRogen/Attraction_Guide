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
    class SmokeAreaMenuActivity : Activity
    {
        public static Facility Facility { get; set; }
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.SmokeAreaMenu);

            Button smokeArea1_irl = FindViewById<Button>(Resource.Id.smokeAreaButton1_irl);
            Button smokeArea2_irl = FindViewById<Button>(Resource.Id.smokeAreaButton2_irl);

            smokeArea1_irl.Click += delegate
            {
                LoadSmoke(AttractionDataBase.SmokeArea1);
                MapActivity.Attraction = Facility;
                StartActivity(typeof(MapActivity));
            };

            smokeArea2_irl.Click += delegate
            {
                LoadSmoke(AttractionDataBase.SmokeArea2);
                MapActivity.Attraction = Facility;
                StartActivity(typeof(MapActivity));
            };

        }
        public void LoadSmoke(Facility facility)
        {
            SmokeAreaMenuActivity.Facility = facility;
        }
    }
}