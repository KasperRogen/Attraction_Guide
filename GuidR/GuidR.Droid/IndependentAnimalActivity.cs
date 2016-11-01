using Android.App;
using Android.OS;
using Android.Widget;

namespace GuidR.Droid {
    [Activity(Label = "Aalborg Zoo", Theme = "@style/NoTitle.splash")]
    public class IndependentAnimalActivity : Activity {

        public static Animal Animal
        {
            get; set;
        }

        protected override void OnCreate(Bundle bundle) {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.AnimalPage);
            FindViewById<ImageView>(Resource.Id.HeaderImage).SetImageResource(Animal.Image);
            FindViewById<TextView>(Resource.Id.Name).Text = Animal.Name;
            FindViewById<TextView>(Resource.Id.LatinName).Text = Animal.LatinName;
            FindViewById<TextView>(Resource.Id.AboutAnimal).Text = Animal.Description;

            TextView feedingTime = FindViewById<TextView>(Resource.Id.Feedingtime);

            if (Animal.HasFeedingTime)
            {
                if (Animal.NextFeeding.IsPassed)
                    feedingTime.Text = "Ingen fodring i dag";
                else
                    feedingTime.Text = "Næste fodring: " + Animal.NextFeeding.ToString();
            }
            else
                feedingTime.Text = "Ingen fodringstid.";

            Button mapButton = FindViewById<Button>(Resource.Id.mapButton);

            mapButton.Click += delegate {
                MapActivity.goToPlace = true;
                MapActivity.PlaceToGo = Animal.Location;
                StartActivity(typeof(MapActivity));
            };
        }
    }
}