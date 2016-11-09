using System;
using Android.Widget;

namespace GuidR.Droid
{
    class AndroidDependency : PlatformDependency
    {
        public override void SetImage (object source, object resource)
        {
            if (source is ImageView)
            {
                ImageView i = source as ImageView;
                int ID = 0;

                try
                {
                    ID = Convert.ToInt32(resource);
                    i.SetImageResource(ID);
                }
                catch
                {
                    throw new NullReferenceException("No valid image with the ID: " + ID);
                }
            }
            else
                throw new InvalidCastException("Object cannot be casted as an ImageView");
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
