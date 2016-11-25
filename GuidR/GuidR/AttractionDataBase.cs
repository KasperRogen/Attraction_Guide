using System;
using System.Collections.Generic;

namespace GuidR
{
    public static class AttractionDataBase
    {
        public static PlatformDependency Platform { get; set; }

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

        public static Facility Toilet1 { get; set; }
        public static Facility Toilet2 { get; set; }
        public static Facility Toilet3 { get; set; }
        public static Facility Toilet4 { get; set; }
        public static Facility Toilet5 { get; set; }
        public static Facility SmokeArea1 { get; set; }
        public static Facility SmokeArea2 { get; set; }
        public static Facility Skovbakken { get; set; }
        public static Facility CasaFamilia { get; set; }
        public static Facility PlaygroundKiosk { get; set; }
        public static Facility SelfGrill { get; set; }
        public static Facility Bornezoo { get; set; }
        public static Facility zoofariScene { get; set; }
        public static Facility Playground { get; set; }

        public static void InitializeAttraction()
        {
            InitializeAnimals();
            InitializeFacilities();
        }

        private static void InitializeAnimals()
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
            Baboon = new Animal("Kappebavian", baboonDescription, baboonCoordinates, "Papio Hamadryas");


            Coordinates bearCoordinates = new Coordinates(57.037393, 9.897042);
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
            FeedingTime bearFeeding = new FeedingTime(new DateTime(2016, 1, 1), new DateTime(2016, 12, DateTime.DaysInMonth(2016, 12)), new Time(13, 45), new int[] { 2, 3, 6, 7 });
            Bear = new Animal("Brunbjørn", bearDescription, bearCoordinates, "Ursus Arctos", bearFeeding);

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
            FeedingTime seaLionFeeding = new FeedingTime(new DateTime(2016, 5, 1), new DateTime(2016, 10, DateTime.DaysInMonth(2016,10)), new Time(13, 45), new int[] { 2, 3, 6, 7 });
            FeedingTime seaLionFeeding2 = new FeedingTime(new DateTime(2016, 5, 1), new DateTime(2016, 10, DateTime.DaysInMonth(2016, 10)), new Time(14,30), new int[] { 2, 3, 6, 7 });

            SeaLion = new Animal("Søløve", seaLionDescription, seaLionCoordinates, "Zalophus Californianus", seaLionFeeding, seaLionFeeding2);

            Coordinates hippoCoordinates = new Coordinates(57.035081, 9.898212);
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
            Hippo = new Animal("Dværgflodhest", hippoDescription, hippoCoordinates, "Hexaprotodon Liberiensis");

            Coordinates elephantCoordinates = new Coordinates(57.035886, 9.897210);
            string elephantDescription = "Historisk set fandtes den afrikanske elefant syd for Sahara ørkenen, mod den sydlige del af Afrika, helt fra Atlanterhavet " +
                                         "i vest til Det Indiske Ocean i øst. Den nuværende bestand af elefanter findes i splittede habitater, der stadigt spredes mere og mere. " +
                                         "Elefanten findes primært i nærheden af reservater og beskyttede områder grundet krybskytteri og habitat-ødelæggelser. \n" + 
                                         "Elefantens habitat er meget varierende da elefanter kan overleve længe uden vand. De lever som regel i ørkner, skove, savannaer, flod dale eller sumpe.\n\n" +
                                         "Den afrikanske elefant er det tungeste landdyr i verden. Det er også det andet højeste dyr i dyreriget. " +
                                         "Hannerne bliver op til 3,75 meter høje, hvor hunnerne bliver cirka 3 meter høje. Deres kæmpe ører måler omkring 120-125 cm og snablen er cirka 150 cm lang. " +
                                         "De vejer i gennemsnit 135 kg. Deres stødtænder kan blive op til 250 cm lange og veje omkring 60 kg hver. " +
                                         "Den afrikanske elefant bliver op til 70 år gammel i naturen og 80 år i fangeskab.\n\n" + 
                                         "Elefanter er vegetarer og spiser ting som blade, rødder, bark og frugt. De spiser mellem 100 og 300 kg mad, og drikker omkring 190 liter vand, hver dag!";
                       
