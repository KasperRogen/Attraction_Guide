using System.Collections.Generic;

// The shared properties between all animals

namespace GuidR.Droid
{
    public class Animal : Attraction
    {
        // Lav CTOR'en om til CTOR chaining

        public Animal (string name, string description, Coordinates location, string latinName, int image, params Time[] feedingTimes)
        {
            this.Name = name;
            this.Description = description;
            this.Location = location;
            this.LatinName = latinName;
            this.Image = image;

            foreach (Time t in feedingTimes)
                this.FeedingTimes.Add(t);
        }

        public Animal (string name, string description, Coordinates location, string latinName, int image)
        {
            this.Name = name;
            this.Description = description;
            this.Location = location;
            this.LatinName = latinName;
            this.Image = image;
        }

        public override string Name { get; set; }

        public override string Description { get; set; }

        public override Coordinates Location { get; set; }

        public override int Image { get; set; }

        public string LatinName { get; set; }

        public bool HasFeedingTime { get { return FeedingTimes.Count > 0; } }

        // Returns the next feeding time if such exist
        // Check 'HasFeedingTime' before
        public Time NextFeeding
        {
            get
            {
                Time nearestFeedingTime = FeedingTimes[0];

                foreach (Time t in FeedingTimes)
                {
                    if (/*t.TimeOfDay > DateTime.Now && */t.TimeOfDay < nearestFeedingTime.TimeOfDay && !t.IsPassed)
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