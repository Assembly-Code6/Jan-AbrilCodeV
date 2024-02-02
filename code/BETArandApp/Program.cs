using BETArandDomain;
using BETArandRepo;
using BETArandService;

namespace BETArandApp
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            BookRepo bookRepo = new BookRepo();
            BookService bookService = new BookService(bookRepo);
            BookManagement application = new BookManagement(bookService);
            application.run();
            
        }
    }
}
