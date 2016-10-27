using System;
using System.Collections.Generic;

namespace GuidR
{
    class Event
    {
        private class AttractionEvent
        {
            public AttractionEvent (Animal animal, Time time, DayOfWeek dayOfWeek)
            {
                this.Animal = animal;
                this.Time = time;
                this.TESTDateOfWeek = dayOfWeek;
            }

            public Animal Animal { get; set; }
            public Time Time { get; set; }
            public DayOfWeek TESTDateOfWeek { get; set; }
        }

        private List<AttractionEvent> _events = new List<AttractionEvent>();

        public Event (Animal animal, Time time, DayOfWeek dayOfWeek)
        {
            // An event cannot contain null arguments
            if (animal == null || time == null)
                throw new ArgumentNullException("Arguments 'Animal' and 'Time' cannot be null");
            else
            {
                // Add the event to a list of events
                _events.Add(new AttractionEvent(animal, time, dayOfWeek));
            }
        }
    }
}
