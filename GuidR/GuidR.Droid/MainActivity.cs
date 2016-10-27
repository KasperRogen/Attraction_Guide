using System;
using Android.App;
using Android.Gms.Maps;
using Android.OS;
using Android.Widget;

namespace GuidR.Droid
{
	[Activity (Label = "GuidR.Droid", Icon = "@drawable/icon")]
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
            ActionBar.Hide();
			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);




            Button button = FindViewById<Button>(Resource.Id.animalButton);
            Button facilityButton = FindViewById<Button>(Resource.Id.facilityButton);
            Button mapButton = FindViewById<Button>(Resource.Id.mapButton);

            button.Click += delegate {
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

        }

    }
}


