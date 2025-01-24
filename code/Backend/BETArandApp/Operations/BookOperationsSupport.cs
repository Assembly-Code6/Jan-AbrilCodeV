using BETArandDomain;
using BETArandService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BETArandApp.Operations
{
    internal static class BookOperationsSupport
    {
        internal static Book createBookText()
        {
            Book book = new Book();
            Console.WriteLine("Give me the book information");
            Console.Write("ISBN:");
            book.ISBN = Console.ReadLine();
            Console.Write("Title:");
            book.Title = Console.ReadLine();
            Console.Write("Autor:");
            book.Author = Console.ReadLine();
            Console.Write("Sinopse:");
            book.Sinopse = Console.ReadLine();
            return book;
        }

        internal static string deleteBookText()
        {
            Console.WriteLine("Qual é o livro que queres apagar");
            string ISBN = Console.ReadLine();
            return ISBN;
        }


        
        internal static List<Book> SearchBooks(List<Book> bookS)
        {
            List<Book> result = new List<Book>();
            Console.WriteLine("Escreva os termos de pesquisa");
            string searchTerms = Console.ReadLine();
            foreach (Book book in bookS)
            {
                if (
                    book.ISBN.Contains(searchTerms) ||
                    book.Author.Contains(searchTerms) ||
                    book.Sinopse.Contains(searchTerms) ||
                    book.Title.Contains(searchTerms))
                {
                    result.Add(book);
                }
            }
            return result;
        }

        internal static void ShowBooks(List<Book> books)
        {
            foreach (Book book in books)
            {
                Console.WriteLine($"ISBN:{book.ISBN},Title:{book.Title},Author:{book.Author},Sinopse:{book.Sinopse}");
            }
        }

        internal static Book updateBookText()
        {
            Console.WriteLine("Qual é o livro que queres alterar info sobre");
            Book uBook = new Book();

            uBook.ISBN = Console.ReadLine();
            Console.WriteLine("Give me the updated book information");

            Console.Write("Title:");
            uBook.Title = Console.ReadLine();
            Console.Write("Autor:");
            uBook.Author = Console.ReadLine();
            Console.Write("Sinopse:");
            uBook.Sinopse = Console.ReadLine();

            return uBook;
        }


        /*
         internal static void createBookText2(Func<Book, bool> createBooks)
        {
            Book book = new Book();
            Console.WriteLine("Give me the book information");
            Console.Write("ISBN:");
            book.ISBN = Console.ReadLine();
            Console.Write("Title:");
            book.Title = Console.ReadLine();
            Console.Write("Autor:");
            book.Author = Console.ReadLine();
            Console.Write("Sinopse:");
            book.Sinopse = Console.ReadLine();

            bool result = createBooks(book);
            Console.WriteLine("The operation concluded with " + result);
        }
         */
    }
}
