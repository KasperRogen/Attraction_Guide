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
            FindViewById<ImageView>(Resource.Id.HeaderImage).SetImageResource(Animal.HeaderImage);
            FindViewById<TextView>(Resource.Id.Name).Text = Animal.Name;
            FindViewById<TextView>(Resource.Id.LatinName).Text = Animal.LatinName;
            FindViewById<TextView>(Resource.Id.AboutAnimal).Text = Animal.Description;
            FindViewById<TextView>(Resource.Id.Feedingtime).Text = Animal.NextFeeding.ToString();
        }
    }
}