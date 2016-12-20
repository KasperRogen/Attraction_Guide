using System;
using System.Collections.Generic;

using Android.App;
using Android.OS;
using Android.Widget;
using Android.Graphics;

namespace GuidR.Droid {
    [Activity(Label = "Aalborg Zoo", Theme = "@style/NoTitle.splash")]
    class FacilitiesMenuActivity : Activity {
        protected override void OnCreate(Bundle bundle) {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.FacilitiesMenu);

            int typeIndex = 0;

            Android.Util.DisplayMetrics metrics = Resources.DisplayMetrics;
            int buttonsize = (int)(metrics.WidthPixels / 2.5);
            int verticalSpaceBetweenButtons = (int)(metrics.HeightPixels / 20);

            List<AnimalButton> animalButtons = new List<AnimalButton>();
            LinearLayout baseLayout = FindViewById<LinearLayout>(Resource.Id.facilityMenuBase);

            LinearLayout buttonLayout = (LinearLayout)LayoutInflater.Inflate(Resource.Layout.ButtonLayout, baseLayout, false);
            baseLayout.AddView(buttonLayout);

            LinearLayout verticalSpacer = (LinearLayout)LayoutInflater.Inflate(Resource.Layout.LinearLayout, baseLayout, false);
            verticalSpacer.LayoutParameters.Height = verticalSpaceBetweenButtons;
            baseLayout.AddView(verticalSpacer);

            var types = Enum.GetValues(typeof(Facility.attractionType));
            foreach (Facility.attractionType type in types)
            {
                if (type == Attraction.attractionType.Animal)
                    continue;

                    if (typeIndex > 1)
                    {
                        typeIndex = 0;
                        buttonLayout = (LinearLayout)LayoutInflater.Inflate(Resource.Layout.ButtonLayout, baseLayout, false);
                        baseLayout.AddView(buttonLayout);
                        verticalSpacer = (LinearLayout)LayoutInflater.Inflate(Resource.Layout.LinearLayout, baseLayout, false);
                        verticalSpacer.LayoutParameters.Height = verticalSpaceBetweenButtons;
                        baseLayout.AddView(verticalSpacer);
                    }

                    ImageView button = (ImageView)LayoutInflater.Inflate(Resource.Layout.roundButton, baseLayout, false);

                    System.IO.Stream ims = Assets.Open("img/FacilityTypeButtons/" + type.ToString() + "Button.png");
                    // load image as Drawable
                    Bitmap bitmap = BitmapFactory.DecodeStream(ims);
                    ims.Close();
                    button.SetImageBitmap(bitmap);
                    button.SetMinimumWidth(buttonsize);
                    button.SetMinimumHeight(buttonsize);
                    button.Click += delegate { LoadFacilitymenu(type); };
                    buttonLayout.AddView(button);
                    //    break;

                    typeIndex++;
                }

            ImageView banner = FindViewById<ImageView>(Resource.Id.homeBanner);
            banner.Click += delegate
            {
                StartActivity(typeof(MainActivity));
            };
        }

        void LoadFacilitymenu(Facility.attractionType type)
        {
            SelectedFacilityMenuActivity.FacilityType = type;
            StartActivity(typeof(SelectedFacilityMenuActivity));
        }

    }
}