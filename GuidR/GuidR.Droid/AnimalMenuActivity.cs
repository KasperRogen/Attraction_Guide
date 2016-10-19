using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;


using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace GuidR.Droid {
    [Activity(Label = "Aalborg Zoo", Theme = "@style/NoTitle.splash")]
    public class AnimalMenuActivity : Activity {
        protected override void OnCreate(Bundle bundle) {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.AnimalMenu);

            Button baboonButton = FindViewById<Button>(Resource.Id.baboonButton);
            Button brownbearButton = FindViewById<Button>(Resource.Id.baboonButton);
            Button californiansealionButton = FindViewById<Button>(Resource.Id.californian);
            Button baboonButton = FindViewById<Button>(Resource.Id.baboonButton);
            Button baboonButton = FindViewById<Button>(Resource.Id.baboonButton);
            Button baboonButton = FindViewById<Button>(Resource.Id.baboonButton);
            Button baboonButton = FindViewById<Button>(Resource.Id.baboonButton);
            Button baboonButton = FindViewById<Button>(Resource.Id.baboonButton);
            Button baboonButton = FindViewById<Button>(Resource.Id.baboonButton);
            Button baboonButton = FindViewById<Button>(Resource.Id.baboonButton);
            Button baboonButton = FindViewById<Button>(Resource.Id.baboonButton);
            Button baboonButton = FindViewById<Button>(Resource.Id.baboonButton);
            Button baboonButton = FindViewById<Button>(Resource.Id.baboonButton);


            button.Click += delegate {
                StartActivity(typeof(AnimalMenuActivity));
            };

        }

    }


}