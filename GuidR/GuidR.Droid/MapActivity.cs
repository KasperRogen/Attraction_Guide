using System;
using Android.App;
using Android.Gms.Maps;
using Android.OS;
using Android.Widget;
using Android.Gms.Maps.Model;
using System.Collections.Generic;

namespace GuidR.Droid
{
    [Activity(Label = "GuidR.Droid", Icon = "@drawable/icon")]
    public class MapActivity : Activity, IOnMapReadyCallback
    {
        private GoogleMap mMap;

        public List<MarkerOptions> animals = new List<MarkerOptions>();

        public void OnMapReady(GoogleMap googleMap)
        {
            AttractionDataBase.InitializeAttraction();
            mMap = googleMap;
            //BitmapDescriptor img = BitmapDescriptorFactory.DefaultMarker();

            /*foreach(Animal animal in attractionda) {
                mMap.AddMarker(new MarkerOptions().SetPosition(animal.).SetTitle("HER").SetIcon(BitmapDescriptorFactory.FromResource(Resource.Drawable.Baboon)));
            }*/

            //mMap.AddMarker(new MarkerOptions().SetPosition(new LatLng(10, 10)).SetTitle("HER"));

            foreach (Attraction attraction in AttractionDataBase.Attractions) {
                Console.WriteLine(attraction.Name);
                if (attraction.Name.Contains("Toilet"))
                    break;
                mMap.AddMarker(new MarkerOptions().SetPosition(new LatLng(attraction.Location.Longitude, attraction.Location.Latitude)).SetTitle(attraction.Name).SetIcon(BitmapDescriptorFactory.FromResource(attraction.Pin)));
            }


            //mMap.AddMarker(new MarkerOptions().SetPosition(new LatLng(10, 10)).SetTitle("HER").SetIcon(BitmapDescriptorFactory.FromResource(Resource.Drawable.Baboon)));
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


