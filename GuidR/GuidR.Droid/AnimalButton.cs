using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;


namespace GuidR.Droid {
    public class animalButton {

        public Button _button { get; set; }
        //public Animal animal { get; set; }

        public Animal _animal { get; set; }



        public animalButton(Button button, Animal animal) {
            _button = button;
            _animal = animal;
        }

    }
}