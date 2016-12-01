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

            Button toiletButton = FindViewById<Button>(Resource.Id.toiletButton);
            Button restaurantButton = FindViewById<Button>(Resource.Id.restaurantButton);
            Button smokeButton = FindViewById<Button>(Resource.Id.smokeButton);
            Button playgroundButton = FindViewById<Button>(Resource.Id.playgroudButton);

            toiletButton.Click += delegate
            {
                StartActivity(typeof(ToiletMenuActivity));
            };

            restaurantButton.Click += delegate
            {
                StartActivity(typeof(RestaurantMenuActivity));
            };

            smokeButton.Click += delegate
            {
                StartActivity(typeof(SmokeAreaMenuActivity));
            };

            playgroundButton.Click += delegate
            {
                StartActivity(typeof(PlaygroundMenuActivity));
            };

            ImageView banner = FindViewById<ImageView>(Resource.Id.homeBanner);
            banner.Click += delegate {
                StartActivity(typeof(MainActivity));
            };
        }
            
    }
}