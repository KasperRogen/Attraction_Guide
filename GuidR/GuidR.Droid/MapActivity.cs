using System;
using Android.App;
using Android.Gms.Maps;
using Android.OS;
using Android.Widget;
using Android.Gms.Maps.Model;

namespace GuidR.Droid
{
    [Activity(Label = "GuidR.Droid", Icon = "@drawable/icon")]
    public class MapActivity : Activity, IOnMapReadyCallback
    {
        private GoogleMap mMap;

        public void OnMapReady(GoogleMap googleMap)
        {
            mMap = googleMap;
            BitmapDescriptor img = BitmapDescriptorFactory.DefaultMarker();
            mMap.AddMarker(new MarkerOptions().SetPosition(new LatLng(10, 10)).SetTitle("HER").SetIcon(BitmapDescriptorFactory.FromResource(Resource.Drawable.Baboon)));
        }


        protected override void OnCreate(Bundle bundle)
        {

            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Map);



            SetUpMap();



        }

        private void SetUpMap()
        {
            if (mMap == null)
            {
                FragmentManager.FindFragmentById<MapFragment>(Resource.Id.map).GetMapAsync(this);
            }
        }

    }
}


