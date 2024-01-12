using BETArandDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BETArandApp
{
    internal class BookManagement
    {
        internal void run()
        {
            Console.WriteLine("Olá bem vindo BETArand");
            Console.WriteLine("O que queres fazer:");

            int opcao = ShowMenu();
            Book book = new Book();
        }

        private int ShowMenu()
        {
            Console.WriteLine("Escolhe uma opção");
            Console.WriteLine("1-Consultar Livros");

            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
}
