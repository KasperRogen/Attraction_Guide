namespace GuidR.Droid
{
    public static class AttractionDataBase
    {
        public static Animal Baboon { get; set; }
        public static Animal Bear { get; set; }
        public static Animal SeaLion { get; set; }
        public static Animal Hippo { get; set; }
        public static Animal Elephant { get; set; }
        public static Animal Giraffe { get; set; }
        public static Animal PolarBear { get; set; }
        public static Animal Kaiman { get; set; }
        public static Animal Tamarin { get; set; }
        public static Animal Lemur { get; set; }
        public static Animal Lion { get; set; }
        public static Animal Penguin { get; set; }
        public static Animal Meercat { get; set; }
        public static Animal Zebra { get; set; }
        public static Animal Tiger { get; set; }

        public static int BaboonImage { get; set; }
        public static int BearImage { get; set; }
        public static int SeaLionImage { get; set; }
        public static int HippoImage { get; set; }
        public static int ElephantImage { get; set; }
        public static int GiraffeImage { get; set; }
        public static int PolarBearImage { get; set; }
        public static int KaimanImage { get; set; }
        public static int TamarinImage { get; set; }
        public static int LemurImage { get; set; }
        public static int LionImage { get; set; }
        public static int PenquinImage { get; set; }
        public static int MeercatImage { get; set; }
        public static int ZebraImage { get; set; }
        public static int TigerImage { get; set; }

        public static Facility Toilet
        {
            get; set;
        }

        public static void InitializeAttraction()
        {
            InitializeAnimals();
            InitializeFacilities();
        }

        public static void InitializeAnimals()
        {
            // Ikke godt. Virker ikke på andet end Android, vil fikse snart!
            Coordinates baboonCoordinates = new Coordinates(100, 100);
            string baboonDescription = "Beskrivelse";
            //Resource.Drawable.baboonHeader;
            Time baboonFeeding = new Time(24);
            Baboon = new Animal("Bavian", baboonDescription, baboonCoordinates, "Papio Hamadryas", BaboonImage, baboonFeeding);

            Coordinates bearCoordinates = new Coordinates(100, 100);
            string bearDescription = "Beskrivelse";
            Time bearFeeding = new Time(14, 45);
            Bear = new Animal("Brunbjørn", bearDescription, bearCoordinates, "Ursus Arctos", BearImage, bearFeeding);

            Coordinates seaLionCoordinates = new Coordinates(100, 100);
            string seaLionDescription = "Beskrivelse";
            Time seaLionFeeding = new Time(08, 30);
            SeaLion = new Animal("Søløve", seaLionDescription, seaLionCoordinates, "Zalophus Californianus", SeaLionImage, seaLionFeeding);

            Coordinates hippoCoordinates = new Coordinates(100, 100);
            string hippoDescription = "Beskrivelse";
            Time hippoFeeding = new Time(13);
            Hippo = new Animal("Dværgflodhest", hippoDescription, hippoCoordinates, "Hexaprotodon Liberiensis", HippoImage, hippoFeeding);

            Coordinates elephantCoordinates = new Coordinates(100, 100);
            string elephantDescription = "Beskrivelse";
            Time elephantFeeding = new Time(15);
            Time elephantFeeding2 = new Time(18);
            Elephant = new Animal("Elefant", elephantDescription, elephantCoordinates, "Loxodonta Africana", ElephantImage, elephantFeeding, elephantFeeding2);

            Coordinates giraffeCoordinates = new Coordinates(100, 100);
            string giraffeDescription = "Beskrivelse";
            Time giraffeFeeding = new Time(24);
            Giraffe = new Animal("Giraf", giraffeDescription, giraffeCoordinates, "Giraffa Camelopardalis Rotschildi", GiraffeImage, giraffeFeeding);

            Coordinates polarBearCoordinates = new Coordinates(100, 100);
            string polarBearDescription = "Beskrivelse";
            Time polarBearFeeding = new Time(24);
            PolarBear = new Animal("Isbjørn", polarBearDescription, polarBearCoordinates, "Ursus Maritimus", PolarBearImage, polarBearFeeding);

            Coordinates kaimanCoordinates = new Coordinates(100, 100);
            string kaimanDescription = "Beskrivelse";
            Time kaimanFeeding = new Time(24);
            Kaiman = new Animal("Sort Kaiman", kaimanDescription, kaimanCoordinates, "Melanosuchus Niger", KaimanImage, kaimanFeeding);

            Coordinates tamarinCoordinates = new Coordinates(100, 100);
            string tamarinDescription = "Beskrivelse";
            Time tamarinFeeding = new Time(24);
            Tamarin = new Animal("Kejsertamarin", tamarinDescription, tamarinCoordinates, "Saguinus Imperator", TamarinImage, tamarinFeeding);

            Coordinates lemurCoordinates = new Coordinates(100, 100);
            string lemurDescription = "Beskrivelse";
            Time lemurFeeding = new Time(24);
            Lemur = new Animal("Lemur", lemurDescription, lemurCoordinates, "Lemur Catta", LemurImage, lemurFeeding);

            Coordinates lionCoordinates = new Coordinates(100, 100);
            string lionDescription = "Beskrivelse";
            Time lionFeeding = new Time(24);
            Lion = new Animal("Løve", lionDescription, lionCoordinates, "Panthera leo persica", LionImage, lionFeeding);

            Coordinates penquinCoordinates = new Coordinates(100, 100);
            string penquinDescription = "Beskrivelse";
            Time penquinFeeding = new Time(24);
            Penguin = new Animal("Penquin", penquinDescription, penquinCoordinates, "Spheniscus Humboldti", PenquinImage, penquinFeeding);

            Coordinates meercatCoordinates = new Coordinates(100, 100);
            string meercatDescription = "Beskrivelse";
            Time meercatFeeding = new Time(24);
            Meercat = new Animal("Meercat", meercatDescription, meercatCoordinates, "Suricata Suricatta", MeercatImage, meercatFeeding);

            Coordinates zebraCoordinates = new Coordinates(100, 100);
            string zebraDescription = "Beskrivelse";
            Time zebraFeeding = new Time(24);
            Zebra = new Animal("Zebra", zebraDescription, zebraCoordinates, "Equus Grevyi", ZebraImage, zebraFeeding);

            Coordinates tigerCoordinates = new Coordinates(100, 100);
            string tigerDescription = "Beskrivelse";
            Time tigerFeeding = new Time(24);
            Tiger = new Animal("Tiger", tigerDescription, tigerCoordinates, "Panthea Sigris Sumatrae", TigerImage, tigerFeeding);
        }

        public static void InitializeFacilities()
        {
            Coordinates toiletCoordinates = new Coordinates(100, 100);
            string toiletDescription = "sdfsdfsf";

            Toilet = new Facility("Toilet - NAVN", toiletDescription, toiletCoordinates);
        }
    }
}

