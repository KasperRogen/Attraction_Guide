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
                LoadToilet(AttractionDataBase.Toilet1);   
                MapActivity.Attraction = Facility;
                StartActivity(typeof(MapActivity));
                
            };

            toilet2_irl.Click += delegate
            {
                LoadToilet(AttractionDataBase.Toilet2);
                MapActivity.Attraction = Facility;
                StartActivity(typeof(MapActivity));
            };

            toilet3_irl.Click += delegate
            {
                LoadToilet(AttractionDataBase.Toilet3);
                MapActivity.Attraction = Facility;
                StartActivity(typeof(MapActivity));
            };

            toilet4_irl.Click += delegate
            {
                LoadToilet(AttractionDataBase.Toilet4);
                MapActivity.Attraction = Facility;
                StartActivity(typeof(MapActivity));
            };

            toilet5_irl.Click += delegate
            {
                LoadToilet(AttractionDataBase.Toilet5);
                MapActivity.Attraction = Facility;
                StartActivity(typeof(MapActivity));
            };

        }
            public void LoadToilet(Facility facility)
            {
                ToiletMenuActivity.Facility = facility;
            }
    }
}