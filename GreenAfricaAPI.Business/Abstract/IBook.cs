using GreenAfrica.DataAccess.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GreenAfricaAPI.Business.Abstract
{
    public interface IBook
    {
        IEnumerable<Book> GetAll();
        Book GetById(int Id);
        void AddBook(Book newBook);
        void Delete(Book deleteBook);
        void Update(Book updateBook);
    }
}
