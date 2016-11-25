using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuidR {
    public class FeedingTime : Time, IComparable {
        public FeedingTime(DateTime startDate, DateTime endDate, Time time, int[] feedingDates) 
            : base (time.TimeOfDay.Hour, time.TimeOfDay.Minute) {
            _startDate = startDate;
            _endDate = endDate;
        }

        public DateTime _startDate { get; set; }
        public DateTime _endDate { get; set; }

        public int CompareTo(object obj) {
            if (obj is FeedingTime)
            {
                if ((obj as FeedingTime).TimeOfDay.Hour < this.TimeOfDay.Hour) // Hour is earlier
                    return -1;

                else if ((obj as FeedingTime).TimeOfDay.Hour == this.TimeOfDay.Hour) //Hour is the same
                    if ((obj as FeedingTime).TimeOfDay.Minute < this.TimeOfDay.Minute) //Minute is earlier, time is earlier
                        return -1;
                    else
                        return 0; //minute is the same, time is the same

                else
                    return 1; //Time is later
            }
            else return 2;
        }
    }

}
