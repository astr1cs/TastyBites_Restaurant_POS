using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            orderTable.Columns.Add("Quantity", typeof(int));

            staffOrderGrid.DataSource = orderTable;
            staffOrderGrid.Visible = false;       // Hide the order grid initially
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            LoadMenuItems(); // Load menu items when the form loads
            //InitializeOrderTable();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login loginForm = new Login();
            loginForm.Show();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void RefreshOrderListBox()
        {
            staffOrderListBox.Items.Clear();
            foreach (var item in orderItems)
            {
                staffOrderListBox.Items.Add($"{item.Quantity}x {item.Name} ${item.Price * item.Quantity:F2}");
            }
        }

        private void staffDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && staffDataGrid.Columns[e.ColumnIndex].Name == "SelectButton")
            {
                int id = Convert.ToInt32(staffDataGrid.Rows[e.RowIndex].Cells["MenuItemId"].Value);
                string name = staffDataGrid.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                decimal price = Convert.ToDecimal(staffDataGrid.Rows[e.RowIndex].Cells["Price"].Value);

                var existingItem = orderItems.FirstOrDefault(item => item.Id == id);
                if (existingItem != null)
                {
                    existingItem.Quantity++;
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

                RefreshOrderListBox();
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

       
    }
}
