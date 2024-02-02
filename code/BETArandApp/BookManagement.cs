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
                        //Create book
                        Book cbook = new Book();
                        Console.WriteLine("Give me the book information");
                        Console.Write("ISBN:");
                        cbook.isbn = Console.ReadLine();
                        Console.Write("Title:");
                        cbook.title = Console.ReadLine();
                        Console.Write("Autor:");
                        cbook.author = Console.ReadLine();
                        Console.Write("Sinopse:");
                        cbook.sinopse = Console.ReadLine();

                        bool result = bookService.createBooks(cbook);
                        Console.WriteLine("The operation concluded with "+result);

                        break;

                    case 2:
                        List<Book> books = bookService.GetBooks();
                        foreach (Book book in books)
                        {
                            Console.WriteLine($"Titulo: {book.title}, Autor: {book.author}, Sinopse: {book.sinopse}");
                        }
                        break;

                    case 3:
                        Console.WriteLine("Alterar very livros");
                        break;

                    case 4:
                        Console.WriteLine("Apagar very livros");
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

            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
