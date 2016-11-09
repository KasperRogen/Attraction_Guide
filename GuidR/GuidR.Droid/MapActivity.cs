using System;
using Android.App;
using Android.Gms.Maps;
using Android.OS;
using Android.Gms.Maps.Model;

namespace GuidR.Droid
{
    [Activity(Label = "Aalborg Zoo", Theme = "@style/NoTitle.splash")]
    public class MapActivity : Activity, IOnMapReadyCallback
    {
        private GoogleMap mMap;

        public static Attraction Attraction { get; set; }

        public void OnMapReady(GoogleMap googleMap)
        {
            mMap = googleMap;

            if (Attraction != null)
                mMap.MoveCamera(CameraUpdateFactory.NewLatLngZoom(new LatLng(Attraction.Location.Longitude, Attraction.Location.Latitude), 19));
            else
                mMap.MoveCamera(CameraUpdateFactory.NewLatLngZoom(new LatLng(AttractionDataBase.Penguin.Location.Longitude,
                    AttractionDataBase.Penguin.Location.Latitude), 16.5F));

            foreach (Attraction attraction in AttractionDataBase.Attractions)
            {
                try
                {
                    mMap.AddMarker(new MarkerOptions().SetPosition(new LatLng(attraction.Location.Longitude, 
                        attraction.Location.Latitude)).SetTitle(attraction.Name)
                            .SetIcon(BitmapDescriptorFactory.FromResource(attraction.Pin)));
                }
                catch
                {
                    throw new Exception("Caught an exception at: " + attraction.Name);
                }
            }
        }


        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Map);

            SetUpMap();
        }

        private void SetUpMap ()
        {
            if (mMap == null)
                FragmentManager.FindFragmentById<MapFragment>(Resource.Id.map).GetMapAsync(this);
        }
    }
}


