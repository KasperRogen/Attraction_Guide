using System;

namespace GuidR
{
    public class Event
    {
        public Event (string title, EventTime time, string description)
        {
            // An event cannot contain null arguments
            if (title == null || time == null)
                throw new ArgumentNullException("Arguments 'Title' or 'Time' cannot be null");

            this.Title = title;
            this.Time = time;
            this.Description = description;
        }

        public string Title { get; set; }
        public EventTime Time { get; set; }
        public string Description { get; set; }
    }
}
