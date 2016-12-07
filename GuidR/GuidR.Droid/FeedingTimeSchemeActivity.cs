using Android.App;
using Android.Graphics;
using Android.OS;
using Android.Views;
using Android.Widget;
using DeviceInfo.Plugin;
using System;
using System.Collections.Generic;
using System.Linq;


namespace GuidR.Droid {
    [Activity(Label = "Aalborg Zoo", Theme = "@style/NoTitle.splash")]

    public class FeedingTimeSchemeActivity : Activity {

        int feedingtimeLineHeight;



        protected override void OnCreate(Bundle bundle) {

            base.OnCreate(bundle);

            SetContentView(Resource.Layout.FeedingTimeScheme);


            Android.Util.DisplayMetrics metrics = Resources.DisplayMetrics;
            feedingtimeLineHeight = (int)(metrics.HeightPixels / 8.5);


            ImageView banner = FindViewById<ImageView>(Resource.Id.homeBanner);
            banner.Click += delegate {
                StartActivity(typeof(MainActivity));
            };
            
            if(CrossDeviceInfo.Current.Version.CompareTo("6.0") >= 0) {
                setTimeline();
                HorizontalScrollView animalScroller = FindViewById<HorizontalScrollView>(Resource.Id.animalScroller);
                HorizontalScrollView timelineScroller = FindViewById<HorizontalScrollView>(Resource.Id.timelineScrollView);
                //HERFRA

                animalScroller.ScrollChange += delegate {
                    timelineScroller.ScrollTo(animalScroller.ScrollX, animalScroller.ScrollY);
                };

                timelineScroller.ScrollChange += delegate {
                    animalScroller.ScrollTo(timelineScroller.ScrollX, timelineScroller.ScrollY);
                };
            }
            else {
                HorizontalScrollView timelineScroller = FindViewById<HorizontalScrollView>(Resource.Id.timelineScrollView);
                timelineScroller.RemoveAllViews();
            }

            SetFeedingtimeBlocks();

           
            
        }

        void setTimeline() {


            LinearLayout timeLine = FindViewById<LinearLayout>(Resource.Id.timeLine);
            timeLine.SetGravity(GravityFlags.CenterVertical);

            View blockLine;

            blockLine = LayoutInflater.Inflate(Resource.Layout.line, timeLine, false);

            //Make the horizontal white lines between the animals
            LinearLayout.LayoutParams horizontalLine = new LinearLayout.LayoutParams(LinearLayout.LayoutParams.MatchParent, 10);
            blockLine.LayoutParameters = horizontalLine;
            blockLine.SetBackgroundColor(Color.ParseColor("#000000"));



            //Make the block that goes where the animal image should go, used to space everything correctly
            

            //Make the timeline addition
            LinearLayout timelineLayout = (LinearLayout)LayoutInflater.Inflate(Resource.Layout.LinearLayout, timeLine, false);
            LinearLayout.LayoutParams timelineLayoutParams = new LinearLayout.LayoutParams(LinearLayout.LayoutParams.MatchParent, 100);
            timelineLayout.Orientation = Orientation.Horizontal;
            timelineLayout.LayoutParameters = timelineLayoutParams;
            timelineLayout.SetGravity(GravityFlags.Left);

            timeLine.AddView(timelineLayout);


            //for every hour, there should be a xx:00 and a xx:30.
            for (int i = 0; i < 24; i++) {
                TextView timelineElement = (TextView)LayoutInflater.Inflate(Resource.Layout.Text, timelineLayout, false);
                timelineElement.SetTextSize(Android.Util.ComplexUnitType.Dip, 17);
                timelineElement.Gravity = GravityFlags.Center;
                timelineElement.SetTextColor(Color.ParseColor("#AAAAAA"));
                timelineElement.Text = i.ToString("00") + ".00";
                timelineElement.SetWidth(30 * 5);
                // timelineElement.Gravity = GravityFlags.Center;
                timelineLayout.AddView(timelineElement);

                timelineElement = (TextView)LayoutInflater.Inflate(Resource.Layout.Text, timelineLayout, false);
                timelineElement.Gravity = GravityFlags.Center;
                timelineElement.SetTextSize(Android.Util.ComplexUnitType.Dip, 17);
                timelineElement.SetTextColor(Color.ParseColor("#FFFFFF"));
                timelineElement.Text = i.ToString("00") + ".30";
                timelineElement.SetWidth(30 * 5);
                timelineElement.Gravity = GravityFlags.Center;
                timelineLayout.AddView(timelineElement);

            }

            timeLine.AddView(blockLine);
            HorizontalScrollView animalScroller = FindViewById<HorizontalScrollView>(Resource.Id.animalScroller);
            animalScroller.LayoutParameters.Width = timeLine.Width;
        }


