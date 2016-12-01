using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GuidR.Droid
{
    [Activity(Label = "Aalborg Zoo", Theme = "@style/NoTitle.splash")]

    public class FeedingTimeSchemeActivity : Activity
    {



        protected override void OnCreate(Bundle bundle)
        {

            base.OnCreate(bundle);

            SetContentView(Resource.Layout.FeedingTimeScheme);

            ImageView banner = FindViewById<ImageView>(Resource.Id.homeBanner);
            banner.Click += delegate {
                StartActivity(typeof(MainActivity));
            };


            setTimeline();
            DoIt();

            HorizontalScrollView animalScroller = FindViewById<HorizontalScrollView>(Resource.Id.animalScroller);
            HorizontalScrollView timelineScroller = FindViewById<HorizontalScrollView>(Resource.Id.timelineScrollView);
            //HERFRA
           // animalScroller.ViewTreeObserver.AddOnScrollChangedListener(this);
            animalScroller.ScrollChange += delegate {
                timelineScroller.ScrollTo(animalScroller.ScrollX, animalScroller.ScrollY);
            };

            timelineScroller.ScrollChange += delegate {
                animalScroller.ScrollTo(timelineScroller.ScrollX, timelineScroller.ScrollY);
            };

        }




        void setTimeline()
        {


            LinearLayout timeLine = FindViewById<LinearLayout>(Resource.Id.timeLine);

            View blockLine;

            blockLine = LayoutInflater.Inflate(Resource.Layout.line, timeLine, false);

            //Make the horizontal white lines between the animals
            LinearLayout.LayoutParams horizontalLine = new LinearLayout.LayoutParams(LinearLayout.LayoutParams.MatchParent, 10);
            blockLine.LayoutParameters = horizontalLine;
            blockLine.SetBackgroundColor(Color.ParseColor("#FFFFFF"));



            //Make the block that goes where the animal image should go, used to space everything correctly
            

            //Make the timeline addition
            LinearLayout timelineLayout = (LinearLayout)LayoutInflater.Inflate(Resource.Layout.LinearLayout, timeLine, false);
            LinearLayout.LayoutParams timelineLayoutParams = new LinearLayout.LayoutParams(LinearLayout.LayoutParams.MatchParent, 100);
            timelineLayout.Orientation = Orientation.Horizontal;
            timelineLayout.LayoutParameters = timelineLayoutParams;
            timelineLayout.SetGravity(GravityFlags.Left);

            timeLine.AddView(timelineLayout);


            //for every hour, there should be a xx:00 and a xx:30.
            for(int i = 0; i < 24; i++)
            {
                TextView timelineElement = (TextView)LayoutInflater.Inflate(Resource.Layout.Text, timelineLayout, false);
                timelineElement.SetTextSize(Android.Util.ComplexUnitType.Dip, 17);
                timelineElement.Gravity = GravityFlags.Center;
                timelineElement.SetTextColor(Color.ParseColor("#FFFFFF"));
                timelineElement.Text = i.ToString() + ".00";
                timelineElement.SetWidth(30 * 5);
               // timelineElement.Gravity = GravityFlags.Center;
                timelineLayout.AddView(timelineElement);
                
                timelineElement = (TextView)LayoutInflater.Inflate(Resource.Layout.Text, timelineLayout, false);
                timelineElement.Gravity = GravityFlags.Center;
                timelineElement.SetTextSize(Android.Util.ComplexUnitType.Dip, 17);
                timelineElement.Text = i.ToString() + ".30";
                timelineElement.SetWidth(30 * 5);
                timelineElement.Gravity = GravityFlags.Center;
                timelineLayout.AddView(timelineElement);

            }

            timeLine.AddView(blockLine);
            HorizontalScrollView animalScroller = FindViewById<HorizontalScrollView>(Resource.Id.animalScroller);
            animalScroller.LayoutParameters.Width = timeLine.Width;
        }


        void DoIt()
        {
            LinearLayout Scheme = FindViewById<LinearLayout>(Resource.Id.FeedingTimeSchemeLayout);
            LinearLayout Text = FindViewById<LinearLayout>(Resource.Id.FeedingTimeSchemeText);
            LinearLayout Root = FindViewById<LinearLayout>(Resource.Id.FeedingTimeSchemeRoot);

            List<Animal> TempAnimalList = new List<Animal>();
          


            Animal animal;
            for(int i = AttractionDataBase.Attractions.Count - 1; i > 0; i--)
            {
                Attraction attraction = AttractionDataBase.Attractions[i];
                if (attraction is Animal && (attraction as Animal).HasFeedingTime) {
                    animal = (attraction as Animal);
                        TempAnimalList.Add(animal);
                    
                }
            }


           TempAnimalList = TempAnimalList.OrderBy(x => x.NextFeeding).ToList();

            foreach (Animal a in TempAnimalList) {
                View textLine = LayoutInflater.Inflate(Resource.Layout.line, Text, false); 
                View blockLine = LayoutInflater.Inflate(Resource.Layout.line, Text, false);
                foreach (FeedingTime FT in a.FeedingTimes) {
                    //set the destination

                    textLine = LayoutInflater.Inflate(Resource.Layout.line, Text, false);
                    blockLine = LayoutInflater.Inflate(Resource.Layout.line, Text, false);
                    LinearLayout.LayoutParams horizontalLine = new LinearLayout.LayoutParams(LinearLayout.LayoutParams.MatchParent, 2);
                    textLine.LayoutParameters = horizontalLine;
                    textLine.SetBackgroundColor(Color.ParseColor("#FFFFFF"));
                    blockLine.LayoutParameters = horizontalLine;
                    blockLine.SetBackgroundColor(Color.ParseColor("#FFFFFF"));


                    View animalBlock = LayoutInflater.Inflate(Resource.Layout.AnimalFeedingBlock, Scheme, false);
                    View animalText = LayoutInflater.Inflate(Resource.Layout.AnimalFeedingText, Text, false);

                    LinearLayout.LayoutParams animalTextLL = new LinearLayout.LayoutParams(270, 225);
                    animalText.LayoutParameters = animalTextLL;
                    if (((animalText as ViewGroup).GetChildAt(0) is ImageView))
                        ((animalText as ViewGroup).GetChildAt(0) as ImageView).SetImageResource((int)a.Image);
                    Text.AddView(animalText);


                    //Find the text and linearlayout children
                    for (int i = 0; i < (animalBlock as ViewGroup).ChildCount; i++) {

                        if ((animalBlock as ViewGroup).GetChildAt(i) is LinearLayout) {
                            LinearLayout.LayoutParams animalBlockParams = new LinearLayout.LayoutParams(((animalBlock as ViewGroup).GetChildAt(i) as LinearLayout).LayoutParameters.Width = FT.ShowLength * 5, 225);
                            ((animalBlock as ViewGroup).GetChildAt(i) as LinearLayout).LayoutParameters = animalBlockParams;
                            //((animalBlock as ViewGroup).GetChildAt(i) as LinearLayout).Left = FT.TimeOfDay.Hour * 60 * 5 + FT.TimeOfDay.Second * 5;
                            animalBlockParams.LeftMargin = (int)(FT.TimeOfDay.Hour * 60 * 5 + FT.TimeOfDay.Second * 5);
                            ((animalBlock as ViewGroup).GetChildAt(i) as LinearLayout).SetBackgroundColor(Color.ParseColor("#AAAAAA"));
                            ((animalBlock as ViewGroup).GetChildAt(i) as LinearLayout).LayoutParameters.Width = FT.ShowLength * 5;
                        }
                    }
                    (animalBlock as LinearLayout).LayoutParameters.Height = 225;
                    Scheme.AddView(animalBlock);
                    Text.AddView(textLine);
                    Scheme.AddView(blockLine);
                }
            }
            }
        }
    }
