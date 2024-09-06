using System;
namespace GreenAfrica.DataAccess.Entity
{
    public class PassengerEntity:BaseEntity
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Nationality { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string PassportNumber { get; set; }
        public string BookingReferenceNumber { get; set; }
        public string IsActive { get; set; }

        //
        //public Tickets passengersTicket { get; set; }

    }
}
