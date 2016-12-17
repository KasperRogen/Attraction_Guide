using Android.App;
using Android.Content.Res;
using Android.Graphics;
using Android.Media;
using Android.OS;
using Android.Views;
using Android.Widget;
using Java.IO;
using System.IO;
using System.Collections.Generic;
using static Android.Resource;

namespace GuidR.Droid {
    [Activity(Label = "Aalborg Zoo", Theme = "@style/NoTitle.splash")]
    public class AnimalMenuActivity : Activity {
        protected override void OnCreate(Bundle bundle) {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.AnimalMenu);
            int animalIndex = 0;

            Android.Util.DisplayMetrics metrics = Resources.DisplayMetrics;
            int buttonsize = (int)(metrics.WidthPixels / 2.5);
            int verticalSpaceBetweenButtons = (int)(metrics.HeightPixels / 20);

            List<AnimalButton> animalButtons = new List<AnimalButton>();
            LinearLayout baseLayout = FindViewById<LinearLayout>(Resource.Id.animalMenuBase);

            LinearLayout buttonLayout = (LinearLayout)LayoutInflater.Inflate(Resource.Layout.ButtonLayout, baseLayout, false);
            baseLayout.AddView(buttonLayout);

            LinearLayout verticalSpacer = (LinearLayout)LayoutInflater.Inflate(Resource.Layout.LinearLayout, baseLayout, false);
            verticalSpacer.LayoutParameters.Height = verticalSpaceBetweenButtons;
            baseLayout.AddView(verticalSpacer);

            AssetManager assets = this.Assets;
            foreach (Animal animal in AttractionDataBase.Attractions) {

                System.Console.WriteLine(animal.Name);

                if (animalIndex > 1)
                {
                    animalIndex = 0;
                    buttonLayout = (LinearLayout)LayoutInflater.Inflate(Resource.Layout.ButtonLayout, baseLayout, false);
                    baseLayout.AddView(buttonLayout);
                    verticalSpacer = (LinearLayout)LayoutInflater.Inflate(Resource.Layout.LinearLayout, baseLayout, false);
                    verticalSpacer.LayoutParameters.Height = verticalSpaceBetweenButtons;
                    baseLayout.AddView(verticalSpacer);
                }

                //Animal animal = (Animal)AttractionDataBase.Attractions[0];

                ImageView button = (ImageView)LayoutInflater.Inflate(Resource.Layout.roundButton, baseLayout, false);

                System.IO.Stream ims = assets.Open("img/AnimalButtons/" + animal.Name+"Button.png");
                // load image as Drawable
                Bitmap bitmap = BitmapFactory.DecodeStream(ims);
                ims.Close();
                button.SetImageBitmap(bitmap);
                button.SetMinimumWidth(buttonsize);
                button.SetMinimumHeight(buttonsize);
                button.Click += delegate { LoadAnimalPage(animal.Name); };
                buttonLayout.AddView(button);
                //    break;

                animalIndex++;

            }

            /*Button brownbearButton = FindViewById<Button>(Resource.Id.brownbearButton);
            brownbearButton.Click += delegate { LoadAnimalPage(AttractionDataBase.Bear); };
            Button sealionButton = FindViewById<Button>(Resource.Id.sealionButton);
            sealionButton.Click += delegate { LoadAnimalPage(AttractionDataBase.SeaLion); };
            Button hippoButton = FindViewById<Button>(Resource.Id.hippoButton);
            hippoButton.Click += delegate { LoadAnimalPage(AttractionDataBase.Hippo); };
            Button elephantButton = FindViewById<Button>(Resource.Id.elephantButton);
            elephantButton.Click += delegate { LoadAnimalPage(AttractionDataBase.Elephant); };
            Button giraffeButton = FindViewById<Button>(Resource.Id.giraffeButton);
            giraffeButton.Click += delegate { LoadAnimalPage(AttractionDataBase.Giraffe); };
            Button polarbearButton = FindViewById<Button>(Resource.Id.polarbearButton);
            polarbearButton.Click += delegate { LoadAnimalPage(AttractionDataBase.PolarBear); };
            Button kaimanButton = FindViewById<Button>(Resource.Id.blackkaimanButton);
            kaimanButton.Click += delegate { LoadAnimalPage(AttractionDataBase.Kaiman); };
            Button tamarinButton = FindViewById<Button>(Resource.Id.emperorButton);
            tamarinButton.Click += delegate { LoadAnimalPage(AttractionDataBase.Tamarin); };
            Button lemurButton = FindViewById<Button>(Resource.Id.lemurButton);
            lemurButton.Click += delegate { LoadAnimalPage(AttractionDataBase.Lemur); };
            Button lionButton = FindViewById<Button>(Resource.Id.lionButton);
            lionButton.Click += delegate { LoadAnimalPage(AttractionDataBase.Lion); };
            Button penguinButton = FindViewById<Button>(Resource.Id.penguinButton);
            penguinButton.Click += delegate { LoadAnimalPage(AttractionDataBase.Penguin); };
            Button meercatButton = FindViewById<Button>(Resource.Id.meercatButton);
            meercatButton.Click += delegate { LoadAnimalPage(AttractionDataBase.Meercat); };
            Button tigerButton = FindViewById<Button>(Resource.Id.tigerButton);
            tigerButton.Click += delegate { LoadAnimalPage(AttractionDataBase.Tiger); };
            Button zebraButton = FindViewById<Button>(Resource.Id.zebraButton);
            zebraButton.Click += delegate { LoadAnimalPage(AttractionDataBase.Zebra); };
            */
            ImageView banner = FindViewById<ImageView>(Resource.Id.homeBanner);
            banner.Click += delegate {
                StartActivity(typeof(MainActivity));
            };
        }

        void LoadAnimalPage (string animal) {
            //FindViewById<ImageView>(Resource.Id.HeaderImage) = 
            IndependentAnimalActivity.animalName = animal;
            StartActivity(typeof(IndependentAnimalActivity));
        }
    }
}