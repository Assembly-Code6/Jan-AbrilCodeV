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
            books.Add(new Book()
            {
                author = "jacklino",
                isbn = "123fasfafas",
                title = "cao azul aprende as cores",
                sinopse = "O cao está azul mas queria ser vermelho"
            });
            books.Add(new Book()
            {
                author = "mANUEL",
                isbn = "2134xbbse",
                title = "As aventuras da ex do menezes",
                sinopse = "Katakana e companhia e as suas desaventuras"
            });
            books.Add(new Book()
            {
                author = "cristina ferreira",
                isbn = "tininha1234",
                title = "As aventuras do manuel luis goucha",
                sinopse = "o manel é lindo e maravilhoso."
            });
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
