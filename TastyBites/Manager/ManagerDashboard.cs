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

namespace TastyBites.Manager
{

    public partial class managerDashboard : Form
    {
        private DataTable allMenuItems;
        public managerDashboard()
        {
            InitializeComponent();
        }
        public managerDashboard(User user)
        {
            InitializeComponent();
            managerName.Text = user.Username;
        }

        private void managerLogoutBtn_Click(object sender, EventArgs e)
        {

            this.Hide(); // Hide current dashboard
            Login loginForm = new Login();
            loginForm.Show(); // Show login form

        }

        private void managerDashboard_Load(object sender, EventArgs e)
        {
            LoadStockHistory(); // Load stock history on form load
            LoadMenuItems(); // Load menu items on form load
        }
        //-----------------------------------------------------------SIDEBAR BUTTONS-----------------------------------------------------------
        private void orderHistoryBtn_Click(object sender, EventArgs e)
        {

            stockPanel.Visible = false; // Hide stock panel
            //ordeerHistoryPanelMD.Visible = true; // Show order history panel
            //ordeerHistoryPanelMD.BringToFront(); // Bring order history panel to front

            // This method is called when the "Order History" button is clicked
            string searchTerm = orderHistorySearchBox.Text.Trim();

            DataAccess db = new DataAccess();
            DataTable dt;

            if (string.IsNullOrEmpty(searchTerm))
            {
                dt = db.GetAllOrders();  // Load all orders when search is empty
            }
            else
            {
                dt = db.searchOrderHistory(searchTerm); // Search based on the term
            }

            stockHistoryGrid.DataSource = dt;
        }

        private void stockBtn_Click(object sender, EventArgs e)
        {
            stockPanel.Visible = true; // Show stock panel
            //ordeerHistoryPanelMD.Visible = false; // Hide order history panel
            stockPanel.BringToFront(); // Bring stock panel to front
        }






        private void orderHistorySearchBtn_Click(object sender, EventArgs e)
        {
            string searchTerm = orderHistorySearchBox.Text.Trim();

            DataAccess db = new DataAccess();
            DataTable dt;

            if (string.IsNullOrEmpty(searchTerm))
            {
                dt = db.GetAllOrders();  // Load all orders when search is empty
            }
            else
            {
                dt = db.searchOrderHistory(searchTerm); // Search based on the term
            }

            stockHistoryGrid.DataSource = dt;
        }

        private void LoadStockHistory()
        {
            DataAccess db = new DataAccess();
            DataTable orderData = db.GetAllOrders();

            stockHistoryGrid.DataSource = orderData;

            // Optional: Disable sorting for all columns
            foreach (DataGridViewColumn column in stockHistoryGrid.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void orderHistoryShowBtn_Click(object sender, EventArgs e)
        {

            LoadStockHistory(); // Reload all order history
            orderHistorySearchBox.Clear(); // Clear search box
            stockHistoryGrid.ClearSelection(); // Clear any selected rows
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            using (Pen pen = new Pen(Color.LightGray, 1)) // 1 pixel thick
            {
                int y = panel2.ClientRectangle.Height - 1; // Bottom Y position
                e.Graphics.DrawLine(pen, 0, y, panel2.ClientRectangle.Width, y); // Horizontal line
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            using (Pen pen = new Pen(Color.LightGray, 1)) // 20 pixels thick
            {
                int x = panel1.ClientRectangle.Right - 10; // Adjust to be inside the panel
                e.Graphics.DrawLine(pen, x, 0, x, panel1.ClientRectangle.Height);
            }
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide current dashboard
            Login loginForm = new Login();
            loginForm.Show(); // Show login form
        }
        //Load Menu items
        private void LoadMenuItems()
        {
            DataAccess db = new DataAccess();
            DataTable menuItems = db.GetAllMenuItems(); // Create this method in DataAccess
            DataTable stockItems = db.GetAllMenuStockItems();

            allMenuItems = stockItems; // Store for sorting

            //Menu items shows on the stocks Grid
            stockGridView.DataSource = stockItems;



        }

        private void stockSearchBtn_Click(object sender, EventArgs e)
        {
            string searchTerm = stockSearchBox.Text.Trim();

            if (string.IsNullOrEmpty(searchTerm))
            {
                LoadMenuItems(); // Show all items if search is empty
                return;
            }

            DataAccess db = new DataAccess();
            db.SearchStockMenuItemsByName(searchTerm);
            DataTable filteredItems = db.SearchStockMenuItemsByName(searchTerm);

            if (filteredItems.Rows.Count == 0)
            {
                MessageBox.Show("No matching items found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            stockGridView.DataSource = filteredItems;
        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            LoadMenuItems();
        }

        private void stockSortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (allMenuItems == null) return;

            string selectedSort = stockSortComboBox.SelectedItem.ToString();

            if (selectedSort == "Low to High")
            {
                // Sort ascending by Price
                DataView dv = allMenuItems.DefaultView;
                dv.Sort = "Price ASC";
                stockGridView.DataSource = dv.ToTable();
            }
            else if (selectedSort == "High to Low")
            {
                // Sort descending by Price
                DataView dv = allMenuItems.DefaultView;
                dv.Sort = "Price DESC";
                stockGridView.DataSource = dv.ToTable();
            }
            else
            {
                // "Sort by" selected, show original unsorted data
                stockGridView.DataSource = allMenuItems;
            }
        }
    }
}
