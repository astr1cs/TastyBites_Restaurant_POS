using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using TastyBites.Database;
using TastyBites.Models;
using iTextSharp.text;
using iTextSharp.text.pdf;


namespace TastyBites.Manager
{

    public partial class managerDashboard : Form
    {
        private DataTable allMenuItems;
        public managerDashboard()
        {
            InitializeComponent();
        }
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

        private void managerDashboard_Load(object sender, EventArgs e)
        {
            LoadStockHistory(); // Load stock history on form load
            LoadMenuItems(); // Load menu items on form load
            generatePanel.Visible = false;
            stockPanel.Visible = false;
            orderHistoryPanelMD.Visible = true;
        }
        //-----------------------------------------------------------SIDEBAR BUTTONS-----------------------------------------------------------
        private void orderHistoryBtn_Click(object sender, EventArgs e)
        {

            stockPanel.Visible = false; // Hide stock panel
            generatePanel.Visible = false;
            orderHistoryPanelMD.Visible = true; // Show order history panel
            orderHistoryPanelMD.BringToFront(); // Bring order history panel to front

            // This method is called when the "Order History" button is clicked
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

        private void stockBtn_Click(object sender, EventArgs e)
        {
            stockPanel.Visible = true; // Show stock panel
            generatePanel.Visible = false;
            orderHistoryPanelMD.Visible = false; // Hide order history panel
            stockPanel.BringToFront(); // Bring stock panel to front
        }

        private void generateBtn_Click(object sender, EventArgs e)
        {
            stockPanel.Visible = false;
            orderHistoryPanelMD.Visible = false;
            generatePanel.Visible = true;
            generatePanel.BringToFront(); // Bring generate panel to front  



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

        private void orderHistoryShowBtn_Click(object sender, EventArgs e)
        {

            LoadStockHistory(); // Reload all order history
            orderHistorySearchBox.Clear(); // Clear search box
            stockHistoryGrid.ClearSelection(); // Clear any selected rows
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            using (Pen pen = new Pen(Color.LightGray, 1)) // 1 pixel thick
            {
                int y = panel2.ClientRectangle.Height - 1; // Bottom Y position
                e.Graphics.DrawLine(pen, 0, y, panel2.ClientRectangle.Width, y); // Horizontal line
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            using (Pen pen = new Pen(Color.LightGray, 1)) // 20 pixels thick
            {
                int x = panel1.ClientRectangle.Right - 10; // Adjust to be inside the panel
                e.Graphics.DrawLine(pen, x, 0, x, panel1.ClientRectangle.Height);
            }
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide current dashboard
            Login loginForm = new Login();
            loginForm.Show(); // Show login form
        }
        //Load Menu items
        private void LoadMenuItems()
        {
            DataAccess db = new DataAccess();
            DataTable menuItems = db.GetAllMenuItems(); // Create this method in DataAccess
            DataTable stockItems = db.GetAllMenuStockItems();

            allMenuItems = stockItems; // Store for sorting

            //Menu items shows on the stocks Grid
            stockGridView.DataSource = stockItems;



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

        private void showBtn_Click(object sender, EventArgs e)
        {
            LoadMenuItems();
        }

        private void stockSortComboBox_SelectedIndexChanged(object sender, EventArgs e)
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

        private void genBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime startDate = dateTimePickerStart.Value.Date;
                DateTime endDate = dateTimePickerEnd.Value.Date;

                if (endDate < startDate)
                {
                    MessageBox.Show("End date must be after start date.", "Invalid Date Range", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DataAccess db = new DataAccess();
                DataTable filteredTable = db.GetOrdersByDateRange(startDate, endDate);

                if (filteredTable == null || filteredTable.Rows.Count == 0)
                {
                    MessageBox.Show("No orders found in the selected date range.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                SaveFileDialog saveDialog = new SaveFileDialog
                {
                    Filter = "PDF Files|*.pdf",
                    FileName = $"OrderHistory_{startDate:yyyyMMdd}_to_{endDate:yyyyMMdd}.pdf"
                };

                if (saveDialog.ShowDialog() != DialogResult.OK)
                    return;

                // Create PDF document
                iTextSharp.text.Document doc = new iTextSharp.text.Document(iTextSharp.text.PageSize.A4);
                doc.SetMargins(10f, 10f, 10f, 10f);

                PdfWriter.GetInstance(doc, new FileStream(saveDialog.FileName, FileMode.Create));
                doc.Open();

                // Title
                Paragraph title = new Paragraph("Order History Report")
                {
                    Alignment = Element.ALIGN_CENTER,
                    SpacingAfter = 15f
                };
                doc.Add(title);

                // Date range subtitle
                Paragraph dateRange = new Paragraph($"From: {startDate:yyyy-MM-dd}  To: {endDate:yyyy-MM-dd}")
                {
                    Alignment = Element.ALIGN_CENTER,
                    SpacingAfter = 15f
                };
                doc.Add(dateRange);

                // Create PDF table with same columns as DataTable
                PdfPTable table = new PdfPTable(filteredTable.Columns.Count)
                {
                    WidthPercentage = 100
                };

                // Add header cells
                foreach (DataColumn column in filteredTable.Columns)
                {
                    PdfPCell headerCell = new PdfPCell(new Phrase(column.ColumnName))
                    {
                        BackgroundColor = BaseColor.LIGHT_GRAY
                    };
                    table.AddCell(headerCell);
                }

                // Add data rows
                foreach (DataRow row in filteredTable.Rows)
                {
                    foreach (object item in row.ItemArray)
                    {
                        table.AddCell(item?.ToString() ?? "");
                    }
                }

                doc.Add(table);
                doc.Close();

                MessageBox.Show("PDF Generated Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while generating PDF:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
