using System;
using System.Collections.Generic;
using System.Text;

namespace AirTicketBookingSystem
{
    public enum FlightTypes
    {
        VietnameAirlines,
        VietjetAir,
        BambooAirways
    }
    public class Flight
    {
        public string FlightID{ get; set; }
        public DateTime TimeDepart { get; set; }
        public DateTime TimeArrival { get; set; }
        public FlightTypes FlightType { get; set;  }
        public Flight(string FlightID, DateTime TimeDepart, DateTime TimeArrival, FlightTypes FlightType)
        {
            this.FlightID = FlightID;
            this.TimeDepart = TimeDepart;
            this.TimeArrival = TimeArrival;
            this.FlightType = FlightType;
        }
        public override string ToString()
        {
            return String.Format("Flight ID: {0} | Departure: {1} | Arrival: {2} | Airline: {3}", FlightID, TimeDepart, TimeArrival, FlightType);
        }
    }
}
