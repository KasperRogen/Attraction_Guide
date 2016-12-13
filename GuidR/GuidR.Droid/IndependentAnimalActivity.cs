using System;
using Android.App;
using Android.OS;
using Android.Widget;

namespace GuidR.Droid {
    [Activity(Label = "Aalborg Zoo", Theme = "@style/NoTitle.splash")]
    public class IndependentAnimalActivity : Activity {

        public static Animal Animal { get; set; }

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.AnimalPage);
            FindViewById<ImageView>(Resource.Id.HeaderImage).SetImageResource(Convert.ToInt32(Animal.Image));

            FindViewById<TextView>(Resource.Id.Name).Text = Animal.Name;
            FindViewById<TextView>(Resource.Id.LatinName).Text = Animal.LatinName;
            FindViewById<TextView>(Resource.Id.AboutAnimal).Text = Animal.Description;

            if(AttractionDataBase.animalsToWatch.Contains(Animal) == false) {
                FindViewById<ImageView>(Resource.Id.AlarmButton).SetImageResource(Resource.Drawable.Alarm_inactive);
            }
            else {
                FindViewById<ImageView>(Resource.Id.AlarmButton).SetImageResource(Resource.Drawable.Alarm);
            }

            if(Animal.HasFeedingTime == false || Animal.IsInSeason == false) {
                FindViewById<ImageView>(Resource.Id.AlarmButton).SetImageResource(0);
            } else {

                FindViewById<ImageView>(Resource.Id.AlarmButton).Click += delegate {
                    if (AttractionDataBase.animalsToWatch.Contains(Animal) == false) {
                        FindViewById<ImageView>(Resource.Id.AlarmButton).SetImageResource(Resource.Drawable.Alarm);
                        AttractionDataBase.animalsToWatch.Add(Animal);
                    }
                    else {
                        FindViewById<ImageView>(Resource.Id.AlarmButton).SetImageResource(Resource.Drawable.Alarm_inactive);
                        AttractionDataBase.animalsToWatch.Remove(Animal);
                    }
                };

            }

            TextView feedingTime = FindViewById<TextView>(Resource.Id.Feedingtime);

            if (Animal.HasFeedingTime)
            {
                if (Animal.NextFeeding.IsPassed)
                    feedingTime.Text = "Ingen fodring i dag";
                else if (Animal.IsInSeason == false)
                    feedingTime.Text = "Ude af sæson";
                else
                    feedingTime.Text = "Næste fodring: " + Animal.NextFeeding.ToString();
            }
            else
                feedingTime.Text = "Ingen fodringstid.";

            FindViewById<Button>(Resource.Id.mapButton).Click += delegate {
                MapActivity.Attraction = Animal;
                StartActivity(typeof(MapActivity));
            };

            ImageView banner = FindViewById<ImageView>(Resource.Id.homeBanner);
            banner.Click += delegate {
                StartActivity(typeof(MainActivity));
            };
        }
    }
}