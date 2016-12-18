using System;
using System.Collections.Generic;
using System.Linq;

// The shared properties between all animals

namespace GuidR
{
    public class Animal : Attraction
    {
        // Lav CTOR'en om til CTOR chaining

        public Animal (string name, string description, Coordinates location, string latinName, params FeedingTime[] feedingTimes)
        {
            this.Name = name;
            this.Description = description;
            this.Location = location;
            this.LatinName = latinName;

            if (feedingTimes != null)
            {
                foreach (FeedingTime t in feedingTimes)
                    _feedingTimes.Add(t);
            }

           // AttractionDataBase.Attractions.Add(this);
        }

        public Animal (string name, string description, Coordinates location, string latinName) 
            : this (name, description, location, latinName, null) { }

        public override string Name { get; set; }

        public override string Description { get; set; }

        public override Coordinates Location { get; set; }

        public string LatinName { get; set; }

        public bool HasFeedingTime { get { return FeedingTimes.Count > 0; } }

        public bool IsInSeason { get { return (DateTime.Today <= NextFeeding.EndDate && DateTime.Today >= NextFeeding.StartDate); } }

        // Returns the next feeding time if such exist
        public FeedingTime NextFeeding
        {
            get
            {
                if (!HasFeedingTime)
                    throw new System.NullReferenceException(Name + "Does not have a feeding time. Check HasFeedingTime prior to calling");
                
                FeedingTime nearestFeedingTime = FeedingTimes[FeedingTimes.Count - 1];
                                                                                                    
                foreach (FeedingTime t in FeedingTimes)
                {
                    if (!t.IsPassed && t.TimeOfDay < nearestFeedingTime.TimeOfDay)
                        nearestFeedingTime = t;
                }

                return nearestFeedingTime;
            }
        }

        private List<FeedingTime> _feedingTimes = new List<FeedingTime>();

        public List<FeedingTime> FeedingTimes
        {
            get { return _feedingTimes; }
            set { _feedingTimes = value; }
        }
    }
}