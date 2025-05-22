using System;
using System.Data;
using System.Data.SqlClient;
using TastyBites.Models;

namespace TastyBites.Database
{
    class DataAccess
    {
        private readonly string connectionString = @"Data Source=DESKTOP-U6CD3IB;Initial Catalog=Demo;Integrated Security=True";

        // Authenticate user by checking username and password from DB
        public User AuthenticateUser(string username, string password)
        {
            string query = "SELECT Username, Role FROM Users WHERE Username = @Username AND Password = @Password";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);

                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new User
                        {
                            Username = reader["Username"].ToString(),
                            Role = reader["Role"].ToString()
                        };
                    }
                }
            }

            return null;
        }

        // Get all users from DB
        public DataTable GetAllUsers()
        {
            var dataTable = new DataTable();
            string query = "SELECT UserID, Username, Role FROM Users";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                conn.Open();
                adapter.Fill(dataTable);
            }

            return dataTable;
        }


        // Insert new user into DB
        public int InsertUser(string username, string password)
        {
            string query = "INSERT INTO Users (Username, Password, Role) VALUES (@Username, @Password, 'Staff')"; // default role as Staff

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);

                conn.Open();
                return cmd.ExecuteNonQuery();
            }
        }
    }
}
