namespace TastyBites
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
            Console.WriteLine("Main running");
            //MessageBox.Show("Hello, World!");
        }
    }
}
//using System;
//using System.Data.SqlClient;

//class Program
//{
//    static void Main()
//    {
//        string connectionString = @"Data Source=DESKTOP-U6CD3IB;Initial Catalog=Demo;Integrated Security=True";

//        try
//        {
//            using (SqlConnection con = new SqlConnection(connectionString))
//            {
//                con.Open();
//                Console.WriteLine("Connection Successful!");
//                MessageBox.Show("Connection Successful!");
//                con.Close();
//            }
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine("Connection Failed!");
//            Console.WriteLine(ex.Message);
//        }
//    }
//}
