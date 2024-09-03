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

        public async Task AddTicketBookingAsync(TicketBooking ticketBooking)
        {
            await _ticketBookingRepository.AddAsync(ticketBooking);
            await _ticketBookingRepository.SaveChangesAsync();
        }

        public async Task DeleteTicketBookingAsync(TicketBooking request)
        {
           await _ticketBookingRepository.DeleteTicketBookingAsync(request);
        }

        public Task<TicketBooking> GetTicketBookingAsyncById(int ticketBookingId)
        {
            return GetTicketBookingAsyncById(ticketBookingId);
        }

        public Task<IEnumerable<TicketBooking>> GetTicketBookingsAsync(Func<TicketBooking, bool> predicate)
        {
            return GetTicketBookingsAsync(predicate);
        }

        public async Task UpdateTicketBookingAsync(TicketBooking ticketBooking)
        {
            await _ticketBookingRepository.UpdateAsync(ticketBooking);
            await _ticketBookingRepository.SaveChangesAsync();
        }
    }
}