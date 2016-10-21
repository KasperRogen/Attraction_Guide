using Android.Widget;

namespace GuidR.Droid {
    public class AnimalButton {

        public Button Button { get; set; }
        public Animal Animal { get; set; }

        public AnimalButton (Button button, Animal animal) {
            this.Button = button;
            this.Animal = animal;
        }
    }
}