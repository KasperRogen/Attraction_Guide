namespace GuidR.Droid
{
    public static class AttractionDataBase
    {
        public static int baboonHeader;
        public static int brownBearHeader;
        public static int sealionHeader;
        public static int hippoHeader;
        public static int elephantHeader;
        public static int giraffeHeader;
        public static int polarBearHeader;
        public static int kaimanHeader;
        public static int tamarinHeader;
        public static int lemurHeader;
        public static int lionHeader;
        public static int penguinHeader;
        public static int meercatHeader;
        public static int tigerHeader;
        public static int zebraHeader;


        public static Animal Baboon
        {
            get; set;
        }

        public static Animal Bear
        {
            get; set;
        }

        public static Animal SeaLion
        {
            get; set;
        }

        public static Animal Hippo
        {
            get; set;
        }

        public static Animal Elephant
        {
            get; set;
        }

        public static Animal Giraffe
        {
            get; set;
        }

        public static Animal PolarBear
        {
            get; set;
        }

        public static Animal Kaiman
        {
            get; set;
        }

        public static Animal Tamarin
        {
            get; set;
        }

        public static Animal Lemur
        {
            get; set;
        }

        public static Animal Lion
        {
            get; set;
        }

        public static Animal Penguin
        {
            get; set;
        }

        public static Animal Meercat
        {
            get; set;
        }

        public static Animal Zebra
        {
            get; set;
        }

        public static Animal Tiger 
        {
            get; set;
        }

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
            Coordinates baboonCoordinates = new Coordinates(100, 100);
            string baboonDescription = "Beskrivelse";
            Baboon = new Animal("Bavian", baboonDescription, baboonCoordinates, "Papio Hamadryas");

            Coordinates bearCoordinates = new Coordinates(100, 100);
            string bearDescription = "Beskrivelse";
            Time bearFeeding = new Time(14, 45);
            Bear = new Animal("Brunbjørn", bearDescription, bearCoordinates, "Ursus Arctos", bearFeeding, brownBearHeader);

            Coordinates seaLionCoordinates = new Coordinates(100, 100);
            string seaLionDescription = "Beskrivelse";
            Time seaLionFeeding = new Time(11, 30);
            SeaLion = new Animal("Søløve", seaLionDescription, seaLionCoordinates, "Zalophus Californianusu", seaLionFeeding, sealionHeader);

            Coordinates hippoCoordinates = new Coordinates(100, 100);
            string hippoDescription = "Beskrivelse";
            Time hippoFeeding = new Time(13);
            Hippo = new Animal("Dværgflodhest", hippoDescription, hippoCoordinates, "Hexaprotodon Liberiensis", hippoFeeding, hippoHeader);

            Coordinates elephantCoordinates = new Coordinates(100, 100);
            string elephantDescription = "Beskrivelse";

            Time elephantFeeding = new Time(15);
            Time elephantFeeding2 = new Time(18);

            Elephant = new Animal("Elefant", elephantDescription, elephantCoordinates, "Lozodonta Africana", elephantFeeding, elephantFeeding2);

            Coordinates giraffeCoordinates = new Coordinates(100, 100);
            string giraffeDescription = "Beskrivelse";
            Giraffe = new Animal("Giraf", giraffeDescription, giraffeCoordinates, "Giraffa Camelopardalis Rotschildi");

            Coordinates polarBearCoordinates = new Coordinates(100, 100);
            string polarBearDescription = "Beskrivelse";
            PolarBear = new Animal("Isbjørn", polarBearDescription, polarBearCoordinates, "Ursus Maritimus");

            Coordinates kaimanCoordinates = new Coordinates(100, 100);
            string kaimanDescription = "Beskrivelse";
            Kaiman = new Animal("Sort Kaiman", kaimanDescription, kaimanCoordinates, "Melanosuchus Niger");

            Coordinates tamarinCoordinates = new Coordinates(100, 100);
            string tamarinDescription = "Beskrivelse";
            Tamarin = new Animal("Kejsertamarin", tamarinDescription, tamarinCoordinates, "Saguinus Imperator");

            Coordinates lemurCoordinates = new Coordinates(100, 100);
            string lemurDescription = "Beskrivelse";
            Lemur = new Animal("Lemur", lemurDescription, lemurCoordinates, "Lemur Catta");

            Coordinates lionCoordinates = new Coordinates(100, 100);
            string lionDescription = "Beskrivelse";
            Lion = new Animal("Løve", lionDescription, lionCoordinates, "Panthera leo persica");

            Coordinates penquinCoordinates = new Coordinates(100, 100);
            string penquinDescription = "Beskrivelse";
            Penguin = new Animal("Penquin", penquinDescription, penquinCoordinates, "Spheniscus Humboldti");

            Coordinates meercatCoordinates = new Coordinates(100, 100);
            string meercatDescription = "Beskrivelse";
            Meercat = new Animal("Meercat", meercatDescription, meercatCoordinates, "Suricata Suricatta");

            Coordinates zebraCoordinates = new Coordinates(100, 100);
            string zebraDescription = "Beskrivelse";
            Zebra = new Animal("Zebra", zebraDescription, zebraCoordinates, "Equus Grevyi");

            Coordinates tigerCoordinates = new Coordinates(100, 100);
            string tigerDescription = "Beskrivelse";
            Tiger = new Animal("Tiger", tigerDescription, tigerCoordinates, "Panthea Sigris Sumatrae");
        }

        public static void InitializeFacilities()
        {
            Coordinates toiletCoordinates = new Coordinates(100, 100);
            string toiletDescription = "sdfsdfsf";

            Toilet = new Facility("Toilet - NAVN", toiletDescription, toiletCoordinates);
        }
    }
}

