using GreenAfrica.DataAccess.Models;
using System;

namespace GreenAfrica_API.Dtos
{
    public class TicketBookingDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public TicketStatus TicketStatus { get; set; }
        public DateTime Dob { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string Departure { get; set; }
        public string Destination { get; set; }
        public DateTime DepartureDate { get; set; }
        public DateTime ArrivalDate { get; set; }
        public bool IsInternational { get; set; }
        public string Passport { get; set; }
        public string EmergencyPhoneNumber { get; set; }
    }
}