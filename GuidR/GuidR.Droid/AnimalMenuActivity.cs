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

            //Get information about the screen
            Android.Util.DisplayMetrics metrics = Resources.DisplayMetrics;
            int buttonsize = (int)(metrics.WidthPixels / 2.5);
            int verticalSpaceBetweenButtons = (int)(metrics.HeightPixels / 20);

            LinearLayout baseLayout = FindViewById<LinearLayout>(Resource.Id.animalMenuBase);

            //Create the buttonlayout
            LinearLayout buttonLayout = (LinearLayout)LayoutInflater.Inflate(Resource.Layout.ButtonLayout, baseLayout, false);
            baseLayout.AddView(buttonLayout);

            //Create the spacer between the buttons
            LinearLayout verticalSpacer = (LinearLayout)LayoutInflater.Inflate(Resource.Layout.LinearLayout, baseLayout, false);
            verticalSpacer.LayoutParameters.Height = verticalSpaceBetweenButtons;
            baseLayout.AddView(verticalSpacer);
            ImageView button;
            AssetManager assets = this.Assets;
            foreach (Attraction animal in AttractionDataBase.Attractions) {
                if(animal is Animal) { 

                    //If this is gonna be the third button on the line, create a new line and set the index to 0.
                if (animalIndex > 1)
                {
                    animalIndex = 0;
                    buttonLayout = (LinearLayout)LayoutInflater.Inflate(Resource.Layout.ButtonLayout, baseLayout, false);
                    baseLayout.AddView(buttonLayout);
                    verticalSpacer = (LinearLayout)LayoutInflater.Inflate(Resource.Layout.LinearLayout, baseLayout, false);
                    verticalSpacer.LayoutParameters.Height = verticalSpaceBetweenButtons;
                    baseLayout.AddView(verticalSpacer);
                }

                button = (ImageView)LayoutInflater.Inflate(Resource.Layout.roundButton, baseLayout, false);

                System.IO.Stream ims = assets.Open("img/AnimalButtons/" + animal.Name+"Button.png");
                // load image as Drawable
                Bitmap bitmap = BitmapFactory.DecodeStream(ims);
                ims.Close();
                button.SetImageBitmap(bitmap);
                button.SetMinimumWidth(buttonsize);
                button.SetMinimumHeight(buttonsize);
                button.Click += delegate { LoadAnimalPage(animal.Name); };
                buttonLayout.AddView(button);
                animalIndex++;

            }

            ImageView banner = FindViewById<ImageView>(Resource.Id.homeBanner);
            banner.Click += delegate {
                    StartActivity(typeof(MainActivity));
                };
            }
            
        }

        void LoadAnimalPage (string animal) {
            //FindViewById<ImageView>(Resource.Id.HeaderImage) = 
            IndependentAnimalActivity.animalName = animal;
            StartActivity(typeof(IndependentAnimalActivity));
        }
    }
}