// The shared properties between all attractions (toilets, resturants, Animals.)

namespace GuidR
{
    public abstract class Attraction
    {
        // The name for this attraction
        public abstract string Name { get; set; }

        // The description for this attraction
        public abstract string Description { get; set; }

        // The location of this attraction
        public abstract Coordinates Location { get; set; }

        // The image for this attraction
        public abstract int Image { get; set; }
    }
}