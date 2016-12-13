using Android.App;
using Android.OS;

namespace GuidR.Droid
{
    [Activity(Label ="Aalborg Zoo", MainLauncher = true, NoHistory = true, Theme ="@style/Theme.splash", Icon ="@drawable/logo")]
    public class SplashScreen: Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            AttractionDataBase.InitializeAttraction();

            InitializeAndroidDependencies();

            StartActivity(typeof(MainActivity));
        }

        // Initializes Android specific Drawables
        void InitializeAndroidDependencies ()
        {
            AttractionDataBase.Baboon.Image = Resource.Drawable.BaboonHeader;
            AttractionDataBase.Bear.Image = Resource.Drawable.BrownBearHeader;
            AttractionDataBase.SeaLion.Image = Resource.Drawable.SeaLionHeader;
            AttractionDataBase.Hippo.Image = Resource.Drawable.HippoHeader;
            AttractionDataBase.Elephant.Image = Resource.Drawable.ElephantHeader;
            AttractionDataBase.Giraffe.Image = Resource.Drawable.GiraffeHeader;
            AttractionDataBase.PolarBear.Image = Resource.Drawable.PolarBearHeader;
            AttractionDataBase.Kaiman.Image = Resource.Drawable.KaimanHeader;
            AttractionDataBase.Tamarin.Image = Resource.Drawable.TamarinHeader;
            AttractionDataBase.Lemur.Image = Resource.Drawable.LemurHeader;
            AttractionDataBase.Lion.Image = Resource.Drawable.LionHeader;
            AttractionDataBase.Penguin.Image = Resource.Drawable.PenguinHeader;
            AttractionDataBase.Meercat.Image = Resource.Drawable.MeercatHeader;
            AttractionDataBase.Tiger.Image = Resource.Drawable.TigerHeader;
            AttractionDataBase.Zebra.Image = Resource.Drawable.ZebraHeader;

            AttractionDataBase.Toilet1.Image = Resource.Drawable.Toilet1_irl;
            AttractionDataBase.Toilet2.Image = Resource.Drawable.Toilet1Header;
            AttractionDataBase.Toilet3.Image = Resource.Drawable.Toilet3_irl;
            AttractionDataBase.Toilet4.Image = Resource.Drawable.Toilet1_ved_krokodillerneHeader;
            AttractionDataBase.Toilet5.Image = Resource.Drawable.Toilet5_irl;

            AttractionDataBase.CasaFamilia.Image = Resource.Drawable.CasafamiliaHeader;
            AttractionDataBase.Skovbakken.Image = Resource.Drawable.SkovBakkenHeader;
            AttractionDataBase.SelfGrill.Image = Resource.Drawable.grill_selvHeader;
            AttractionDataBase.PlaygroundKiosk.Image = Resource.Drawable.PlaygroundKioskHeader;
            AttractionDataBase.Playground1_irl.Image = Resource.Drawable.PlaygroundHeader;
            AttractionDataBase.SmokeArea1.Image = Resource.Drawable.Smoke_Area1Header;
            AttractionDataBase.SmokeArea2.Image = Resource.Drawable.Smoke_Area2Header;
            AttractionDataBase.Bornezoo.Image = Resource.Drawable.bornezooHeader;
            AttractionDataBase.zoofariScene.Image = Resource.Drawable.ZoofariScenenHeader;

            InitializePins();
        }


        void InitializePins ()
        {
            AttractionDataBase.Baboon.Pin = Resource.Drawable.Baboon_Pin;
            AttractionDataBase.Bear.Pin = Resource.Drawable.Brown_bear_Pin;
            AttractionDataBase.SeaLion.Pin = Resource.Drawable.Californian_Sea_Lion_pin;
            AttractionDataBase.Hippo.Pin = Resource.Drawable.Pygmy_Hippo_Pin;
            AttractionDataBase.Elephant.Pin = Resource.Drawable.Elephant_Pin;
            AttractionDataBase.Giraffe.Pin = Resource.Drawable.Giraffe_Pin;
            AttractionDataBase.PolarBear.Pin = Resource.Drawable.Polar_bear_Pin;
            AttractionDataBase.Kaiman.Pin = Resource.Drawable.Black_kaiman_Pin;
            AttractionDataBase.Tamarin.Pin = Resource.Drawable.Emperor_tamarin_Pin;
            AttractionDataBase.Lemur.Pin = Resource.Drawable.Lemur_pin;
            AttractionDataBase.Lion.Pin = Resource.Drawable.Lion_Pin;
            AttractionDataBase.Penguin.Pin = Resource.Drawable.Penguin_Pin;
            AttractionDataBase.Meercat.Pin = Resource.Drawable.Meercat_Pin;
            AttractionDataBase.Tiger.Pin = Resource.Drawable.Tiger_Pin;
            AttractionDataBase.Zebra.Pin = Resource.Drawable.Zebra_Pin;

            AttractionDataBase.Toilet1.Pin = Resource.Drawable.Toilet_pin;
            AttractionDataBase.Toilet2.Pin = Resource.Drawable.Toilet_pin;
            AttractionDataBase.Toilet3.Pin = Resource.Drawable.Toilet_pin;
            AttractionDataBase.Toilet4.Pin = Resource.Drawable.Toilet_pin;
            AttractionDataBase.Toilet5.Pin = Resource.Drawable.Toilet_pin;

            AttractionDataBase.CasaFamilia.Pin = Resource.Drawable.Restaurant_Pin;
            AttractionDataBase.Skovbakken.Pin = Resource.Drawable.Restaurant_Pin;
            AttractionDataBase.SelfGrill.Pin = Resource.Drawable.Restaurant_Pin;
            AttractionDataBase.PlaygroundKiosk.Pin = Resource.Drawable.Restaurant_Pin;
            AttractionDataBase.Playground1_irl.Pin = Resource.Drawable.Playground_Pin;
            AttractionDataBase.SmokeArea1.Pin = Resource.Drawable.Smoke_area_pin;
            AttractionDataBase.SmokeArea2.Pin = Resource.Drawable.Smoke_area_pin;
            AttractionDataBase.Bornezoo.Pin = Resource.Drawable.Playground_Pin;
            AttractionDataBase.zoofariScene.Pin = Resource.Drawable.Playground_Pin;
        }
    }
}