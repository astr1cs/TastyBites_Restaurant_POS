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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffDashboard));
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            FavIcon = new PictureBox();
            placeOrderBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cashRadio = new RadioButton();
            cardRadio = new RadioButton();
            takeaWayCombo = new ComboBox();
            label4 = new Label();
            label8 = new Label();
            palestineTextBox = new TextBox();
            roleNameLabel = new Label();
            Staff = new Label();
            staffSearchBox = new TextBox();
            panel1 = new Panel();
            staffDataGrid = new DataGridView();
            staffAllMenuBtn = new Button();
            staffSearchBtn = new Button();
            label9 = new Label();
            staffPriceSortComboBox = new ComboBox();
            staffCategoryComboBox = new ComboBox();
            contextMenu = new ContextMenuStrip(components);
            removeItem = new ToolStripMenuItem();
            subTotalBox = new TextBox();
            logoutBtn = new Button();
            panel3 = new Panel();
            panel2 = new Panel();
            staffOrderGridBox = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)FavIcon).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)staffDataGrid).BeginInit();
            contextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)staffOrderGridBox).BeginInit();
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
            // placeOrderBtn
            // 
            placeOrderBtn.BackColor = Color.FromArgb(27, 160, 154);
            placeOrderBtn.ForeColor = Color.White;
            placeOrderBtn.Location = new Point(769, 658);
            placeOrderBtn.Name = "placeOrderBtn";
            placeOrderBtn.Size = new Size(201, 31);
            placeOrderBtn.TabIndex = 2;
            placeOrderBtn.Text = "Place Order";
            placeOrderBtn.UseVisualStyleBackColor = false;
            placeOrderBtn.Click += placeOrderBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(770, 90);
            label1.Name = "label1";
            label1.Size = new Size(83, 16);
            label1.TabIndex = 3;
            label1.Text = "Order Items";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MS Reference Sans Serif", 11.25F);
            label2.Location = new Point(769, 424);
            label2.Name = "label2";
            label2.Size = new Size(153, 19);
            label2.TabIndex = 4;
            label2.Text = "Payment Summery";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(770, 577);
            label3.Name = "label3";
            label3.Size = new Size(99, 15);
            label3.TabIndex = 5;
            label3.Text = "Payment Method";
            // 
            // cashRadio
            // 
            cashRadio.AutoSize = true;
            cashRadio.Location = new Point(769, 606);
            cashRadio.Name = "cashRadio";
            cashRadio.Padding = new Padding(10, 0, 10, 0);
            cashRadio.Size = new Size(71, 19);
            cashRadio.TabIndex = 6;
            cashRadio.TabStop = true;
            cashRadio.Text = "Cash";
            cashRadio.UseVisualStyleBackColor = true;
            // 
            // cardRadio
            // 
            cardRadio.AutoSize = true;
            cardRadio.Location = new Point(838, 607);
            cardRadio.Name = "cardRadio";
            cardRadio.Padding = new Padding(10, 0, 10, 0);
            cardRadio.Size = new Size(70, 19);
            cardRadio.TabIndex = 7;
            cardRadio.TabStop = true;
            cardRadio.Text = "Card";
            cardRadio.UseVisualStyleBackColor = true;
            // 
            // takeaWayCombo
            // 
            takeaWayCombo.FormattingEnabled = true;
            takeaWayCombo.Items.AddRange(new object[] { "Dine-in", "Takeway" });
            takeaWayCombo.Location = new Point(914, 606);
            takeaWayCombo.Name = "takeaWayCombo";
            takeaWayCombo.Size = new Size(69, 23);
            takeaWayCombo.TabIndex = 8;
            takeaWayCombo.Text = "Dine-in";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("MS Reference Sans Serif", 11.25F);
            label4.Location = new Point(769, 461);
            label4.Name = "label4";
            label4.Size = new Size(78, 19);
            label4.TabIndex = 9;
            label4.Text = "Subtotal:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("MS Reference Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(770, 493);
            label8.Name = "label8";
            label8.Size = new Size(138, 15);
            label8.TabIndex = 13;
            label8.Text = "Donation for Palestine:";
            // 
            // palestineTextBox
            // 
            palestineTextBox.Font = new Font("MS Reference Sans Serif", 8.25F);
            palestineTextBox.Location = new Point(908, 490);
            palestineTextBox.Name = "palestineTextBox";
            palestineTextBox.RightToLeft = RightToLeft.Yes;
            palestineTextBox.Size = new Size(77, 21);
            palestineTextBox.TabIndex = 15;
            palestineTextBox.Text = "$10.89";
            // 
            // roleNameLabel
            // 
            roleNameLabel.AutoSize = true;
            roleNameLabel.Font = new Font("MS Reference Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roleNameLabel.Location = new Point(807, 9);
            roleNameLabel.Name = "roleNameLabel";
            roleNameLabel.Padding = new Padding(10, 0, 10, 0);
            roleNameLabel.Size = new Size(170, 24);
            roleNameLabel.TabIndex = 16;
            roleNameLabel.Text = "MERAZ UDDIN";
            // 
            // Staff
            // 
            Staff.AutoSize = true;
            Staff.Font = new Font("MS Reference Sans Serif", 8.25F);
            Staff.ForeColor = SystemColors.ControlDarkDark;
            Staff.Location = new Point(811, 32);
            Staff.Name = "Staff";
            Staff.Padding = new Padding(10, 0, 10, 0);
            Staff.Size = new Size(54, 15);
            Staff.TabIndex = 17;
            Staff.Text = "Staff";
            // 
            // staffSearchBox
            // 
            staffSearchBox.Location = new Point(5, 10);
            staffSearchBox.Name = "staffSearchBox";
            staffSearchBox.Size = new Size(424, 23);
            staffSearchBox.TabIndex = 20;
            // 
            // panel1
            // 
            panel1.Controls.Add(staffDataGrid);
            panel1.Controls.Add(staffAllMenuBtn);
            panel1.Controls.Add(staffSearchBtn);
            panel1.Controls.Add(staffSearchBox);
            panel1.Location = new Point(161, 78);
            panel1.Name = "panel1";
            panel1.Size = new Size(589, 653);
            panel1.TabIndex = 21;
            // 
            // staffDataGrid
            // 
            staffDataGrid.AllowUserToAddRows = false;
            staffDataGrid.AllowUserToResizeColumns = false;
            dataGridViewCellStyle7.BackColor = Color.WhiteSmoke;
            staffDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            staffDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            staffDataGrid.BackgroundColor = SystemColors.ButtonFace;
            staffDataGrid.BorderStyle = BorderStyle.None;
            staffDataGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.LightSteelBlue;
            dataGridViewCellStyle8.Font = new Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle8.ForeColor = Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            staffDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            staffDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = SystemColors.Window;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle9.SelectionForeColor = Color.White;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            staffDataGrid.DefaultCellStyle = dataGridViewCellStyle9;
            staffDataGrid.EnableHeadersVisualStyles = false;
            staffDataGrid.GridColor = Color.LightGray;
            staffDataGrid.Location = new Point(5, 47);
            staffDataGrid.MultiSelect = false;
            staffDataGrid.Name = "staffDataGrid";
            staffDataGrid.ReadOnly = true;
            staffDataGrid.RowHeadersVisible = false;
            staffDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            staffDataGrid.Size = new Size(584, 615);
            staffDataGrid.TabIndex = 23;
            staffDataGrid.CellContentClick += staffDataGrid_CellContentClick;
            // 
            // staffAllMenuBtn
            // 
            staffAllMenuBtn.Font = new Font("MS Reference Sans Serif", 8.25F);
            staffAllMenuBtn.Location = new Point(516, 10);
            staffAllMenuBtn.Name = "staffAllMenuBtn";
            staffAllMenuBtn.Size = new Size(75, 23);
            staffAllMenuBtn.TabIndex = 22;
            staffAllMenuBtn.Text = "All Menu";
            staffAllMenuBtn.UseVisualStyleBackColor = true;
            staffAllMenuBtn.Click += staffAllMenuBtn_Click_1;
            // 
            // staffSearchBtn
            // 
            staffSearchBtn.Font = new Font("MS Reference Sans Serif", 8.25F);
            staffSearchBtn.Location = new Point(435, 10);
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
            // contextMenu
            // 
            contextMenu.Items.AddRange(new ToolStripItem[] { removeItem });
            contextMenu.Name = "contextMenu";
            contextMenu.Size = new Size(68, 26);
            // 
            // removeItem
            // 
            removeItem.Name = "removeItem";
            removeItem.Size = new Size(67, 22);
            // 
            // subTotalBox
            // 
            subTotalBox.Font = new Font("MS Reference Sans Serif", 8.25F);
            subTotalBox.Location = new Point(873, 461);
            subTotalBox.Name = "subTotalBox";
            subTotalBox.RightToLeft = RightToLeft.Yes;
            subTotalBox.Size = new Size(112, 21);
            subTotalBox.TabIndex = 26;
            subTotalBox.TextChanged += subTotalBox_TextChanged;
            // 
            // logoutBtn
            // 
            logoutBtn.BackColor = Color.FromArgb(27, 160, 156);
            logoutBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logoutBtn.ForeColor = Color.White;
            logoutBtn.Location = new Point(12, 659);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.Size = new Size(128, 31);
            logoutBtn.TabIndex = 27;
            logoutBtn.Text = "Logout";
            logoutBtn.UseVisualStyleBackColor = false;
            logoutBtn.Click += logoutBtn_Click_1;
            // 
            // panel3
            // 
            panel3.Location = new Point(0, -1);
            panel3.Name = "panel3";
            panel3.Size = new Size(1008, 75);
            panel3.TabIndex = 46;
            panel3.Paint += panel3_Paint;
            // 
            // panel2
            // 
            panel2.Location = new Point(0, 78);
            panel2.Name = "panel2";
            panel2.Size = new Size(155, 653);
            panel2.TabIndex = 47;
            panel2.Paint += panel2_Paint_1;
            // 
            // staffOrderGridBox
            // 
            staffOrderGridBox.AllowUserToAddRows = false;
            staffOrderGridBox.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            staffOrderGridBox.BackgroundColor = SystemColors.Window;
            staffOrderGridBox.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            staffOrderGridBox.Location = new Point(756, 125);
            staffOrderGridBox.Name = "staffOrderGridBox";
            staffOrderGridBox.RowHeadersVisible = false;
            staffOrderGridBox.Size = new Size(240, 278);
            staffOrderGridBox.TabIndex = 48;
            staffOrderGridBox.CellClick += staffOrderGridBox_CellClick;
            staffOrderGridBox.CellContentClick += staffOrderGridBox_CellContentClick;
            // 
            // StaffDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 729);
            Controls.Add(staffOrderGridBox);
            Controls.Add(Staff);
            Controls.Add(roleNameLabel);
            Controls.Add(FavIcon);
            Controls.Add(panel3);
            Controls.Add(logoutBtn);
            Controls.Add(staffCategoryComboBox);
            Controls.Add(staffPriceSortComboBox);
            Controls.Add(label9);
            Controls.Add(subTotalBox);
            Controls.Add(panel1);
            Controls.Add(palestineTextBox);
            Controls.Add(label8);
            Controls.Add(label4);
            Controls.Add(takeaWayCombo);
            Controls.Add(cardRadio);
            Controls.Add(cashRadio);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(placeOrderBtn);
            Controls.Add(panel2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "StaffDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Staff";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)FavIcon).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)staffDataGrid).EndInit();
            contextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)staffOrderGridBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox FavIcon;
        private Button placeOrderBtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private RadioButton cashRadio;
        private RadioButton cardRadio;
        private ComboBox takeaWayCombo;
        private Label label4;
        private Label label8;
        private TextBox palestineTextBox;
        private Label roleNameLabel;
        private Label Staff;
        private TextBox staffSearchBox;
        private Panel panel1;
        private DataGridView staffDataGrid;
        private Button staffAllMenuBtn;
        private Button staffSearchBtn;
        private Label label9;
        private ComboBox staffPriceSortComboBox;
        private ComboBox staffCategoryComboBox;
        private TextBox subTotalBox;
        private Button logoutBtn;
        private Panel panel3;
        private Panel panel2;
        private ContextMenuStrip contextMenu;
        private ToolStripMenuItem removeItem;
        private DataGridView staffOrderGridBox;
    }
}