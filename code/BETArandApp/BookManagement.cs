using BETArandApp.Operations;
using BETArandDomain;
using BETArandRepo;
using BETArandService;
using System.Reflection.Metadata;

namespace BETArandApp
{
    internal class BookManagement
    {
        private BookService bookService;
        private User? userLogged = null;

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
            Console.Write("O que queres fazer: ");
            if(userLogged != null) { Console.WriteLine(userLogged.Name); }
            else { Console.WriteLine(); }

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
                        //Book cbook = BookOperationsSupport.createBookText();
                        //bool result = bookService.createBooks(cbook);
                        User user = UserRepo.GetUser(1);
                        Console.WriteLine("The operation concluded with " + user.Name);
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
                    case 6: //Create U
                        DateTime dt = DateTime.Now;
                        User user1 = UserOperationsSupport.createUser();
                        bool resultU = bookService.createUsers(user1);
                        TimeSpan timeSpan = DateTime.Now - dt;
                        Console.WriteLine($"The operation concluded with {resultU} in {timeSpan} seconds");
                        break;

                    case 7: //Read User
                        List<User> users = bookService.GetUsers();
                        UserOperationsSupport.ShowUsers(users);
                        break;


                    case 8:// Update User
                        User uUser = UserOperationsSupport.updateUserText();
                        bookService.updateUser(uUser);
                        break;

                    case 9:// Delete User
                        int ID = UserOperationsSupport.deleteUserText();
                        bookService.deleteUser(ID);
                        break;

                    case 10:// Login
                        Console.WriteLine("Gira email");
                        string email = Console.ReadLine();
                        Console.WriteLine("Gira a pass");
                        string password = Console.ReadLine();

                        userLogged = bookService.Login(email,password);

                        if(userLogged == null)
                        {
                            Console.WriteLine("Password ou email errado");
                            break;
                        }

                        Console.WriteLine("Bem vindo "+userLogged.Name);

                        break;

                    case 11:// Req Livros
                        int id = 1;
                        List<Book> books = bookService.GetBooks();
                        //pedir para selecionar o livro que quer
                        int bookId = 1;
                        BookService.GetPastReq(id, bookId);
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
            Console.WriteLine("6-Criar User");//Create
            Console.WriteLine("7-Consultar User");//Read
            Console.WriteLine("8-Alterar User");//Update
            Console.WriteLine("9-Apagar User");//Delete
            Console.WriteLine("10-Login");//Procurar

            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
