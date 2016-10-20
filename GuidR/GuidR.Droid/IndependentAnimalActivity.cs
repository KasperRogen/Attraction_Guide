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
    public class IndependentAnimalActivity : Activity {

        public static Animal animal;

        protected override void OnCreate(Bundle bundle) {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.AnimalPage);
            FindViewById<TextView>(Resource.Id.Name).Text = animal.Name;
            FindViewById<TextView>(Resource.Id.LatinName).Text = animal.LatinName;
            FindViewById<TextView>(Resource.Id.AboutAnimal).Text = animal.Description;
            FindViewById<TextView>(Resource.Id.Feedingtime).Text = animal.NextFeeding.ToString();

        }

    }


}