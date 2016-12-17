using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Text;
using Android.Text.Style;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace GuidR.Droid {
    [Activity(Label = "Aalborg Zoo", Theme = "@style/NoTitle.splash")]

    public class FeedingTimeSchemeActivity : Activity {

        int feedingtimeLineHeight;
        Animal selectedAnimal;


        protected override void OnCreate(Bundle bundle) {

            base.OnCreate(bundle);

            SetContentView(Resource.Layout.FeedingTimeScheme);
            HorizontalScrollView animalScroller;
            HorizontalScrollView timelineScroller;

            Android.Util.DisplayMetrics metrics = Resources.DisplayMetrics;
            feedingtimeLineHeight = (int)(metrics.HeightPixels / 8.5);


            ImageView banner = FindViewById<ImageView>(Resource.Id.homeBanner);
            banner.Click += delegate {
                StartActivity(typeof(MainActivity));
            };
            
                setTimeline();
                animalScroller = FindViewById<HorizontalScrollView>(Resource.Id.animalScroller);
                timelineScroller = FindViewById<HorizontalScrollView>(Resource.Id.timelineScrollView);

            SetFeedingtimeBlocks();


            scrollViewSyncer(animalScroller, timelineScroller);

        }


        public void scrollViewSyncer(HorizontalScrollView scrollView, HorizontalScrollView scrollview2)
        {

            bool initialRun = true;
            int currentTime = (DateTime.Now.Hour - 1) * 5 * 60 + DateTime.Now.Minute * 5;
            int scrolledAt = 0;
            int TimerWait = 30;
            Timer _timer;




            Thread t = new Thread(() =>
            {

                _timer = new Timer(o =>
                {
                    if (scrollView.ScrollX < currentTime && initialRun == true) {
                        RunOnUiThread(() =>
                       {
                           scrollView.ScrollTo(scrolledAt+=12, 0);
                           scrollview2.ScrollTo(scrolledAt+=12, 0);
                       });
                    } else
                    {
                        initialRun = false;
                        scrollview2.ScrollTo(scrollView.ScrollX, 0);
                    }

                },
                      null,
                      0,
                      TimerWait);
            });
            t.Start();
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
        }


        void SetFeedingtimeBlocks() {
            List<Animal> TempAnimalList = new List<Animal>();



            Animal animal;
            for (int i = AttractionDataBase.Attractions.Count - 1; i > 0; i--) {
                Attraction attraction = AttractionDataBase.Attractions[i];
                if (attraction is Animal && (attraction as Animal).HasFeedingTime && (attraction as Animal).IsInSeason) {
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
                LinearLayout.LayoutParams LL = new LinearLayout.LayoutParams(24*60*5, feedingtimeLineHeight);
                horizontalAnimalLayout.Orientation = Orientation.Horizontal;
              //  horizontalAnimalLayout.SetBackgroundColor(colours[index]);

                horizontalAnimalLayout.LayoutParameters = LL;
                Scheme.AddView(horizontalAnimalLayout);
                

                LinearLayout.LayoutParams animalTextLL = new LinearLayout.LayoutParams(LinearLayout.LayoutParams.FillParent, feedingtimeLineHeight);
                animalText.LayoutParameters = animalTextLL;
                if ((animalText as ViewGroup).GetChildAt(0) is ImageView) {

                    System.IO.Stream ims = Assets.Open("img/AnimalHeaders/" + a.Name + "Header.png");
                    // load image as Drawable
                    Bitmap bitmap = BitmapFactory.DecodeStream(ims);
                    ims.Close();



                    ((animalText as ViewGroup).GetChildAt(0) as ImageView).SetImageBitmap(bitmap);
                    ((animalText as ViewGroup).GetChildAt(0) as ImageView).Click += delegate {
                        selectedAnimal = a;
                        PopupMenu menu = new PopupMenu(this, ((animalText as ViewGroup).GetChildAt(0) as ImageView));
                        menu.MenuInflater.Inflate(Resource.Layout.FeedingAlarmMenu, menu.Menu);
                        menu.Show();


                        IMenuItem item = menu.Menu.FindItem(Resource.Id.MenuReminderButton);



                        menu.MenuItemClick += delegate {
                            Console.WriteLine(selectedAnimal.Name + AttractionDataBase.animalsToWatch.Contains(selectedAnimal));
                            foreach(Animal an in AttractionDataBase.animalsToWatch)
                                Console.WriteLine(an.Name);
                            if (AttractionDataBase.animalsToWatch.Contains(selectedAnimal)) { 
                                AttractionDataBase.animalsToWatch.Remove(selectedAnimal);
                            }
                            else { 
                                AttractionDataBase.animalsToWatch.Add(selectedAnimal);
                                Console.WriteLine("ADDING");
                            }
                        };



                        if (AttractionDataBase.animalsToWatch.Contains(selectedAnimal)) { 
                            item.SetTitle("Remove reminder?");
                        }
                        else { 
                            item.SetTitle("Set reminder?");
                        }
                        SpannableString spanString = new SpannableString(item.TitleFormatted);
                        int end = spanString.Length();
                        spanString.SetSpan(new RelativeSizeSpan(0.8f), 0, end, SpanTypes.ExclusiveExclusive);
                        item.SetTitle(spanString);

                    };
                }
                if ((animalText as ViewGroup).GetChildAt(1) is LinearLayout)
                    ((animalText as ViewGroup).GetChildAt(1) as LinearLayout).LayoutParameters.Height = feedingtimeLineHeight;
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
