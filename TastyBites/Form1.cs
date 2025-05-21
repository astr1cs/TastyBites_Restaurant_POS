using System;
using System.Windows.Forms;
using WFAManagementPro;   // add this so DataAccess is recognized

namespace TastyBites
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
                int rows = db.InsertUser(username, password); 

                if (rows > 0)
                    MessageBox.Show("User inserted successfully!");
                else
                    MessageBox.Show("Insertion failed.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
