using System;
// Der mangler nogle using statements

namespace GuidR // Mangler også Namespace her.
{
    class iOSDependency : PlatformDependency
    {
        public override void SetImage (object source, object resource)
        {
            /*if (source as UIImageView)
            {
                string s = "";
                try
                {
                    s = resource as string;

                    UIImageView i = new UIImageView(UIImage.FromBundle(s));
                }
                catch
                {
                    throw new NullReferenceException("No valid image with the path: " + s);
                }
            }
            else
                throw new InvalidCastException("Object cannot be casted as an UIImageView");*/
        }
    }
}
