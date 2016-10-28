using System;
using System.Collections.Generic;

namespace GuidR
{
    class Calender
    {
        private List<Event> _events = new List<Event>();

        public void AddEvent (Attraction attraction, Time time, DayOfWeek dayOfWeek, string description)
        {
            // An event cannot contain null arguments
            if (attraction == null || time == null)
                throw new ArgumentNullException("Arguments 'Attraction' and 'Time' cannot be null");
            else
            {
                // Add the event to an event list
                _events.Add(new Event(attraction, time, dayOfWeek, description));
            }

            // Cast: (attraction as Animal) or (attraction as Facility)
        }
    }
}
