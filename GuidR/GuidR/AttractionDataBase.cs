using System.Collections.Generic;

namespace GuidR
{
    public static class AttractionDataBase
    {
        public static List<Attraction> Attractions = new List<Attraction>();

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
        public static int PenguinImage { get; set; }
        public static int MeercatImage { get; set; }
        public static int ZebraImage { get; set; }
        public static int TigerImage { get; set; }

        public static int BaboonPin { get; set; }
        public static int BearPin { get; set; }
        public static int SeaLionPin { get; set; }
        public static int HippoPin { get; set; }
        public static int ElephantPin { get; set; }
        public static int GiraffePin { get; set; }
        public static int PolarBearPin { get; set; }
        public static int KaimanPin { get; set; }
        public static int TamarinPin { get; set; }
        public static int LemurPin { get; set; }
        public static int LionPin { get; set; }
        public static int PenguinPin { get; set; }
        public static int MeercatPin { get; set; }
        public static int ZebraPin { get; set; }
        public static int TigerPin { get; set; }

        public static Facility Toilet { get; set; }
        public static Facility Skovbakken { get; set; }
        public static Facility CasaFamilia { get; set; }
        public static Facility PlaygroundKiosk { get; set; }
        public static Facility SelfGrill { get; set; }

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
            Baboon = new Animal("Kappebavian", baboonDescription, baboonCoordinates, "Papio Hamadryas", BaboonImage, BaboonPin);


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
            Bear = new Animal("Brunbjørn", bearDescription, bearCoordinates, "Ursus Arctos", BearImage, BearPin, bearFeeding);

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
            SeaLion = new Animal("Søløve", seaLionDescription, seaLionCoordinates, "Zalophus Californianus", SeaLionImage, SeaLionPin, seaLionFeeding);

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
            Hippo = new Animal("Dværgflodhest", hippoDescription, hippoCoordinates, "Hexaprotodon Liberiensis", HippoImage, HippoPin, hippoFeeding);

            Coordinates elephantCoordinates = new Coordinates(57.035886, 9.897210);
            string elephantDescription = "Beskrivelse";
            Time elephantFeeding = new Time(15);
            Time elephantFeeding2 = new Time(13, 05);
            Elephant = new Animal("Elefant", elephantDescription, elephantCoordinates, "Loxodonta Africana", ElephantImage, ElephantPin, elephantFeeding, elephantFeeding2);

            Coordinates giraffeCoordinates = new Coordinates(57.035251, 9.897022);
            string giraffeDescription = "Beskrivelse";
            Giraffe = new Animal("Giraf", giraffeDescription, giraffeCoordinates, "Giraffa Camelopardalis Rotschildi", GiraffeImage, GiraffePin);

            Coordinates polarBearCoordinates = new Coordinates(57.036717, 9.896924);
            string polarBearDescription = "Beskrivelse";
            PolarBear = new Animal("Isbjørn", polarBearDescription, polarBearCoordinates, "Ursus Maritimus", PolarBearImage, PolarBearPin);

            Coordinates kaimanCoordinates = new Coordinates(57.036116, 9.898195);
            string kaimanDescription = "Beskrivelse";
            Kaiman = new Animal("Sort Kaiman", kaimanDescription, kaimanCoordinates, "Melanosuchus Niger", KaimanImage, KaimanPin);

            Coordinates tamarinCoordinates = new Coordinates(57.036075, 9.898411);
            string tamarinDescription = "Beskrivelse";
            Tamarin = new Animal("Kejsertamarin", tamarinDescription, tamarinCoordinates, "Saguinus Imperator", TamarinImage, TamarinPin);

            Coordinates lemurCoordinates = new Coordinates(57.038091, 9.898626);
            string lemurDescription = "Beskrivelse";
            Lemur = new Animal("Lemur", lemurDescription, lemurCoordinates, "Lemur Catta", LemurImage, LemurPin);

