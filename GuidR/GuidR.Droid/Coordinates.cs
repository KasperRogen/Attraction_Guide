namespace App_Time
{
    public class Coordinates
    {
        public Coordinates (double longitude, double latitude)
        {
            this.Longitude = longitude;
            this.Latitude = latitude;
        }

        public double Longitude
        {
            get;
            set;
        }

        public double Latitude
        {
            get;
            set;
        }

        public override string ToString ()
        {
            return "Longitude:" + Longitude + " Latitude:" + Latitude;
        }
    }
}