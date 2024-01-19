using System;
using System.Linq;
using System.Threading.Tasks;
using GreenAfrica.DataAccess.Models;
using GreenAfrica.DataAccess;

namespace GreenAfricaAPI.Business.Repository
{
    public interface ITicketBookingRepository
    {
        Task AddAsync(TicketBooking ticketBooking);

        Task<TicketBooking> GetTicketBookingAsyncById(int ticketBookingId);

        Task<IQueryable<TicketBooking>> GetTicketBookingsAsync(Func<TicketBooking, bool> predicate);

        Task UpdateAsync(TicketBooking ticketBooking);

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

        public async Task<TicketBooking> GetTicketBookingAsyncById(int ticketBookingId)
        {
            return await _context.TicketBookings.FindAsync(ticketBookingId);
        }

        public async Task<IQueryable<TicketBooking>> GetTicketBookingsAsync(Func<TicketBooking, bool> predicate)
        {
            return _context.TicketBookings.Where(predicate).AsQueryable();
        }

        public async Task<bool> SaveChangesAsync()
        {
            return _context.SaveChanges() > 0;
        }

        public async Task UpdateAsync(TicketBooking ticketBooking)
        {
            _context.Update(ticketBooking);
        }
    }
}