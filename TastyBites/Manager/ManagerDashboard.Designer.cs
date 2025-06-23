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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            pictureBox1 = new PictureBox();
            managerLabel = new Label();
            roleLabel = new Label();
            managerName = new Label();
            orderHistoryBtn = new Button();
            panel1 = new Panel();
            dataPanel = new Panel();
            label1 = new Label();
            button2 = new Button();
            orderHistorySearchBtn = new Button();
            orderHistorySearchBox = new TextBox();
            stockHistoryGrid = new DataGridView();
            panel3 = new Panel();
            stockBtn = new Button();
            generateBtn = new Button();
            logoutBtn = new Button();
            panel2 = new Panel();
            stockPanel = new Panel();
            stockSortComboBox = new ComboBox();
            stockSearchBtn = new Button();
            stockSearchBox = new TextBox();
            stockGridView = new DataGridView();
            stockShowAllBtn = new Button();
            button1 = new Button();
            orderHistoryPanel = new Panel();
            label2 = new Label();
            button3 = new Button();
            button4 = new Button();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            dataPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)stockHistoryGrid).BeginInit();
            stockPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)stockGridView).BeginInit();
            orderHistoryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            panel1.Controls.Add(dataPanel);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(stockBtn);
            panel1.Controls.Add(generateBtn);
            panel1.Controls.Add(logoutBtn);
            panel1.Controls.Add(orderHistoryBtn);
            panel1.Location = new Point(3, 80);
            panel1.Name = "panel1";
            panel1.Size = new Size(155, 653);
            panel1.TabIndex = 45;
            panel1.Paint += panel1_Paint;
            // 
            // dataPanel
            // 
            dataPanel.Controls.Add(label1);
            dataPanel.Controls.Add(button2);
            dataPanel.Controls.Add(orderHistorySearchBtn);
            dataPanel.Controls.Add(orderHistorySearchBox);
            dataPanel.Controls.Add(stockHistoryGrid);
            dataPanel.Location = new Point(155, 1);
            dataPanel.Name = "dataPanel";
            dataPanel.Size = new Size(867, 654);
            dataPanel.TabIndex = 56;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS Reference Sans Serif", 15.75F);
            label1.Location = new Point(25, 15);
            label1.Name = "label1";
            label1.Size = new Size(155, 26);
            label1.TabIndex = 50;
            label1.Text = "Order History";
            // 
            // button2
            // 
            button2.Location = new Point(636, 17);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 49;
            button2.Text = "Show All";
            button2.UseVisualStyleBackColor = true;
            // 
            // orderHistorySearchBtn
            // 
            orderHistorySearchBtn.BackColor = Color.FromArgb(27, 160, 156);
            orderHistorySearchBtn.ForeColor = Color.White;
            orderHistorySearchBtn.Location = new Point(555, 17);
            orderHistorySearchBtn.Name = "orderHistorySearchBtn";
            orderHistorySearchBtn.Size = new Size(75, 23);
            orderHistorySearchBtn.TabIndex = 48;
            orderHistorySearchBtn.Text = "Search";
            orderHistorySearchBtn.UseVisualStyleBackColor = false;
            // 
            // orderHistorySearchBox
            // 
            orderHistorySearchBox.Location = new Point(235, 17);
            orderHistorySearchBox.Name = "orderHistorySearchBox";
            orderHistorySearchBox.Size = new Size(314, 23);
            orderHistorySearchBox.TabIndex = 47;
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
            stockHistoryGrid.Location = new Point(17, 58);
            stockHistoryGrid.MultiSelect = false;
            stockHistoryGrid.Name = "stockHistoryGrid";
            stockHistoryGrid.ReadOnly = true;
            stockHistoryGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            stockHistoryGrid.Size = new Size(815, 557);
            stockHistoryGrid.TabIndex = 46;
            // 
            // panel3
            // 
            panel3.Location = new Point(155, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(850, 652);
            panel3.TabIndex = 56;
            // 
            // stockBtn
            // 
            stockBtn.Font = new Font("Microsoft Sans Serif", 12F);
            stockBtn.Location = new Point(21, 201);
            stockBtn.Name = "stockBtn";
            stockBtn.Size = new Size(87, 28);
            stockBtn.TabIndex = 55;
            stockBtn.Text = "Stock List";
            stockBtn.TextAlign = ContentAlignment.MiddleLeft;
            stockBtn.UseVisualStyleBackColor = true;
            stockBtn.Click += stockBtn_Click;
            // 
            // generateBtn
            // 
            generateBtn.Font = new Font("Microsoft Sans Serif", 12F);
            generateBtn.Location = new Point(21, 112);
            generateBtn.Name = "generateBtn";
            generateBtn.Size = new Size(116, 33);
            generateBtn.TabIndex = 48;
            generateBtn.Text = "Generate";
            generateBtn.TextAlign = ContentAlignment.MiddleLeft;
            generateBtn.UseVisualStyleBackColor = true;
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
            logoutBtn.Click += logoutBtn_Click;
            // 
            // panel2
            // 
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1008, 75);
            panel2.TabIndex = 54;
            panel2.Paint += panel2_Paint;
            // 
            // stockPanel
            // 
            stockPanel.Controls.Add(stockSortComboBox);
            stockPanel.Controls.Add(stockSearchBtn);
            stockPanel.Controls.Add(stockSearchBox);
            stockPanel.Controls.Add(stockGridView);
            stockPanel.Controls.Add(stockShowAllBtn);
            stockPanel.Location = new Point(158, 81);
            stockPanel.Name = "stockPanel";
            stockPanel.Size = new Size(850, 654);
            stockPanel.TabIndex = 55;
            // 
            // stockSortComboBox
            // 
            stockSortComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            stockSortComboBox.FormattingEnabled = true;
            stockSortComboBox.Items.AddRange(new object[] { "Sort By Default", "Low to High", "High to Low" });
            stockSortComboBox.Location = new Point(697, 5);
            stockSortComboBox.Name = "stockSortComboBox";
            stockSortComboBox.Size = new Size(121, 23);
            stockSortComboBox.TabIndex = 4;
            stockSortComboBox.SelectedIndexChanged += stockSortComboBox_SelectedIndexChanged;
            // 
            // stockSearchBtn
            // 
            stockSearchBtn.BackColor = Color.FromArgb(27, 160, 156);
            stockSearchBtn.ForeColor = Color.White;
            stockSearchBtn.Location = new Point(535, 4);
            stockSearchBtn.Name = "stockSearchBtn";
            stockSearchBtn.Size = new Size(75, 23);
            stockSearchBtn.TabIndex = 2;
            stockSearchBtn.Text = "Search";
            stockSearchBtn.UseVisualStyleBackColor = false;
            stockSearchBtn.Click += stockSearchBtn_Click;
            // 
            // stockSearchBox
            // 
            stockSearchBox.Location = new Point(5, 4);
            stockSearchBox.Name = "stockSearchBox";
            stockSearchBox.Size = new Size(524, 23);
            stockSearchBox.TabIndex = 1;
            // 
            // stockGridView
            // 
            stockGridView.AllowUserToAddRows = false;
            stockGridView.AllowUserToResizeColumns = false;
            stockGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = Color.WhiteSmoke;
            stockGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            stockGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            stockGridView.BackgroundColor = SystemColors.ButtonFace;
            stockGridView.BorderStyle = BorderStyle.None;
            stockGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.LightGray;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = Color.LightGray;
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            stockGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            stockGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            stockGridView.DefaultCellStyle = dataGridViewCellStyle6;
            stockGridView.EnableHeadersVisualStyles = false;
            stockGridView.GridColor = Color.LightGray;
            stockGridView.Location = new Point(6, 34);
            stockGridView.MultiSelect = false;
            stockGridView.Name = "stockGridView";
            stockGridView.ReadOnly = true;
            stockGridView.RowHeadersVisible = false;
            stockGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            stockGridView.Size = new Size(813, 576);
            stockGridView.TabIndex = 5;
            // 
            // stockShowAllBtn
            // 
            stockShowAllBtn.Location = new Point(616, 5);
            stockShowAllBtn.Name = "stockShowAllBtn";
            stockShowAllBtn.Size = new Size(75, 23);
            stockShowAllBtn.TabIndex = 52;
            stockShowAllBtn.Text = "Show All";
            stockShowAllBtn.UseVisualStyleBackColor = true;
            stockShowAllBtn.Click += stockShowAllBtn_Click;
            // 
            // button1
            // 
            button1.Location = new Point(616, 4);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Show All";
            button1.UseVisualStyleBackColor = true;
            // 
            // orderHistoryPanel
            // 
            orderHistoryPanel.Controls.Add(label2);
            orderHistoryPanel.Controls.Add(button3);
            orderHistoryPanel.Controls.Add(button4);
            orderHistoryPanel.Controls.Add(textBox1);
            orderHistoryPanel.Controls.Add(dataGridView1);
            orderHistoryPanel.Location = new Point(161, 82);
            orderHistoryPanel.Name = "orderHistoryPanel";
            orderHistoryPanel.Size = new Size(847, 654);
            orderHistoryPanel.TabIndex = 53;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MS Reference Sans Serif", 15.75F);
            label2.Location = new Point(25, 15);
            label2.Name = "label2";
            label2.Size = new Size(155, 26);
            label2.TabIndex = 50;
            label2.Text = "Order History";
            // 
            // button3
            // 
            button3.Location = new Point(636, 17);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 49;
            button3.Text = "Show All";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(27, 160, 156);
            button4.ForeColor = Color.White;
            button4.Location = new Point(555, 17);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 48;
            button4.Text = "Search";
            button4.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(235, 17);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(314, 23);
            textBox1.TabIndex = 47;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = Color.White;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.WhiteSmoke;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.SteelBlue;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = Color.LightSteelBlue;
            dataGridViewCellStyle9.SelectionForeColor = Color.Black;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle9;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.LightGray;
            dataGridView1.Location = new Point(17, 58);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(815, 557);
            dataGridView1.TabIndex = 46;
            // 
            // managerDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 729);
            Controls.Add(roleLabel);
            Controls.Add(managerName);
            Controls.Add(managerLabel);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(stockPanel);
            Controls.Add(orderHistoryPanel);
            Name = "managerDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manager Dashboard";
            Load += managerDashboard_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            dataPanel.ResumeLayout(false);
            dataPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)stockHistoryGrid).EndInit();
            stockPanel.ResumeLayout(false);
            stockPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)stockGridView).EndInit();
            orderHistoryPanel.ResumeLayout(false);
            orderHistoryPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private Panel panel2;
        private Button generateBtn;
        private Button stockBtn;
        private Panel stockPanel;
        private ComboBox stockSortComboBox;
        private Button button1;
        private Button stockSearchBtn;
        private TextBox stockSearchBox;
        private DataGridView stockGridView;
        private Panel panel3;
        private Button stockShowAllBtn;
        private Panel dataPanel;
        private Label label1;
        private Button button2;
        private Button orderHistorySearchBtn;
        private TextBox orderHistorySearchBox;
        private DataGridView stockHistoryGrid;
        private Panel orderHistoryPanel;
        private Label label2;
        private Button button3;
        private Button button4;
        private TextBox textBox1;
        private DataGridView dataGridView1;
    }
}