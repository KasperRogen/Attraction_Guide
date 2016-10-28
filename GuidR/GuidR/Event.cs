using System;

namespace GuidR
{
    public class Event
    {
        public Event (Attraction attraction, Time time, DayOfWeek dayOfWeek, string description)
        {
            this.Attraction = attraction;
            this.Time = time;
            this.TESTDateOfWeek = dayOfWeek;
            this.Description = description;
        }

        public Attraction Attraction { get; set; }
        public Time Time { get; set; }
        public DayOfWeek TESTDateOfWeek { get; set; }
        public string Description { get; set; }
    }
}
