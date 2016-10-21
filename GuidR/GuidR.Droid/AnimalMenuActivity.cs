using System.Collections.Generic;

using Android.App;
using Android.OS;
using Android.Widget;

namespace GuidR.Droid {
    [Activity(Label = "Aalborg Zoo", Theme = "@style/NoTitle.splash")]
    public class AnimalMenuActivity : Activity {
        protected override void OnCreate(Bundle bundle) {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.AnimalMenu);

            List<Button> animalMenuButtons = new List<Button>();
            List<AnimalButton> animalButtons = new List<AnimalButton>();

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

            AnimalButton baboonAnimalButton = new AnimalButton(baboonButton, AttractionDataBase.Baboon);
            AnimalButton brownbearAnimalButton = new AnimalButton(brownbearButton, AttractionDataBase.Bear);
            AnimalButton sealionAnimalButton = new AnimalButton(sealionButton, AttractionDataBase.SeaLion);
            AnimalButton hippoAnimalButton = new AnimalButton(hippoButton, AttractionDataBase.Hippo);
            AnimalButton elephantAnimalButton = new AnimalButton(elephantButton, AttractionDataBase.Elephant);
            AnimalButton giraffeAnimalButton = new AnimalButton(giraffeButton, AttractionDataBase.Giraffe);
            AnimalButton polarbearAnimalButton = new AnimalButton(polarbearButton, AttractionDataBase.PolarBear);
            AnimalButton kaimanAnimalButton = new AnimalButton(kaimanButton, AttractionDataBase.Kaiman);
            AnimalButton tamarinAnimalButton = new AnimalButton(tamarinButton, AttractionDataBase.Tamarin);
            AnimalButton lemurAnimalButton = new AnimalButton(lemurButton, AttractionDataBase.Lemur);
            AnimalButton lionAnimalButton = new AnimalButton(lionButton, AttractionDataBase.Lion);
            AnimalButton penguinAnimalButton = new AnimalButton(penguinButton, AttractionDataBase.Penguin);
            AnimalButton meercatAnimalButton = new AnimalButton(meercatButton, AttractionDataBase.Meercat);
            AnimalButton tigerAnimalButton = new AnimalButton(tigerButton, AttractionDataBase.Tiger);
            AnimalButton zebraAnimalButton = new AnimalButton(zebraButton, AttractionDataBase.Zebra);

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

            foreach (AnimalButton ab in animalButtons) 
            {
                ab.Button.Click += delegate {
                    LoadAnimalPage(ab.Animal);
                };
            }
        }

        void LoadAnimalPage (Animal animal) {
            //FindViewById<ImageView>(Resource.Id.HeaderImage) = 
            IndependentAnimalActivity.Animal = animal;
            StartActivity(typeof(IndependentAnimalActivity));
        }
    }
}