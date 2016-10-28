namespace GuidR
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
            Coordinates baboonCoordinates = new Coordinates(57.037463, 9.898570);
            string baboonDescription = "Kappebavianen lever i den østlige del af det afrikanske kontinent, i lande som Etiopien, Somalia, Sudan og Eritrea. " +
                                       "Kappebavianen kan findes i stepper og tørre ørkener, og er den bavian-art der tilbringer mest tid på jorden. " +
                                       "Kappebavianen lever oftest i stenede områder, hvor de bruger klipperne til at finde vand og som soveplads.\n\n" +
                                       "Kappebavianen er altædende og har tilpasset dens kost til dens tørre levested. " +
                                       "Dens kost består primært af frugter, græs, rødder og insekter, men vil af og til også fange og spise mindre pattedyr.\n\n" +
                                       "Kappebavianen bliver op til 75 cm i højden, hvor hannerne kan veje op til 18 kg og hunnerne kan veje op til 10 kg. " +
                                       "Levealderen for en kappebavian i naturen er stadig ukendt, men den ældste i fangeskab blev 38 år gammel.";
        //    Time baboonFeeding = new Time(24);
            Baboon = new Animal("Kappebavian", baboonDescription, baboonCoordinates, "Papio Hamadryas", BaboonImage);


            Coordinates bearCoordinates = new Coordinates(100, 100);
            string bearDescription = "Brunbjørnen er den mest udbredte af bjørne-arten i verdenen. " +
                                     "Den er at finde, i en af dens 11 under-arter, i lande som Rusland, Kina, Canada, USA(dog mest Alaska), " +
                                     "Skandinavien, og findes også i nærheden af Karpaterne i Central- og Østeuropa. " +
                                     "Brunbjørnens habitat afhænger af hvilken underart og verdensdel den er at finde i. " +
                                     "Fælles for alle brunbjørne-arternes habitater er at områderne oftest er tæt bevoksede, så bjørnene har ly i dagstimerne.\n\n" +
                                     "Brunbjørnen er altædende, og vil spise næsten alt nærende føde. " +
                                     "Om sommeren og efteråret vil brunbjørnen lede efter frugter, bær, knolde og rødder. " +
                                     "De er også kendt for at spise insekter, samt at grave mindre pattedyr, for eksempel mus, jordegern og murmeldyr, ud af deres huller i jorden for at spise dem. " +
                                     "De større under-arter, eksempelvis grizzlybjørnen fra Canada, er kendt for at jage store pattedyr. " +
                                     "Elge, rensdyr og bjerggeder er en del af grizzlyens diæt.\n\n" +
                                     "Brunbjørnens vægt og kropsmål afhænger af hvilken underart der tages udgangspunkt i. " +
                                     "Dens vægt varierer mellem 70-350 kg, og de bliver 1,7-2,5 meter i længden. " +
                                     "I naturen bliver de omkring 20 år gamle, mens de i zoologiske haver kan blive op til 30 år gamle.";
            Time bearFeeding = new Time(14, 45);
            Bear = new Animal("Brunbjørn", bearDescription, bearCoordinates, "Ursus Arctos", BearImage, bearFeeding);

            Coordinates seaLionCoordinates = new Coordinates(57.036286, 9.898246);
            string seaLionDescription = "Den californiske søløve kan findes langs den nedre del af den nordamerikanske vestkyst og ud fra den mexicanske kyst. " +
                                        "En underart kan også findes nær Galapagos-øerne. De holder til nær kysterne, men er også set svømme op i floderne nær den amerikanske kyst. " +
                                        "De californiske søløver samler sig ofte på menneskabte konstruktioner som moler, bøjer og olieplatforme. " +
                                        "De vælger deres habitat ud fra hvor meget menneskelig indgriben der har været i området. Jo mere indgriben, jo bedre.\n\n" +
                                        "Søløven er kødædende, og spiser udelukkende fisk, bløddyr og blæksprutter. " +
                                        "Af og til vil søløven arbejde sammen med andre arter, for eksempel havfugle og hvaler, for at finde føde. " +
                                        "En af arterne finder en samling af fisk, hvorefter den signalerer til de andre arter hvor samlingen befinder sig. " +
                                        "Derefter hjælper arterne hinanden med at få fat i fiskene.\n\n" +
                                        "Voksne hanner vejer i gennemsnit 275 kg og er 2,2 meter lange. Hunner er lidt mindre, med et gennemsnit på 91 kg og 1,8 meter i længden. " +
                                        "I naturen blev den ældste dokumenterede søløve 17 år gammel, hvor den ældste i fangenskab blev 31 år gammel. " +
                                        "Alderen af en søløve kan fastgøres ved at tælle antallet af ringe på et tværsnit af dens tænder.";
            Time seaLionFeeding = new Time(08, 00);
            SeaLion = new Animal("Søløve", seaLionDescription, seaLionCoordinates, "Zalophus Californianus", SeaLionImage, seaLionFeeding);

            Coordinates hippoCoordinates = new Coordinates(57.035092, 9.897645);
            string hippoDescription = "Dværgflodhesten er en truet dyreart der kun findes i 4 vestafrikanske lande; Liberia, Elfenbenskysten, Sierra Leone og Guinea. " +
                                      "Størstedelen af dværgflodheste-bestanden, mellem 2000-3000 i verdenen, er koncentreret i Liberia.\n" +
                                      "Dværgflodhesten opholder sig i lavtliggende områder af træer, aldrig langt fra vandkilder. " +
                                      "De bruger sumpe, floder og strømme til at holde fare på afstand, samt for at holde deres følsomme hud fugtigt. " +
                                      "Dværgflodheste er også blevet fundet i huler i siden af flodbredde. " +
                                      "Man mener ikke at flodhestene selv graver hulerne, men at de finder eksisterende huler og udvider dem.\n\n" +
                                      "Dværgflodhesten er vegetar og spiser en blanding af urter, bredbladede planter, græs, falden frugt og vandplanter der ligger i overfladen af vandet. " +
                                      "Som andre drøvtyggere har dværgflodhesten også 4 mavesække, men til forskel fra andre drøvtyggere bruger dværgflodhesten ikke mikrober " + 
                                      "eller gæring til nedbrydning af deres mad. De tygger heller ikke drøvet før de sluger det.\n\n" +
                                      "Dværgflodhesten bliver 1,5-1,7 meter lange og 0,7-1,0 meter høje. " +
                                      "De vejer mellem 160 kg og 275 kg, og der er normalvis ikke er stor forksel mellem hunnerne og hannerne. " +
                                      "Flodhesten kan blive op til 42 år gammel.";
            Time hippoFeeding = new Time(13);
            Hippo = new Animal("Dværgflodhest", hippoDescription, hippoCoordinates, "Hexaprotodon Liberiensis", HippoImage, hippoFeeding);

            Coordinates elephantCoordinates = new Coordinates(57.035886, 9.897210);
            string elephantDescription = "Beskrivelse";
            Time elephantFeeding = new Time(15);
            Time elephantFeeding2 = new Time(13, 05);
            Elephant = new Animal("Elefant", elephantDescription, elephantCoordinates, "Loxodonta Africana", ElephantImage, elephantFeeding, elephantFeeding2);

            Coordinates giraffeCoordinates = new Coordinates(57.035251, 9.897022);
            string giraffeDescription = "Beskrivelse";
            Time giraffeFeeding = new Time(24);
            Giraffe = new Animal("Giraf", giraffeDescription, giraffeCoordinates, "Giraffa Camelopardalis Rotschildi", GiraffeImage, giraffeFeeding);

            Coordinates polarBearCoordinates = new Coordinates(57.036717, 9.896924);
            string polarBearDescription = "Beskrivelse";
            Time polarBearFeeding = new Time(24);
            PolarBear = new Animal("Isbjørn", polarBearDescription, polarBearCoordinates, "Ursus Maritimus", PolarBearImage, polarBearFeeding);

            Coordinates kaimanCoordinates = new Coordinates(57.036116, 9.898195);
            string kaimanDescription = "Beskrivelse";
            Time kaimanFeeding = new Time(24);
            Kaiman = new Animal("Sort Kaiman", kaimanDescription, kaimanCoordinates, "Melanosuchus Niger", KaimanImage, kaimanFeeding);

            Coordinates tamarinCoordinates = new Coordinates(57.036075, 9.898411);
            string tamarinDescription = "Beskrivelse";
            Time tamarinFeeding = new Time(24);
            Tamarin = new Animal("Kejsertamarin", tamarinDescription, tamarinCoordinates, "Saguinus Imperator", TamarinImage, tamarinFeeding);

            Coordinates lemurCoordinates = new Coordinates(57.038091, 9.898626);
            string lemurDescription = "Beskrivelse";
            Time lemurFeeding = new Time(24);
            Lemur = new Animal("Lemur", lemurDescription, lemurCoordinates, "Lemur Catta", LemurImage, lemurFeeding);

            Coordinates lionCoordinates = new Coordinates(57.036281, 9.897057);
            string lionDescription = "Beskrivelse";
            Time lionFeeding = new Time(24);
            Lion = new Animal("Løve", lionDescription, lionCoordinates, "Panthera leo persica", LionImage, lionFeeding);

            Coordinates penquinCoordinates = new Coordinates(57.036389, 9.898301);
            string penquinDescription = "Beskrivelse";
            Time penquinFeeding = new Time(24);
            Penguin = new Animal("Penquin", penquinDescription, penquinCoordinates, "Spheniscus Humboldti", PenquinImage, penquinFeeding);

            Coordinates meercatCoordinates = new Coordinates(100, 100);
            string meercatDescription = "Beskrivelse";
            Time meercatFeeding = new Time(24);
            Meercat = new Animal("Meercat", meercatDescription, meercatCoordinates, "Suricata Suricatta", MeercatImage, meercatFeeding);

            Coordinates zebraCoordinates = new Coordinates(57.035073, 9.897715);
            string zebraDescription = "Beskrivelse";
            Time zebraFeeding = new Time(24);
            Zebra = new Animal("Zebra", zebraDescription, zebraCoordinates, "Equus Grevyi", ZebraImage, zebraFeeding);

            Coordinates tigerCoordinates = new Coordinates(57.036355, 9.896779);
            string tigerDescription = "Beskrivelse";
            Time tigerFeeding = new Time(24);
            Tiger = new Animal("Tiger", tigerDescription, tigerCoordinates, "Panthea Sigris Sumatrae", TigerImage, tigerFeeding);
        }

        public static void InitializeFacilities()
        {
            Coordinates toiletCoordinates = new Coordinates(57.037814, 9.897785);
            string toiletDescription = "sdfsdfsf";

            Toilet = new Facility("Toilet - NAVN", toiletDescription, toiletCoordinates);
        }
    }
}

