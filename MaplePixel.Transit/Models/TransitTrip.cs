using System;

namespace MaplePixel.Transit.Models
{
    public class TransitTrip
    {
        public int Id { get; set; }
        public TransitRoute Route { get; set; }

        // Simple for now.  No consideration for services/calendars etc

        public DateTime DepartingTime { get; set; }
        public string DepartingLocation { get; set; }

        public DateTime ArrivingTime { get; set; }
        public string ArrivingLocation { get; set; }
    }
}