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
            VideoView mVideoView = FindViewById<VideoView>(Resource.Id.SampleVideoView);

            mVideoView.SetVideoPath("https://monitor.y-cam.com/bc/viewZooCam.php?cam=camera8");
            mVideoView.SetMediaController(new MediaController(this));

        }


    }
}