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

namespace TastyBites
{
    public partial class AdminDashboard : Form
    {
        private User currentUser;
        private DataTable allMenuItems;


        public AdminDashboard()
        {
            InitializeComponent();
        }
        public AdminDashboard(User user)
        {
            InitializeComponent();
            currentUser = user;
            userName.Text = user.Username;
            this.Load += AdminDashboard_Load;
            // You can show the role or other details if needed
            //roleLabel.Text = "Role: " + user.Role;
        }
        //-------------------------------------------------FUNCTIONS-----------------------------------
        //Load USer Grid View
        private void LoadUsersIntoGrid()
        {
            DataAccess db = new DataAccess();
            DataTable users = db.GetAllUsers();

            userTableGrid.DataSource = users;

            // Optional: adjust columns
            userTableGrid.Columns["UserID"].HeaderText = "User ID";
            userTableGrid.Columns["Username"].HeaderText = "Username";
            userTableGrid.Columns["Password"].HeaderText = "Password";
            userTableGrid.Columns["Role"].HeaderText = "Role";
            userTableGrid.Columns["Password"].Visible = false;

        }
        //Load all categories into the dropdown menu
        private void LoadCategoriesIntoDropdown()
        {
            DataAccess db = new DataAccess();
            DataTable categories = db.GetAllCategories();

            categoryComboBox.DataSource = categories;
            categoryComboBox.DisplayMember = "CategoryName";
            categoryComboBox.ValueMember = "CategoryID";
        }
        //Load Menu items
        private void LoadMenuItems()
        {
            DataAccess db = new DataAccess();
            DataTable menuItems = db.GetAllMenuItems(); // Create this method in DataAccess
            DataTable stockItems = db.GetAllMenuStockItems();

            allMenuItems = stockItems; // Store for sorting
            //Menu Items shows on the Menu Grid
            menuGrid.DataSource = menuItems;
            //Menu items shows on the stocks Grid
            stockGridView.DataSource = stockItems;



        }


        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            LoadCategoriesIntoDropdown();
            LoadMenuItems();
            LoadUsersIntoGrid();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide current dashboard
            Login loginForm = new Login();
            loginForm.Show(); // Show login form
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }






        private void userTableGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void menuListBtn_Click(object sender, EventArgs e)
        {
            menuPanel.Visible = true;
            userPanel.Visible = false;
            stockPanel.Visible = false;
            dataPanel.Visible = false;
            menuPanel.BringToFront();
        }
        private void manageUserBtn_Click(object sender, EventArgs e)
        {
            userPanel.Visible = true;
            stockPanel.Visible = false;
            menuPanel.Visible = false;
            dataPanel.Visible = false;
            userPanel.BringToFront();
        }



        private void stockBtn_Click(object sender, EventArgs e)
        {
            userPanel.Visible = false;
            dataPanel.Visible = false;
            menuPanel.Visible = false;
            stockPanel.Visible = true;
            stockPanel.BringToFront();

        }

        private void dataBtn_Click(object sender, EventArgs e)
        {
            userPanel.Visible = false;
            menuPanel.Visible = false;
            stockPanel.Visible = false;
            dataPanel.Visible = true;
            dataPanel.BringToFront();
        }

        private void adminLabel_Click(object sender, EventArgs e)
        {

        }

        private void userName_Click(object sender, EventArgs e)
        {

        }

