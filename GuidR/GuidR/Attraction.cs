// The shared properties between all attractions (toilets, resturants, Animals.)

namespace GuidR
{
    public abstract class Attraction
    {

            public enum attractionType
        {
            Animal,
            Restaurant,
            Toilet,
            SmokeArea,
            Playground
        }

        public abstract attractionType attractiontype { get; set; }
        public abstract string ImageName { get; set; }
        // The name for this attraction
        public abstract string Name { get; set; }

        // The description for this attraction
        public abstract string Description { get; set; }

        // The location of this attraction
        public abstract Coordinates Location { get; set; }
    }
}