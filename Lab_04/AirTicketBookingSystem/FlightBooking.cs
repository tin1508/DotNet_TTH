using System;
using System.Collections.Generic;
using System.Text;

namespace AirTicketBookingSystem
{
    public class FlightBooking
    {
        public string CustomerID { get; set; }
        public List<Flight> FlightEnrollList;
        public FlightBooking()
        {
            CustomerID = "Not Assigned";
            FlightEnrollList = new List<Flight>();
        }
        public FlightBooking(string CustomerID)
        {
            this.CustomerID = CustomerID;
            this.FlightEnrollList = new List<Flight>();
        }
        
    }
}
