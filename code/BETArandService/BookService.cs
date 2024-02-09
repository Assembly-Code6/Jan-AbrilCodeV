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
        private ServiceValidations validations;

        public BookService(BookRepo bookRepo)
        {
            this.bookRepo = bookRepo;
            this.validations = new ServiceValidations(bookRepo);
        }

        public List<Book> GetBooks()
        {
            return bookRepo.GetBooks();
        }

        public bool createBooks(Book book)
        {
            if(!validations.isbnNotExists(book.ISBN) || !validations.NoEmptyProperties(book))
            {   
                return false;
            }
            bookRepo.createBook(book);
            return true;
        }
        

    }
}
