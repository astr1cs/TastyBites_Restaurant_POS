using System;
using System.Windows.Forms;
using TastyBites.Database;
using TastyBites.Models;
using TastyBites.Staff;

using TastyBites.Manager;
namespace TastyBites
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            //this.Icon = new Icon("../favIcico.ico");
            //this.Icon = Properties.Resources.favIcico;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = userNameField.Text.Trim();
            string password = passwordField.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            try
            {
                DataAccess db = new DataAccess();
                User user = db.AuthenticateUser(username, password);

                if (user != null)
                {
                    MessageBox.Show("Login successful! Role: " + user.Role);

                    // Route based on role
                    if (user.Role == "Admin")
                    {
                        AdminDashboard admin = new AdminDashboard(user);
                        admin.Show();
                    }
                    else if (user.Role == "Manager")
                    {
                   managerDashboard manager = new managerDashboard(user);       
                        manager.Show();
                    }
                    else if (user.Role == "Staff")
                    {
                        StaffDashboard staff = new StaffDashboard(user);
                        staff.Show();
                    }

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid credentials.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void passwordField_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
