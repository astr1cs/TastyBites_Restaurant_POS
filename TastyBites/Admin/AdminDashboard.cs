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
        private DataGridViewRow selectedMenuRow;



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

            stockSortComboBox.Text = "Sort By Default"; // Set default text for the combo box
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
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            LoadCategoriesIntoDropdown();
            LoadMenuItems();
            LoadUsersIntoGrid();
            LoadStockHistory();
            addUser.Visible = true;
            saveChangesButton.Visible = false;

            editMenuBtn.Visible = true;
            saveChangesMenu.Visible = false;

        }

        //-----------------------------------------------------------------BASIC BUTTONS WORKS--------------------------------------------
        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide current dashboard
            Login loginForm = new Login();
            loginForm.Show(); // Show login form
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

        //-------------------------------------------------------------------------USER MANAGEMENT--------------------------------------

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


        //EDIT USER BUTTOn
        private void editUser_Click(object sender, EventArgs e)
        {
            if (userTableGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a user to edit.");
                return;
            }

            var selectedRow = userTableGrid.SelectedRows[0];
            userNameTextBox.Text = selectedRow.Cells["Username"].Value.ToString();
            passwordFieldBox.Text = selectedRow.Cells["Password"].Value.ToString();
            roleComboBox.Text = selectedRow.Cells["Role"].Value.ToString();

            // Optional: Enable Save button after data is loaded
            saveChangesButton.Visible = true;

            saveChangesButton.Enabled = true;
            addUser.Visible = false; // Hide Add User button when editing   
        }
        //Save user changes
        private void saveChangesButton_Click(object sender, EventArgs e)
        {
            if (userTableGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a user.");
                return;
            }

            var selectedRow = userTableGrid.SelectedRows[0];
            int userId = Convert.ToInt32(selectedRow.Cells["UserID"].Value);
            string updatedUsername = userNameTextBox.Text.Trim();
            string updatedPassword = passwordFieldBox.Text.Trim();
            string updatedRole = roleComboBox.Text.Trim();

            if (string.IsNullOrEmpty(updatedUsername) || string.IsNullOrEmpty(updatedPassword) || string.IsNullOrEmpty(updatedRole))
            {
                MessageBox.Show("All fields are required.");
                return;
            }

            DataAccess db = new DataAccess();
            int result = db.UpdateUser(userId, updatedUsername, updatedPassword, updatedRole);


            if (result > 0)
            {
                MessageBox.Show("User updated successfully.");
                LoadUsersIntoGrid();


                // After successful save:
                addUser.Visible = true;
                saveChangesButton.Visible = false;
                ClearFieldsUserPanel();
            }
            else
            {
                MessageBox.Show("Update failed.");
            }
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

        private void userShowBtn_Click(object sender, EventArgs e)
        {
            LoadUsersIntoGrid();
        }


        //---------------------------------------------------------------------<MENU FUNCTIONS>--------------------------------------------------//////
        private void menuShowDetailsBtn_Click(object sender, EventArgs e)
        {
            LoadMenuItems();
        }
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
                MessageBox.Show("Menu item updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadMenuItems(); // Refresh DataGridView

                SetMenuInputsReadOnly(true);
                editMenuBtn.Visible = true;
                saveChangesMenu.Visible = false;
            }
            else
            {
                MessageBox.Show("Failed to delete menu item.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //MENU FUNCIONS
        private void SetMenuInputsReadOnly(bool isReadOnly)
        {
            menuNameTextBox.ReadOnly = isReadOnly;
            menuDescriptionTextBox.ReadOnly = isReadOnly;
            menuPriceTextBox.ReadOnly = isReadOnly;
            menuQuantityTextBox.ReadOnly = isReadOnly;
            categoryComboBox.Enabled = !isReadOnly;
        }

        //EDIT MENU BUTTON
        private void editMenuBtn_Click(object sender, EventArgs e)
        {
            if (selectedMenuRow == null)
            {
                MessageBox.Show("Please select a menu item to edit.");
                return;
            }

            // Populate the text fields with selected row data
            menuNameTextBox.Text = selectedMenuRow.Cells["Name"].Value?.ToString();
            menuDescriptionTextBox.Text = selectedMenuRow.Cells["Description"].Value?.ToString();
            menuPriceTextBox.Text = selectedMenuRow.Cells["Price"].Value?.ToString();
            menuQuantityTextBox.Text = selectedMenuRow.Cells["StockQuantity"].Value?.ToString();

            string categoryName = selectedMenuRow.Cells["CategoryName"].Value?.ToString();
            if (!string.IsNullOrEmpty(categoryName))
            {
                for (int i = 0; i < categoryComboBox.Items.Count; i++)
                {
                    if (categoryComboBox.Items[i] is DataRowView drv &&
                        drv["CategoryName"].ToString() == categoryName)
                    {
                        categoryComboBox.SelectedIndex = i;
                        break;
                    }
                }
            }

            // Enable editing
            SetMenuInputsReadOnly(false);
            saveChangesMenu.Visible = true; ;
            editMenuBtn.Visible = false;
        }

        //SAVE CHANGES MENU BUTTON
        private void saveChangesMenu_Click(object sender, EventArgs e)
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
                SetMenuInputsReadOnly(false);
                editMenuBtn.Visible = true;
                saveChangesMenu.Visible = false;
            }
            else
            {
                MessageBox.Show("Failed to update menu item.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        //MENU GRID SELECTION CHANGED
        private void menuGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (menuGrid.SelectedRows.Count > 0)
            {
                selectedMenuRow = menuGrid.SelectedRows[0];

                // Clear and lock all inputs
                menuNameTextBox.Clear();
                menuDescriptionTextBox.Clear();
                menuPriceTextBox.Clear();
                menuQuantityTextBox.Clear();
                categoryComboBox.SelectedIndex = -1;

                SetMenuInputsReadOnly(true);
                editMenuBtn.Enabled = true;
                editMenuBtn.Visible = true;
                saveChangesMenu.Visible = false;
            }
        }
        //MENU GRID CELL CLICK
        private void menuGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                // Just store the selected row for later use
                selectedMenuRow = menuGrid.Rows[e.RowIndex];

                // Clear UI (optional)
                menuNameTextBox.Clear();
                menuDescriptionTextBox.Clear();
                menuPriceTextBox.Clear();
                menuQuantityTextBox.Clear();
                categoryComboBox.SelectedIndex = -1;

                //SetMenuInputsReadOnly(true);
                //editMenuBtn.Visible = true;
                //saveChangesMenu.Visible = false;
            }
        }


        //MENU SEARCH FUNCTION

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

        //------------------------------------------------------------------------STOCK MANAGEMENT FUNCTIONS--------------------------------------
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


        //-------------------------------------------------------------------------SIDE PANEL BORDER PAINT FUNCTIONS--------------------------------------
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


        //User panel clear fields function
        private void ClearFieldsUserPanel()
        {
            userNameTextBox.Text = "";
            passwordFieldBox.Text = "";
            roleComboBox.SelectedIndex = -1;
        }


        //---------------------------------------------------------------------<ORDER History FUNCTIONS>--------------------------------------------------//////
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

        private void orderHistoryShowBtn_Click(object sender, EventArgs e)
        {

            LoadStockHistory(); // Reload all order history
            orderHistorySearchBox.Clear(); // Clear search box
            stockHistoryGrid.ClearSelection(); // Clear any selected rows
        }

        private void AdminDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }

}
