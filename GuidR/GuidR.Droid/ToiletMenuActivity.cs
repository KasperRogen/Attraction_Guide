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
    class ToiletMenuActivity : Activity
    {
        public static Facility Facility { get; set; }
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.ToiletMenu);

            Button toilet1_irl = FindViewById<Button>(Resource.Id.toilet1_irl);
            Button toilet2_irl = FindViewById<Button>(Resource.Id.toilet2_irl);
            Button toilet3_irl = FindViewById<Button>(Resource.Id.toilet3_irl);
            Button toilet4_irl = FindViewById<Button>(Resource.Id.toilet4_irl);
            Button toilet5_irl = FindViewById<Button>(Resource.Id.toilet5_irl);

            toilet1_irl.Click += delegate
            {
                LoadFacilityPage(AttractionDataBase.Toilet1);
            };

            toilet2_irl.Click += delegate
            {
                LoadFacilityPage(AttractionDataBase.Toilet2);
            };

            toilet3_irl.Click += delegate
            {
                LoadFacilityPage(AttractionDataBase.Toilet3);
            };

            toilet4_irl.Click += delegate
            {
                LoadFacilityPage(AttractionDataBase.Toilet4);
            };

            toilet5_irl.Click += delegate
            {
                LoadFacilityPage(AttractionDataBase.Toilet5);
            };


            ImageView banner = FindViewById<ImageView>(Resource.Id.homeBanner);
            banner.Click += delegate {
                StartActivity(typeof(MainActivity));
            };

        }
        void LoadFacilityPage(Facility facility)
        {
            //FindViewById<ImageView>(Resource.Id.HeaderImage) = 
            IndependentFacilityActivity.Facility = facility;
            StartActivity(typeof(IndependentFacilityActivity));
        }
    }
}