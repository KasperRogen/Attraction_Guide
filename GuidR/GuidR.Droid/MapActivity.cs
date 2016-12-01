using System;
using Android.App;
using Android.Gms.Maps;
using Android.OS;
using Android.Gms.Maps.Model;
using Android.Views;
using Android.Widget;

namespace GuidR.Droid
{
    [Activity(Label = "Aalborg Zoo", Theme = "@style/NoTitle.splash")]
    public class MapActivity : Activity, IOnMapReadyCallback, Android.Gms.Maps.GoogleMap.IInfoWindowAdapter
    {
        private GoogleMap mMap;

        public static Attraction Attraction { get; set; }

        public View GetInfoContents(Marker marker) {
            
            // FindViewById<ImageView>(Resource.Id.Map_Info_Window_Image = marker.)
            return null;
        }

        public View GetInfoWindow(Marker marker) {
            View view = LayoutInflater.Inflate(Resource.Layout.Map_Info_Window, null, false);
            view.FindViewById<TextView>(Resource.Id.Map_Info_Window_Name).Text = marker.Title;
            Attraction attraction = AttractionDataBase.Attractions.Find( x=> x.Name == marker.Title);
            view.FindViewById<ImageView>(Resource.Id.Map_Info_Window_Image).SetImageResource((int)attraction.Image);
            if (attraction is Animal) {
                TextView feedingTime = view.FindViewById<TextView>(Resource.Id.Map_Info_Window_Feeding_Time);

                if ((attraction as Animal).HasFeedingTime) {
                    if ((attraction as Animal).NextFeeding.IsPassed)
                        feedingTime.Text = "Ingen fodring i dag";
                    else
                        feedingTime.Text = "Næste fodring: " + (attraction as Animal).NextFeeding.ToString();
                }
                else
                    feedingTime.Text = "Ingen fodringstid.";
            } else if(attraction is Facility) {
                TextView feedingTime = view.FindViewById<TextView>(Resource.Id.Map_Info_Window_Feeding_Time);
                if ((attraction as Facility).Open != null)
                    feedingTime.Text = (attraction as Facility).Open.ToString();
            }
            return view;
        }

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

            

            mMap.SetInfoWindowAdapter(this);
        }


        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Map);

            ImageView banner = FindViewById<ImageView>(Resource.Id.homeBanner);
            banner.Click += delegate {
                StartActivity(typeof(MainActivity));
            };

            SetUpMap();
        }

        private void SetUpMap ()
        {
            if (mMap == null)
                FragmentManager.FindFragmentById<MapFragment>(Resource.Id.map).GetMapAsync(this);

        }
    }

    

}