            FeedingTime elephantFeeding = new FeedingTime(new DateTime(2016, 5, 1), new DateTime(2016, 8, DateTime.DaysInMonth(2016, 8)), new Time(13, 00), new int[] { 2, 3, 6, 7 });
            Elephant = new Animal("Elefant", elephantDescription, elephantCoordinates, "Loxodonta Africana", elephantFeeding);

            Coordinates giraffeCoordinates = new Coordinates(57.035251, 9.897022);
            string giraffeDescription = "Giraffen findes i Afrika, primært fra Sahara's sydlige grænse til det østlige Transvaal i Sydafrika, og det nordlige Botswana. " +
                                        "Giraffer er udryddet fra det meste af det vestlige Afrika, pånær en lille bestanddel i Niger. Giraffer bor i bart, tørt land, oftest områder med adgang til mange Acacia træer. " +
                                        "Den findes oftest i savannaer, græsområder eller åbne områder med træer sprædt langt mellem hinanden. " +
                                        "De har ikke behov for at drikke tit, så de kan også sagtens finde habitat langt væk fra vandkilder.\n\n" +
                                        "Giraffen er det højeste dyr i hele dyreriget. Hannerne bliver 5,7 meter høje, hvor hunnerne bliver omkring 1 meter mindre. Hannerne vejer op til 1,930 kg, mens hunnerne kun vejer 1,180 kg. " +
                                        "De bliver omkring 25 år gamle i naturen og 27 år i fangeskab.\n\n" +
                                        "Giraffen er vegetar, og har en diæt bestående af blade, blomster, frø og frugter. I steder hvor jorden er saltet og fyldt med mineraler har man også fundet giraffer i færd med at spise jorden. " +
                                        "Giraffen er drøvtygger og har derfor 4 maver. Under en rejse bruger giraffen tiden på at tygge drøv for at få det meste ud af føden.";
            Giraffe = new Animal("Giraf", giraffeDescription, giraffeCoordinates, "Giraffa Camelopardalis Rotschildi");

            FeedingTime polarBearFeeding = new FeedingTime(new DateTime(2016, 1, 1), new DateTime(2016, 12, DateTime.DaysInMonth(2016, 12)), new Time(13, 45), new int[] { 2, 3, 6, 7 });
            Coordinates polarBearCoordinates = new Coordinates(57.036717, 9.896924);
            string polarBearDescription = "Isbjørne findes i størstedelen af Nordpolen, og er også blevet set i de sydligste dele af Island og Grønland. " +
                                          "Om vinteren kan man finde dem gående langs den sydlige kyst eller den nordlige kant af Nordpolen. " + 
                                          "Isbjørne er også blevet fundet i den vestlige og nordlige del af Alaska.\n" + 
                                          "Isbjørnen antages af mange for at være et havpattedyr. Deres foretrukne habitat er områder med pakis i det arktiske ocean, da dette giver de bedste jage-muligheder for isbjørnen. " +
                                          "Hvis pakisen smelter i det område isbjørnen befinder sig i, vil isbjørnen bevæge sig op til 1,000 km nord eller syd, i jagt på nye områder hvor pakisen er tæt nok.\n\n" +
                                          "Isbjørnen kan blive op til 1,6 meter høj. De voksne hanner kan veje mellem 300 og 800 kg, mens hunnerne vejer mellem 150 og 300 kg. " +
                                          "I naturen lever de oftest mellem 25 og 30 år, hvor de i fangenskab kan blive op til 38 år gamle.\n\n" +
                                          "Isbjørnen er kødædende og har en diæt primært bestående af sæler og hvalrosser, samt fugle og mindre fisk. " +
                                          "Om sommeren kan de godt finde på at spise vegetation hvis de kan finde det.";
            PolarBear = new Animal("Isbjørn", polarBearDescription, polarBearCoordinates, "Ursus Maritimus", polarBearFeeding);

