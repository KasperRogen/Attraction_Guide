using System;

namespace App_Time
{
    public class Time
    {
        public Time (int hour) : this (hour, 0) { }

        public Time (int hour, int minutes)
        {
            this.Hour = hour;
            this.Minutes = minutes;
        }

        public int Hour
        {
            get;
            set;
        }

        public int Minutes
        {
            get;
            set;
        }

        public bool IsPassed
        {
            get
            {
                DateTime now = DateTime.Now;
                DateTime eventTime = new DateTime(now.Year, now.Month, now.Day, Hour, Minutes, 0);

                TimeSpan diff = eventTime.Subtract(now);

                return now > eventTime;
            }
        }

        public string CalculateTimeDifference ()
        {
            if (IsPassed)
                return "This event has passed for today";
            else
            {
                DateTime now = DateTime.Now;
                DateTime eventTime = new DateTime(now.Year, now.Month, now.Day, Hour, Minutes, 0);

                TimeSpan time = eventTime.Subtract(now);

                // This does not handle plural / singular hours (1 timer).

                if (time.Hours == 0)
                    return time.Minutes + "minutter";
                else if (time.Hours > 0 && time.Minutes > 0)
                    return time.Hours + "timer " + time.Minutes + " og minutter ";
                else
                    return time.Hours + "timer";
            }
        }
    }
}