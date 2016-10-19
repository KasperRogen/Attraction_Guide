using System;

// The shared properties between all attractions (toilets, resturants, Animals.)

namespace GuidR.Droid
{
    public class Attraction
    {
        // All attractions share a name, a description and a location
        public Attraction (string name, string description, Coordinates location)
        {
            this.Name = name;
            this.Description = description;
            this.Location = location;
        }

        // The name for this attraction
        public string Name
        {
            get; set;
        }

        // The description for this attraction
        public string Description
        {
            get; set;
        }

        // The location of this attraction
        public Coordinates Location
        {
            get; set;
        }
    }
}

/*public abstract Image-WhatTypeIsThis?
{
    //
    //
}*/
