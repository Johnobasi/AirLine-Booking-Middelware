using GreenAfrica.DataAccess.Models;
using GreenAfricaAPI.Business.Abstract;
using GreenAfricaAPI.Business.Repository;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GreenAfricaAPI.Business
{
    public class TicketBookingService : ITicketBookingService
    {
        private readonly ITicketBookingRepository _ticketBookingRepository;

        public TicketBookingService(ITicketBookingRepository ticketBookingRepository)
        {
            _ticketBookingRepository = ticketBookingRepository;
        }

        public Task AddTicketBookingAsync(TicketBooking ticketBooking)
        {
            return _ticketBookingRepository.AddAsync(ticketBooking);
        }

        public Task<TicketBooking> GetTicketBookingAsyncById(int ticketBookingId)
        {
            return GetTicketBookingAsyncById(ticketBookingId);
        }

        public Task<IEnumerable<TicketBooking>> GetTicketBookingsAsync(Func<TicketBooking, bool> predicate)
        {
            return GetTicketBookingsAsync(predicate);
        }
    }
}