namespace TastyBites.Manager
{
    partial class managerDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(managerDashboard));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            pictureBox1 = new PictureBox();
            managerLabel = new Label();
            roleLabel = new Label();
            managerName = new Label();
            orderHistoryBtn = new Button();
            panel1 = new Panel();
            logoutBtn = new Button();
            orderHistoryShowBtn = new Button();
            orderHistorySearchBtn = new Button();
            orderHistorySearchBox = new TextBox();
            stockHistoryGrid = new DataGridView();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)stockHistoryGrid).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(137, 74);
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // managerLabel
            // 
            managerLabel.AutoSize = true;
            managerLabel.Location = new Point(398, 26);
            managerLabel.Name = "managerLabel";
            managerLabel.Size = new Size(10, 15);
            managerLabel.TabIndex = 19;
            managerLabel.Text = "`";
            // 
            // roleLabel
            // 
            roleLabel.AutoSize = true;
            roleLabel.Font = new Font("Microsoft Sans Serif", 8.25F);
            roleLabel.ForeColor = SystemColors.ControlDark;
            roleLabel.Location = new Point(846, 38);
            roleLabel.Name = "roleLabel";
            roleLabel.Padding = new Padding(10, 0, 10, 0);
            roleLabel.Size = new Size(69, 13);
            roleLabel.TabIndex = 22;
            roleLabel.Text = "Manager";
            // 
            // managerName
            // 
            managerName.AutoSize = true;
            managerName.Font = new Font("MS Reference Sans Serif", 14.25F);
            managerName.Location = new Point(836, 14);
            managerName.Name = "managerName";
            managerName.Padding = new Padding(10, 0, 10, 0);
            managerName.Size = new Size(170, 24);
            managerName.TabIndex = 21;
            managerName.Text = "MERAZ UDDIN";
            // 
            // orderHistoryBtn
            // 
            orderHistoryBtn.Font = new Font("Microsoft Sans Serif", 12F);
            orderHistoryBtn.Location = new Point(21, 151);
            orderHistoryBtn.Name = "orderHistoryBtn";
            orderHistoryBtn.Size = new Size(116, 33);
            orderHistoryBtn.TabIndex = 35;
            orderHistoryBtn.Text = "Order History";
            orderHistoryBtn.TextAlign = ContentAlignment.MiddleLeft;
            orderHistoryBtn.UseVisualStyleBackColor = true;
            orderHistoryBtn.Click += orderHistoryBtn_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(logoutBtn);
            panel1.Controls.Add(orderHistoryBtn);
            panel1.Location = new Point(3, 80);
            panel1.Name = "panel1";
            panel1.Size = new Size(155, 653);
            panel1.TabIndex = 45;
            panel1.Paint += panel1_Paint;
            // 
            // logoutBtn
            // 
            logoutBtn.BackColor = Color.FromArgb(27, 160, 156);
            logoutBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logoutBtn.ForeColor = Color.White;
            logoutBtn.Location = new Point(9, 588);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.Size = new Size(128, 31);
            logoutBtn.TabIndex = 46;
            logoutBtn.Text = "Logout";
            logoutBtn.UseVisualStyleBackColor = false;
            // 
            // orderHistoryShowBtn
            // 
            orderHistoryShowBtn.Location = new Point(749, 80);
            orderHistoryShowBtn.Name = "orderHistoryShowBtn";
            orderHistoryShowBtn.Size = new Size(75, 23);
            orderHistoryShowBtn.TabIndex = 52;
            orderHistoryShowBtn.Text = "Show All";
            orderHistoryShowBtn.UseVisualStyleBackColor = true;
            orderHistoryShowBtn.Click += orderHistoryShowBtn_Click;
            // 
            // orderHistorySearchBtn
            // 
            orderHistorySearchBtn.BackColor = Color.FromArgb(27, 160, 156);
            orderHistorySearchBtn.ForeColor = Color.White;
            orderHistorySearchBtn.Location = new Point(668, 80);
            orderHistorySearchBtn.Name = "orderHistorySearchBtn";
            orderHistorySearchBtn.Size = new Size(75, 23);
            orderHistorySearchBtn.TabIndex = 51;
            orderHistorySearchBtn.Text = "Search";
            orderHistorySearchBtn.UseVisualStyleBackColor = false;
            orderHistorySearchBtn.Click += orderHistorySearchBtn_Click;
            // 
            // orderHistorySearchBox
            // 
            orderHistorySearchBox.Location = new Point(348, 80);
            orderHistorySearchBox.Name = "orderHistorySearchBox";
            orderHistorySearchBox.Size = new Size(314, 23);
            orderHistorySearchBox.TabIndex = 50;
            // 
            // stockHistoryGrid
            // 
            stockHistoryGrid.AllowUserToAddRows = false;
            stockHistoryGrid.AllowUserToDeleteRows = false;
            stockHistoryGrid.AllowUserToResizeColumns = false;
            stockHistoryGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            stockHistoryGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            stockHistoryGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            stockHistoryGrid.BackgroundColor = Color.WhiteSmoke;
            stockHistoryGrid.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.SteelBlue;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            stockHistoryGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            stockHistoryGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.LightSteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            stockHistoryGrid.DefaultCellStyle = dataGridViewCellStyle3;
            stockHistoryGrid.EnableHeadersVisualStyles = false;
            stockHistoryGrid.GridColor = Color.LightGray;
            stockHistoryGrid.Location = new Point(164, 109);
            stockHistoryGrid.MultiSelect = false;
            stockHistoryGrid.Name = "stockHistoryGrid";
            stockHistoryGrid.ReadOnly = true;
            stockHistoryGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            stockHistoryGrid.Size = new Size(815, 590);
            stockHistoryGrid.TabIndex = 53;
            // 
            // panel2
            // 
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1008, 75);
            panel2.TabIndex = 54;
            panel2.Paint += panel2_Paint;
            // 
            // managerDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 729);
            Controls.Add(stockHistoryGrid);
            Controls.Add(orderHistoryShowBtn);
            Controls.Add(roleLabel);
            Controls.Add(orderHistorySearchBtn);
            Controls.Add(managerName);
            Controls.Add(orderHistorySearchBox);
            Controls.Add(managerLabel);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "managerDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manager Dashboard";
            Load += managerDashboard_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)stockHistoryGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label managerLabel;
        private Label roleLabel;
        private Label managerName;
        private Button orderHistoryBtn;
        private Panel panel1;
        private Button logoutBtn;
        private Button orderHistoryShowBtn;
        private Button orderHistorySearchBtn;
        private TextBox orderHistorySearchBox;
        private DataGridView stockHistoryGrid;
        private Panel panel2;
    }
}