            Coordinates kaimanCoordinates = new Coordinates(57.036116, 9.898195);
            string kaimanDescription = "Den sorte kaiman findes i størstedelen af Amazonas. Dens leveområde strækker sig fra det nordlige til det centrale Sydamerika. " +
                                       "Dog har ødelæggelse af kaimanens habitater gjort at den nu til dags er mere sjælden end den var for 20 år siden, dog uden at være en truet dyreart. " +
                                       "Den sorte kaiman holder til på stejle klipper langs langsomt-strømmende ferskvandsflode, søer, sumpe og i de oversvømmede dele af Amazonas.\n\n" +
                                       "Den sorte kaiman er det største rovdyr i Amazonas. I gennemsnit bliver kaimanen 3-4,5 meter lang, men de er før blevet set på helt op til 6 meter lange! " +
                                       "De største kaimaner kan veje helt op til 400 kg, men det er dog mere normalt at de har en vægt på omkring 250-300 kg. " +
                                       "I fangenskab bliver kaimaner cirka 13 år gamle.\n\n" +
                                       "Man ved ikke super meget om den sorte kaimans spisevaner, men få undersøgelser viser at de har en diæt bestående af piratfisk, havkatte, insekter og mindre skaldyr. " +
                                       "Den sorte kaiman hjælper med at holde bestanden nede af fisk og andre små dyr. " +
                                       "Dog kan dette også have en negativ effekt da de i deres leveområder spiser de fisk som mennesker gerne vil spise.";
            Kaiman = new Animal("Sort Kaiman", kaimanDescription, kaimanCoordinates, "Melanosuchus Niger");

            Coordinates tamarinCoordinates = new Coordinates(57.036075, 9.898411);
            string tamarinDescription = "Kejsertamarinen lever i Amazonas, mere specifikt de store tropiske skovregioner af det sydvestlige Peru, nordvestlige Bolivia og nordvestlige Brazilien. " +
                                        "Især småfloderne Acre, Purus og Jurua i Peru har en stor bestanddel af kejsertamarinen." +
                                        "Kejsertamarinen holder til i lyse områder med tør bund i Amazonas skove. " +
                                        "Deres territorium kan strække sig helt op til 400 kvadratkilometer, hvor området også strækker sig gennem åbne skovarealer. " +
                                        "Kejsertamarinen bruger det meste af sin tid i træer, oftest i en højde af 25-30 meter.\n\n" +
                                        "Kejsertamarinen er altædende og spiser oftest frugter, insekter, nektar fra blomster og harpiks fra træer. " +
                                        "Den er omkring 25 cm høj med en hale-længde på næsten det dobbelte. " +
                                        "De vejer omkring 500 gram, hvilket giver dem mulighed for at kunne finde føde på de yderste grene af træerne og jage insekter meget diskret. " +
                                        "Kejsertamarinen lever i op til 20 år i fangeskab.";
            Tamarin = new Animal("Kejsertamarin", tamarinDescription, tamarinCoordinates, "Saguinus Imperator");

            Coordinates lemurCoordinates = new Coordinates(57.038091, 9.898626);
            string lemurDescription = "Kattalemuren, også kaldet ringhale-lemuren, er en halvabe-art der udelukkende lever på Madagaskar, primært i den sydlige og sydvestlige del af landet. " +
                                      "De 22 lemurarter, heriblandt kattalemuren, lever alle udelukkende på Madagaskar og de omkringliggende øer. " +
                                      "Kattalemurens habitat består oftest af træer med stenede buskområder, da lemuren tilbringer størstedelen af sin tid i træerne.\n\n" +
                                      "Kattalemuren er af gennemsnitlig størrelse i forhold til resten af lemurarterne, med en kropslængde der varierer mellem 380 og 450 mm. " +
                                      "Dens hale er længere end dens krop, med en længde på 560-625 mm. Det der kendetegner kattalemuren er især dens hale. " +
                                      "Dens hale er skiftevis sort og hvid, hvilket har gjort at den har fået øgenavnet ringhale-lemuren. Lemuren vejer mellem 2,3 og 3,5 kg.\n\n" +
                                      "Kattalemuren er planteæder og har derfor en kost bestående af planter, blade, blomster, frugter og i nogle tilfælde harpiks og bark. " +
                                      "I fangenskab lever lemuren i gennemsnit 30 år, mens de i naturen lever omkring 27 år.";
            Lemur = new Animal("Lemur", lemurDescription, lemurCoordinates, "Lemur Catta");

