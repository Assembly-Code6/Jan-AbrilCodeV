using System;
using BETArandRepo;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BETArandDomain;
using static System.Reflection.Metadata.BlobBuilder;
using System.Text.RegularExpressions;

namespace BETArandService
{
    internal static class ServiceValidations
    {
        public static bool isEmailUnique(string email, List<User> users)
        {
            foreach (User user in users)
            {
                if (user.Email == email)
                {
                    return false;
                }
            }
            return true;
        }

        public static bool isEmailValid(string email)
        {
            string pattern = "[A-Za-z0-9]+@[A-Za-z0-9]+\\.[A-Za-z]+";
            Regex emailRegex = new Regex(pattern, RegexOptions.Compiled);

            return emailRegex.IsMatch(email);
        }

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
