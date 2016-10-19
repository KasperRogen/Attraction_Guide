using System;

// The shared properties between all facilities (toilets, resturants, etc.)

namespace GuidR.Droid
{
    public class Facility : Attraction
    {
        public Facility (string name, string description, Coordinates location, DateTime open, DateTime close) 
            : base (name, description, location)
        {
            this.Open = open;
            this.Close = close;
        }

        // The opening hours of the facility
        public DateTime Open
        {
            get;
            set;
        }

        // The closed hours of the facility
        public DateTime Close
        {
            get;
            set;
        }
        
        // Is this facility open?
        public bool IsOpened
        {
            get
            {
                // A null open and close means the facility is always open
                if (Open == null && Close == null)
                    return true;

                // If current time is between close and open, return true
                return DateTime.Now > Open && DateTime.Now < Close;
            }
        }
            
        // If closed returns time left
        public string OpensIn
        {
            get
            {
                if (!IsOpened)
                    return "Opens in: " + (Open - DateTime.Now).ToString();
                else
                    return "IT IS OPEN, FAGGOT!";
            }
        }

        // If Opened returns time until close
        public string ClosesIn
        {
            get
            {
                if (IsOpened)
                    return "Closes in: " + (Close - DateTime.Now).ToString();
                else
                    return "IS CLOSED, FAGGOT!";
            }
        }
    }
}