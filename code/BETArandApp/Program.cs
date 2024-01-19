using BETArandDomain;
using BETArandService;

namespace BETArandApp
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            Book book = new Book();
            BookService bookService = new BookService();
            BookManagement application = new BookManagement();
            application.run();
            
        }
    }
}
