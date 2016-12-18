using System;

// The shared properties between all facilities (toilets, resturants, etc.)

namespace GuidR
{
    public class Facility : Attraction
    {

        public enum facilityType
        {
            Restaurant,
            Toilet,
            SmokeArea,
            Playground
        }

        public Facility (facilityType type, string name, string description, Coordinates location)
            : this(type, name, description, location, null, null)
        {
        }

        public Facility (facilityType type, string name, string description, Coordinates location, Time open, Time close)
        {
            this.Name = name;
            this.Description = description;
            this.Location = location;
            this.Open = open;
            this.Close = close;
            this.type = type;
        }

        public facilityType type { get; set; }
        public override string Name { get; set; }

        public override string Description { get; set; }

        public override Coordinates Location { get; set; }

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
                return !Open.IsPassed && Close.IsPassed;
            }
        }

        // If closed returns time until opening. If open returns null 
        public Time OpensIn
        {
            get
            {
                // Untested:
                if (IsOpened)
                    throw new Exception("This facility is already open. Check IsOpened prior to calling");
                else
                    return Open.TimeRemaining;
            }
        }

        // If opened returns time until close. If closed returns 0
        public Time ClosesIn
        {
            get
            {
                if (IsOpened)
                    return Close.TimeRemaining;
                else
                    throw new Exception("This facility is already closed. Check IsOpened prior to calling");
            }
        }
    }
}