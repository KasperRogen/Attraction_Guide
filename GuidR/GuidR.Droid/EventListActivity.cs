using System;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace GuidR.Droid
{
    [Activity(Label = "Event List Activity")]
    public class EventListActivity : ListActivity
    {
        protected override void OnCreate (Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.EventPage);

            /*Event e = TranslateObject.Deserialize(Intent.GetByteArrayExtra("Event")) as Event;

            if (e == null)
                throw new NullReferenceException("Sad face :(");

            Toast.MakeText(this, e.Title, ToastLength.Long).Show();*/




           /* try
            { 
                Event e = Calendar.Events[Intent.GetBundleExtra("Event").GetInt("Index")];

                FindViewById<Button>(Resource.Id.EventTitle).Text = e.Title;
                FindViewById<Button>(Resource.Id.EventDescription).Text = e.Description;
                FindViewById<Button>(Resource.Id.EventTime).Text = e.Time.ToString();  
            }
            catch (Exception)
            {
                throw new NullReferenceException("Make sure the Bundle contains the correct keys");
            }*/
        }
    }
}