using Android.App;
using Android.OS;

namespace GuidR.Droid {
    [Activity(Label ="Aalborg Zoo", MainLauncher = true, NoHistory = true, Theme ="@style/Theme.splash", Icon ="@drawable/logo")]
    public class SplashScreen: Activity {
        protected override void OnCreate(Bundle bundle) {
            base.OnCreate(bundle);
            InitializeHeaderImages();
            InitializePinImages();
            AttractionDataBase.InitializeAttraction();
            //Console.WriteLine("elefant: " + AttractionDataBase.Elephant.HeaderImage);
            StartActivity(typeof(MainActivity));
        }

        void InitializeHeaderImages()
        {
            AttractionDataBase.BaboonImage = Resource.Drawable.BaboonHeader;
            AttractionDataBase.BearImage = Resource.Drawable.BrownBearHeader;
            AttractionDataBase.SeaLionImage = Resource.Drawable.SeaLionHeader;
            AttractionDataBase.HippoImage = Resource.Drawable.HippoHeader;
            AttractionDataBase.ElephantImage = Resource.Drawable.ElephantHeader;
            AttractionDataBase.GiraffeImage = Resource.Drawable.GiraffeHeader;
            AttractionDataBase.PolarBearImage = Resource.Drawable.PolarBearHeader;
            AttractionDataBase.KaimanImage = Resource.Drawable.KaimanHeader;
            AttractionDataBase.TamarinImage = Resource.Drawable.TamarinHeader;
            AttractionDataBase.LemurImage = Resource.Drawable.LemurHeader;
            AttractionDataBase.LionImage = Resource.Drawable.LionHeader;
            AttractionDataBase.PenguinImage = Resource.Drawable.PenguinHeader;
            AttractionDataBase.MeercatImage = Resource.Drawable.MeercatHeader;
            AttractionDataBase.TigerImage = Resource.Drawable.TigerHeader;
            AttractionDataBase.ZebraImage = Resource.Drawable.ZebraHeader;
        }


        void InitializePinImages() {
            AttractionDataBase.BaboonPin = Resource.Drawable.Baboon_Pin;
            AttractionDataBase.BearPin = Resource.Drawable.Brown_bear_Pin;
            AttractionDataBase.SeaLionPin = Resource.Drawable.Californian_Sea_Lion_pin;
            AttractionDataBase.HippoPin = Resource.Drawable.Pygmy_Hippo_Pin;
            AttractionDataBase.ElephantPin = Resource.Drawable.Elephant_Pin;
            AttractionDataBase.GiraffePin = Resource.Drawable.Giraffe_Pin;
            AttractionDataBase.PolarBearPin = Resource.Drawable.Polar_bear_Pin;
            AttractionDataBase.KaimanPin = Resource.Drawable.Black_kaiman_Pin;
            AttractionDataBase.TamarinPin = Resource.Drawable.Emperor_tamarin_Pin;
            AttractionDataBase.LemurPin = Resource.Drawable.Lemur_pin;
            AttractionDataBase.LionPin = Resource.Drawable.Lion_Pin;
            AttractionDataBase.PenguinPin = Resource.Drawable.Penguin_Pin;
            AttractionDataBase.MeercatPin = Resource.Drawable.Meercat_Pin;
            AttractionDataBase.TigerPin = Resource.Drawable.Tiger_Pin;
            AttractionDataBase.ZebraPin = Resource.Drawable.Zebra_Pin;
        }

    }
   

}