        private void addUser_Click(object sender, EventArgs e)
        {
            string username = userNameTextBox.Text.Trim();
            string password = passwordFieldBox.Text.Trim();
            string role = roleComboBox.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Please fill all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DataAccess db = new DataAccess();
                int result = db.InsertUser(username, password, role);

                if (result > 0)
                {
                    // 🔁 Refresh the DataGridView
                    LoadUsersIntoGrid();

                    // Optional: Clear fields after adding
                    userNameTextBox.Clear();
                    passwordFieldBox.Clear();
                    roleComboBox.SelectedIndex = 0;
                    MessageBox.Show("User added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to add user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void userTableGrid_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
        //----------------------------------------------**------------------------------
        //Delete User Button
        private void deleteUser_Click(object sender, EventArgs e)
        {
            if (userTableGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a user to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // first column is UserID
            int selectedUserId = Convert.ToInt32(userTableGrid.SelectedRows[0].Cells["UserID"].Value);

            DialogResult confirmResult = MessageBox.Show("Are you sure you want to delete this user?",
                                                         "Confirm Delete",
                                                         MessageBoxButtons.YesNo,
                                                         MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    DataAccess db = new DataAccess();
                    int result = db.DeleteUser(selectedUserId);

                    if (result > 0)
                    {
                        MessageBox.Show("User deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadUsersIntoGrid(); // Refresh the grid
                    }
                    else
                    {
                        MessageBox.Show("Delete failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //-----------------------------------------------**------------------------------
        //Edit User Button
        private void editUser_Click(object sender, EventArgs e)
        {


            if (userTableGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a user to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int userId = Convert.ToInt32(userTableGrid.SelectedRows[0].Cells["UserID"].Value);
            string username = userNameTextBox.Text.Trim();
            string password = passwordFieldBox.Text.Trim();
            string role = roleComboBox.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Please fill all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DataAccess db = new DataAccess();
                int result = db.UpdateUser(userId, username, password, role);

                if (result > 0)
                {
                    MessageBox.Show("User updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadUsersIntoGrid(); // Refresh
                }
                else
                {
                    MessageBox.Show("Update failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Editable User Table Grid View
        private void userTableGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (userTableGrid.SelectedRows.Count > 0)
            {
                var row = userTableGrid.SelectedRows[0];
                userNameTextBox.Text = row.Cells["Username"].Value.ToString();
                passwordFieldBox.Text = row.Cells["Password"].Value.ToString(); // If password is in grid
                roleComboBox.Text = row.Cells["Role"].Value.ToString();
            }

        }

        //Menu Item Add Button
        private void addMenuBtn_Click(object sender, EventArgs e)
        {
            string name = menuNameTextBox.Text.Trim();
            string description = menuDescriptionTextBox.Text.Trim(); // ✅ fix here
            decimal price;
            int stockQty;

            // Safely handle selected category ID
            if (categoryComboBox.SelectedValue == null)
            {
                MessageBox.Show("Please select a category.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedCategoryID = (int)categoryComboBox.SelectedValue;

            // Validate inputs
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(description) ||
                !decimal.TryParse(menuPriceTextBox.Text, out price) ||
                !int.TryParse(menuQuantityTextBox.Text, out stockQty))
            {
                MessageBox.Show("Please enter valid values for all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Insert data
            DataAccess db = new DataAccess();
            int result = db.InsertMenuItem(name, description, price, stockQty, selectedCategoryID);

            if (result > 0)
            {
                // Refresh category dropdown (not always needed here, but ok)
                LoadCategoriesIntoDropdown();
                LoadMenuItems(); // <-- Load the updated list into the grid
                // Clear fields
                menuNameTextBox.Clear();
                menuDescriptionTextBox.Clear();
                menuQuantityTextBox.Clear();
                menuPriceTextBox.Clear();
                categoryComboBox.SelectedIndex = 0;

                MessageBox.Show("Menu item added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to add menu item.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void deleteMenuBtn_Click(object sender, EventArgs e)
        {
            if (menuGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a menu item to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get the selected row's MenuItemID
            int menuItemId = Convert.ToInt32(menuGrid.SelectedRows[0].Cells["MenuItemID"].Value);

            // Confirm delete
            DialogResult confirm = MessageBox.Show("Are you sure you want to delete this menu item?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.No) return;

            // Call delete method
            DataAccess db = new DataAccess();
            int result = db.DeleteMenuItem(menuItemId);

            if (result > 0)
            {
                MessageBox.Show("Menu item deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadMenuItems(); //  Refresh the DataGridView
            }
            else
            {
                MessageBox.Show("Failed to delete menu item.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void editMenuBtn_Click(object sender, EventArgs e)
        {
            if (menuGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a menu item to update.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get ID of selected menu item
            int menuItemId = Convert.ToInt32(menuGrid.SelectedRows[0].Cells["MenuItemID"].Value);

            // Get values from input fields
            string name = menuNameTextBox.Text.Trim();
            string description = menuDescriptionTextBox.Text.Trim();
            decimal price;
            int stockQty;
            int categoryID = (int)categoryComboBox.SelectedValue;

            if (string.IsNullOrEmpty(name) || !decimal.TryParse(menuPriceTextBox.Text, out price) ||
                !int.TryParse(menuQuantityTextBox.Text, out stockQty))
            {
                MessageBox.Show("Please enter valid values for all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataAccess db = new DataAccess();
            int result = db.UpdateMenuItem(menuItemId, name, description, price, stockQty, categoryID);

            if (result > 0)
            {
                MessageBox.Show("Menu item updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadMenuItems(); // Refresh DataGridView
            }
            else
            {
                MessageBox.Show("Failed to update menu item.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void menuGrid_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void menuGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure it's not header row
            {
                DataGridViewRow row = menuGrid.Rows[e.RowIndex];

                // Set textboxes
                menuNameTextBox.Text = row.Cells["Name"].Value?.ToString() ?? "";
                menuDescriptionTextBox.Text = row.Cells["Description"].Value?.ToString() ?? "";
                menuPriceTextBox.Text = row.Cells["Price"].Value?.ToString() ?? "";
                menuQuantityTextBox.Text = row.Cells["StockQuantity"].Value?.ToString() ?? "";

                // Get CategoryName from grid
                string categoryName = row.Cells["CategoryName"].Value?.ToString();

                if (!string.IsNullOrEmpty(categoryName))
                {
                    // Find category in ComboBox datasource by CategoryName and select it
                    for (int i = 0; i < categoryComboBox.Items.Count; i++)
                    {
                        DataRowView drv = categoryComboBox.Items[i] as DataRowView;
                        if (drv != null && drv["CategoryName"].ToString() == categoryName)
                        {
                            categoryComboBox.SelectedIndex = i;
                            break;
                        }
                    }
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void menuSearchBox_TextChanged(object sender, EventArgs e)
        {

        }



        private void menuSearchBtn_Click(object sender, EventArgs e)
        {
            string searchTerm = menuSearchBox.Text.Trim();

            if (string.IsNullOrEmpty(searchTerm))
            {
                LoadMenuItems(); // Show all items if search is empty
                return;
            }

            DataAccess db = new DataAccess();
            DataTable filteredItems = db.SearchMenuItemsByName(searchTerm);

            if (filteredItems.Rows.Count == 0)
            {
                MessageBox.Show("No matching items found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            menuGrid.DataSource = filteredItems;
        }





        private void userSearchBtn_Click(object sender, EventArgs e)
        {
            string searchTerm = userSearchBox.Text.Trim();
            if (string.IsNullOrEmpty(searchTerm))
            {
                LoadUsersIntoGrid(); // Show all users if search is empty
                return;
            }
            DataAccess db = new DataAccess();
            DataTable filteredUsers = db.SearchUsersByUsername(searchTerm); // We'll create this
            if (filteredUsers.Rows.Count == 0)
            {
                MessageBox.Show("No matching users found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            userTableGrid.DataSource = filteredUsers;
        }

        private void stockGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
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

        private void button1_Click(object sender, EventArgs e)
        {
            LoadMenuItems();
        }

        private void stockSortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void stockSortComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
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

        private void userShowBtn_Click(object sender, EventArgs e)
        {
            LoadUsersIntoGrid();
        }

        private void menuPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

            using (Pen pen = new Pen(Color.LightGray, 1)) // 20 pixels thick
            {
                int x = panel1.ClientRectangle.Right - 10; // Adjust to be inside the panel
                e.Graphics.DrawLine(pen, x, 0, x, panel1.ClientRectangle.Height);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            using (Pen pen = new Pen(Color.LightGray, 1)) // 1 pixel thick
            {
                int y = panel2.ClientRectangle.Height - 1; // Bottom Y position
                e.Graphics.DrawLine(pen, 0, y, panel2.ClientRectangle.Width, y); // Horizontal line
            }
        }

    }
}
