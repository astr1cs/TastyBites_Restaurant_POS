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
            userTableGrid.Columns["Role"].HeaderText = "Role";
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



        private void manageUserBtn_Click(object sender, EventArgs e)
        {

        }

        private void userTableGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
