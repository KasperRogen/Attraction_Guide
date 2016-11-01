using System.Collections.Generic;

// The shared properties between all animals

namespace GuidR
{
    public class Animal : Attraction
    {
        // Lav CTOR'en om til CTOR chaining

        public Animal (string name, string description, Coordinates location, string latinName, int image, int pin, params Time[] feedingTimes)
        {
            this.Name = name;
            this.Description = description;
            this.Location = location;
            this.LatinName = latinName;
            this.Image = image;
            this.Pin = pin;

            if (feedingTimes != null)
            {
                foreach (Time t in feedingTimes)
                    this.FeedingTimes.Add(t);
            }

            AttractionDataBase.Attractions.Add(this);
        }

        public Animal (string name, string description, Coordinates location, string latinName, int image, int pin) 
            : this (name, description, location, latinName, image, pin, null) { }

        public override string Name { get; set; }

        public override string Description { get; set; }

        public override Coordinates Location { get; set; }

        public override int Image { get; set; }

        public override int Pin { get; set; }

        public string LatinName { get; set; }

        public bool HasFeedingTime { get { return FeedingTimes.Count > 0; } }

        // Returns the next feeding time if such exist
        public Time NextFeeding
        {
            get
            {
                if (!HasFeedingTime)
                    throw new System.NullReferenceException(Name + "Does not have a feeding time. Check HasFeedingTime prior to calling");
                
                Time nearestFeedingTime = FeedingTimes[FeedingTimes.Count - 1];
                                                                                                    
                foreach (Time t in FeedingTimes)
                {
                    if (!t.IsPassed && t.TimeOfDay < nearestFeedingTime.TimeOfDay)
                        nearestFeedingTime = t;
                }

                return nearestFeedingTime;
            }
        }

        private List<Time> _feedingTimes = new List<Time>();

        public List<Time> FeedingTimes
        {
            get { return _feedingTimes; }
            set { _feedingTimes = value; }
        }
    }
}