using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;

namespace GuidR.Droid {
    [Activity(Label = "Aalborg Zoo", Theme = "@style/NoTitle.splash")]

    class animalClass {
        public FeedingTime _time { get; set; }
        public string _name { get; set; }
    }

    public class FeedingTimeSchemeActivity : Activity {



        protected override void OnCreate(Bundle bundle) {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.FeedingTimeScheme);
            Console.WriteLine("TIIIIING");
//            DoIt();
                
        }

        void DoIt() {
            LinearLayout Scheme = FindViewById<LinearLayout>(Resource.Id.FeedingTimeSchemeLayout);



            List<animalClass> SortedFeedingTimeAnimals = new List<animalClass>();
            Animal animalToStore = null;
            FeedingTime lastTime = new FeedingTime(new DateTime(2016, 1, 1), new DateTime(2016, 12, 1), new Time(23, 59), new int[] { 1, 2, 3, 4, 5, 6, 7 });

            animalClass AC = new animalClass();

            for (int i = 0; i < AttractionDataBase.Attractions.Count; i++) {
                foreach (Attraction a in AttractionDataBase.Attractions) {
                    if (a is Animal && (a as Animal).HasFeedingTime) {
                        foreach (FeedingTime FT in (a as Animal).FeedingTimes) {
                            if (FT.CompareTo(lastTime) < 0) {
                                AC._name = a.Name;
                                AC._time = FT;

                                
                                }
                        }
                    }
                }
                SortedFeedingTimeAnimals.Add(AC);
            }

            foreach (animalClass animal in SortedFeedingTimeAnimals) {
                        
                            

                        //set the destination
                        View animalBlock = LayoutInflater.Inflate(Resource.Layout.AnimalFeedingBlock, Scheme, false);

                        //Find the text and linearlayout children
                        for (int i = 0; i < (animalBlock as ViewGroup).ChildCount; i++) {

                            if ((animalBlock as ViewGroup).GetChildAt(i) is TextView) {
                                ((animalBlock as ViewGroup).GetChildAt(i) as TextView).Text = animal._name;
                                ((animalBlock as ViewGroup).GetChildAt(i) as TextView).LayoutParameters.Width = animal._time.TimeOfDay.Hour * 60 + animal._time.TimeOfDay.Minute;

                            }
                            else if ((animalBlock as ViewGroup).GetChildAt(i) is LinearLayout) {
                                //((animalBlock as ViewGroup).GetChildAt(i) as LinearLayout).SetPadding((animal as Animal).NextFeeding.TimeOfDay.Hour * 60 + (animal as Animal).NextFeeding.TimeOfDay.Minute,0,0,0);
                                ((animalBlock as ViewGroup).GetChildAt(i) as LinearLayout).SetBackgroundColor(Color.ParseColor("#AAAAAA"));
                                ((animalBlock as ViewGroup).GetChildAt(i) as LinearLayout).LayoutParameters.Width = 30;
                            }
                        }
                        Scheme.AddView(animalBlock);
                    }
                }


                
            }
        }
