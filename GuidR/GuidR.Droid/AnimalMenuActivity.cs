using Android.App;
using Android.OS;
using Android.Widget;
using System.Collections.Generic;

namespace GuidR.Droid {
    [Activity(Label = "Aalborg Zoo", Theme = "@style/NoTitle.splash")]
    public class AnimalMenuActivity : Activity {
        protected override void OnCreate(Bundle bundle) {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.AnimalMenu);

            List<AnimalButton> animalButtons = new List<AnimalButton>();

            Button baboonButton = FindViewById<Button>(Resource.Id.baboonButton);
            baboonButton.Click += delegate { LoadAnimalPage(AttractionDataBase.Baboon); };
            Button brownbearButton = FindViewById<Button>(Resource.Id.brownbearButton);
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
        }

        void LoadAnimalPage (Animal animal) {
            //FindViewById<ImageView>(Resource.Id.HeaderImage) = 
            IndependentAnimalActivity.Animal = animal;
            StartActivity(typeof(IndependentAnimalActivity));
        }
    }
}