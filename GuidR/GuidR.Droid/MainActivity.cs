using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

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

            button.Click += delegate {
                StartActivity(typeof(AnimalMenuActivity));
            };

            facilityButton.Click += delegate
            {
                StartActivity(typeof(FacilitiesMenuActivity));
            };


        }
    }
}


