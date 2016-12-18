using Android.App;
using Android.Content.Res;
using Android.Locations;
using Android.OS;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace GuidR.Droid
{
    [Activity(Label ="Aalborg Zoo", MainLauncher = true, NoHistory = true, Theme ="@style/Theme.splash", Icon ="@drawable/logo")]
    public class SplashScreen: Activity
    {

        List<Animal> animalList = new List<Animal>();
	    List<string> Lines = new List<string>();

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            ReadFile("AnimalDatabase");
            SplitAndConvertAnimals();

            ReadFile("FacilityDatabase");
            SplitAndConvertFacilities();

            foreach(Attraction a in AttractionDataBase.Attractions)
                if(a is Facility)
                    Console.WriteLine((a as Facility).Name + " : " + (a as Facility).type);

            StartActivity(typeof(MainActivity));
        }


        public void ReadFile(string fileName) {
            Lines.Clear();
            List<string> lines = new List<string>();
            using (StreamReader sr = new StreamReader(Assets.Open(fileName + ".csv"), System.Text.Encoding.GetEncoding("iso-8859-1"), true)) {
                while (!sr.EndOfStream) {
                    string line = sr.ReadLine();

                    lines.Add(line);
                }
            }


            try {
                foreach (string line in lines) {
                    if (line != null) {
                        Lines.Add(line);
                        Console.WriteLine("In readfile(). Foreach line in lines: " + line);
                    }
                    else
                        break;
                }
            }
            catch (NullReferenceException e) {
                Console.WriteLine("File not found: " + e.Message);
            }



            Lines.RemoveAt(0);
        }



        public void SplitAndConvertAnimals()
        {

            Console.WriteLine("*ØØØØØØØØØØØØØØØØØØØØØØØØØØØØØØØØØØØØØ: " + Lines.Count);

            const int nameIndex = 0;
            const int descriptionIndex = 1;
            const int latinNameIndex = 2;
            const int locationIndex = 3;
            const int feedingTimeIndex = 4;
            const int startDateIndex = 5;
            const int endDateIndex = 6;
            const int showLengthIndex = 7;
            const int feedingDateIndex = 8;

            foreach (string line in Lines)
            {
                bool hasFeedingTime = false;
                string[] newLine = line.Split(';');
                string[] coord = newLine[locationIndex].Split(',');
                List<Time> feedingtimesHM = new List<Time>();
                List<FeedingTime> feedingTimes = new List<FeedingTime>();

                if (newLine[feedingTimeIndex] != "")
                {
                    string[] ftimes = newLine[feedingTimeIndex].Split(',');
                    foreach (string feed in ftimes)
                    {
                        string[] hm = feed.Split('.');
                        foreach (string a in hm)
                        feedingtimesHM.Add(new Time(int.Parse(hm[0]), int.Parse(hm[1])));
                        hasFeedingTime = true;
                    }
                }

                foreach (Time t in feedingtimesHM)
                {
                    string[] startDates = newLine[startDateIndex].Split(',');
                    string[] endDates = newLine[endDateIndex].Split(',');
                    string[] feedingDates = newLine[feedingDateIndex].Split(',');
                    List<int> feedingDatesAsInt = new List<int>();

                    foreach (string dates in feedingDates)
                        feedingDatesAsInt.Add(int.Parse(dates));

                    feedingTimes.Add(new FeedingTime(
                        new DateTime(int.Parse(startDates[0]), int.Parse(startDates[1]), int.Parse(startDates[2])),
                        new DateTime(int.Parse(endDates[0]), int.Parse(endDates[1]), int.Parse(endDates[2])),
                        t,
                        int.Parse(newLine[showLengthIndex]),
                        feedingDatesAsInt.ToArray()
                        ));
                }

                //Elephant = new Animal("Elefant", elephantDescription, elephantCoordinates, "Loxodonta Africana", elephantFeeding);
                if (hasFeedingTime)
                {
                    AttractionDataBase.Attractions.Add(new Animal(
                        newLine[nameIndex],
                        newLine[descriptionIndex],
                        ParseCoordinates(newLine[locationIndex]),
                        newLine[latinNameIndex],
                        feedingTimes.ToArray()
                        ));
                }


                //Hippo = new Animal("Dværgflodhest", hippoDescription, hippoCoordinates, "Hexaprotodon Liberiensis");
                else
                {
                    AttractionDataBase.Attractions.Add(new Animal(
                        newLine[nameIndex],
                        newLine[descriptionIndex],
                        new Coordinates(double.Parse(coord[0]), double.Parse(coord[1])),
                        newLine[latinNameIndex]
                        ));
                }
            }
        }



        void SplitAndConvertFacilities()
        {
            const int typeIndex = 0;
            const int nameIndex = 1;
            const int descriptionIndex = 2;
            const int locationIndex = 3;
            const int openIndex = 4;
            const int closeIndex = 5;
            Time opens = new Time(00, 00);
            Time closes = new Time (23,59);
            bool alwaysOpen = true;

            foreach (string line in Lines)
            {
                alwaysOpen = true;
                string[] newLine = line.Split(';');
                string[] coord = newLine[locationIndex].Split(',');

                if (newLine[openIndex] != "")
                {
                    string[] opensAsStrings = newLine[openIndex].Split('.');
                    opens = new Time(int.Parse(opensAsStrings[0]), int.Parse(opensAsStrings[1]));

                    string[] closesAsStrings = newLine[closeIndex].Split('.');
                    closes = new Time(int.Parse(closesAsStrings[0]), int.Parse(closesAsStrings[1]));

                    alwaysOpen = false;
                }


                if (alwaysOpen == false)
                {
                    Console.WriteLine(alwaysOpen + newLine[nameIndex]);
                    AttractionDataBase.Attractions.Add(new Facility(
                        (Facility.facilityType)Enum.Parse(typeof(Facility.facilityType), newLine[typeIndex], true),
                        newLine[nameIndex],
                        newLine[descriptionIndex],
                        ParseCoordinates(newLine[locationIndex]),
                        opens,
                        closes
                        ));
                }
                else
                {
                    Console.WriteLine(alwaysOpen + newLine[nameIndex]);
                    AttractionDataBase.Attractions.Add(new Facility(
                        (Facility.facilityType)Enum.Parse(typeof(Facility.facilityType), newLine[typeIndex], true),
                        newLine[nameIndex],
                        newLine[descriptionIndex],
                        ParseCoordinates(newLine[locationIndex])));
                }
            }

        }


        Coordinates ParseCoordinates(string coordString)
        {
            string[] coordsAsStrings = coordString.Split(',');
            Double[] coordsAsDoubles = new Double[2];

            coordsAsDoubles[0] = double.Parse(coordsAsStrings[0]);
            coordsAsDoubles[1] = double.Parse(coordsAsStrings[1]);

            Coordinates coords = new Coordinates(coordsAsDoubles[0], coordsAsDoubles[1]);


            return coords;
        }

    }
}