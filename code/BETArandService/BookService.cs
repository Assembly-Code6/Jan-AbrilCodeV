using BETArandDomain;
using BETArandRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BETArandService
{
    public class BookService
    {
        private BookRepo bookRepo;

        public BookService(BookRepo bookRepo)
        {
            this.bookRepo = bookRepo;
        }

        public List<Book> GetBooks()
        {
            return bookRepo.GetBooks();
        }

        public bool createBooks(Book book)
        {
            if(!ServiceValidations.isbnNotExists(book.ISBN,bookRepo.GetBooks()) || 
                !ServiceValidations.NoEmptyProperties(book))
            {   
                return false;
            }
            bookRepo.createBook(book);
            return true;
        }

        public void updateBook(Book uBook)
        {
            bookRepo.updateBook(uBook);
        }
    }
}
