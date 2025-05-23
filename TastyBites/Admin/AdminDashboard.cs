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

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
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
        //Data grids For User Management





        private void userTableGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void manageUserBtn_Click(object sender, EventArgs e)
        {
            userPanel.Visible = true;
            stockPanel.Visible = false;
            menuPanel.Visible = false;
            dataPanel.Visible = false;
        }

        private void menuBtn_Click(object sender, EventArgs e)
        {
            userPanel.Visible = false;
            menuPanel.Visible = true;
            stockPanel.Visible = false;
            dataPanel.Visible = false;
        }

        private void stockBtn_Click(object sender, EventArgs e)
        {
            userPanel.Visible = false;
            dataPanel.Visible = false;
            menuPanel.Visible = false;
            stockPanel.Visible = true;

        }

        private void dataBtn_Click(object sender, EventArgs e)
        {
            userPanel.Visible = false;
            menuPanel.Visible = false;
            stockPanel.Visible = false;
            dataPanel.Visible = true;
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
    }
}
