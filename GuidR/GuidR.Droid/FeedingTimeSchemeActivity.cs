using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;

namespace GuidR.Droid
{
    [Activity(Label = "Aalborg Zoo", Theme = "@style/NoTitle.splash")]

    public class FeedingTimeSchemeActivity : Activity
    {



        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.FeedingTimeScheme);
            DoIt();

        }

        void DoIt()
        {
            LinearLayout Scheme = FindViewById<LinearLayout>(Resource.Id.FeedingTimeSchemeLayout);



            List<Animal> TempAnimalList = new List<Animal>();

            Animal animalToStore = null;
            FeedingTime lastTime = new FeedingTime(new DateTime(2016, 1, 1), new DateTime(2016, 12, 1), new Time(23, 59), new int[] { 1, 2, 3, 4, 5, 6, 7 });

          


            Animal animal;
            for(int i = AttractionDataBase.Attractions.Count - 1; i > 0; i--)
            {
                Attraction attraction = AttractionDataBase.Attractions[i];
                if (attraction is Animal && (attraction as Animal).HasFeedingTime) {
                    animal = (attraction as Animal);
                    foreach (FeedingTime feedingTime in animal.FeedingTimes) {
                        TempAnimalList.Add(new Animal(animal.Name, (attraction as Animal).Description, (attraction as Animal).Location, (attraction as Animal).LatinName, feedingTime));
                    }
                    
                }
            }


            for(int i = TempAnimalList.Count -1; i > 0; i--)
            {
                Time tempTime = new Time(23, 59);
                for(int j = TempAnimalList.Count -1; i > 0; i--)
                {
                    Console.WriteLine("Comparing: " + TempAnimalList[j].NextFeeding + " to: " + tempTime);
                    if(TempAnimalList[j].NextFeeding.CompareTo(tempTime) == -1)
                    {
                        tempTime = TempAnimalList[j].NextFeeding;
                        Console.WriteLine(TempAnimalList[j].NextFeeding + " < " + tempTime);
                    }
                }
            }


      foreach (Animal a in TempAnimalList) {

                    //set the destination
                    View animalBlock = LayoutInflater.Inflate(Resource.Layout.AnimalFeedingBlock, Scheme, false);

                    //Find the text and linearlayout children
                    for (int i = 0; i < (animalBlock as ViewGroup).ChildCount; i++) {

                        if ((animalBlock as ViewGroup).GetChildAt(i) is TextView) {
                            ((animalBlock as ViewGroup).GetChildAt(i) as TextView).Text = a.Name;
                            ((animalBlock as ViewGroup).GetChildAt(i) as TextView).LayoutParameters.Width = a.NextFeeding.TimeOfDay.Hour * 60 + a.NextFeeding.TimeOfDay.Minute;
                        }

                        else if ((animalBlock as ViewGroup).GetChildAt(i) is LinearLayout) {
                            ((animalBlock as ViewGroup).GetChildAt(i) as LinearLayout).SetBackgroundColor(Color.ParseColor("#AAAAAA"));
                            ((animalBlock as ViewGroup).GetChildAt(i) as LinearLayout).LayoutParameters.Width = 30;
                        }
                    }
                    Scheme.AddView(animalBlock);
                }
            }
        }
    }
