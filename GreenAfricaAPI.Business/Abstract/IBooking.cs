using GreenAfrica.DataAccess.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GreenAfricaAPI.Business.Abstract
{
    public interface IBooking
    {
        Task<IEnumerable<Booking>> GetAll();
        Booking GetById(int Id);
        Task AddBook(Booking newBook);
        Task Delete(Booking deleteBook);
        Task Update(Booking updateBook);
    }
}
