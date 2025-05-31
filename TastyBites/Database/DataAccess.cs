using System;
using System.Data;
using System.Data.SqlClient;
using TastyBites.Models;

namespace TastyBites.Database
{
    class DataAccess
    {
        private readonly string connectionString = @"Data Source=DESKTOP-J3H208I;Initial Catalog=Demo;Integrated Security=True";

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
            string query = "SELECT UserID, Username, Password, Role FROM Users";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                conn.Open();
                adapter.Fill(dataTable);
            }

            return dataTable;
        }
        //Get All Menu Items from DB
        public DataTable GetAllMenuItems()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"SELECT m.MenuItemID, m.Name, m.Description, m.Price, m.StockQuantity, c.CategoryName
                         FROM MenuItem m
                         INNER JOIN Category c ON m.CategoryID = c.CategoryID";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
        //Gett all Menu Stock Items List
        public DataTable GetAllMenuStockItems()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"SELECT m.Name, m.Price, m.StockQuantity, c.CategoryName FROM MenuItem m INNER
                                JOIN Category c ON m.CategoryID = c.CategoryID";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }

        }
        //Get Menu Items for Staff 
        public DataTable GetAllMenuStockItemsStaff()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"SELECT m.MenuItemID, m.Name, m.Price, m.StockQuantity, c.CategoryName FROM MenuItem m INNER
                                JOIN Category c ON m.CategoryID = c.CategoryID";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }

        }

        //Search Menu Item by Name
        public DataTable SearchMenuItemsByName(string keyword)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM MenuItem WHERE Name LIKE @Keyword";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
        //Search Stock Menu by Names
        public DataTable SearchStockMenuItemsByName(string keyword)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
            SELECT m.Name, m.Price, m.StockQuantity, c.CategoryName
            FROM MenuItem m
            INNER JOIN Category c ON m.CategoryID = c.CategoryID
            WHERE m.Name LIKE @Keyword";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
        //Search User by Name
        public DataTable SearchUsersByUsername(string keyword)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Users WHERE Username LIKE @Keyword";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        // Insert new user into DB
        public int InsertUser(string username, string password, string role)
        {
            string query = "INSERT INTO Users (Username, Password, Role) VALUES (@Username, @Password, @Role)"; // default role as Staff

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.Parameters.AddWithValue("@Role", role); // default role as Staff

                conn.Open();
                return cmd.ExecuteNonQuery();
            }
        }
        
        //Delete Selected User
        public int DeleteUser(int userId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Users WHERE UserID = @UserID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserID", userId);
                conn.Open();
                return cmd.ExecuteNonQuery();
            }
        }

        //EDIT/UPDATE SELECTED USER
        public int UpdateUser(int userId, string username, string password, string role)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Users SET Username = @Username, Password = @Password, Role = @Role WHERE UserID = @UserID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.Parameters.AddWithValue("@Role", role);
                cmd.Parameters.AddWithValue("@UserID", userId);

                conn.Open();
                return cmd.ExecuteNonQuery();
            }
        }

        //INSERT MENU ITEM
        public int InsertMenuItem(string name, string description, decimal price, int stockQty, int categoryID)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO MenuItem (Name, Description, Price, StockQuantity, CategoryID) " +
                               "VALUES (@Name, @Description, @Price, @StockQuantity, @CategoryID)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Description", description);
                cmd.Parameters.AddWithValue("@Price", price);
                cmd.Parameters.AddWithValue("@StockQuantity", stockQty);
                cmd.Parameters.AddWithValue("@CategoryID", categoryID);

                conn.Open();
                return cmd.ExecuteNonQuery();
            }
        }

        //Get Menu Data
        public DataTable GetAllCategories()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT CategoryID, CategoryName FROM Category";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }

        //Delete Menu Item
        public int DeleteMenuItem(int menuItemId)
        { 
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM MenuItem WHERE MenuItemID = @MenuItemID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MenuItemID", menuItemId);
                conn.Open();
                return cmd.ExecuteNonQuery();
            }
        }
        //Update Menu Item
        public int UpdateMenuItem(int menuItemId, string name, string description, decimal price, int stockQty, int categoryID)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE MenuItem SET Name = @Name, Description = @Description, Price = @Price, StockQuantity = @StockQuantity, CategoryID = @CategoryID WHERE MenuItemID = @MenuItemID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Description", description);
                cmd.Parameters.AddWithValue("@Price", price);
                cmd.Parameters.AddWithValue("@StockQuantity", stockQty);
                cmd.Parameters.AddWithValue("@CategoryID", categoryID);
                cmd.Parameters.AddWithValue("@MenuItemID", menuItemId);
                conn.Open();
                return cmd.ExecuteNonQuery();
            }
        }


    }
}
