using BETArandDomain;

namespace BETArandApp
{
    internal class BookManagement
    {
        /*
        This is the main runpoint of the method
        Code should loop here until the user chooses to leave
        */
        internal void run()
        {
            Console.WriteLine("Olá bem vindo BETArand");
            Console.WriteLine("O que queres fazer:");

            int opcao = ShowMenu();

            //Adicionar a o switch aqui
        }

        /*
        This is the codes main menu options
        returns the option the user choose
        */
        private int ShowMenu()
        {
            Console.WriteLine("Escolhe uma opção");
            Console.WriteLine("1-Consultar Livros");

            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
