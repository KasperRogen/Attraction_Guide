using Android.App;
using Android.Content;
using Android.OS;
using Android.Views;
using Android.Widget;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;

namespace GuidR.Droid
{
    [Activity(Label = "Event Activity")]
    public class EventActivity : ListActivity
    {
        protected override void OnCreate (Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.EventMenu);
                        
            /*this.ListAdapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1,
                Calendar.Events.Select(e => (string)e.Title).ToList());*/
        }

        protected override void OnListItemClick (ListView l, View v, int position, long id)
        {
            /*Intent intent = new Intent(this, typeof(EventListActivity));
            intent.PutExtra("Event", TranslateObject.Serialize(Calendar.Events[position]));

            StartActivity(intent);*/
        }
    }
}
