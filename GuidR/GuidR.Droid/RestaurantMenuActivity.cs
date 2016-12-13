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
            Button restaurant4_irl = FindViewById<Button>(Resource.Id.restaurantButton4);



            restaurant1_irl.Click += delegate
            {
                LoadFacilityPage(AttractionDataBase.Skovbakken);
            };

            restaurant2_irl.Click += delegate
            {
                LoadFacilityPage(AttractionDataBase.CasaFamilia);
            };

            restaurant3_irl.Click += delegate
            {
                LoadFacilityPage(AttractionDataBase.SelfGrill);
            };

            restaurant4_irl.Click += delegate
            {
                LoadFacilityPage(AttractionDataBase.PlaygroundKiosk);
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