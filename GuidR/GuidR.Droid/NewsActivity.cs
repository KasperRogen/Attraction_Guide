using System;
using Android.App;
using Android.Gms.Maps;
using Android.OS;
using Android.Widget;
using Android.Gms.Maps.Model;

namespace GuidR.Droid
{
    [Activity(Label = "GuidR.Droid", Icon = "@drawable/icon")]
    public class NewsActivity : Activity
    {


        protected override void OnCreate(Bundle bundle)
        {

            base.OnCreate(bundle);

            SetContentView(Resource.Layout.News);

        }


    }
}