using System;

namespace GuidR
{
    public class Time
    {
        public Time (int hour) : this(hour, 0) { }

        public Time (int hour, int minutes)
        {
            this.TimeOfDay = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 
                DateTime.Now.Day, hour, minutes, 0);
        }

        public DateTime TimeOfDay { get; set; }

        public bool IsPassed
        {
            get { return TimeOfDay.Subtract(DateTime.Now).TotalSeconds < 0; }
        }

        public Time TimeRemaining
        {
            get
            {
                if (IsPassed)
                    throw new Exception("This event has passed. Check IsPassed prior to calling");
                else
                    return new Time(TimeOfDay.Subtract(DateTime.Now).Hours, TimeOfDay.Subtract(DateTime.Now).Minutes);
            }
        }

        // Formates the time to "HH:MM"
        public override string ToString ()
        {
            string formattedHour, formattedMinute;

            if (TimeOfDay.Hour < 10)
                formattedHour = "0" + TimeOfDay.Hour;
            else
                formattedHour = TimeOfDay.Hour.ToString();

            if (TimeOfDay.Minute < 10)
                formattedMinute = "0" + TimeOfDay.Minute;
            else if (TimeOfDay.Minute >= 10)
                formattedMinute = TimeOfDay.Minute.ToString();
            else
                formattedMinute = "00";

            return formattedHour + ":" + formattedMinute;
        }
    }
}