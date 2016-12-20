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
using Android.Graphics;

namespace GuidR.Droid
{
    [Activity(Label = "Aalborg Zoo", Theme = "@style/NoTitle.splash")]

    class IndependentFacilityActivity : Activity
    {
        public static string Facility { get; set; }
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.FacilityPage);

            Facility facility = (Facility)AttractionDataBase.Attractions.Find(x => x.Name == Facility);

            System.IO.Stream ims = Assets.Open("img/FacilityHeaders/" + facility.ImageName + "Header.png");
            // load image as Drawable
            Bitmap bitmap = BitmapFactory.DecodeStream(ims);
            ims.Close();

            FindViewById<ImageView>(Resource.Id.HeaderImage).SetImageBitmap(bitmap);

            FindViewById<TextView>(Resource.Id.Name).Text = facility.Name;
            FindViewById<TextView>(Resource.Id.AboutFacility).Text = facility.Description;

            FindViewById<Button>(Resource.Id.mapButton).Click += delegate 
            {
                MapActivity.Attraction = facility;
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