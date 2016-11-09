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

            SetContentView(Resource.Layout.News);

            AddCardToNews(5);

        }

        public void AddCardToNews(int i) {
            for (int n = 0; n < i; n++)
            {
                LinearLayout cardContainer = FindViewById<LinearLayout>(Resource.Id.cardContainer);

                CardView card = new CardView(this);
                card.Id = 987654114;
                card.SetMinimumHeight(200);
                card.SetMinimumWidth(200);
                card.SetContentPadding(2, 1, 1, 2);
                cardContainer.AddView(card);

                ImageView img = new ImageView(this);
                img.SetMinimumHeight(100);
                img.SetMinimumWidth(100);
                img.SetBackgroundColor(Android.Graphics.Color.Blue);
                card.AddView(img);

                LinearLayout space = new LinearLayout(this);
                space.SetMinimumHeight(20);
                space.SetMinimumWidth(20);
                cardContainer.AddView(space);

            }


        }

    }
}