        void SetFeedingtimeBlocks() {
            List<Animal> TempAnimalList = new List<Animal>();



            Animal animal;
            for (int i = AttractionDataBase.Attractions.Count - 1; i > 0; i--) {
                Attraction attraction = AttractionDataBase.Attractions[i];
                if (attraction is Animal && (attraction as Animal).HasFeedingTime) {
                    animal = (attraction as Animal);
                    TempAnimalList.Add(animal);

                }
            }


            TempAnimalList = TempAnimalList.OrderBy(x => x.NextFeeding).ToList();

            LinearLayout Scheme = FindViewById<LinearLayout>(Resource.Id.FeedingTimeSchemeLayout);
            LinearLayout Text = FindViewById<LinearLayout>(Resource.Id.FeedingTimeSchemeText);
            LinearLayout Root = FindViewById<LinearLayout>(Resource.Id.FeedingTimeSchemeRoot);
            Random rng = new Random();
            int index = 0;
            foreach (Animal a in TempAnimalList) {

                View animalText = LayoutInflater.Inflate(Resource.Layout.AnimalFeedingText, Text, false);


                Color[] colours = new Color[] { Color.Red, Color.Green, Color.Blue, Color.Yellow, Color.Red, Color.Green, Color.Blue, Color.Yellow , Color.Red, Color.Green, Color.Blue, Color.Yellow , Color.Red, Color.Green, Color.Blue, Color.Yellow };




                LinearLayout horizontalAnimalLayout = (LinearLayout)LayoutInflater.Inflate(Resource.Layout.LinearLayout, Scheme, false);
                LinearLayout.LayoutParams LL = new LinearLayout.LayoutParams(LinearLayout.LayoutParams.MatchParent, feedingtimeLineHeight);
                horizontalAnimalLayout.Orientation = Orientation.Horizontal;
              //  horizontalAnimalLayout.SetBackgroundColor(colours[index]);

                horizontalAnimalLayout.LayoutParameters = LL;
                Scheme.AddView(horizontalAnimalLayout);
                

                LinearLayout.LayoutParams animalTextLL = new LinearLayout.LayoutParams(240, feedingtimeLineHeight);
                animalText.LayoutParameters = animalTextLL;
                if (((animalText as ViewGroup).GetChildAt(0) is ImageView))
                    ((animalText as ViewGroup).GetChildAt(0) as ImageView).SetImageResource((int)a.Image);
                Text.AddView(animalText);


                LinearLayout.LayoutParams horizontalLine = new LinearLayout.LayoutParams(LinearLayout.LayoutParams.MatchParent, 2);
                View textLine = LayoutInflater.Inflate(Resource.Layout.line, Text, false);
                textLine = LayoutInflater.Inflate(Resource.Layout.line, Text, false);
                textLine.LayoutParameters = horizontalLine;
                textLine.SetBackgroundColor(Color.ParseColor("#000000"));


                int feedingtimeCounter = 0;
                foreach (FeedingTime FT in a.FeedingTimes) {
                    //set the destination

                    



                    

                    View animalBlock = LayoutInflater.Inflate(Resource.Layout.AnimalFeedingBlock, (LinearLayout)Scheme.GetChildAt(index), false);

                    //Find the text and linearlayout children

                    LinearLayout.LayoutParams animalBlockParams = new LinearLayout.LayoutParams((animalBlock as LinearLayout).LayoutParameters.Width = FT.ShowLength * 5, feedingtimeLineHeight);

                    (animalBlock as LinearLayout).LayoutParameters = animalBlockParams;
                    //((animalBlock as ViewGroup).GetChildAt(i) as LinearLayout).Left = FT.TimeOfDay.Hour * 60 * 5 + FT.TimeOfDay.Second * 5;

                    int timeBeforeCurrentFeedingtime = 0;
                    for (int i = 0; i < feedingtimeCounter; i++)
                    {
                        timeBeforeCurrentFeedingtime += a.FeedingTimes[i].TimeOfDay.Hour * 60 * 5 + a.FeedingTimes[i].TimeOfDay.Minute * 5 + a.FeedingTimes[i].ShowLength * 5 + 25;
                    }



                     animalBlockParams.LeftMargin = (int)(FT.TimeOfDay.Hour * 60 + FT.TimeOfDay.Minute)
                        * 5 + 25 - timeBeforeCurrentFeedingtime ;

                    (animalBlock as LinearLayout).SetBackgroundColor(Color.ParseColor("#e6e8ed"));
                    (animalBlock as LinearLayout).LayoutParameters.Height = feedingtimeLineHeight;




                    ((animalBlock as ViewGroup).GetChildAt(0) as TextView).Text = (FT.TimeOfDay.Hour.ToString("00") + ":" + FT.TimeOfDay.Minute.ToString("00"));

                    (Scheme.GetChildAt(index) as LinearLayout).AddView(animalBlock);
                    feedingtimeCounter++;
                }

                //if(index < 3) { 
                View blockLine = LayoutInflater.Inflate(Resource.Layout.line, Scheme, false);
                horizontalLine = new LinearLayout.LayoutParams(LinearLayout.LayoutParams.MatchParent, 2);
                blockLine.LayoutParameters = horizontalLine;
                blockLine.SetBackgroundColor(Color.ParseColor("#000000"));
                Scheme.AddView(blockLine);
                //}


                index+=2;
                Text.AddView(textLine);

            }
        }
    }
}