            FeedingTime lionFeeding = new FeedingTime(new DateTime(2016, 1, 1), new DateTime(2016, 12, DateTime.DaysInMonth(2016, 12)), new Time(13, 45), new int[] { 2, 3, 6, 7 });
            Coordinates lionCoordinates = new Coordinates(57.036185, 9.896652);
            string lionDescription = "Den asiatiske løve var før i tiden meget udbredt helt fra Grækenland til det centrale Indien, " +
                                     "men på grund af krybskytteri og ødelæggelse af habitater findes den asiatiske løve nu kun Girskoven i det nordvestlige Indien. " +
                                     "Man mener at bestanden er faldet til kun at være på cirka 350 løver. " +
                                     "Den asiatiske løve lever i tørre skovarealer af teaktræer, mens den mere udbredte afrikanske løve vælger habitat efter antallet af byttedyr i området. " +
                                     "Den afrikanske løve er god til at tilpasse sig det område den lever i, hvilket gør at den kan findes i alt fra tætte skovarealer til savannaher og lignende semi-ørkener.\n\n" +
                                     "Den typiske vægt for voksne hanløver er 190 kg, mens hunnerne i gennemsnit vejer 125 kg. " +
                                     "Hannerne bliver omkring 1,1 meter høje, hvor hunnerne bliver lidt mindre end hannerne. " +
                                     "Fælles for begge køn er længden, hvor de i gennemsnit bliver 2,5 til 3 meter lange.\n\n" +
                                     "Løven er kødædende. De jager oftest i små grupper, hvilket gør det muligt for dem at jage dyr der er betydeligt større end dem selv. " +
                                     "Det er dog ikke så normalt for den asiatiske løve at fange bytte der er større end dem selv. " +
                                     "Den asiatiske løve jager oftest hjorte og antiloper, og i nogle tilfælde også mindre pattedyr. " +
                                     "Løven søger også aktivt efter bytte der allerede er dødt, på samme måde som hyænen gør. " +
                                     "I naturen lever løver mellem 12 og 15 år, mens de i fangenskab i gennemsnit bliver 25 år gamle.";
            Lion = new Animal("Løve", lionDescription, lionCoordinates, "Panthera leo persica", lionFeeding);

            FeedingTime penguinFeeding = new FeedingTime(new DateTime(2016, 5, 1), new DateTime(2016, 10, DateTime.DaysInMonth(2016, 10)), new Time(11, 15), new int[] { 1, 2, 3, 4, 5, 6, 7 });
            FeedingTime penguinFeeding2 = new FeedingTime(new DateTime(2016, 5, 1), new DateTime(2016, 10, DateTime.DaysInMonth(2016, 10)), new Time(14, 15), new int[] { 1, 2, 3, 4, 5, 6, 7 });
            Coordinates penquinCoordinates = new Coordinates(57.036389, 9.898301);
            string penquinDescription = "Humboldt-pingvinen er knyttet til kun et sted på Jorden. " +
                                        "De lever ved den sydamerikanske vestkyst i Chile og Peru, et område også kendetegnet " + 
                                        "ved at ligge nær Humboldt-strømmen, som er en havstrøm karakteriseret ved koldt, næringsholdigt vand. " +
                                        "Humboldt-pingvinen bruger det meste af sin tid i vandet nær kysten, hvor de i gennemsnit bruger 60 timer i vandet før de svømmer tilbage til land. " +
                                        "De bruger landjorden til at sove og avle, men også til at opdrage deres nyfødte unger før de også kan komme i vandet. " +
                                        "Den sydamerikanske kyst kendetegnes ved stenede områder, hvor der af og til findes grotter. " +
                                        "Pingvinerne bruger de stenede områder og grotterne til at bygge rede og avle deres unger.\n\n" +
                                        "Humboldt-pingvinen bliver mellem 66 og 70 cm i længden, med en vægt på 4 til 5 kg. " +
                                        "Fælles for alle pingvinarterne er deres farver. Mørke fjer på ryggen og hvide fjer på maven giver pingvinerne camouflage. " +
                                        "Set oppefra blænder pingvinens sorte ryg ind med det mørke vand, og nedefra blænder pingvinens hvide mave ind med himlen.\n\n" +
                                        "Humboldt-pingvinen spiser udelukkende fisk og sprutter. " +
                                        "Pingvinerne nær det nordlige Chile spiser ofte hornfisk, mens dem nær det centrale Chile ofte spiser ansjoser og sardiner. " +
                                        "Uafhængigt af område spiser humboldt-pingvinen også mange sild. " +
                                        "Humboldt-pingvinens levetid i naturen er ukendt, men i fangenskab bliver de mellem 15-20 år gammel.";
            Penguin = new Animal("Penguin", penquinDescription, penquinCoordinates, "Spheniscus Humboldti", penguinFeeding, penguinFeeding2);

