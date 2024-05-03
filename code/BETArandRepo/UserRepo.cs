using BETArandDomain;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BETArandRepo
{
    public class UserRepo
    {
        private readonly static string pass = System.Environment.GetEnvironmentVariable("PassDaDB");

        private readonly static string _connectionString = @$"Server=db.assembly.pt;
                                                             Database=D2_RC_RC_BetaRand;
                                                             User Id=Staff;
                                                             Password={pass}; 
                                                             TrustServerCertificate=True;";
        

        private readonly static SqlConnection _connection = new SqlConnection(_connectionString);

        public static User GetUser(int id)
        {
            _connection.Open();
            SqlCommand command = new SqlCommand($"Select * from users where id = {id}", _connection);
            SqlDataReader reader = command.ExecuteReader();
            
            User user = new User();

            if (reader.Read()) {

                user = Parse(reader);
            }
            _connection.Close();
            return user;

        }

        public static List<User> GetUsers()
        {
            _connection.Open();
            SqlCommand command = new SqlCommand($"Select * from users", _connection);
            SqlDataReader reader = command.ExecuteReader();

            List<User> users = new List<User>();

            while (reader.Read())
            {

                users.Add(Parse(reader));
            }
            _connection.Close();
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
