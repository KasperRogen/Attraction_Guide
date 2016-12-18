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
    class PlaygroundMenuActivity : Activity
    {
        public static Facility Facility { get; set; }
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.PlaygroundMenu);

            Button playground1_irl = FindViewById<Button>(Resource.Id.playGround1_irl);
            Button playground2_irl = FindViewById<Button>(Resource.Id.playGround2_irl);
            Button playground3_irl = FindViewById<Button>(Resource.Id.playGround3_irl);

            /*
            playground1_irl.Click += delegate
            {
                LoadFacilityPage(AttractionDataBase.Playground1_irl);
            };

            playground2_irl.Click += delegate
            {
                LoadFacilityPage(AttractionDataBase.Bornezoo);
            };

            playground3_irl.Click += delegate
            {
                LoadFacilityPage(AttractionDataBase.zoofariScene);
            };

            ImageView banner = FindViewById<ImageView>(Resource.Id.homeBanner);
            banner.Click += delegate {
                StartActivity(typeof(MainActivity));
            };
            */

        }
        void LoadFacilityPage(string facility)
        {
            //FindViewById<ImageView>(Resource.Id.HeaderImage) = 
            IndependentFacilityActivity.Facility = facility;
            StartActivity(typeof(IndependentFacilityActivity));
        }
    }
}