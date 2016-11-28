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
    class RestaurantMenuActivity : Activity
    {
        public static Facility Facility { get; set; }
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.RestaurantMenu);

            Button restaurant1_irl = FindViewById<Button>(Resource.Id.restaurantButton1);
            Button restaurant2_irl = FindViewById<Button>(Resource.Id.restaurantButton2);
            Button restaurant3_irl = FindViewById<Button>(Resource.Id.restaurantButton3);


            restaurant1_irl.Click += delegate
            {
                LoadRestaurant(AttractionDataBase.Skovbakken);
                MapActivity.Attraction = Facility;
                StartActivity(typeof(MapActivity));
            };

            restaurant2_irl.Click += delegate
            {
                LoadRestaurant(AttractionDataBase.CasaFamilia);
                MapActivity.Attraction = Facility;
                StartActivity(typeof(MapActivity));
            };

            restaurant3_irl.Click += delegate
            {
                LoadRestaurant(AttractionDataBase.SelfGrill);
                MapActivity.Attraction = Facility;
                StartActivity(typeof(MapActivity));
            };
        }
            public void LoadRestaurant(Facility facility)
            {
                RestaurantMenuActivity.Facility = facility;
            }
    }
}