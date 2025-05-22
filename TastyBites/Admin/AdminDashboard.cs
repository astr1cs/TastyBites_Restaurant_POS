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

namespace TastyBites
{
    public partial class AdminDashboard : Form
    {
        private User currentUser;
        public AdminDashboard()
        {
            InitializeComponent();
        }
        public AdminDashboard(User user )
        {
            InitializeComponent();
            currentUser = user;
            usernameLabel.Text = "Username: " + user.Username;
            // You can show the role or other details if needed
            //roleLabel.Text = "Role: " + user.Role;
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
