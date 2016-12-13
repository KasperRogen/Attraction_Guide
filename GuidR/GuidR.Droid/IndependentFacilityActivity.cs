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

    class IndependentFacilityActivity : Activity
    {
        public static Facility Facility { get; set; }
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.FacilityPage);

            FindViewById<ImageView>(Resource.Id.HeaderImage).SetImageResource((int)Facility.Image);

            FindViewById<TextView>(Resource.Id.Name).Text = Facility.Name;
            FindViewById<TextView>(Resource.Id.AboutFacility).Text = Facility.Description;

            FindViewById<Button>(Resource.Id.mapButton).Click += delegate 
            {
                MapActivity.Attraction = Facility;
                StartActivity(typeof(MapActivity));
            };

            ImageView banner = FindViewById<ImageView>(Resource.Id.homeBanner);
            banner.Click += delegate 
            {
                StartActivity(typeof(MainActivity));
            };
        }

    }
}