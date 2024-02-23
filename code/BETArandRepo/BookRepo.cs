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

        public void updateBook(Book uBook)
        {
            foreach(Book book in books )
            {
                if(book.ISBN== uBook.ISBN)
                {
                    book.Author = uBook.Author;
                    book.Sinopse = uBook.Sinopse;
                    book.Title = uBook.Title;
                }
            }
        }

        public void deleteBook(string isbn)
        {
            foreach (Book book in books)
            {
                if (book.ISBN == isbn)
                {
                    books.Remove(book);
                    break;
                }
            }
        }

        /*
         public void updateBook(Book uBook)
        {
            
            Book? bookToUpdate = books.Find(book => book.ISBN == uBook.ISBN);

            if (bookToUpdate == null) return;

            bookToUpdate.Author = uBook.Author;
            bookToUpdate.Title = uBook.Title;
            bookToUpdate.Sinopse=uBook.Sinopse;
        }
         */
    }
}
