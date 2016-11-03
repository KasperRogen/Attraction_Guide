using System;
using Android.App;
using Android.Gms.Maps;
using Android.OS;
using Android.Widget;
using Android.Gms.Maps.Model;
using System.Collections.Generic;
using Android.Content;

namespace GuidR.Droid
{
    [Activity(Label = "Aalborg Zoo", Theme = "@style/NoTitle.splash")]
    public class MapActivity : Activity, IOnMapReadyCallback
    {
        private GoogleMap mMap;

        public static bool goToPlace = false;
        public static Coordinates PlaceToGo;   

        public void OnMapReady(GoogleMap googleMap)
        {
            AttractionDataBase.InitializeAttraction();
            mMap = googleMap;

            foreach (Attraction attraction in AttractionDataBase.Attractions) {
                Console.WriteLine(attraction.Name);

                if (goToPlace) 
                mMap.MoveCamera(CameraUpdateFactory.NewLatLngZoom( new LatLng(PlaceToGo.Longitude, PlaceToGo.Latitude), 19));

                else
                    mMap.MoveCamera(CameraUpdateFactory.NewLatLngZoom(new LatLng(AttractionDataBase.Penguin.Location.Longitude, AttractionDataBase.Penguin.Location.Latitude), 17));


                mMap.AddMarker(new MarkerOptions().SetPosition(new LatLng(attraction.Location.Longitude, attraction.Location.Latitude)).SetTitle(attraction.Name).SetIcon(BitmapDescriptorFactory.FromResource(attraction.Pin)));
            }

            goToPlace = false;
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


