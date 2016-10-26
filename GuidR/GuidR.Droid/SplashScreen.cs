using Android.App;
using Android.OS;

namespace GuidR.Droid {
    [Activity(Label ="Aalborg Zoo", MainLauncher = true, NoHistory = true, Theme ="@style/Theme.splash", Icon ="@drawable/logo")]
    public class SplashScreen: Activity {
        protected override void OnCreate(Bundle bundle) {
            base.OnCreate(bundle);
            InitializeHeaderImages();
            AttractionDataBase.InitializeAttraction();
            //Console.WriteLine("elefant: " + AttractionDataBase.Elephant.HeaderImage);
            StartActivity(typeof(MainActivity));
        }

        void InitializeHeaderImages()
        {
            AttractionDataBase.BaboonImage = Resource.Drawable.BaboonHeader;
            AttractionDataBase.BearImage = Resource.Drawable.BearHeader;
            AttractionDataBase.SeaLionImage = Resource.Drawable.SeaLionHeader;
            AttractionDataBase.HippoImage = Resource.Drawable.HippoHeader;
            AttractionDataBase.ElephantImage = Resource.Drawable.ElephantHeader;
            AttractionDataBase.GiraffeImage = Resource.Drawable.GiraffeHeader;
            AttractionDataBase.PolarBearImage = Resource.Drawable.PolarBearHeader;
            AttractionDataBase.KaimanImage = Resource.Drawable.KaimanHeader;
            AttractionDataBase.TamarinImage = Resource.Drawable.TamarinHeader;
            AttractionDataBase.LemurImage = Resource.Drawable.LemurHeader;
            AttractionDataBase.LionImage = Resource.Drawable.LionHeader;
            AttractionDataBase.PenquinImage = Resource.Drawable.PenguinHeader;
            AttractionDataBase.MeercatImage = Resource.Drawable.MeercatHeader;
            AttractionDataBase.TigerImage = Resource.Drawable.TigerHeader;
            AttractionDataBase.ZebraImage = Resource.Drawable.ZebraHeader;
        }

    }
   

}