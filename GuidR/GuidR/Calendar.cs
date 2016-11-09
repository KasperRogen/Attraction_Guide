using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuidR
{
    public static class Calendar
    {
        public static List<Event> Events = new List<Event>();

        public static void AddEvent (Event e)
        {
            Events.Add(e);
        }
    }
}
