// The shared properties between all animals

namespace GuidR.Droid
{
    public class Animal : Attraction
    {
        // Lav CTOR'en om til CTOR chaining

        public Animal (string name, string description, Coordinates location, string latinName, Time feedingTime) 
            : base(name, description, location)
        {
            this.LatinName = latinName;
            this.FeedingTime = feedingTime;
        }

        public Animal (string name, string description, Coordinates location, string latinName)
            : base(name, description, location)
        {
            this.LatinName = latinName;
            this.FeedingTime = null;
        }

        public string LatinName
        {
            get;
            set;
        }

        public Time FeedingTime
        {
            get;
            set;
        }
    }
}

/*public Animal (string name) : this (name, "") { }
public Animal (string name, string latinName) : this (name, latinName, null) { }*/
