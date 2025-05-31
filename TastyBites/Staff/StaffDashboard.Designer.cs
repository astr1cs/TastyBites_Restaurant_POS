using System.Windows.Forms;

namespace TastyBites.Staff
{
    partial class StaffDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffDashboard));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            FavIcon = new PictureBox();
            staffOrderGrid = new DataGridView();
            placeOrderBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            comboBox1 = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            label8 = new Label();
            palestineTextBox = new TextBox();
            roleNameLabel = new Label();
            Staff = new Label();
            dataGridView2 = new DataGridView();
            logoutBtn = new Button();
            staffSearchBox = new TextBox();
            panel1 = new Panel();
            staffDataGrid = new DataGridView();
            staffAllMenuBtn = new Button();
            staffSearchBtn = new Button();
            label9 = new Label();
            staffPriceSortComboBox = new ComboBox();
            staffCategoryComboBox = new ComboBox();
            staffOrderListBox = new ListBox();
            ((System.ComponentModel.ISupportInitialize)FavIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)staffOrderGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)staffDataGrid).BeginInit();
            SuspendLayout();
            // 
            // FavIcon
            // 
            FavIcon.Image = (Image)resources.GetObject("FavIcon.Image");
            FavIcon.Location = new Point(0, 0);
            FavIcon.Name = "FavIcon";
            FavIcon.Size = new Size(136, 72);
            FavIcon.TabIndex = 0;
            FavIcon.TabStop = false;
            // 
            // staffOrderGrid
            // 
            staffOrderGrid.BackgroundColor = SystemColors.ButtonFace;
            staffOrderGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            staffOrderGrid.Location = new Point(756, 69);
            staffOrderGrid.Name = "staffOrderGrid";
            staffOrderGrid.Size = new Size(240, 662);
            staffOrderGrid.TabIndex = 1;
            staffOrderGrid.CellContentClick += staffOrderGrid_CellContentClick;
            // 
            // placeOrderBtn
            // 
            placeOrderBtn.BackColor = Color.FromArgb(27, 160, 154);
            placeOrderBtn.Location = new Point(780, 671);
            placeOrderBtn.Name = "placeOrderBtn";
            placeOrderBtn.Size = new Size(201, 31);
            placeOrderBtn.TabIndex = 2;
            placeOrderBtn.Text = "Place Order";
            placeOrderBtn.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(781, 91);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 3;
            label1.Text = "Order Items";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(780, 406);
            label2.Name = "label2";
            label2.Size = new Size(108, 15);
            label2.TabIndex = 4;
            label2.Text = "Payment Summery";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(766, 596);
            label3.Name = "label3";
            label3.Size = new Size(99, 15);
            label3.TabIndex = 5;
            label3.Text = "Payment Method";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(766, 625);
            radioButton1.Name = "radioButton1";
            radioButton1.Padding = new Padding(10, 0, 10, 0);
            radioButton1.Size = new Size(71, 19);
            radioButton1.TabIndex = 6;
            radioButton1.TabStop = true;
            radioButton1.Text = "Cash";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(843, 625);
            radioButton2.Name = "radioButton2";
            radioButton2.Padding = new Padding(10, 0, 10, 0);
            radioButton2.Size = new Size(70, 19);
            radioButton2.TabIndex = 7;
            radioButton2.TabStop = true;
            radioButton2.Text = "Card";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Dine-in", "Takeway" });
            comboBox1.Location = new Point(919, 624);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(69, 23);
            comboBox1.TabIndex = 8;
            comboBox1.Text = "Dine-in";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(780, 444);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 9;
            label4.Text = "Subtotal";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(929, 444);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 10;
            label5.Text = "$58.68";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(780, 471);
            label8.Name = "label8";
            label8.Size = new Size(124, 15);
            label8.TabIndex = 13;
            label8.Text = "Donation for Palestine";
            // 
            // palestineTextBox
            // 
            palestineTextBox.Location = new Point(929, 468);
            palestineTextBox.Name = "palestineTextBox";
            palestineTextBox.Size = new Size(52, 23);
            palestineTextBox.TabIndex = 15;
            palestineTextBox.Text = "$10.89";
            // 
            // roleNameLabel
            // 
            roleNameLabel.AutoSize = true;
            roleNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roleNameLabel.Location = new Point(809, 9);
            roleNameLabel.Name = "roleNameLabel";
            roleNameLabel.Padding = new Padding(10, 0, 10, 0);
            roleNameLabel.Size = new Size(20, 21);
            roleNameLabel.TabIndex = 16;
            // 
            // Staff
            // 
            Staff.AutoSize = true;
            Staff.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Staff.Location = new Point(811, 30);
            Staff.Name = "Staff";
            Staff.Padding = new Padding(10, 0, 10, 0);
            Staff.Size = new Size(54, 17);
            Staff.TabIndex = 17;
            Staff.Text = "Staff";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(0, 69);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(150, 662);
            dataGridView2.TabIndex = 18;
            // 
            // logoutBtn
            // 
            logoutBtn.BackColor = Color.FromArgb(27, 160, 154);
            logoutBtn.Location = new Point(12, 679);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.Size = new Size(124, 23);
            logoutBtn.TabIndex = 19;
            logoutBtn.Text = "Logout";
            logoutBtn.UseVisualStyleBackColor = false;
            logoutBtn.Click += logoutBtn_Click;
            // 
            // staffSearchBox
            // 
            staffSearchBox.Location = new Point(0, 3);
            staffSearchBox.Name = "staffSearchBox";
            staffSearchBox.Size = new Size(429, 23);
            staffSearchBox.TabIndex = 20;
            // 
            // panel1
            // 
            panel1.Controls.Add(staffDataGrid);
            panel1.Controls.Add(staffAllMenuBtn);
            panel1.Controls.Add(staffSearchBtn);
            panel1.Controls.Add(staffSearchBox);
            panel1.Location = new Point(156, 69);
            panel1.Name = "panel1";
            panel1.Size = new Size(594, 662);
            panel1.TabIndex = 21;
            // 
            // staffDataGrid
            // 
            staffDataGrid.AllowUserToAddRows = false;
            staffDataGrid.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.BackColor = Color.WhiteSmoke;
            staffDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            staffDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            staffDataGrid.BackgroundColor = SystemColors.ButtonFace;
            staffDataGrid.BorderStyle = BorderStyle.None;
            staffDataGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.LightSteelBlue;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            staffDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            staffDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            staffDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            staffDataGrid.EnableHeadersVisualStyles = false;
            staffDataGrid.GridColor = Color.LightGray;
            staffDataGrid.Location = new Point(0, 32);
            staffDataGrid.MultiSelect = false;
            staffDataGrid.Name = "staffDataGrid";
            staffDataGrid.ReadOnly = true;
            staffDataGrid.RowHeadersVisible = false;
            staffDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            staffDataGrid.Size = new Size(594, 630);
            staffDataGrid.TabIndex = 23;
            staffDataGrid.CellClick += staffDataGrid_CellClick;
            staffDataGrid.CellContentClick += dataGridView3_CellContentClick;
            // 
            // staffAllMenuBtn
            // 
            staffAllMenuBtn.Location = new Point(516, 3);
            staffAllMenuBtn.Name = "staffAllMenuBtn";
            staffAllMenuBtn.Size = new Size(75, 23);
            staffAllMenuBtn.TabIndex = 22;
            staffAllMenuBtn.Text = "All Menu";
            staffAllMenuBtn.UseVisualStyleBackColor = true;
            staffAllMenuBtn.Click += staffAllMenuBtn_Click_1;
            // 
            // staffSearchBtn
            // 
            staffSearchBtn.Location = new Point(435, 3);
            staffSearchBtn.Name = "staffSearchBtn";
            staffSearchBtn.Size = new Size(75, 23);
            staffSearchBtn.TabIndex = 21;
            staffSearchBtn.Text = "Search";
            staffSearchBtn.UseVisualStyleBackColor = true;
            staffSearchBtn.Click += staffSearchBtn_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 125);
            label9.Name = "label9";
            label9.Size = new Size(41, 15);
            label9.TabIndex = 22;
            label9.Text = "Filters:";
            // 
            // staffPriceSortComboBox
            // 
            staffPriceSortComboBox.FormattingEnabled = true;
            staffPriceSortComboBox.Items.AddRange(new object[] { "Sort By Default", "Low to High", "High to Low" });
            staffPriceSortComboBox.Location = new Point(12, 157);
            staffPriceSortComboBox.Name = "staffPriceSortComboBox";
            staffPriceSortComboBox.Size = new Size(121, 23);
            staffPriceSortComboBox.TabIndex = 23;
            // 
            // staffCategoryComboBox
            // 
            staffCategoryComboBox.FormattingEnabled = true;
            staffCategoryComboBox.Items.AddRange(new object[] { "Drinks", "Main", "Dessert" });
            staffCategoryComboBox.Location = new Point(12, 197);
            staffCategoryComboBox.Name = "staffCategoryComboBox";
            staffCategoryComboBox.Size = new Size(121, 23);
            staffCategoryComboBox.TabIndex = 24;
            // 
            // staffOrderListBox
            // 
            staffOrderListBox.Font = new Font("MS Reference Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            staffOrderListBox.FormattingEnabled = true;
            staffOrderListBox.Location = new Point(780, 126);
            staffOrderListBox.Name = "staffOrderListBox";
            staffOrderListBox.Size = new Size(208, 260);
            staffOrderListBox.TabIndex = 25;
            // 
            // StaffDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 729);
            Controls.Add(staffOrderListBox);
            Controls.Add(staffCategoryComboBox);
            Controls.Add(staffPriceSortComboBox);
            Controls.Add(label9);
            Controls.Add(panel1);
            Controls.Add(logoutBtn);
            Controls.Add(dataGridView2);
            Controls.Add(Staff);
            Controls.Add(roleNameLabel);
            Controls.Add(palestineTextBox);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(placeOrderBtn);
            Controls.Add(staffOrderGrid);
            Controls.Add(FavIcon);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "StaffDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Staff";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)FavIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)staffOrderGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)staffDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox FavIcon;
        private DataGridView staffOrderGrid;
        private Button placeOrderBtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private ComboBox comboBox1;
        private Label label4;
        private Label label5;
        private Label label8;
        private TextBox palestineTextBox;
        private Label roleNameLabel;
        private Label Staff;
        private DataGridView dataGridView2;
        private Button logoutBtn;
        private TextBox staffSearchBox;
        private Panel panel1;
        private DataGridView staffDataGrid;
        private Button staffAllMenuBtn;
        private Button staffSearchBtn;
        private Label label9;
        private ComboBox staffPriceSortComboBox;
        private ComboBox staffCategoryComboBox;
        private ListBox staffOrderListBox;
    }
}