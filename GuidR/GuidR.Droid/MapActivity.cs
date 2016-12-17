using System;
using Android.App;
using Android.Gms.Maps;
using Android.OS;
using Android.Gms.Maps.Model;
using Android.Views;
using Android.Widget;
using Android.Locations;
using System.Collections.Generic;
using System.Linq;
using Android.Runtime;
using Android.Graphics;
using Android.Content.PM;

namespace GuidR.Droid
{
    [Activity(Label = "Aalborg Zoo", Theme = "@style/NoTitle.splash", ScreenOrientation = ScreenOrientation.Portrait)]
    public class MapActivity : Activity, IOnMapReadyCallback, Android.Gms.Maps.GoogleMap.IInfoWindowAdapter, ILocationListener {
        private GoogleMap mMap;
        LocationManager locationManager;
        Location myLocation;
        string locationProvider;

        Circle positionMarker;

        public static Attraction Attraction { get; set; }

        public View GetInfoContents(Marker marker) {
            
            // FindViewById<ImageView>(Resource.Id.Map_Info_Window_Image = marker.)
            return null;
        }

        public View GetInfoWindow(Marker marker) {
            View view = LayoutInflater.Inflate(Resource.Layout.Map_Info_Window, null, false);
            view.FindViewById<TextView>(Resource.Id.Map_Info_Window_Name).Text = marker.Title;
            Attraction attraction = AttractionDataBase.Attractions.Find( x=> x.Name == marker.Title);

            System.IO.Stream ims = Assets.Open("img/AnimalHeaders/" + attraction.Name + "Header.png");
            // load image as Drawable
            Bitmap bitmap = BitmapFactory.DecodeStream(ims);
            ims.Close();


            view.FindViewById<ImageView>(Resource.Id.Map_Info_Window_Image).SetImageBitmap(bitmap);
            if (attraction is Animal) {
                TextView feedingTime = view.FindViewById<TextView>(Resource.Id.Map_Info_Window_Feeding_Time);

                if ((attraction as Animal).HasFeedingTime && (attraction as Animal).IsInSeason) {
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
            Console.WriteLine("MAP READY");
            if (Attraction != null)
                mMap.MoveCamera(CameraUpdateFactory.NewLatLngZoom(new LatLng(Attraction.Location.Longitude, Attraction.Location.Latitude), 19));
            else
                mMap.MoveCamera(CameraUpdateFactory.NewLatLngZoom(new LatLng(57.036512,
                    9.897881), 16.5F));

            SetMarkers(16);

            mMap.SetInfoWindowAdapter(this);

            mMap.CameraChange += delegate (object sender, GoogleMap.CameraChangeEventArgs e)
            {
                SetMarkers(e.Position.Zoom);
            };

        }



        void SetMarkers(float zoomLevel)
        {
            mMap.Clear();
            foreach (Attraction attraction in AttractionDataBase.Attractions)
            {
                System.IO.Stream ims = Assets.Open("img/AnimalButtons/" + attraction.Name + "Button.png");
                // load image as Drawable
                Bitmap bitmap = BitmapFactory.DecodeStream(ims);
                ims.Close();

                int scaling = ((int)zoomLevel - 12);
                scaling = (int)Math.Pow(scaling, 3);

                Console.WriteLine(zoomLevel + " : " + scaling);

                Bitmap scaledBitmap = Bitmap.CreateScaledBitmap(bitmap, scaling, scaling, true);


                //Console.WriteLine("Making marker for: " + attraction.Name);
                mMap.AddMarker(new MarkerOptions()
                    .SetPosition(new LatLng(attraction.Location.Longitude, attraction.Location.Latitude))
                    .SetTitle(attraction.Name)
                    .SetIcon(BitmapDescriptorFactory.FromBitmap(scaledBitmap)));

            }
        }


        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Map);

            ImageView banner = FindViewById<ImageView>(Resource.Id.homeBanner);
            banner.Click += delegate {
                StartActivity(typeof(MainActivity));
            };

            InitializeLocationManager();
            locationManager.RequestLocationUpdates(locationProvider, 2000, 0, this);
            SetUpMap();
        }

        void InitializeLocationManager() {
            locationManager = Application.Context.GetSystemService("location") as LocationManager;
        Criteria criteriaForLocationService = new Criteria {
                Accuracy = Accuracy.Coarse,
                PowerRequirement = Power.NoRequirement
            };
            locationProvider = locationManager.GetBestProvider(criteriaForLocationService, true);
            //this.RunOnUiThread(() => locationManager.RequestLocationUpdates(locationProvider, 1000, 1, this));
        }

        private void SetUpMap ()
        {
            if (mMap == null)
                FragmentManager.FindFragmentById<MapFragment>(Resource.Id.map).GetMapAsync(this);

        }

        protected override void OnResume() {
            base.OnResume();
            locationManager.RequestLocationUpdates(locationProvider, 2000, 0, this);
        }

        protected override void OnPause() {
            base.OnPause();
            locationManager.RemoveUpdates(this);
        }

        public void OnProviderDisabled(string provider) {
            throw new NotImplementedException();
        }

        public void OnProviderEnabled(string provider) {
            throw new NotImplementedException();
        }

        public void OnStatusChanged(string provider, [GeneratedEnum] Availability status, Bundle extras) {
            throw new NotImplementedException();
        }


        public void OnLocationChanged(Location location) {
            Location currentLocation = location;
            myLocation = location;
            if (currentLocation == null) {
                Console.WriteLine("Unable to determine your location. Try again in a short while.");
            }
            else {
                Console.WriteLine("Ø****************************************************************");
                Console.WriteLine("Ø****************************************************************");
                Console.WriteLine("Ø****************************************************************");
                Console.WriteLine("Ø****************************************************************");
                Console.WriteLine("Ø****************************************************************");
                Console.WriteLine("Ø****************************************************************");
                Console.WriteLine("Ø****************************************************************");
                Console.WriteLine("Ø****************************************************************");
                Console.WriteLine(string.Format("{0:f6},{1:f6}", currentLocation.Latitude, currentLocation.Longitude));
                myLocation = location;
                Console.WriteLine("Ø****************************************************************: " + myLocation);

                if (positionMarker != null)
                    positionMarker.Remove();
                var circleOptions = new CircleOptions();
                circleOptions.InvokeCenter(new LatLng(location.Latitude, location.Longitude));
                circleOptions.InvokeRadius(20);
                circleOptions.InvokeFillColor(0X66FF0000);
                circleOptions.InvokeStrokeColor(0X66FF0000);
                circleOptions.InvokeStrokeWidth(0);
               positionMarker = mMap.AddCircle(circleOptions);
                //.SetTitle("")
                //.SetIcon(BitmapDescriptorFactory.FromResource(Resource.Drawable.your_location)));

            }
        }

    }

    

}


