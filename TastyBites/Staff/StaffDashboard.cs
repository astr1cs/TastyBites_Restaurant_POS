using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TastyBites.Models;
namespace TastyBites.Staff
{
    public partial class StaffDashboard : Form
    {
        private User currentUser;
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
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login loginForm = new Login(); 
            loginForm.Show();
        }
    }
}
