using System;

// The shared properties between all facilities (toilets, resturants, etc.)

namespace GuidR.Droid
{
    public class Facility : Attraction
    {
        public Facility (string name, string description, Coordinates location)
            : this(name, description, location, null, null) { }

        public Facility (string name, string description, Coordinates location, Time open, Time close)
        {
            this.Name = name;
            this.Description = description;
            this.Location = location;
            this.Open = open;
            this.Close = close;
        }

        public override string Name { get; set; }

        public override string Description { get; set; }

        public override Coordinates Location { get; set; }

        public override int Image { get; set; }

        // The opening hours of the facility
        public Time Open { get; set; }

        // The closing hours of the facility
        public Time Close { get; set; }

        // Is this facility open?
        public bool IsOpened
        {
            get
            {
                // A null open and close means the facility is always open
                if (Open == null && Close == null)
                    return true;

                // If current time is between close and open, return true
                return DateTime.Now > Open.TimeOfDay && DateTime.Now < Close.TimeOfDay;
            }
        }

        // If closed returns time left
        public string OpensIn
        {
            get
            {
                if (!IsOpened)
                    return "Opens in: " + (Open.TimeOfDay - DateTime.Now).ToString();
                else
                    return "IT IS OPEN, FAGGOT!";
            }
        }

        // If opened returns time until close
        public string ClosesIn
        {
            get
            {
                if (IsOpened)
                    return "Closes in: " + (Close.TimeOfDay - DateTime.Now).ToString();
                else
                    return "IS CLOSED, FAGGOT!";
            }
        }
    }
}