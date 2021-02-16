using GreenAfrica.DataAccess;
using GreenAfrica.DataAccess.Models;
using GreenAfricaAPI.Business.Abstract;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreenAfricaAPI.Business
{
    public class BookingService : IBooking
    {
        private readonly GreenAPIDbContext _context;

        public BookingService(GreenAPIDbContext context)
        {
            _context = context;
        }

        public Task AddBook(Booking newBook)
        {
            throw new System.NotImplementedException();
        }

        public Task Delete(Booking deleteBook)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<Booking>> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Booking GetById(int Id)
        {
            throw new System.NotImplementedException();
        }

        public Task Update(Booking updateBook)
        {
            throw new System.NotImplementedException();
        }
    }
}
