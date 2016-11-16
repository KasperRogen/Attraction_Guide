using System;
using Android.App;
using Android.Gms.Maps;
using Android.OS;
using Android.Widget;

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




            Button button = FindViewById<Button>(Resource.Id.animalButton);
            Button facilityButton = FindViewById<Button>(Resource.Id.facilityButton);
            Button mapButton = FindViewById<Button>(Resource.Id.mapButton);
            Button newsButton = FindViewById<Button>(Resource.Id.newsbutton);
            Button infoButton = FindViewById<Button>(Resource.Id.infoButton);

            infoButton.Click += delegate {
                StartActivity(typeof(VideoStreamActivity));
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

        }

    }
}


