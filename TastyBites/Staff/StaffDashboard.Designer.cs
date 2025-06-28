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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
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
            FavIcon.Margin = new Padding(3, 4, 3, 4);
            FavIcon.Name = "FavIcon";
            FavIcon.Size = new Size(155, 96);
            FavIcon.TabIndex = 0;
            FavIcon.TabStop = false;
            // 
            // placeOrderBtn
            // 
            placeOrderBtn.BackColor = Color.FromArgb(27, 160, 154);
            placeOrderBtn.ForeColor = Color.White;
            placeOrderBtn.Location = new Point(879, 877);
            placeOrderBtn.Margin = new Padding(3, 4, 3, 4);
            placeOrderBtn.Name = "placeOrderBtn";
            placeOrderBtn.Size = new Size(230, 41);
            placeOrderBtn.TabIndex = 2;
            placeOrderBtn.Text = "Place Order";
            placeOrderBtn.UseVisualStyleBackColor = false;
            placeOrderBtn.Click += placeOrderBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(880, 120);
            label1.Name = "label1";
            label1.Size = new Size(99, 19);
            label1.TabIndex = 3;
            label1.Text = "Order Items";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MS Reference Sans Serif", 11.25F);
            label2.Location = new Point(879, 565);
            label2.Name = "label2";
            label2.Size = new Size(189, 24);
            label2.TabIndex = 4;
            label2.Text = "Payment Summery";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(880, 769);
            label3.Name = "label3";
            label3.Size = new Size(121, 20);
            label3.TabIndex = 5;
            label3.Text = "Payment Method";
            // 
            // cashRadio
            // 
            cashRadio.AutoSize = true;
            cashRadio.Location = new Point(879, 808);
            cashRadio.Margin = new Padding(3, 4, 3, 4);
            cashRadio.Name = "cashRadio";
            cashRadio.Padding = new Padding(11, 0, 11, 0);
            cashRadio.Size = new Size(83, 24);
            cashRadio.TabIndex = 6;
            cashRadio.TabStop = true;
            cashRadio.Text = "Cash";
            cashRadio.UseVisualStyleBackColor = true;
            // 
            // cardRadio
            // 
            cardRadio.AutoSize = true;
            cardRadio.Location = new Point(958, 809);
            cardRadio.Margin = new Padding(3, 4, 3, 4);
            cardRadio.Name = "cardRadio";
            cardRadio.Padding = new Padding(11, 0, 11, 0);
            cardRadio.Size = new Size(83, 24);
            cardRadio.TabIndex = 7;
            cardRadio.TabStop = true;
            cardRadio.Text = "Card";
            cardRadio.UseVisualStyleBackColor = true;
            // 
            // takeaWayCombo
            // 
            takeaWayCombo.FormattingEnabled = true;
            takeaWayCombo.Items.AddRange(new object[] { "Dine-in", "Takeway" });
            takeaWayCombo.Location = new Point(1045, 808);
            takeaWayCombo.Margin = new Padding(3, 4, 3, 4);
            takeaWayCombo.Name = "takeaWayCombo";
            takeaWayCombo.Size = new Size(78, 28);
            takeaWayCombo.TabIndex = 8;
            takeaWayCombo.Text = "Dine-in";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("MS Reference Sans Serif", 11.25F);
            label4.Location = new Point(879, 615);
            label4.Name = "label4";
            label4.Size = new Size(99, 24);
            label4.TabIndex = 9;
            label4.Text = "Subtotal:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("MS Reference Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(880, 657);
            label8.Name = "label8";
            label8.Size = new Size(169, 18);
            label8.TabIndex = 13;
            label8.Text = "Donation for Palestine:";
            // 
            // palestineTextBox
            // 
            palestineTextBox.Font = new Font("MS Reference Sans Serif", 8.25F);
            palestineTextBox.Location = new Point(998, 684);
            palestineTextBox.Margin = new Padding(3, 4, 3, 4);
            palestineTextBox.Name = "palestineTextBox";
            palestineTextBox.RightToLeft = RightToLeft.Yes;
            palestineTextBox.Size = new Size(127, 24);
            palestineTextBox.TabIndex = 15;
            palestineTextBox.Text = "Coming Soon";
            palestineTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // roleNameLabel
            // 
            roleNameLabel.AutoSize = true;
            roleNameLabel.Font = new Font("MS Reference Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roleNameLabel.Location = new Point(922, 12);
            roleNameLabel.Name = "roleNameLabel";
            roleNameLabel.Padding = new Padding(11, 0, 11, 0);
            roleNameLabel.Size = new Size(211, 29);
            roleNameLabel.TabIndex = 16;
            roleNameLabel.Text = "MERAZ UDDIN";
            // 
            // Staff
            // 
            Staff.AutoSize = true;
            Staff.Font = new Font("MS Reference Sans Serif", 8.25F);
            Staff.ForeColor = SystemColors.ControlDarkDark;
            Staff.Location = new Point(927, 43);
            Staff.Name = "Staff";
            Staff.Padding = new Padding(11, 0, 11, 0);
            Staff.Size = new Size(64, 18);
            Staff.TabIndex = 17;
            Staff.Text = "Staff";
            // 
            // staffSearchBox
            // 
            staffSearchBox.Location = new Point(6, 13);
            staffSearchBox.Margin = new Padding(3, 4, 3, 4);
            staffSearchBox.Name = "staffSearchBox";
            staffSearchBox.Size = new Size(484, 27);
            staffSearchBox.TabIndex = 20;
            staffSearchBox.TextChanged += staffSearchBox_TextChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(staffDataGrid);
            panel1.Controls.Add(staffAllMenuBtn);
            panel1.Controls.Add(staffSearchBtn);
            panel1.Controls.Add(staffSearchBox);
            panel1.Location = new Point(184, 104);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(673, 871);
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
            staffDataGrid.ColumnHeadersHeight = 29;
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
            staffDataGrid.Location = new Point(6, 63);
            staffDataGrid.Margin = new Padding(3, 4, 3, 4);
            staffDataGrid.MultiSelect = false;
            staffDataGrid.Name = "staffDataGrid";
            staffDataGrid.ReadOnly = true;
            staffDataGrid.RowHeadersVisible = false;
            staffDataGrid.RowHeadersWidth = 51;
            staffDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            staffDataGrid.Size = new Size(667, 820);
            staffDataGrid.TabIndex = 23;
            staffDataGrid.CellContentClick += staffDataGrid_CellContentClick;
            // 
            // staffAllMenuBtn
            // 
            staffAllMenuBtn.Font = new Font("MS Reference Sans Serif", 8.25F);
            staffAllMenuBtn.Location = new Point(590, 13);
            staffAllMenuBtn.Margin = new Padding(3, 4, 3, 4);
            staffAllMenuBtn.Name = "staffAllMenuBtn";
            staffAllMenuBtn.Size = new Size(86, 31);
            staffAllMenuBtn.TabIndex = 22;
            staffAllMenuBtn.Text = "All Menu";
            staffAllMenuBtn.UseVisualStyleBackColor = true;
            staffAllMenuBtn.Click += staffAllMenuBtn_Click_1;
            // 
            // staffSearchBtn
            // 
            staffSearchBtn.Font = new Font("MS Reference Sans Serif", 8.25F);
            staffSearchBtn.Location = new Point(497, 13);
            staffSearchBtn.Margin = new Padding(3, 4, 3, 4);
            staffSearchBtn.Name = "staffSearchBtn";
            staffSearchBtn.Size = new Size(86, 31);
            staffSearchBtn.TabIndex = 21;
            staffSearchBtn.Text = "Search";
            staffSearchBtn.UseVisualStyleBackColor = true;
            staffSearchBtn.Click += staffSearchBtn_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(14, 167);
            label9.Name = "label9";
            label9.Size = new Size(51, 20);
            label9.TabIndex = 22;
            label9.Text = "Filters:";
            // 
            // staffPriceSortComboBox
            // 
            staffPriceSortComboBox.FormattingEnabled = true;
            staffPriceSortComboBox.Items.AddRange(new object[] { "Sort By Default", "Low to High", "High to Low" });
            staffPriceSortComboBox.Location = new Point(14, 209);
            staffPriceSortComboBox.Margin = new Padding(3, 4, 3, 4);
            staffPriceSortComboBox.Name = "staffPriceSortComboBox";
            staffPriceSortComboBox.Size = new Size(138, 28);
            staffPriceSortComboBox.TabIndex = 23;
            staffPriceSortComboBox.SelectedIndexChanged += staffPriceSortComboBox_SelectedIndexChanged;
            // 
            // staffCategoryComboBox
            // 
            staffCategoryComboBox.FormattingEnabled = true;
            staffCategoryComboBox.Items.AddRange(new object[] { "Drinks", "Main", "Desserts" });
            staffCategoryComboBox.Location = new Point(14, 263);
            staffCategoryComboBox.Margin = new Padding(3, 4, 3, 4);
            staffCategoryComboBox.Name = "staffCategoryComboBox";
            staffCategoryComboBox.Size = new Size(138, 28);
            staffCategoryComboBox.TabIndex = 24;
            staffCategoryComboBox.SelectedIndexChanged += staffCategoryComboBox_SelectedIndexChanged;
            // 
            // contextMenu
            // 
            contextMenu.ImageScalingSize = new Size(20, 20);
            contextMenu.Items.AddRange(new ToolStripItem[] { removeItem });
            contextMenu.Name = "contextMenu";
            contextMenu.Size = new Size(70, 26);
            // 
            // removeItem
            // 
            removeItem.Name = "removeItem";
            removeItem.Size = new Size(69, 22);
            // 
            // subTotalBox
            // 
            subTotalBox.Font = new Font("MS Reference Sans Serif", 8.25F);
            subTotalBox.Location = new Point(998, 615);
            subTotalBox.Margin = new Padding(3, 4, 3, 4);
            subTotalBox.Name = "subTotalBox";
            subTotalBox.ReadOnly = true;
            subTotalBox.RightToLeft = RightToLeft.Yes;
            subTotalBox.Size = new Size(127, 24);
            subTotalBox.TabIndex = 26;
            subTotalBox.TextChanged += subTotalBox_TextChanged;
            // 
            // logoutBtn
            // 
            logoutBtn.BackColor = Color.FromArgb(27, 160, 156);
            logoutBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logoutBtn.ForeColor = Color.White;
            logoutBtn.Location = new Point(14, 879);
            logoutBtn.Margin = new Padding(3, 4, 3, 4);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.Size = new Size(146, 41);
            logoutBtn.TabIndex = 27;
            logoutBtn.Text = "Logout";
            logoutBtn.UseVisualStyleBackColor = false;
            logoutBtn.Click += logoutBtn_Click_1;
            // 
            // panel3
            // 
            panel3.Location = new Point(0, -1);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(1152, 100);
            panel3.TabIndex = 46;
            panel3.Paint += panel3_Paint;
            // 
            // panel2
            // 
            panel2.Location = new Point(0, 104);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(177, 871);
            panel2.TabIndex = 47;
            panel2.Paint += panel2_Paint_1;
            // 
            // staffOrderGridBox
            // 
            staffOrderGridBox.AllowUserToAddRows = false;
            staffOrderGridBox.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            staffOrderGridBox.BackgroundColor = SystemColors.Window;
            staffOrderGridBox.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            staffOrderGridBox.Location = new Point(864, 167);
            staffOrderGridBox.Margin = new Padding(3, 4, 3, 4);
            staffOrderGridBox.Name = "staffOrderGridBox";
            staffOrderGridBox.RowHeadersVisible = false;
            staffOrderGridBox.RowHeadersWidth = 51;
            staffOrderGridBox.Size = new Size(274, 371);
            staffOrderGridBox.TabIndex = 48;
            staffOrderGridBox.CellClick += staffOrderGridBox_CellClick;
            staffOrderGridBox.CellContentClick += staffOrderGridBox_CellContentClick;
            // 
            // StaffDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1152, 972);
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
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "StaffDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Staff";
            FormClosing += StaffDashboard_FormClosing;
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