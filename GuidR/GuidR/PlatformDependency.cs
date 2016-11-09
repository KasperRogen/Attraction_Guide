namespace GuidR
{
    // Every platform specific code is placed in this class
    public abstract class PlatformDependency
    {
        public abstract void SetImage(object source, object resource);
    }
}
