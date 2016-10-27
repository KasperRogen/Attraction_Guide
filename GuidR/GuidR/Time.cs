using System;

namespace GuidR
{
    public class Time
    {
        public Time (int hour) : this(hour, 0) { }

        public Time (int hour, int minutes)
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

        public int Hour { get; set; }

        public int Minutes { get; set; }

        public bool IsPassed
        {
            get { return DateTime.Now > TimeOfDay; }
        }

        public string TimeRemaining()
        {
            if (IsPassed)
                return "This event has passed for today";
            else
            {
                // Calculates the differences in hours and minutes
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

        public override string ToString ()
        {
            string format = "";

            if (Hour < 10)
                format = "0" + Hour;
            else
                format = Hour.ToString();

            if (Minutes < 10)
                format += "" + Minutes;
            else if (Minutes >= 10)
                format += Minutes.ToString();
            else format += "00";

            return format;
        }
    }
}