            Coordinates lionCoordinates = new Coordinates(57.036281, 9.897057);
            string lionDescription = "Beskrivelse";
            Lion = new Animal("Løve", lionDescription, lionCoordinates, "Panthera leo persica", LionImage, LionPin);

            Coordinates penquinCoordinates = new Coordinates(57.036389, 9.898301);
            string penquinDescription = "Beskrivelse";
            Penguin = new Animal("Penguin", penquinDescription, penquinCoordinates, "Spheniscus Humboldti", PenguinImage, PenguinPin);

            Coordinates meercatCoordinates = new Coordinates(100, 100);
            string meercatDescription = "Beskrivelse";
            Meercat = new Animal("Meercat", meercatDescription, meercatCoordinates, "Suricata Suricatta", MeercatImage, MeercatPin);

            Coordinates zebraCoordinates = new Coordinates(57.035073, 9.897715);
            string zebraDescription = "Beskrivelse";
            Zebra = new Animal("Zebra", zebraDescription, zebraCoordinates, "Equus Grevyi", ZebraImage, ZebraPin);

            Coordinates tigerCoordinates = new Coordinates(57.036355, 9.896779);
            string tigerDescription = "Beskrivelse";
            Tiger = new Animal("Tiger", tigerDescription, tigerCoordinates, "Panthea Sigris Sumatrae", TigerImage, TigerPin);
        }

        public static void InitializeFacilities()
        {
            Coordinates toiletCoordinates = new Coordinates(57.037814, 9.897785);
            string toiletDescription = "Det er et toilet... Hvad mere vil du vide?";

            Toilet = new Facility("Toilet - NAVN", toiletDescription, toiletCoordinates);

            Coordinates skovbakkenCoordinates = new Coordinates(100, 100);
            string skovbakkenDescription = "(REPLACE) Skovbakken er Aalborg Zoos spisested, placeret ved Faunavej på bakken op mod skoven. Her har vi udsigt over byen og Aalborg Zoo.";
            Time skovbakkenOpen = new Time(8);
            Time skovbakkenClose = new Time(16);

            Skovbakken = new Facility("Skovbakken", skovbakkenDescription, skovbakkenCoordinates, skovbakkenOpen, skovbakkenClose);

            Coordinates casaFamiliaCoordinates = new Coordinates(100, 100);
            string casaFamiliaDescription = "(REPLACE) Casa Familia er Zoos sydamerikanske spisested, hvor du kan få serveret dagens grill over trækul:";
            Time casaFamiliaOpen = new Time(8);
            Time casaFamiliaClose = new Time(16);

            CasaFamilia = new Facility("Casa Familia", casaFamiliaDescription, casaFamiliaCoordinates, casaFamiliaOpen, casaFamiliaClose);

            Coordinates playgroundKioskCoordinates = new Coordinates(100, 100);
            string playgroundKioskDescription = "(REPLACE) I Legepladskiosken kan du få serveret fransk hotdog, burgers, pommes frites, pølser, sandwich, is, kaffe og drikkevarer.";
            Time playgroundKioskOpen = new Time(8);
            Time playgroundKioskClose = new Time(16);

            PlaygroundKiosk = new Facility("Legepladskiosken", playgroundKioskDescription, playgroundKioskCoordinates, playgroundKioskOpen, playgroundKioskClose);

            Coordinates selfGrillCoordinates = new Coordinates(100, 100);
            string selfGrillDescription = "(REPLACE) Pak madkurven og besøg familieområdet i Aalborg Zoo, hvor du har mulighed for at grille din egen medbragte mad i en af vores to store grillhytter (Det er ikke muligt at købe mad til grill selv i Aalborg Zoo) Grillen slukkes ca. en time før havens lukketid. Grillerne kan benyttes indtil 23. oktober.";
            Time selfGrillOpen = new Time(8);
            Time selfGrillClose = new Time(16);

            SelfGrill = new Facility("Grill-selv", selfGrillDescription, selfGrillCoordinates, selfGrillOpen, selfGrillClose);
        }
    }
}

