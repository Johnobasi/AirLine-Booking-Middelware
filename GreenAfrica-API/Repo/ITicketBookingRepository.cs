using GreenAfrica_API.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GreenAfrica.DataAccess.Models;
using GreenAfrica.DataAccess;

namespace GreenAfrica_API.Repo
{
    public interface ITicketBookingRepository
    {
        Task AddAsync(TicketBooking ticketBooking);

        Task<TicketBooking> GetTicketBookingAsyncById(int ticketBookingId);

        Task<IEnumerable<TicketBooking>> GetTicketBookingsAsync(Func<TicketBooking, bool> predicate);

        Task<bool> SaveChangesAsync();
    }

    public class TicketBookingRepository : ITicketBookingRepository
    {
        private readonly GreenAPIDbContext _context;

        public TicketBookingRepository(GreenAPIDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(TicketBooking ticketBooking)
        {
            await _context.AddAsync(ticketBooking);
        }

        public Task<TicketBooking> GetTicketBookingAsyncById(int ticketBookingId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<TicketBooking>> GetTicketBookingsAsync(Func<TicketBooking, bool> predicate)
        {
            return _context.TicketBookings.Where(predicate).ToList();
        }

        public async Task<bool> SaveChangesAsync()
        {
            return _context.SaveChanges() > 0;
        }
    }
}