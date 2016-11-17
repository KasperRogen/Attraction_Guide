using System;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Support.V4;
using Android.Support.V7;
using Android.Support.V7.CardView;
using Android.Support.V7.Widget;

namespace GuidR.Droid
{
    [Activity(Label = "Aalborg Zoo", Theme = "@style/NoTitle.splash")]
    public class NewsActivity : Activity
    {


        protected override void OnCreate(Bundle bundle)
        {

            base.OnCreate(bundle);

            SetContentView(Resource.Layout.RelativeNews);

      //      AddCardToNews(5);

        }


        public void AddCardToNews(int i)
        {
            for (int n = 0; n < i; n++)
            {
                LinearLayout cardContainer = FindViewById<LinearLayout>(Resource.Id.cardContainer);


                //    cardContainer.LayoutParameters = lparams;


                CardView card = new CardView(this);
                card.Id = (int)System.DateTime.Now.Ticks * (n + 1);
                card.SetMinimumHeight(400);
                card.SetMinimumWidth(200);
                card.SetContentPadding(5, 5, 5, 5);
                cardContainer.AddView(card);


                ImageView img = new ImageView(this);
                img.SetMinimumHeight(300);
                img.SetMinimumWidth(200);
                img.SetBackgroundColor(Android.Graphics.Color.Blue);
                var lparams = new RelativeLayout.LayoutParams(ViewGroup.LayoutParams.WrapContent, ViewGroup.LayoutParams.WrapContent);
                img.LayoutParameters = lparams;
                card.AddView(img);


                TextView txt = new TextView(this);
                txt.SetMinimumHeight(400);
                txt.SetMinimumWidth(200);
                txt.SetTextColor(Android.Graphics.Color.Black);
                txt.LayoutParameters = lparams;
                txt.Text = "AIDSNIGGER";
                card.AddView(txt);


                RelativeLayout space = new RelativeLayout(this);
                space.SetMinimumHeight(20);
                space.SetMinimumWidth(20);
                cardContainer.AddView(space); 

            }
        }

        /*  var linearLayout = new LinearLayout(this);
            var lp = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.FillParent,
                ViewGroup.LayoutParams.WrapContent)
            { Gravity = GravityFlags.Right };
            linearLayout.LayoutParameters = lp;
            linearLayout.Orientation = Orientation.Vertical;

            var textView = new TextView(this)
            {
                LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.WrapContent,
                    ViewGroup.LayoutParams.WrapContent)
            };

            linearLayout.AddView(textView);
            */
    //    }

    }
}