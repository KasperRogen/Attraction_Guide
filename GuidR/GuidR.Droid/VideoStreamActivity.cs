using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Media;

namespace GuidR.Droid {
    [Activity(Label = "VideoStreamActivity")]
    public class VideoStreamActivity : Activity {
        protected override void OnCreate(Bundle savedInstanceState) {
            base.OnCreate(savedInstanceState);


            SetContentView(Resource.Layout.VideoStream);

                var uri = Android.Net.Uri.Parse("https://monitor.y-cam.com/bc/viewZooCam.php?cam=camera8");
                var intent = new Intent(Intent.ActionView, uri);
                StartActivity(intent);

        }


    }
}