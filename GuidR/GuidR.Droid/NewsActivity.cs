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

            ImageView banner = FindViewById<ImageView>(Resource.Id.homeBanner);
            banner.Click += delegate {
                StartActivity(typeof(MainActivity));
            };

            AddCardToNews();

        }


        void AddCardToNews()
        {
            GetDataFromDatabase();

            for (int i = 0; i < 3; i++)
            {
                News news = NewsDatabase.NewsList[i];

                LinearLayout cardContainer = FindViewById<LinearLayout>(Resource.Id.cardContainer);
                View view = LayoutInflater.Inflate(Resource.Layout.NewsItem, cardContainer, false);
                view.FindViewById<TextView>(Resource.Id.cardHeader).Text = news.Header;
                view.FindViewById<TextView>(Resource.Id.cardText).Text = news.NewsInfo;
                view.FindViewById<ImageView>(Resource.Id.cardImage).SetImageResource((int)news.Image);

                cardContainer.AddView(view);
            }
        }

        void GetDataFromDatabase()
        {
            string text1 = "Den bedste juleaften begynder i Zoo med julemusik og gudstjeneste på Zoofariscenen. Mød Julemanden, der har rigeligt med pebernødder og glad julestemning til alle, og hils på rensdyrene, inden de skal afsted på gaveudbringning. Haven er åben fra kl. 10-13.";
            string text2 = "Girafferne er gået til deres natlogi, elefanterne gumler dagens sidste måltid, og mens du lukker lynlåsen i dit telt, brøler løven godnat. Du kan opleve den helt specielle nattestemning i Zoo, når vi den 3.-4. juni inviterer årskortholdere til at overnatte på den afrikanske savanne.";
            string text3 = "Gigantiske mammutter, en imponerende kæmpehjort, uldhårede næsehorn, skovelefanter og drabelige sabelkatte gør istiden levende i Aalborg Zoo denne sommer. Stå på den store plæne og oplev, hvordan fortidens og nutidens dyr møder hinanden i en storslået udstilling, der giver dig et helt unikt indblik i istidens særegne dyre- og planteliv. Udstillingen kan ses fra 22. april til 23. oktober 2016.";


            NewsDatabase.AddNews("Juleaften med fri entré!", text1, Resource.Drawable.AalborgZoo_indgang);
            NewsDatabase.AddNews("Den vildeste overnatning!", text2, Resource.Drawable.TigerHeader);
            NewsDatabase.AddNews("Tilbage til istiden", text3, Resource.Drawable.Mammoth);

        }

    }
}