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


            animalButton brownbearAnimalButton = new animalButton(brownbearButton, AttractionDataBase.Bear);
            animalButton baboonAnimalButton = new animalButton(baboonButton, AttractionDataBase.Baboon);
            animalButton sealionAnimalButton = new animalButton(sealionButton, AttractionDataBase.SeaLion);
            animalButton hippoAnimalButton = new animalButton(hippoButton, AttractionDataBase.Hippo);
            animalButton elephantAnimalButton = new animalButton(elephantButton, AttractionDataBase.Elephant);
            animalButton giraffeAnimalButton = new animalButton(giraffeButton, AttractionDataBase.Giraffe);
            animalButton polarbearAnimalButton = new animalButton(polarbearButton, AttractionDataBase.PolarBear);
            animalButton kaimanAnimalButton = new animalButton(kaimanButton, AttractionDataBase.Kaiman);
            animalButton tamarinAnimalButton = new animalButton(tamarinButton, AttractionDataBase.Tamarin);
            animalButton lemurAnimalButton = new animalButton(lemurButton, AttractionDataBase.Lemur);
            animalButton lionAnimalButton = new animalButton(lionButton, AttractionDataBase.Lion);
            animalButton penguinAnimalButton = new animalButton(penguinButton, AttractionDataBase.Penguin);
            animalButton meercatAnimalButton = new animalButton(meercatButton, AttractionDataBase.Meercat);
            animalButton tigerAnimalButton = new animalButton(tigerButton, AttractionDataBase.Tiger);
            animalButton zebraAnimalButton = new animalButton(tigerButton, AttractionDataBase.Zebra);


            animalButtons.Add(baboonAnimalButton);
            animalButtons.Add(brownbearAnimalButton);
            animalButtons.Add(sealionAnimalButton);
            animalButtons.Add(hippoAnimalButton);
            animalButtons.Add(elephantAnimalButton);
            animalButtons.Add(giraffeAnimalButton);
            animalButtons.Add(polarbearAnimalButton);
            animalButtons.Add(kaimanAnimalButton);
            animalButtons.Add(tamarinAnimalButton);
            animalButtons.Add(lemurAnimalButton);
            animalButtons.Add(lionAnimalButton);
            animalButtons.Add(penguinAnimalButton);
            animalButtons.Add(meercatAnimalButton);
            animalButtons.Add(tigerAnimalButton);
            animalButtons.Add(zebraAnimalButton);

            foreach (animalButton ab in animalButtons) 
                {
                ab._button.Click += delegate {
                    loadAnimalPage(ab._animal);
                    };
                }



        }

        void loadAnimalPage(Animal animal) {
            //FindViewById<ImageView>(Resource.Id.HeaderImage) = 
            IndependentAnimalActivity.animal = animal;
            StartActivity(typeof(IndependentAnimalActivity));
        }

    }


}