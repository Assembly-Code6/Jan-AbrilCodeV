using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BETArandRepo
{
    internal class SQL
    {
        private readonly static string pass = System.Environment.GetEnvironmentVariable("PassDaDB");

        private readonly static string _connectionString = @$"Server=db.assembly.pt;
                                                             Database=D2_RC_RC_BetaRand;
                                                             User Id=Staff;
                                                             Password=Cyb3rAdmin; 
                                                             TrustServerCertificate=True;";


        private readonly static SqlConnection _connection = new SqlConnection(_connectionString);
        private static bool isOpen = false;


        private static void ConnectionHandler()
        {
            if (isOpen)
            {
                _connection.Close();
                _connection.Open();
            }
            else
            {
                _connection.Open();
                isOpen = true;
            }
        }

        public static SqlDataReader Execute(string sql)
        {
            ConnectionHandler();
            SqlCommand command = new SqlCommand(sql,_connection);
            SqlDataReader reader = command.ExecuteReader();
            return reader;
        }

        public static int ExecuteNonQuery(string sql)
        {
            ConnectionHandler();
            SqlCommand command = new SqlCommand(sql, _connection);
            int ans = command.ExecuteNonQuery();
            return ans;
        }
    }
}
