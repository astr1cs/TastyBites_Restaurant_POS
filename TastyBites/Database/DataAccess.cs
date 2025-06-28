using System;
using System.Data;
using System.Data.SqlClient;
using TastyBites.Models;


namespace TastyBites.Database
{
    class DataAccess
    {
        //Database Connection String
        private readonly string connectionString = @"Data Source=DESKTOP-KP493J1\SQLEXPRESS;Initial Catalog=Demo;Integrated Security=True";
        //private readonly string connectionString = @"Data Source=VICTUS-24H2\SQLEXPRESS;Initial Catalog=Demo;Persist Security Info=True;User ID=sa;Password=@1812;";

        ///---------------------------------------------------ADMIN AUTHENTICATION AND MANAGEMENT---------------------------------------------------///
        // Authenticate user by checking username and password from DB
        public User AuthenticateUser(string username, string password)
        {
            string query = "SELECT UserID, Username, Role FROM Users WHERE Username = @Username AND Password = @Password";

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
                            UserID = Convert.ToInt32(reader["UserID"]), // Assuming UserID is also neededs
                            Username = reader["Username"].ToString(),
                            Role = reader["Role"].ToString(),
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
            try
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
            catch (SqlException sqlEx)
            {

                Console.WriteLine("SQL error while updating user: " + sqlEx.Message);
                return -1;
            }
            catch (Exception ex)
            {

                Console.WriteLine("Unexpected error while updating user: " + ex.Message);
                return -1;
            }
        }



        //---------------------------------------------------MENU MANAGEMENT---------------------------------------------------///
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
        //public DataTable SearchStockMenuItemsByName(string keyword)
        //{
        //    using (SqlConnection conn = new SqlConnection(connectionString))
        //    {
        //        string query = @"
        //    SELECT m.Name, m.Price, m.StockQuantity, c.CategoryName
        //    FROM MenuItem m
        //    INNER JOIN Category c ON m.CategoryID = c.CategoryID
        //    WHERE m.Name LIKE @Keyword";
        //        SqlCommand cmd = new SqlCommand(query, conn);
        //        cmd.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");

        //        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        //        DataTable dt = new DataTable();
        //        adapter.Fill(dt);
        //        return dt;
        //    }
        //}
        public DataTable SearchStockMenuItemsByName(string searchText)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"SELECT m.MenuItemID, m.Name, m.Price, m.StockQuantity, c.CategoryName
                         FROM MenuItem m
                         INNER JOIN Category c ON m.CategoryID = c.CategoryID
                         WHERE LOWER(m.Name) LIKE '%' + @search + '%'";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@search", searchText.ToLower());

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

        //---------------------------------------------------ORDER MANAGEMENT---------------------------------------------------///
        // Get all orders
        public DataTable GetAllOrders()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
        SELECT 
            o.OrderID,
            o.OrderDateTime,
            o.TotalAmount,
            u.Username,
            u.Role,
            m.Name AS MenuItemName,
            oi.Quantity,
            oi.ItemPriceAtOrderTime
        FROM [Order] o
        INNER JOIN Users u ON o.UserID = u.UserID
        INNER JOIN OrderItem oi ON o.OrderID = oi.OrderID
        INNER JOIN MenuItem m ON oi.MenuItemID = m.MenuItemID
        ORDER BY o.OrderID DESC";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
        public DataTable GetOrdersByDateRange(DateTime start, DateTime end)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
SELECT 
    o.OrderID,
    o.OrderDateTime,
    o.TotalAmount,
    u.Username,
    u.Role,
    m.Name AS MenuItemName,
    oi.Quantity,
    oi.ItemPriceAtOrderTime
FROM [Order] o
INNER JOIN Users u ON o.UserID = u.UserID
INNER JOIN OrderItem oi ON o.OrderID = oi.OrderID
INNER JOIN MenuItem m ON oi.MenuItemID = m.MenuItemID
WHERE o.OrderDateTime BETWEEN @start AND @end
ORDER BY o.OrderID DESC";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@start", start);
                adapter.SelectCommand.Parameters.AddWithValue("@end", end);

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public DataTable searchOrderHistory(string searchTerm)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
        SELECT 
            o.OrderID,
            o.OrderDateTime,
            o.TotalAmount,
            u.Username,
            u.Role,
            m.Name AS MenuItemName,
            oi.Quantity,
            oi.ItemPriceAtOrderTime
        FROM [Order] o
        INNER JOIN Users u ON o.UserID = u.UserID
        INNER JOIN OrderItem oi ON o.OrderID = oi.OrderID
        INNER JOIN MenuItem m ON oi.MenuItemID = m.MenuItemID
        WHERE u.Username LIKE @search
           OR u.Role LIKE @search
           OR m.Name LIKE @search
        ORDER BY o.OrderID DESC";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@search", "%" + searchTerm + "%");

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public int GetMenuItemIdByName(string menuName)
        {
            int menuItemId = -1;


            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT MenuItemID FROM MenuItem WHERE Name = @name";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", menuName);

                conn.Open();
                var result = cmd.ExecuteScalar();
                if (result != null)
                {
                    menuItemId = Convert.ToInt32(result);
                }
            }
            return menuItemId;
        }

        public int InsertOrder(int userId, DateTime orderDate, string delivery, string paymentMethod, decimal totalAmount)
        {
            int orderId = -1;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
                INSERT INTO [Order] (UserID, OrderDateTime, Type, PaymentMethod, TotalAmount)
                OUTPUT INSERTED.OrderID
                VALUES (@userId, @orderDate, @delivery, @paymentMethod, @totalAmount)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@userId", userId);
                cmd.Parameters.AddWithValue("@orderDate", orderDate);
                cmd.Parameters.AddWithValue("@delivery", delivery);
                cmd.Parameters.AddWithValue("@paymentMethod", paymentMethod);
                cmd.Parameters.AddWithValue("@totalAmount", totalAmount);

                conn.Open();
                orderId = (int)cmd.ExecuteScalar();
            }
            return orderId;
        }
        public void InsertOrderItem(int orderId, int menuItemId, int quantity, decimal priceAtOrderTime)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
                INSERT INTO [OrderItem] (OrderID, MenuItemID, Quantity, itemPriceAtOrderTime)
                VALUES (@orderId, @menuItemId, @quantity, @priceAtOrderTime)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@orderId", orderId);
                cmd.Parameters.AddWithValue("@menuItemId", menuItemId);
                cmd.Parameters.AddWithValue("@quantity", quantity);
                cmd.Parameters.AddWithValue("@priceAtOrderTime", priceAtOrderTime);

                conn.Open();
                cmd.ExecuteNonQuery();
            }


        }
        public int DecrementMenuItemStock(int menuItemId, int quantitySold)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(
                "UPDATE MenuItem SET StockQuantity = StockQuantity - @qty WHERE MenuItemID = @id", conn))
            {
                cmd.Parameters.AddWithValue("@qty", quantitySold);
                cmd.Parameters.AddWithValue("@id", menuItemId);
                conn.Open();
                return cmd.ExecuteNonQuery(); // returns number of affected rows
            }
        }

        public int GetMenuItemStock(int menuItemId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand("SELECT StockQuantity FROM MenuItem WHERE MenuItemID = @id", conn))
            {
                cmd.Parameters.AddWithValue("@id", menuItemId);
                conn.Open();
                object result = cmd.ExecuteScalar();
                return result != null ? Convert.ToInt32(result) : -1; // -1 if not found
            }
        }


    }
}
