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
    }
}
