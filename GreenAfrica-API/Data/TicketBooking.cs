namespace GreenAfrica_API.Data
{
    public class TicketBooking
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public TicketStatus TicketStatus { get; set; }
    }
}