            Coordinates meercatCoordinates = new Coordinates(57.036098, 9.897970);
            string meercatDescription = "Surikaten lever i områder af Sydafrika, Botswana, Mozambique og Zimbabwe. " +
                                        "Fælles for disse områder er at de er savannaher eller tørre græslande. " +
                                        "Oftest vælger surikaten levested efter hårdheden af jorden. " +
                                        "Hård jord gør det nemmere for surikaten at stabilisere de underjordiske gange de har gravet. " +
                                        "Disse underjordiske gange udgør surikatens habitat, og bliver ofte delt med andre dyr, såsom jordegernet og rævemangusten.\n\n" +
                                        "Surikaten er en af de mindre dyr af arten desmerdyr. " +
                                        "Hannerne vejer i gennemsnit 731 gram, hvor hunnerne vejer 720 gram. " +
                                        "Både hannerne og hunnerne kan have en total længde mellem 425 og 600 mm, hvoraf 175-200 mm er hale. " +
                                        "Den bruger halen til at signalere andre surikater om fare i området og som balancestang. " +
                                        "I fangenskab er det normalt for surikaten at leve i over 12 år, hvor de i naturen lever mellem 5 og 15 år.\n\n" +
                                        "Surikaten er kødæder, og har en diæt primært bestående af insekter. " +
                                        "Surikaten vil lede efter føde i jordbunden, ved at kigge under mindre sten eller grave i jorden. " +
                                        "I nogle tilfælde vil surikaten spise mindre pattedyr eller fugle, men dette sker sjældent.";
            Meercat = new Animal("Meercat", meercatDescription, meercatCoordinates, "Suricata Suricatta");

            Coordinates zebraCoordinates = new Coordinates(57.035073, 9.897715);
            string zebraDescription = "Zebraerne i Aalborg Zoo er af arten Grevys zebra, som er den største nulevende zebraart. " +
                                      "I naturen findes Grevys zebra i det nordlige Kenya og nogle få områder i det sydlige Etiopien. " +
                                      "Historisk set var Grevys zebra meget mere udbredt i Afrika, " +
                                      "men krybskytteri og ødelæggelse af habitater har gjort at den nu er en moderat " +
                                      "truet dyreart med en bestand på mellem 2000 og 2500 dyr, hvor cirka 95 % lever i Kenya. " +
                                      "Zebraen beboer oftest halvtørre græslande med nem adgang til permanente vandkilder.\n\n" +
                                      "Zebra-hannerne er cirka 10% større end hunnerne. " +
                                      "De vejer mellem 350 og 450 kg, og har en gennemsnitlig længde på 135 cm. " +
                                      "Hver zebra har et unikt sort/hvid mønster, hvilket gør at mønsteret fungerer på samme måde som menneskets fingeraftryk. " +
                                      "Mønsteret er et forsvarsværktøj der bruges til at forvirre rovdyr. " +
                                      "Når en zebraflok bliver angrebet vil de løbe væk i en samlet flok, " + 
                                      "hvor mønsteret gør det svært for rovdyrene at udvælge et enkelt dyr at udskille fra resten af flokken.\n\n" +
                                      "I naturen bliver zebraen oftest ikke mere end 12-13 år gammel, hvor de i fangenskab bliver mellem 22 og 30 år gammel. " +
                                      "Grevys zebra er planteædende og spiser primært blade, hårdt græs og skud fra buske. " +
                                      "Deres maver gør det muligt at fordøje planter som andet kvæg ikke har et godt nok fordøjelsessystem til at fordøje. " +
                                      "Zebraen vil nogle gange arbejde sammen med andre dyr, som fx strudse og antiloper, for at holde øje med rovdyr mens dyrene græsser.";
            Zebra = new Animal("Zebra", zebraDescription, zebraCoordinates, "Equus Grevyi");

