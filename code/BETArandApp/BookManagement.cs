﻿using BETArandApp.Operations;
using BETArandDomain;
using BETArandService;
using System.Reflection.Metadata;

namespace BETArandApp
{
    internal class BookManagement
    {
        private BookService bookService;

        public BookManagement(BookService bookService)
        {
            this.bookService = bookService;
        }

        /*
        This is the main runpoint of the method
        Code should loop here until the user chooses to leave
        */
        internal void run()
        {
            Console.WriteLine("Olá bem vindo BETArand");
            Console.WriteLine("O que queres fazer:");

            while (true)
            {
                int opcao = ShowMenu();

                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("Bye bye");
                        Environment.Exit(0);
                        break;

                    case 1:
                        Book cbook = BookOperationsSupport.createBookText();
                        bool result = bookService.createBooks(cbook);
                        Console.WriteLine("The operation concluded with " + result);
                        break;

                    case 2:
                        List<Book> bookS = bookService.GetBooks();
                        BookOperationsSupport.ShowBooks(bookS);
                        break;


                    case 3:
                        Book uBook = BookOperationsSupport.updateBookText();
                        bookService.updateBook(uBook);
                        break;

                    case 4:
                        string ISBN = BookOperationsSupport.deleteBookText();
                        bookService.deleteBook(ISBN);
                        break;

                    case 5:
                        List<Book> bookSearch = bookService.GetBooks();
                        bookSearch = BookOperationsSupport.SearchBooks(bookSearch);
                        BookOperationsSupport.ShowBooks(bookSearch);
                        break;

                    default:
                        Console.WriteLine("Opção não existe");
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }
        }

        /*
        This is the codes main menu options
        returns the option the user choose
        */
        private int ShowMenu()
        {
            Console.WriteLine("Escolhe uma opção");
            Console.WriteLine("0-Sair");
            Console.WriteLine("1-Criar Livro");//Create
            Console.WriteLine("2-Consultar Livros");//Read
            Console.WriteLine("3-Alterar Livro");//Update
            Console.WriteLine("4-Apagar Livro");//Delete
            Console.WriteLine("5-Procurar Livro");//Procurar

            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
