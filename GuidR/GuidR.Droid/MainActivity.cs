using System;
using Android.App;
using Android.Gms.Maps;
using Android.OS;
using Android.Widget;
using Android.Content;

namespace GuidR.Droid
{
	[Activity (Label = "GuidR.Droid", Theme = "@style/NoTitle.splash")]
	public class MainActivity : Activity
	{

        protected override void OnCreate (Bundle bundle)
		{
            /* Properties:
              Animals:
              - Name
              - LatinName
              - Description
              - Location
              - NextFeeding
              - FeedingTimes

              Facilities:
              - Name
              - Description
              - Location
              - Open
              - Close
              - IsOpened
              - OpensIn
              - ClosesIn
            */

            base.OnCreate (bundle);
			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

            if (StopService(new Intent(this, typeof(FeedingTimeNotification))) == true) {
                FindViewById<ImageView>(Resource.Id.checkinbutton).SetImageResource(Resource.Drawable.checkout_button_small);
                StartService(new Intent(this, typeof(FeedingTimeNotification)));
            } else {
                FindViewById<ImageView>(Resource.Id.checkinbutton).SetImageResource(Resource.Drawable.Checkin_button_small);
            }

            Button button = FindViewById<Button>(Resource.Id.animalButton);
            Button facilityButton = FindViewById<Button>(Resource.Id.facilityButton);
            Button mapButton = FindViewById<Button>(Resource.Id.mapButton);
            Button newsButton = FindViewById<Button>(Resource.Id.newsbutton);
            Button infoButton = FindViewById<Button>(Resource.Id.infoButton);
            ImageView CheckInButton = FindViewById<ImageView>(Resource.Id.checkinbutton);

            infoButton.Click += delegate
            {
                StartActivity(typeof(InformationActivity));
            };

            button.Click += delegate 
            {
                StartActivity(typeof(AnimalMenuActivity));
            };

            facilityButton.Click += delegate
            {
                StartActivity(typeof(FacilitiesMenuActivity));
            };

            mapButton.Click += delegate
            {
                 StartActivity(typeof(MapActivity));
            };

            newsButton.Click += delegate
            {
                StartActivity(typeof(NewsActivity));
            };

            CheckInButton.Click += delegate {

                if (StopService(new Intent(this, typeof(FeedingTimeNotification))) == true) { 
                    FindViewById<ImageView>(Resource.Id.checkinbutton).SetImageResource(Resource.Drawable.Checkin_button_small);
                }
                else { 
                    StartService(new Intent(this, typeof(FeedingTimeNotification)));
                    FindViewById<ImageView>(Resource.Id.checkinbutton).SetImageResource(Resource.Drawable.checkout_button_small);
                }
            };

        }



    }
}


