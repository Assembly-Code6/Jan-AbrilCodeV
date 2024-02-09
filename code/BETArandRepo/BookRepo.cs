using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BETArandDomain;

namespace BETArandRepo
{
    public class BookRepo
    {
        private List<Book> books = new List<Book>();

        public BookRepo() {
            books.Add(
                new Book(
                    "jacklino",
                    "123fasfafas",
                    "cao azul aprende as cores",
                    "O cao está azul mas queria ser vermelho"
                    )
                );
            books.Add(
                new Book(
                    "mANUEL",
                    "2134xbbse",
                    "As aventuras da ex do menezes",
                    "Katakana e companhia e as suas desaventuras"
                    )
                );
            books.Add(
                new Book(
                    "cristina ferreira",
                    "tininha1234",
                    "As aventuras do manuel luis goucha",
                    "o manel é lindo e maravilhoso."
                    )
                );
        }
        public List<Book> GetBooks()
        {
            return books ;
        }

        public bool createBook(Book book)
        {
            books.Add(book);
            return true;
        }
    }
}
