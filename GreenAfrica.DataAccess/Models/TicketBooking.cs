using System;

namespace GreenAfrica.DataAccess.Models
{
    public class TicketBooking
    {
        public int Id { get; set; }
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
        public int FlightId { get; set; }
        public string EmergencyPhoneNumber { get; set; }
        public int CustomerId { get; set; }
    }
}