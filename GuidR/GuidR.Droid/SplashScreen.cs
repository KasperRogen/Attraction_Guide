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

            if(AttractionDataBase.splashScreenHasRun == false) { 
            //Read the animaldatabase file and create animals for the attractiondatabase based on this.
            ReadFile("AnimalDatabase");
            SplitAndConvertAnimals();

            //Read the facilitydatabase file and create Facilities for the attractiondatabase based on this.
            ReadFile("FacilityDatabase");
            SplitAndConvertFacilities();
                AttractionDataBase.splashScreenHasRun = true;
            }

            StartActivity(typeof(MainActivity));
        }


        public void ReadFile(string fileName) {
            Lines.Clear();
            List<string> lines = new List<string>();
            using (StreamReader sr = new StreamReader(Assets.Open(fileName + ".csv"), System.Text.Encoding.GetEncoding("iso-8859-1"), true)) {
                while (!sr.EndOfStream) {
                    string line = sr.ReadLine();

                    //add all the lines to the list of lines

                    lines.Add(line);
                }
            }


            try {
                foreach (string line in lines) {
                    //If the line isn't empty, add it to the final list of lines.
                    if (line != null) {
                        Lines.Add(line);
                    }
                    else
                        break;
                }
            }
            catch (NullReferenceException e) {
                Console.WriteLine("File not found: " + e.Message);
            }


            //Remove the line containing the identifiers in the database file
            Lines.RemoveAt(0);
        }



        public void SplitAndConvertAnimals()
        {

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

                //Newline is the line that we are currently looking at, containing an animal or facility.
                string[] newLine = line.Split(';');
                string[] coord = newLine[locationIndex].Split(',');

                List<Time> feedingtimesHM = new List<Time>();
                List<FeedingTime> feedingTimes = new List<FeedingTime>();

                //If the feedingtime index of the line is empty, there is no feedingtime.
                if (newLine[feedingTimeIndex] != "")
                {
                    //get the feedingtimes for the animal
                    string[] ftimes = newLine[feedingTimeIndex].Split(',');
                    foreach (string feed in ftimes)
                    {
                        //split each feedingtime into hours and minutes
                        string[] hm = feed.Split('.');
                        foreach (string a in hm)
                        feedingtimesHM.Add(new Time(int.Parse(hm[0]), int.Parse(hm[1])));
                        hasFeedingTime = true;
                    }
                }

                foreach (Time t in feedingtimesHM)
                {
                    //get the rest of the information for the feedingtime
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

                //add the animal to the database

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

                //IF the openindex of the database is empty, there is no opening time, and the facility is always open
                if (newLine[openIndex] != "")
                {
                    string[] opensAsStrings = newLine[openIndex].Split('.');
                    opens = new Time(int.Parse(opensAsStrings[0]), int.Parse(opensAsStrings[1]));

                    string[] closesAsStrings = newLine[closeIndex].Split('.');
                    closes = new Time(int.Parse(closesAsStrings[0]), int.Parse(closesAsStrings[1]));

                    alwaysOpen = false;
                }

                //add the facility to the attractiondatabase

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