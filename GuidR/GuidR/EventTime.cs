using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuidR
{
    public class EventTime : Time
    {
        // Each event time has a year, day and time associated with it
        public EventTime(int year, int dayOfYear, Time time)
            : base(time.TimeOfDay.Hour, time.TimeOfDay.Minute)
        {
            this.Year = year;
            this.DayOfYear = dayOfYear;
        }

        public int Year { get; set; }
        public int DayOfYear { get; set; }

        public override string ToString ()
        {
            return Year + " " + DayOfYear + base.ToString();
        }
    }
}
