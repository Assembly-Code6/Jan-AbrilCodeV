using BETArandDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BETArandApp.Operations
{
    internal class UserOperationsSupport
    {
        internal static User createUser()
        {

            User user = new User();
            Console.WriteLine("Give me the user information");
            Console.WriteLine("Email: ");
            user.Email = Console.ReadLine();
            Console.WriteLine("Password: ");
            user.Password = Console.ReadLine();
            Console.WriteLine("Name: ");
            user.Name = Console.ReadLine();

            return user;
        }

        internal static int deleteUserText()
        {
            Console.WriteLine("Qual é o User que queres apagar");
            int ID = Convert.ToInt32(Console.ReadLine());
            return ID;
        }

        internal static void ShowUsers(List<User> users)
        {
            Console.WriteLine("Lista de Utilizadores:");
            foreach (User user in users)
            {
                // Assuming User has properties like "Username", "FirstName", "LastName", etc.
                Console.WriteLine($"ID: {user.Id}, Email: {user.Email} Name: {user.Name}");
            }
        }

        internal static User updateUserText()
        {
            User user = new User();
            Console.WriteLine("Give me the user to update information");
            Console.WriteLine("Email: ");
            user.Email = Console.ReadLine();
            Console.WriteLine("Password: ");
            user.Password = Console.ReadLine();
            Console.WriteLine("Name: ");
            user.Name = Console.ReadLine();

            return user;
        }
    }
}
