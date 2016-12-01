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
            // Android:
            AttractionDataBase.Platform.SetImage(FindViewById<ImageView>(Resource.Id.HeaderImage), Animal.Image);
            // iOS:
            //AttractionDataBase.Platform.SetImage(UIImageView, "Image path");

            FindViewById<TextView>(Resource.Id.Name).Text = Animal.Name;
            FindViewById<TextView>(Resource.Id.LatinName).Text = Animal.LatinName;
            FindViewById<TextView>(Resource.Id.AboutAnimal).Text = Animal.Description;

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