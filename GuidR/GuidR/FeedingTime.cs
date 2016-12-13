using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuidR {
    public class FeedingTime : Time, IComparable {
        public FeedingTime(DateTime startDate, DateTime endDate, Time time, int showLength, int[] feedingDates) 
            : base (time.TimeOfDay.Hour, time.TimeOfDay.Minute) {
            StartDate = startDate;
            EndDate = endDate;
            ShowLength = showLength;
        }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int ShowLength { get; set; }

        public int CompareTo (object obj)
        {
            if (obj == null)
                return 1;

            if (obj is FeedingTime)
            {
                FeedingTime FT = (obj as FeedingTime);

                return this.TimeOfDay.CompareTo(FT.TimeOfDay);
            }
            else
                throw new InvalidCastException("Object is not of type FeedingTime");
        }
    }

}
