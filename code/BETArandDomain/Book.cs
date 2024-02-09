using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BETArandDomain
{
    public class Book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Sinopse { get; set; }

        public Book() { 
            
        
        }

        public Book(string ISBN, string Title, string Author, string Sinopse)
        {
            this.ISBN = ISBN;
            this.Title = Title;
            this.Author = Author;
            this.Sinopse = Sinopse;
        }
    }
}
