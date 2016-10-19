using System;

namespace GuidR.Droid
{
    public class Time
    {
        public Time(int hour) : this(hour, 0) { }

        public Time(int hour, int minutes)
        {
            this.Hour = hour;
            this.Minutes = minutes;
        }

        public DateTime TimeOfDay
        {
            get
            {
                DateTime now = DateTime.Now;
                return new DateTime(now.Year, now.Month, now.Day, Hour, Minutes, 0);
            }
        }

        public int Hour
        {
            get; set;
        }

        public int Minutes
        {
            get; set;
        }

        public bool IsPassed
        {
            get
            {
                return DateTime.Now > TimeOfDay;
            }
        }

        public string TimeRemaining()
        {
            if (IsPassed)
                return "This event has passed for today";
            else
            {
                TimeSpan time = TimeOfDay.Subtract(DateTime.Now);

                // This does not handle plural / singular hours (1 timer).

                if (time.Hours == 0)
                    return time.Minutes + "minutter";
                else if (time.Hours > 0 && time.Minutes > 0)
                    return time.Hours + "timer " + time.Minutes + " og minutter ";
                else
                    return time.Hours + "timer";
            }
        }

        public override string ToString()
        {
            return Hour + " : " + Minutes;
        }
    }
}