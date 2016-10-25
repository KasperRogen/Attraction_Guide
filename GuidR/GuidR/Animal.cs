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

        public Animal (string name, string description, Coordinates location, string latinName, int image, Time feedingTime)
        {
            this.Name = name;
            this.Description = description;
            this.Location = location;
            this.LatinName = latinName;
            this.Image = image;
            this.FeedingTimes.Add(feedingTime);
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

        public Time NextFeeding
        {
            get
            {
                if (FeedingTimes.Count == 1)
                    return FeedingTimes[0];

                // If the animal is feed more than once a day, get the nearest feeding time
                else
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
        }

        private List<Time> _feedingTimes = new List<Time>();

        public List<Time> FeedingTimes
        {
            get
            {
                return _feedingTimes;
            }
            set
            {
                _feedingTimes = value;
            }
        }
    }
}