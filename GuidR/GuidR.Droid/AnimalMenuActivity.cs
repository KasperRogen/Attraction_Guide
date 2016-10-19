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
            List<animalButton> animalButtons = new List<animalButton>();

            
            Button baboonButton = FindViewById<Button>(Resource.Id.baboonButton);


            baboonButton.Click += delegate {
                StartActivity(typeof(IndependentAnimalActivity));
            };

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


            animalButton brownbearAnimalButton = new animalButton(brownbearButton, AttractionDataBase.bear);
            animalButton baboonAnimalButton = new animalButton(baboonButton, AttractionDataBase.baboon);
            animalButton sealionAnimalButton = new animalButton(sealionButton, AttractionDataBase.seaLion);
            animalButton hippoAnimalButton = new animalButton(hippoButton, AttractionDataBase.hippo);
            animalButton elephantAnimalButton = new animalButton(elephantButton, AttractionDataBase.elefant);
            animalButton giraffeAnimalButton = new animalButton(giraffeButton, AttractionDataBase.giraf);
            animalButton polarbearAnimalButton = new animalButton(polarbearButton, AttractionDataBase.iceBear);
            animalButton kaimanAnimalButton = new animalButton(kaimanButton, AttractionDataBase.kaiman);
            animalButton tamarinAnimalButton = new animalButton(tamarinButton, AttractionDataBase.tamarin);
            animalButton lemurAnimalButton = new animalButton(lemurButton, AttractionDataBase.lemur);
            animalButton lionAnimalButton = new animalButton(lionButton, AttractionDataBase.lion);
            animalButton penguinAnimalButton = new animalButton(penguinButton, AttractionDataBase.penguin);
            animalButton meercatAnimalButton = new animalButton(meercatButton, AttractionDataBase.meercat);
            animalButton tigerAnimalButton = new animalButton(tigerButton, AttractionDataBase.tiger);
            animalButton zebraAnimalButton = new animalButton(tigerButton, AttractionDataBase.zebra);
        }

        void loadAnimalPage(int ID) {
            //FindViewById<ImageView>(Resource.Id.HeaderImage) = 
            FindViewById<TextView>(Resource.Id.Name).Text = ID.ToString();
            FindViewById<TextView>(Resource.Id.LatinName).Text = ID.ToString();
            FindViewById<TextView>(Resource.Id.AboutAnimal).Text = ID.ToString();
            FindViewById<TextView>(Resource.Id.Feedingtime).Text = ID.ToString();

        }

    }


}