            FeedingTime tigerFeeding = new FeedingTime(new DateTime(2016, 1, 1), new DateTime(2016, 12, DateTime.DaysInMonth(2016, 12)), new Time(13, 45), new int[] { 2, 3, 6, 7 });
            Coordinates tigerCoordinates = new Coordinates(57.036355, 9.896779);
            string tigerDescription = "Der er 8 anerkendte underarter af tiger-arten, hvoraf 3 af arterne menes at være uddøde. " +
                                      "De nulevende arter er den Sibiriske tiger, Bengalske tiger, Indo-kinesiske tiger, Syd-kinesiske tiger og, den som er i Aalborg Zoo, Sumatra-tigeren. " +
                                      "Tigeren lever i meget variende klima alt efter hvilken under-art det er. " +
                                      "De er set levende i tropisk lavlandede stedsegrønne skove, tørre tornskove, egekrat, birkeskove, højtgræssede jungler og sumpe. " +
                                      "De kan leve i varme og fugtige områder, men også i områder med ekstrem kulde. " +
                                      "Tigeren er også blevet fundet i en højde af 4000 meter. " +
                                      "Sumatra-tigeren lever i bjergskove, lavlandsskove eller sumpområder.\n\n" +
                                      "Tigerne er kødædere og foretrækker at jage om natten hvor de kan snige sig ind på sit bytte. " +
                                      "Byttet er oftest mindre pattedyr, men i nogle tilfælde vil tigeren angribe større pattedyr. " +
                                      "Den spiser også af og til fugle og fisk, hvis den kan få fat på dem. " +
                                      "Tigerne spiser normalt ikke hver dag, men fylder maven op ved at spise mellem 20 og 40 kg kød når et bytte nedlægges. " +
                                      "Ved større bytte end den kan spise vil tigeren trække byttet i skjul og gemme det til en anden dag.\n\n" +
                                      "Tigeren varierer meget i vægt og længde, alt efter hvilken underart der er på tale. " +
                                      "Sumatra-tigeren er den mindste levende tiger-art, hvor hannerne i gennemsnit er 2,34 meter lange og vejer 136 kg. " +
                                      "Hunnerne er lidt mindre, med en længde på 1,98 meter og en vægt på 91 kg. " +
                                      "I naturen lever tigre oftest ikke mere end 8 til 10 år, hvor de i fangenskab kan blive helt op til 26 år gamle.";
            Tiger = new Animal("Tiger", tigerDescription, tigerCoordinates, "Panthea Sigris Sumatrae", tigerFeeding);
        }

