using GreenAfrica.DataAccess;
using GreenAfrica.DataAccess.Models;
using GreenAfricaAPI.Business.Abstract;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreenAfricaAPI.Business
{
    public class BookService : IBook
    {
        private readonly GreenAPIDbContext _context;

        public BookService(GreenAPIDbContext context)
        {
            _context = context;
        }

        public void AddBook(Book newBook)
        {
            _context.Books.Add(newBook);

        }

        public void Delete(Book deleteBook)
        {
            _context.Books.Remove(deleteBook);
        }

        public IEnumerable<Book> GetAll()
        {
            return _context.Books;
        }

        public Book GetById(int Id)
        {
            return (Book)_context.Books.Where(c => c.Id ==Id);
        }

        public void Update(Book updateBook)
        {
            _context.Books.Update(updateBook);
        }
    }
}
