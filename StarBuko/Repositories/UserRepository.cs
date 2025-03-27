using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace StarBuko.Repositories
{
    public class UserRepository
    {
        string _connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
        public bool IsValidUser(string username, string password)
        {
            using (MySqlConnection conn = new MySqlConnection(_connectionString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM users WHERE username = @username AND password = SHA1(@password)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                return Convert.ToInt32(cmd.ExecuteScalar()) > 0; 
            }
        }
    }
}
