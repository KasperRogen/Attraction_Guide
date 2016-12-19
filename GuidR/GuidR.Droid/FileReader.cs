using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using Android.App;
using Android.Graphics;
using Android.Content;
using Android.Content.Res;

namespace GuidR.Droid
{



    public class FileReader : Activity
	{
		List<Animal> animalList { get; set; }
		List<String> Lines { get; set; }

		public FileReader()
		{
			Console.WriteLine("File Reader: ACTIVATED.");
			animalList = new List<Animal>();
			Lines = new List<string>();
		}

		public void ReadFile()
		{


            AssetManager assets = this.Assets;

            List<string> lines = new List<string>();
            using (StreamReader sr = new StreamReader(assets.Open("test.csv"))) {
                while (!sr.EndOfStream) {
                    string line = sr.ReadLine();

                    lines.Add(line);
                }
            }


            try
			{
				foreach (string line in lines)
				{
					if (line != null){
						Lines.Add(line);
						Console.WriteLine(line);
					}else
						break;
				}
			}
			catch (NullReferenceException e)
			{
				Console.WriteLine("File not found: " + e.Message);
			}
		}

		public void splitLines()
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
				string[] newLine = line.Split(';');
				string[] coord = newLine[locationIndex].Split(',');
				string[] ftimes = newLine[feedingTimeIndex].Split(',');
				List<Time> feedingtimesHM = new List<Time>();
                List<FeedingTime> feedingTimes = new List<FeedingTime>();


				foreach (string feed in ftimes)
				{
					string[] hm = feed.Split('.');
					feedingtimesHM.Add(new Time(int.Parse(hm[0]), int.Parse(hm[1])));
				}

                foreach(Time t in feedingtimesHM) {
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

                animalList.Add(new Animal(
                    newLine[nameIndex],
                    newLine[descriptionIndex],
                    new Coordinates(double.Parse(coord[0]), double.Parse(coord[1])),
                    newLine[latinNameIndex],
                    feedingTimes.ToArray()
                    ));
				               
			}
			foreach (Animal animal in animalList)
			{
				Console.WriteLine(animal.Name);
			}
		}
	}
}
