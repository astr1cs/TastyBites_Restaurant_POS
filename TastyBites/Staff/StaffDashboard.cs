using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TastyBites.Database;
using TastyBites.Models;
namespace TastyBites.Staff
{
    public partial class StaffDashboard : Form
    {
        private User currentUser;
        private DataTable allMenuItems;
        private DataTable orderTable;
        //List declared to store selected items
        private List<OrderItem> orderItems = new List<OrderItem>();
        class OrderItem
        {
            public int Id;
            public string Name;
            public decimal Price;
            public int Quantity;
        }

        public StaffDashboard()
        {
            InitializeComponent();
        }
        public StaffDashboard(User user)
        {
            InitializeComponent();
            currentUser = user;
            roleNameLabel.Text = user.Username;
            staffPriceSortComboBox.Text = "Sort by Price";
            staffCategoryComboBox.Text = "Sort by Category"; // Reset category filter
            //staffDataGrid.CellContentClick += staffDataGrid_CellContentClick;
            // You can show the role or other details if needed
            //roleLabel.Text = "Role: " + user.Role;
            //InitializeOrderTable();
        }

        //--------------------FUNCTIONS--------------------//
        private void LoadMenuItems()
        {
            DataAccess db = new DataAccess();
            DataTable menuItems = db.GetAllMenuStockItemsStaff(); // Create this method in DataAccess
            allMenuItems = menuItems; // Store the menu items in a class variable for later use
            staffDataGrid.DataSource = allMenuItems;

            // Prevent duplicate button column on reload
            if (!staffDataGrid.Columns.Contains("SelectButton"))
            {
                DataGridViewButtonColumn selectButtonColumn = new DataGridViewButtonColumn();
                selectButtonColumn.Name = "SelectButton";
                selectButtonColumn.HeaderText = "Action";
                selectButtonColumn.Text = "Select";
                selectButtonColumn.UseColumnTextForButtonValue = true;
                selectButtonColumn.Width = 70;

                staffDataGrid.Columns.Add(selectButtonColumn);

            }
        }
        private void InitializeOrderTable()
        {
            orderTable = new DataTable();
            orderTable.Columns.Add("Id", typeof(int));
            orderTable.Columns.Add("Name", typeof(string));
            orderTable.Columns.Add("Price", typeof(decimal));
            orderTable.Columns.Add("Qty", typeof(int));


            staffOrderGridBox.DataSource = orderTable;
            staffOrderGridBox.Columns["Id"].Visible = false;

            // Add button columns if they don't exist
            if (!staffOrderGridBox.Columns.Contains("Increase"))
            {
                AddGridButton("Decrease", "−");
                AddGridButton("Increase", "+");
                AddGridButton("Delete", "❌");
            }

            staffOrderGridBox.Columns["Name"].Width = 100;
            staffOrderGridBox.Columns["Price"].Width = 50;
            staffOrderGridBox.Columns["Qty"].Width = 30;
            staffOrderGridBox.Columns["Increase"].Width = 20;
            staffOrderGridBox.Columns["Decrease"].Width = 20;
            staffOrderGridBox.Columns["Delete"].Width = 20;

            // Enable text wrapping
            staffOrderGridBox.Columns["Name"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            staffOrderGridBox.Columns["Price"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            staffOrderGridBox.Columns["Qty"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            // Set font size (after all columns are added)
            staffOrderGridBox.Columns["Name"].DefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            staffOrderGridBox.Columns["Price"].DefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            staffOrderGridBox.Columns["Qty"].DefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Regular);

            staffOrderGridBox.Columns["Increase"].DefaultCellStyle.Font = new Font("Segoe UI", 8, FontStyle.Regular);
            staffOrderGridBox.Columns["Decrease"].DefaultCellStyle.Font = new Font("Segoe UI", 8, FontStyle.Regular);
            staffOrderGridBox.Columns["Delete"].DefaultCellStyle.Font = new Font("Segoe UI", 8, FontStyle.Regular);

            // Optional: center align buttons
            staffOrderGridBox.Columns["Increase"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            staffOrderGridBox.Columns["Decrease"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            staffOrderGridBox.Columns["Delete"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void AddGridButton(string name, string text)
        {
            DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            button.Name = name;
            button.HeaderText = "";
            button.Text = text;
            button.UseColumnTextForButtonValue = true;
            button.Width = 30;
            staffOrderGridBox.Columns.Add(button);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            LoadMenuItems(); // Load menu items when the form loads
            InitializeOrderTable();

            //InitializeOrderTable();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void RefreshOrderListBox()
        {
            staffOrderGridBox.Rows.Clear();
            foreach (var item in orderItems)
            {
                staffOrderGridBox.Rows.Add(item.Id, item.Name, item.Price.ToString("F2"), item.Quantity);
            }
        }



        private void staffOrderGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void staffAllMenuBtn_Click(object sender, EventArgs e)
        {
            try
            {
                LoadMenuItems();
                MessageBox.Show("Menu loaded successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading menu: " + ex.Message);
            }
        }

        private void staffSearchBtn_Click(object sender, EventArgs e)
        {
            string searchText = staffSearchBox.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(searchText))
            {
                LoadMenuItems(); // Show all items if search is empty
                return;
            }
            DataAccess db = new DataAccess();
            DataTable filteredItems = db.SearchStockMenuItemsByName(searchText);

            if (filteredItems.Rows.Count == 0)
            {
                MessageBox.Show("No matching items found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            staffDataGrid.DataSource = filteredItems;
        }
        private void staffDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            if (staffDataGrid.Columns[e.ColumnIndex].Name == "SelectButton")
            {
                int id = Convert.ToInt32(staffDataGrid.Rows[e.RowIndex].Cells["MenuItemID"].Value);
                string name = staffDataGrid.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                decimal price = Convert.ToDecimal(staffDataGrid.Rows[e.RowIndex].Cells["Price"].Value);

                AddItemToOrder(id, name, price);
                CalculateSubtotal(); // Call after modifying quantity or deleting

            }
        }

        private void staffAllMenuBtn_Click_1(object sender, EventArgs e)
        {
            LoadMenuItems();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            using (Pen pen = new Pen(Color.LightGray, 4)) // 1 pixel thick
            {
                int y = panel2.ClientRectangle.Height - 1; // Bottom Y position
                e.Graphics.DrawLine(pen, 0, y, panel2.ClientRectangle.Width, y); // Horizontal line
            }
        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {
            using (Pen pen = new Pen(Color.LightGray, 1))
            {
                int x = panel2.ClientRectangle.Width - 1; // Right edge
                e.Graphics.DrawLine(pen, x, 0, x, panel2.ClientRectangle.Height); // Draw right border
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            using (Pen pen = new Pen(Color.LightGray, 1))
            {
                int y = panel3.ClientRectangle.Height - 1; // Bottom edge
                e.Graphics.DrawLine(pen, 0, y, panel3.ClientRectangle.Width, y); // Bottom horizontal line
            }
        }



        private void staffOrderGridBox_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            int id = Convert.ToInt32(staffOrderGridBox.Rows[e.RowIndex].Cells["Id"].Value);
            var item = orderItems.FirstOrDefault(x => x.Id == id);
            if (item == null) return;

            string column = staffOrderGridBox.Columns[e.ColumnIndex].Name;

            switch (column)
            {
                case "Increase":
                    item.Quantity++;
                    RefreshOrderGridBox();     // Move this before CalculateSubtotal
                    CalculateSubtotal();      // Now this works on updated data
                    break;

                case "Decrease":
                    if (item.Quantity > 1)
                    {
                        item.Quantity--;
                        RefreshOrderGridBox();
                        CalculateSubtotal();
                    }
                    break;

                case "Delete":
                    orderItems.Remove(item);
                    RefreshOrderGridBox();
                    CalculateSubtotal();
                    break;
            }
        }


        private void RefreshOrderGridBox()
        {
            orderTable.Rows.Clear();
            foreach (var item in orderItems)
            {
                orderTable.Rows.Add(item.Id, item.Name, item.Price, item.Quantity);
            }

        }


        private void staffOrderGridBox_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewButtonColumn selectButtonColumn = new DataGridViewButtonColumn();
            selectButtonColumn.Name = "SelectButton";
            selectButtonColumn.HeaderText = "Action";
            selectButtonColumn.Text = "Select";

            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            if (staffDataGrid.Columns[e.ColumnIndex].Name == "SelectButton")
            {
                int id = Convert.ToInt32(staffDataGrid.Rows[e.RowIndex].Cells["MenuItemID"].Value);
                string name = staffDataGrid.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                decimal price = Convert.ToDecimal(staffDataGrid.Rows[e.RowIndex].Cells["Price"].Value);

                AddItemToOrder(id, name, price);
                CalculateSubtotal(); // Call after modifying quantity or deleting

            }
        }

        private void AddItemToOrder(int id, string name, decimal price)
        {
            var existing = orderItems.FirstOrDefault(x => x.Id == id);
            if (existing != null)
            {

                existing.Quantity++;

            }
            else
            {

                orderItems.Add(new OrderItem
                {
                    Id = id,
                    Name = name,
                    Price = price,
                    Quantity = 1

                });

            }

            RefreshOrderGridBox();
            CalculateSubtotal();
        }
        //Calculate the subtotal of the order
        private void CalculateSubtotal()
        {
            decimal subtotal = 0;

            foreach (DataRow row in orderTable.Rows)
            {
                if (row["Price"] != DBNull.Value && row["Qty"] != DBNull.Value)
                {
                    decimal price = Convert.ToDecimal(row["Price"]);
                    int quantity = Convert.ToInt32(row["Qty"]);
                    subtotal += price * quantity;
                }
            }

            subTotalBox.Text = subtotal.ToString("0.00");
        }

        private void subTotalBox_TextChanged(object sender, EventArgs e)
        {

        }

        //private void placeOrderBtn_Click(object sender, EventArgs e)
        //{
        //    // Check payment method
        //    if (!cardRadio.Checked && !cashRadio.Checked)
        //    {
        //        MessageBox.Show("Please select a payment method.");
        //        return;
        //    }

        //    string paymentMethod = cardRadio.Checked ? "Card" : "Cash";
        //    string delivery = takeaWayCombo.SelectedIndex == 0 ? "Dine-in" : "Takeaway";

        //    decimal totalAmount = 0;
        //    List<OrderItemModel> orderItems = new List<OrderItemModel>();

        //    DataAccess db = new DataAccess();

        //    foreach (DataGridViewRow row in staffOrderGridBox.Rows)
        //    {
        //        if (row.IsNewRow) continue;

        //        string menuName = Convert.ToString(row.Cells["Name"].Value);
        //        decimal price = Convert.ToDecimal(row.Cells["Price"].Value);
        //        int quantity = Convert.ToInt32(row.Cells["Qty"].Value);

        //        totalAmount += price * quantity;

        //        int menuItemId = db.GetMenuItemIdByName(menuName);

        //        orderItems.Add(new OrderItemModel
        //        {
        //            MenuItemID = menuItemId,
        //            Quantity = quantity,
        //            ItemPriceAtOrderTime = price
        //        });
        //    }

        //    int userId = currentUser.UserID;

        //    int orderId = db.InsertOrder(userId, DateTime.Now, delivery, paymentMethod, totalAmount);

        //    foreach (var item in orderItems)
        //    {
        //        db.InsertOrderItem(orderId, item.MenuItemID, item.Quantity, item.ItemPriceAtOrderTime);
        //        // **NEW**: decrement the stock
        //        int rowsAffected = db.DecrementMenuItemStock(item.MenuItemID, item.Quantity);
        //        if (rowsAffected == 0)
        //        {
        //            // handle the case where stock update failed (e.g. no such MenuItemID)
        //            MessageBox.Show($"Failed to update stock for item ID {item.MenuItemID}");
        //        }
        //    }

        //    MessageBox.Show("Order placed successfully!");

        //    // Clear the list and table
        //    orderItems.Clear();
        //    orderTable.Rows.Clear(); // optional if RefreshOrderGridBox is called next
        //    subTotalBox.Text = "0.00"; // Reset subtotal display



        //}
        private void placeOrderBtn_Click(object sender, EventArgs e)
        {
            if (!cardRadio.Checked && !cashRadio.Checked)
            {
                MessageBox.Show("Please select a payment method.");
                return;
            }

            string paymentMethod = cardRadio.Checked ? "Card" : "Cash";
            string delivery = takeaWayCombo.SelectedIndex == 0 ? "Dine-in" : "Takeaway";
            decimal totalAmount = 0;
            List<OrderItemModel> orderItems = new List<OrderItemModel>();
            DataAccess db = new DataAccess();

            // ✅ 1st Pass: Check stock before placing order
            foreach (DataGridViewRow row in staffOrderGridBox.Rows)
            {
                if (row.IsNewRow) continue;

                string menuName = Convert.ToString(row.Cells["Name"].Value);
                decimal price = Convert.ToDecimal(row.Cells["Price"].Value);
                int quantity = Convert.ToInt32(row.Cells["Qty"].Value);

                int menuItemId = db.GetMenuItemIdByName(menuName);
                int currentStock = db.GetMenuItemStock(menuItemId);

                if (currentStock < quantity)
                {
                    MessageBox.Show($"Not enough stock for \"{menuName}\".\nAvailable: {currentStock}, Requested: {quantity}");
                    return;
                }

                totalAmount += price * quantity;

                orderItems.Add(new OrderItemModel
                {
                    MenuItemID = menuItemId,
                    Quantity = quantity,
                    ItemPriceAtOrderTime = price
                });
            }

            // ✅ Stock is okay for all, now place the order
            int userId = currentUser.UserID;
            int orderId = db.InsertOrder(userId, DateTime.Now, delivery, paymentMethod, totalAmount);

            foreach (var item in orderItems)
            {
                db.InsertOrderItem(orderId, item.MenuItemID, item.Quantity, item.ItemPriceAtOrderTime);
                db.DecrementMenuItemStock(item.MenuItemID, item.Quantity);
            }

            MessageBox.Show("Order placed successfully!");

            // ✅ Reset form
            orderItems.Clear();
            orderTable.Rows.Clear();
            subTotalBox.Text = "0.00";
        }




        private void logoutBtn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Login loginForm = new Login();
            loginForm.Show();
        }

        private void staffCategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (allMenuItems == null)
                return;

            string selectedCategory = staffCategoryComboBox.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedCategory) || selectedCategory == "All")
            {
                // Show all items if "All" or nothing selected
                staffDataGrid.DataSource = allMenuItems;
            }
            else
            {
                // Filter rows by selected category
                var filteredRows = allMenuItems.AsEnumerable()
                    .Where(row => row.Field<string>("CategoryName").Equals(selectedCategory, StringComparison.OrdinalIgnoreCase));

                if (filteredRows.Any())
                {
                    DataTable filteredTable = filteredRows.CopyToDataTable();
                    staffDataGrid.DataSource = filteredTable;
                }
                else
                {
                    // No match, show empty table with same structure
                    staffDataGrid.DataSource = allMenuItems.Clone();
                }
            }
        }

        private void staffPriceSortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (allMenuItems == null) return;

            string selectedSort = staffPriceSortComboBox.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedSort) || selectedSort == "Default" || selectedSort == "None")
            {
                // Show original unsorted data
                staffDataGrid.DataSource = allMenuItems;
                return;
            }

            DataView dv = allMenuItems.DefaultView;

            if (selectedSort == "Low to High")
            {
                dv.Sort = "Price ASC";
            }
            else if (selectedSort == "High to Low")
            {
                dv.Sort = "Price DESC";
            }
            else
            {
                dv.Sort = ""; // no sort
            }

            staffDataGrid.DataSource = dv.ToTable();
        }

        private void staffSearchBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
