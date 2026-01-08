using System;
using System.Collections.Generic;
using System.Text;

namespace AirTicketBookingSystem
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string CustomerID { get; set; }
        public User()
        {
            this.Username = "Not Assigned";
            this.Password = "";
            this.CustomerID = "Not Assigned";   
        }
        public User(string Username, string Password, string CustomerID)
        {
            this.Username = Username;
            this.Password = Password;
            this.CustomerID = CustomerID;
        }
    }
}
