using System;
using System.Collections.Generic;
using System.Text;

namespace AirTicketBookingSystem
{
    public enum Genders
    {
        Male,
        Female
    }
    public class Customers
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public Genders Gender { get; set; }
        public string Birthday { get; set; }
        public string PassportNo { get; set; }
        public string Nationality { get; set; }
        public Image Avatar { get; set; }

        public Customers()
        {
            //tao ma ID cho customer la duy nhat
            ID = Guid.NewGuid().ToString("N").Substring(0, 8).ToUpper();
            Name = string.Empty;
            PassportNo = string.Empty;
            Nationality = string.Empty;
            Avatar = null;
        }
        public Customers(string name, Genders gender, string birthday, string passportNo, string nationality, Image avatar)
        {
            //tao ma ID cho customer la duy nhat
            ID = Guid.NewGuid().ToString("N").Substring(0, 8).ToUpper();
            Name = name;
            Gender = gender;
            Birthday = birthday;
            PassportNo = passportNo;
            Nationality = nationality;
            Avatar = avatar;
        }

        public override string ToString()
        {
            return $"ID: {ID}, Name: {Name}, Birthday: {Birthday}, Sex: {Gender}, Passport Number: {PassportNo}, Nationality: { Nationality} ";
        }
    } 
}
