using System;
using System.Collections.Generic;
using System.Text;

namespace GreenAfrica.DataAccess.Models
{
    public class Airline
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Flight> Flights { get; set; }
    }

    public class Flight
    {
        public int Id { get; set; }
        public string Departure { get; set; }
        public string Destination { get; set; }
        public DateTime DateCreated { get; set; }
        public int AirlineId { get; set; }
        public ICollection<TicketBooking> TicketBookings { get; set; }
    }
}