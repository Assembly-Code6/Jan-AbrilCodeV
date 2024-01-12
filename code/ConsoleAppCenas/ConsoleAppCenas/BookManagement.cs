using BETArandDomain;


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