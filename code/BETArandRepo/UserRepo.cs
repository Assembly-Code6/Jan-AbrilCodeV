using BETArandDomain;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BETArandRepo
{
    public class UserRepo
    {
        

        public static User GetUser(int id)
        {
            SqlDataReader reader = SQL.Execute($"Select * from users where id = {id}");
            
            User user = new User();

            if (reader.Read()) {

                user = Parse(reader);
            }
            return user;

        }


        public static bool DeleteUser(int id)
        {
            int ans = SQL.ExecuteNonQuery(@$" Delete from book_sales where users_id = {id};
                                                    Delete from users where id = {id};");
            return Convert.ToBoolean(ans);
        }

        public static bool CreateUser(User user)
        { 
            int ans = SQL.ExecuteNonQuery($@"Insert into Users(name,email,password)
                                                Values('{user.Name}','{user.Email}','{user.Password}');");
            return Convert.ToBoolean(ans);
        }

        public static List<User> GetUsers()
        {
            SqlDataReader reader = SQL.Execute($"Select * from users");
            List<User> users = new List<User>();

            while (reader.Read())
            {

                users.Add(Parse(reader));
            }
            return users;
        }





        private static User Parse(SqlDataReader reader)
        {
            User user = new User();
            user.Id = Convert.ToInt32(reader["id"]);
            user.Name = Convert.ToString(reader["name"]);
            user.Email = Convert.ToString(reader["email"]);
            user.Password = Convert.ToString(reader["password"]);
            return user;
        }
        
    }
}
