using System;

namespace App_Time
{
    public static class AttractionDataBase
    {
        // Make into properties, or make a list. Something clever!
        public static Animal baboon;
        public static Animal bear;
        public static Animal seaLion;
        public static Animal hippo;
        public static Animal elefant;
        public static Animal giraf;
        public static Animal iceBear;
        public static Animal kaiman;
        public static Animal tamarin;
        public static Animal lemur;
        public static Animal lion;
        public static Animal penguin;
        public static Animal meercat;
        public static Animal zebra;

        public static Facility toilet;

        public static void InitializeAttraction()
        {
            InitializeAnimals();
            InitializeFacilities();
        }

        public static void InitializeAnimals ()
        {
            Coordinates baboonCoordinates = new Coordinates(100, 100);
            string baboonDescription = "Beskrivelse";
            baboon = new Animal("Bavian", baboonDescription, baboonCoordinates, "Papio Hamadryas");

            Coordinates bearCoordinates = new Coordinates(100, 100);
            string bearDescription = "Beskrivelse";
            Time bearFeeding = new Time(13, 45);
            bear = new Animal("Brunbjørn", bearDescription, bearCoordinates, "Ursus Arctos", bearFeeding);

            Coordinates seaLionCoordinates = new Coordinates(100, 100);
            string seaLionDescription = "Beskrivelse";
            Time seaLionFeeding = new Time(11, 30);
            seaLion = new Animal("Søløve", seaLionDescription, seaLionCoordinates, "Zalophus Californianusu", seaLionFeeding);

            Coordinates hippoCoordinates = new Coordinates(100, 100);
            string hippoDescription = "Beskrivelse";
            Time hippoFeeding = new Time(13);
            hippo = new Animal("Dværgflodhest", hippoDescription, hippoCoordinates, "Hexaprotodon Liberiensis", hippoFeeding);

            Coordinates elefantCoordinates = new Coordinates(100, 100);
            string elefantDescription = "Beskrivelse";
            Time elefantFeeding = new Time(13);
            elefant = new Animal("Elefant", elefantDescription, elefantCoordinates, "Lozodonta Africana", elefantFeeding);

            Coordinates girafCoordinates = new Coordinates(100, 100);
            string girafDescription = "Beskrivelse";
            giraf = new Animal("Giraf", girafDescription, girafCoordinates, "Giraffa Camelopardalis Rotschildi");

            Coordinates iceBearCoordinates = new Coordinates(100, 100);
            string iceBearDescription = "Beskrivelse";
            iceBear = new Animal("Isbjørn", iceBearDescription, iceBearCoordinates, "Ursus Maritimus");

            Coordinates kaimanCoordinates = new Coordinates(100, 100);
            string kaimanDescription = "Beskrivelse";
            kaiman = new Animal("Sort Kaiman", kaimanDescription, kaimanCoordinates, "Melanosuchus Niger");

            Coordinates tamarinCoordinates = new Coordinates(100, 100);
            string tamarinDescription = "Beskrivelse";
            tamarin = new Animal("Kejsertamarin", tamarinDescription, tamarinCoordinates, "Saguinus Imperator");

            Coordinates lemurCoordinates = new Coordinates(100, 100);
            string lemurDescription = "Beskrivelse";
            lemur = new Animal("Lemur", lemurDescription, lemurCoordinates, "Lemur Catta");

            Coordinates lionCoordinates = new Coordinates(100, 100);
            string lionDescription = "Beskrivelse";
            lion = new Animal("Løve", lionDescription, lionCoordinates, "Panthera leo persica");

            Coordinates penquinCoordinates = new Coordinates(100, 100);
            string penquinDescription = "Beskrivelse";
            penguin = new Animal("Penquin", penquinDescription, penquinCoordinates, "Spheniscus Humboldti");

            Coordinates meercatCoordinates = new Coordinates(100, 100);
            string meercatDescription = "Beskrivelse";
            meercat = new Animal("Meercat", meercatDescription, meercatCoordinates, "Suricata Suricatta");

            Coordinates zebraCoordinates = new Coordinates(100, 100);
            string zebraDescription = "Beskrivelse";
            zebra = new Animal("Zebra", zebraDescription, zebraCoordinates, "Equus Grevyi");
        }

        public static void InitializeFacilities()
        {
            Coordinates toiletCoordinates = new Coordinates(100, 100);
            string toiletDescription = "sdfsdfsf";

            toilet = new Facility("Toilet - NAVN", toiletDescription, null, DateTime.Now, DateTime.Now);
        }
    }
}

