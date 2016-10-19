using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;


using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace GuidR.Droid {
    [Activity(Label = "Aalborg Zoo", Theme = "@style/NoTitle.splash")]
    public class AnimalMenuActivity : Activity {
        protected override void OnCreate(Bundle bundle) {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.AnimalMenu);

            List<Button> animalMenuButtons = new List<Button>();
            
            Button baboonButton = FindViewById<Button>(Resource.Id.baboonButton);
            Button brownbearButton = FindViewById<Button>(Resource.Id.brownbearButton);
            Button sealionButton = FindViewById<Button>(Resource.Id.sealionButton);
            Button hippoButton = FindViewById<Button>(Resource.Id.hippoButton);
            Button elephantButton = FindViewById<Button>(Resource.Id.elephantButton);
            Button giraffeButton = FindViewById<Button>(Resource.Id.giraffeButton);
            Button polarbearButton = FindViewById<Button>(Resource.Id.polarbearButton);
            Button kaimanButton = FindViewById<Button>(Resource.Id.blackkaimanButton);
            Button tamarinButton = FindViewById<Button>(Resource.Id.emperorButton);
            Button lemurButton = FindViewById<Button>(Resource.Id.lemurButton);
            Button lionButton = FindViewById<Button>(Resource.Id.lionButton);
            Button penguinButton = FindViewById<Button>(Resource.Id.penguinButton);
            Button meercatButton = FindViewById<Button>(Resource.Id.meercatButton);
            Button tigerButton = FindViewById<Button>(Resource.Id.tigerButton);
            Button zebraButton = FindViewById<Button>(Resource.Id.zebraButton);

            animalMenuButtons.Add(baboonButton);
            animalMenuButtons.Add(baboonButton);
            animalMenuButtons.Add(baboonButton);
            animalMenuButtons.Add(baboonButton);
            animalMenuButtons.Add(baboonButton);
            animalMenuButtons.Add(baboonButton);
            animalMenuButtons.Add(baboonButton);
            animalMenuButtons.Add(baboonButton);
            animalMenuButtons.Add(baboonButton);
            animalMenuButtons.Add(baboonButton);
            animalMenuButtons.Add(baboonButton);
            animalMenuButtons.Add(baboonButton);
            animalMenuButtons.Add(baboonButton);
            animalMenuButtons.Add(baboonButton);


        }

    }


}