        private static void InitializeFacilities()
        {
            Coordinates toiletCoordinates1 = new Coordinates(57.03760766, 9.89764463);
            string toiletDescription = "Et sted at lade vandet fra kartoflerne";

            Toilet1 = new Facility("Toilet - ved chimpanserne", toiletDescription, toiletCoordinates1, Toilet1);

            Coordinates toiletCoordinates2 = new Coordinates(57.03847141, 9.90024678);
            Toilet2 = new Facility("Toilet - ved indgangen", toiletDescription, toiletCoordinates2, Toilet2);

            Coordinates toiletCoordinates3 = new Coordinates(57.037176, 9.898884);
            Toilet3 = new Facility("Toilet - ved casafamilia", toiletDescription, toiletCoordinates3, Toilet3);

            Coordinates toiletCoordinates4 = new Coordinates(57.03624819, 9.89875707);
            Toilet4 = new Facility("Toilet - ved pingvinerne", toiletDescription, toiletCoordinates4, Toilet4);

            Coordinates toiletCoordinates5 = new Coordinates(57.035668, 9.896225);
            Toilet5 = new Facility("Toilet - ved elefanterne", toiletDescription, toiletCoordinates5, Toilet5);

            Coordinates smokeAreaCoordinates1 = new Coordinates(57.03763956, 9.89869313);
            string smokeAreaDescription = "Et sted at ryge";

            SmokeArea1 = new Facility("Rygeområde - ved bavianerne", smokeAreaDescription, smokeAreaCoordinates1, SmokeArea1);

            Coordinates smokeAreaCoordinates2 = new Coordinates(57.03649414, 9.89805727);
            SmokeArea2 = new Facility("Rygeområde - ved legepladsen", smokeAreaDescription, smokeAreaCoordinates2, SmokeArea2);

            Coordinates skovbakkenCoordinates = new Coordinates(57.03708343, 9.89808152);
            string skovbakkenDescription = "(REPLACE) Skovbakken er Aalborg Zoos spisested, placeret ved Faunavej på bakken op mod skoven. Her har vi udsigt over byen og Aalborg Zoo.";
            Time skovbakkenOpen = new Time(8);
            Time skovbakkenClose = new Time(16);

            Skovbakken = new Facility("Skovbakken", skovbakkenDescription, skovbakkenCoordinates, skovbakkenOpen, skovbakkenClose, Skovbakken);

            Coordinates casaFamiliaCoordinates = new Coordinates(57.03709788, 9.89863601);
            string casaFamiliaDescription = "(REPLACE) Casa Familia er Zoos sydamerikanske spisested, hvor du kan få serveret dagens grill over trækul:";
            Time casaFamiliaOpen = new Time(8);
            Time casaFamiliaClose = new Time(16);

            CasaFamilia = new Facility("Casa Familia", casaFamiliaDescription, casaFamiliaCoordinates, casaFamiliaOpen, casaFamiliaClose, CasaFamilia);

            Coordinates playgroundKioskCoordinates = new Coordinates(57.0361873, 9.89785433);
            string playgroundKioskDescription = "(REPLACE) I Legepladskiosken kan du få serveret fransk hotdog, burgers, pommes frites, pølser, sandwich, is, kaffe og drikkevarer.";
            Time playgroundKioskOpen = new Time(8);
            Time playgroundKioskClose = new Time(16);

            PlaygroundKiosk = new Facility("Legepladskiosken", playgroundKioskDescription, playgroundKioskCoordinates, playgroundKioskOpen, playgroundKioskClose, PlaygroundKiosk);

            Coordinates bornezooCoordinates = new Coordinates(57.03667693, 9.89858478);
            string bornezooDescription = "zoo hvor ungerne kan røre ved geder";
            Time bornezooOpen = new Time(8);
            Time bornezooClosed = new Time(16);

            Bornezoo = new Facility("Bornezoo", bornezooDescription, bornezooCoordinates, bornezooOpen, bornezooClosed, Bornezoo);

            Coordinates zoofariSceneCoordinates = new Coordinates(57.03687671, 9.89742143);
            string zoofariSceneDescription = "scene til events og lign.";
            Time zoofariSceneOpen = new Time(8);
            Time zoofariSceneClosed = new Time(16);

            zoofariScene = new Facility("Zoofari Scene", zoofariSceneDescription, zoofariSceneCoordinates, zoofariSceneOpen, zoofariSceneClosed, zoofariScene);

            Coordinates PlaygroundCoordinates = new Coordinates(57.03650936, 9.89789225);
            string PlaygroundDescription = "legepladsen";
            Time playgroundOpen = new Time(8);
            Time PlaygroundClosed = new Time(16);

            Playground = new Facility("Legepladsen", PlaygroundDescription, PlaygroundCoordinates, playgroundOpen, PlaygroundClosed, Playground);

            Coordinates selfGrillCoordinates = new Coordinates(57.03643918, 9.89743574);
            string selfGrillDescription = "(REPLACE) Pak madkurven og besøg familieområdet i Aalborg Zoo, hvor du har mulighed for at grille din" +
                                          "egen medbragte mad i en af vores to store grillhytter (Det er ikke muligt at købe mad til grill selv i Aalborg Zoo) Grillen slukkes ca. en time før havens lukketid. Grillerne kan benyttes indtil 23. oktober.";
            Time selfGrillOpen = new Time(8);
            Time selfGrillClose = new Time(16);

            SelfGrill = new Facility("Grill-selv", selfGrillDescription, selfGrillCoordinates, selfGrillOpen, selfGrillClose, SelfGrill);
        }
    }
}

