using System;
using BETArandRepo;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BETArandDomain;

namespace BETArandService
{
    internal static class ServiceValidations
    {

        public static bool isbnNotExists(string isbn,List<Book> books)
        {
            foreach (Book book in books)
            {
                if (book.ISBN == isbn)
                {
                    return false;
                }
            }
            return true;
        }

        internal static bool NoEmptyProperties(Book book)
        {
            return
                book.ISBN != "" &&
                book.Title != "" &&
                book.Author != "" &&
                book.Sinopse != "";
        }
    }
}
