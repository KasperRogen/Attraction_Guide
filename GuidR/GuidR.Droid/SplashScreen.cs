﻿using Android.App;
using Android.Content.Res;
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

            ReadFile();
            SplitAndConvert();

           // AttractionDataBase.InitializeAttraction();

           // InitializeAndroidDependencies();

            StartActivity(typeof(MainActivity));
        }


        public void ReadFile() {

            
            AssetManager assets = this.Assets;

            List<string> lines = new List<string>();
            using (StreamReader sr = new StreamReader(assets.Open("test.csv"), System.Text.Encoding.GetEncoding("iso-8859-1"), true)) {
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


            Console.WriteLine("*amount of lines in lines: " + lines.Count);
        }



        public void SplitAndConvert() {

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

            foreach (string line in Lines) {
                Console.WriteLine("DOOING IITT *****************************************");
                string[] newLine = line.Split(';');
                string[] coord = newLine[locationIndex].Split(',');
                string[] ftimes = newLine[feedingTimeIndex].Split(',');
                List<Time> feedingtimesHM = new List<Time>();
                List<FeedingTime> feedingTimes = new List<FeedingTime>();


                foreach (string feed in ftimes) {
                    string[] hm = feed.Split('.');
                    foreach(string a in hm)
                        Console.WriteLine("HM: " + a);
                    feedingtimesHM.Add(new Time(int.Parse(hm[0]), int.Parse(hm[1])));
                }

                foreach (Time t in feedingtimesHM) {
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

                AttractionDataBase.Attractions.Add(new Animal(
                    newLine[nameIndex],
                    newLine[descriptionIndex],
                    new Coordinates(double.Parse(coord[0]), double.Parse(coord[1])),
                    newLine[latinNameIndex],
                    feedingTimes.ToArray()
                    ));



                animalList.Add(new Animal(
    newLine[nameIndex],
    newLine[descriptionIndex],
    new Coordinates(double.Parse(coord[0]), double.Parse(coord[1])),
    newLine[latinNameIndex],
    feedingTimes.ToArray()
    ));

            }
            foreach (Animal animal in animalList) {
                Console.WriteLine("ØØØØØØØØØØØØØØØØØØØØØØØØØ " + animal.Name);
            }
        }



        // Initializes Android specific Drawables
        void InitializeAndroidDependencies ()
        {
            AttractionDataBase.Baboon.Image = Resource.Drawable.BaboonHeader;
            AttractionDataBase.Bear.Image = Resource.Drawable.BrownBearHeader;
            AttractionDataBase.SeaLion.Image = Resource.Drawable.SeaLionHeader;
            AttractionDataBase.Hippo.Image = Resource.Drawable.HippoHeader;
            AttractionDataBase.Elephant.Image = Resource.Drawable.ElephantHeader;
            AttractionDataBase.Giraffe.Image = Resource.Drawable.GiraffeHeader;
            AttractionDataBase.PolarBear.Image = Resource.Drawable.PolarBearHeader;
            AttractionDataBase.Kaiman.Image = Resource.Drawable.KaimanHeader;
            AttractionDataBase.Tamarin.Image = Resource.Drawable.TamarinHeader;
            AttractionDataBase.Lemur.Image = Resource.Drawable.LemurHeader;
            AttractionDataBase.Lion.Image = Resource.Drawable.LionHeader;
            AttractionDataBase.Penguin.Image = Resource.Drawable.PenguinHeader;
            AttractionDataBase.Meercat.Image = Resource.Drawable.MeercatHeader;
            AttractionDataBase.Tiger.Image = Resource.Drawable.TigerHeader;
            AttractionDataBase.Zebra.Image = Resource.Drawable.ZebraHeader;

            AttractionDataBase.Toilet1.Image = Resource.Drawable.Toilet1Header;
            AttractionDataBase.Toilet2.Image = Resource.Drawable.Toilet2Header;
            AttractionDataBase.Toilet3.Image = Resource.Drawable.Toilet3Header;
            AttractionDataBase.Toilet4.Image = Resource.Drawable.Toilet4Header;
            AttractionDataBase.Toilet5.Image = Resource.Drawable.Toilet5Header;

            AttractionDataBase.CasaFamilia.Image = Resource.Drawable.CasafamiliaHeader;
            AttractionDataBase.Skovbakken.Image = Resource.Drawable.SkovBakkenHeader;
            AttractionDataBase.SelfGrill.Image = Resource.Drawable.grill_selvHeader;
            AttractionDataBase.PlaygroundKiosk.Image = Resource.Drawable.PlaygroundKioskHeader;
            AttractionDataBase.Playground1_irl.Image = Resource.Drawable.PlaygroundHeader;
            AttractionDataBase.SmokeArea1.Image = Resource.Drawable.Smoke_Area1Header;
            AttractionDataBase.SmokeArea2.Image = Resource.Drawable.Smoke_Area2Header;
            AttractionDataBase.Bornezoo.Image = Resource.Drawable.bornezooHeader;
            AttractionDataBase.zoofariScene.Image = Resource.Drawable.ZoofariScenenHeader;

            InitializePins();
        }


        void InitializePins ()
        {
            AttractionDataBase.Baboon.Pin = Resource.Drawable.Baboon_Pin;
            AttractionDataBase.Bear.Pin = Resource.Drawable.Brown_bear_Pin;
            AttractionDataBase.SeaLion.Pin = Resource.Drawable.Californian_Sea_Lion_pin;
            AttractionDataBase.Hippo.Pin = Resource.Drawable.Pygmy_Hippo_Pin;
            AttractionDataBase.Elephant.Pin = Resource.Drawable.Elephant_Pin;
            AttractionDataBase.Giraffe.Pin = Resource.Drawable.Giraffe_Pin;
            AttractionDataBase.PolarBear.Pin = Resource.Drawable.Polar_bear_Pin;
            AttractionDataBase.Kaiman.Pin = Resource.Drawable.Black_kaiman_Pin;
            AttractionDataBase.Tamarin.Pin = Resource.Drawable.Emperor_tamarin_Pin;
            AttractionDataBase.Lemur.Pin = Resource.Drawable.Lemur_pin;
            AttractionDataBase.Lion.Pin = Resource.Drawable.Lion_Pin;
            AttractionDataBase.Penguin.Pin = Resource.Drawable.Penguin_Pin;
            AttractionDataBase.Meercat.Pin = Resource.Drawable.Meercat_Pin;
            AttractionDataBase.Tiger.Pin = Resource.Drawable.Tiger_Pin;
            AttractionDataBase.Zebra.Pin = Resource.Drawable.Zebra_Pin;

            AttractionDataBase.Toilet1.Pin = Resource.Drawable.Toilet_pin;
            AttractionDataBase.Toilet2.Pin = Resource.Drawable.Toilet_pin;
            AttractionDataBase.Toilet3.Pin = Resource.Drawable.Toilet_pin;
            AttractionDataBase.Toilet4.Pin = Resource.Drawable.Toilet_pin;
            AttractionDataBase.Toilet5.Pin = Resource.Drawable.Toilet_pin;

            AttractionDataBase.CasaFamilia.Pin = Resource.Drawable.Restaurant_Pin;
            AttractionDataBase.Skovbakken.Pin = Resource.Drawable.Restaurant_Pin;
            AttractionDataBase.SelfGrill.Pin = Resource.Drawable.Restaurant_Pin;
            AttractionDataBase.PlaygroundKiosk.Pin = Resource.Drawable.Restaurant_Pin;
            AttractionDataBase.Playground1_irl.Pin = Resource.Drawable.Playground_Pin;
            AttractionDataBase.SmokeArea1.Pin = Resource.Drawable.Smoke_area_pin;
            AttractionDataBase.SmokeArea2.Pin = Resource.Drawable.Smoke_area_pin;
            AttractionDataBase.Bornezoo.Pin = Resource.Drawable.Playground_Pin;
            AttractionDataBase.zoofariScene.Pin = Resource.Drawable.Playground_Pin;
        }
    }
}