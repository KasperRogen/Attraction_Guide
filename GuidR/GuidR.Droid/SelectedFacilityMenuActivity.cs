using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Graphics;

namespace GuidR.Droid
{
    [Activity(Label = "Aalborg Zoo", Theme = "@style/NoTitle.splash")]
    class SelectedFacilityMenuActivity : Activity
    {

        public static Facility.attractionType FacilityType { get; set; }

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.SelectedFacilityMenu);


            int facilityIndex = 0;

            Android.Util.DisplayMetrics metrics = Resources.DisplayMetrics;
            int buttonsize = (int)(metrics.WidthPixels / 2.5);
            int verticalSpaceBetweenButtons = (int)(metrics.HeightPixels / 20);

            LinearLayout baseLayout = FindViewById<LinearLayout>(Resource.Id.facilityMenuBase);

            LinearLayout buttonLayout = (LinearLayout)LayoutInflater.Inflate(Resource.Layout.ButtonLayout, baseLayout, false);
            baseLayout.AddView(buttonLayout);

            LinearLayout verticalSpacer = (LinearLayout)LayoutInflater.Inflate(Resource.Layout.LinearLayout, baseLayout, false);
            verticalSpacer.LayoutParameters.Height = verticalSpaceBetweenButtons;
            baseLayout.AddView(verticalSpacer);


            foreach (Attraction facility in AttractionDataBase.Attractions)
            {
                if(facility is Facility)
                    Console.WriteLine(facility.Name + " : " + (facility as Facility).attractiontype);

                if(facility is Facility && (facility as Facility).attractiontype == FacilityType) { 
                Console.WriteLine(facility.Name);
                Console.WriteLine(facility.Name + " . " + (facility as Facility).attractiontype);


                    if (facilityIndex > 1)
                {
                    facilityIndex = 0;
                    buttonLayout = (LinearLayout)LayoutInflater.Inflate(Resource.Layout.ButtonLayout, baseLayout, false);
                    baseLayout.AddView(buttonLayout);
                    verticalSpacer = (LinearLayout)LayoutInflater.Inflate(Resource.Layout.LinearLayout, baseLayout, false);
                    verticalSpacer.LayoutParameters.Height = verticalSpaceBetweenButtons;
                    baseLayout.AddView(verticalSpacer);
                }

                //Animal animal = (Animal)AttractionDataBase.Attractions[0];

                ImageView button = (ImageView)LayoutInflater.Inflate(Resource.Layout.roundButton, baseLayout, false);

                System.IO.Stream ims = Assets.Open("img/FacilityButtons/" + (facility as Facility).attractiontype.ToString() + "/" + facility.ImageName + "Button.png");
                // load image as Drawable
                Bitmap bitmap = BitmapFactory.DecodeStream(ims);
                ims.Close();
                button.SetImageBitmap(bitmap);
                button.SetMinimumWidth(buttonsize);
                button.SetMinimumHeight(buttonsize);
                button.Click += delegate { LoadFacilityPage(facility.Name); };
                buttonLayout.AddView(button);
                //    break;

                facilityIndex++;

            }
            }


            ImageView banner = FindViewById<ImageView>(Resource.Id.homeBanner);
            banner.Click += delegate {
                StartActivity(typeof(MainActivity));
            };
        }


        void LoadFacilityPage(string facility)
        {
            //FindViewById<ImageView>(Resource.Id.HeaderImage) = 
            IndependentFacilityActivity.Facility = facility;
            StartActivity(typeof(IndependentFacilityActivity));
        }
    }
}