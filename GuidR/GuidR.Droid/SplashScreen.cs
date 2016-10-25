using Android.App;
using Android.OS;

namespace GuidR.Droid {
    [Activity(Label ="Aalborg Zoo", MainLauncher = true, NoHistory = true, Theme ="@style/Theme.splash", Icon ="@drawable/logo")]
    public class SplashScreen: Activity {
        protected override void OnCreate(Bundle bundle) {
            base.OnCreate(bundle);
           // InitializeHeaderImages();
            AttractionDataBase.InitializeAttraction();
            //Console.WriteLine("elefant: " + AttractionDataBase.Elephant.HeaderImage);
            StartActivity(typeof(MainActivity));
        }

        /*void InitializeHeaderImages()
        {
            AttractionDataBase.baboonHeader = Resource.Drawable.baboonHeader;
            AttractionDataBase.brownBearHeader = Resource.Drawable.brownBearHeader;
            AttractionDataBase.sealionHeader = Resource.Drawable.seaLionHeader;
            AttractionDataBase.hippoHeader = Resource.Drawable.hippoHeader;
            AttractionDataBase.elephantHeader = Resource.Drawable.elephantHeader;
            AttractionDataBase.giraffeHeader = Resource.Drawable.giraffeHeader;
            AttractionDataBase.polarBearHeader = Resource.Drawable.polarBearHeader;
            AttractionDataBase.kaimanHeader = Resource.Drawable.kaimanHeader;
            AttractionDataBase.tamarinHeader = Resource.Drawable.tamarinHeader;
            AttractionDataBase.lemurHeader = Resource.Drawable.lemurHeader;
            AttractionDataBase.lionHeader = Resource.Drawable.lionHeader;
            AttractionDataBase.penguinHeader = Resource.Drawable.penguinHeader;
            AttractionDataBase.meercatHeader = Resource.Drawable.meercatHeader;
            AttractionDataBase.tigerHeader = Resource.Drawable.tigerHeader;
            AttractionDataBase.zebraHeader = Resource.Drawable.zebraHeader;
        }*/

    }
   

}