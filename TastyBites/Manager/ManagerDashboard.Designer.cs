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
            pictureBox1 = new PictureBox();
            managerLabel = new Label();
            roleLabel = new Label();
            managerName = new Label();
            orderHistoryBtn = new Button();
            panel1 = new Panel();
            generateBtn = new Button();
            stockBtn = new Button();
            logoutBtn = new Button();
            orderHistoryShowBtn = new Button();
            orderHistorySearchBtn = new Button();
            orderHistorySearchBox = new TextBox();
            stockHistoryGrid = new DataGridView();
            panel2 = new Panel();
            stockPanel = new Panel();
            stockSortComboBox = new ComboBox();
            showBtn = new Button();
            stockSearchBtn = new Button();
            stockSearchBox = new TextBox();
            stockGridView = new DataGridView();
            generatePanel = new Panel();
            label2 = new Label();
            label1 = new Label();
            genBtn = new Button();
            dateTimePickerEnd = new DateTimePicker();
            dateTimePickerStart = new DateTimePicker();
            orderHistoryPanelMD = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)stockHistoryGrid).BeginInit();
            stockPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)stockGridView).BeginInit();
            generatePanel.SuspendLayout();
            orderHistoryPanelMD.SuspendLayout();
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
            orderHistoryBtn.Location = new Point(25, 150);
            orderHistoryBtn.Name = "orderHistoryBtn";
            orderHistoryBtn.Size = new Size(115, 30);
            orderHistoryBtn.TabIndex = 35;
            orderHistoryBtn.Text = "Order History";
            orderHistoryBtn.TextAlign = ContentAlignment.MiddleLeft;
            orderHistoryBtn.UseVisualStyleBackColor = true;
            orderHistoryBtn.Click += orderHistoryBtn_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(generateBtn);
            panel1.Controls.Add(stockBtn);
            panel1.Controls.Add(logoutBtn);
            panel1.Controls.Add(orderHistoryBtn);
            panel1.Location = new Point(3, 80);
            panel1.Name = "panel1";
            panel1.Size = new Size(155, 653);
            panel1.TabIndex = 45;
            panel1.Paint += panel1_Paint;
            // 
            // generateBtn
            // 
            generateBtn.Font = new Font("Microsoft Sans Serif", 12F);
            generateBtn.Location = new Point(9, 197);
            generateBtn.Name = "generateBtn";
            generateBtn.Size = new Size(131, 30);
            generateBtn.TabIndex = 56;
            generateBtn.Text = "Generate PDF";
            generateBtn.TextAlign = ContentAlignment.MiddleLeft;
            generateBtn.UseVisualStyleBackColor = true;
            generateBtn.Click += generateBtn_Click;
            // 
            // stockBtn
            // 
            stockBtn.Font = new Font("Microsoft Sans Serif", 12F);
            stockBtn.Location = new Point(25, 100);
            stockBtn.Name = "stockBtn";
            stockBtn.Size = new Size(115, 30);
            stockBtn.TabIndex = 55;
            stockBtn.Text = "All Stock List";
            stockBtn.UseVisualStyleBackColor = true;
            stockBtn.Click += stockBtn_Click;
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
            // orderHistoryShowBtn
            // 
            orderHistoryShowBtn.Location = new Point(585, 4);
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
            orderHistorySearchBtn.Location = new Point(504, 4);
            orderHistorySearchBtn.Name = "orderHistorySearchBtn";
            orderHistorySearchBtn.Size = new Size(75, 23);
            orderHistorySearchBtn.TabIndex = 51;
            orderHistorySearchBtn.Text = "Search";
            orderHistorySearchBtn.UseVisualStyleBackColor = false;
            orderHistorySearchBtn.Click += orderHistorySearchBtn_Click;
            // 
            // orderHistorySearchBox
            // 
            orderHistorySearchBox.Location = new Point(184, 4);
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
            stockHistoryGrid.Location = new Point(3, 33);
            stockHistoryGrid.MultiSelect = false;
            stockHistoryGrid.Name = "stockHistoryGrid";
            stockHistoryGrid.ReadOnly = true;
            stockHistoryGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            stockHistoryGrid.Size = new Size(812, 585);
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
            // stockPanel
            // 
            stockPanel.Controls.Add(stockSortComboBox);
            stockPanel.Controls.Add(showBtn);
            stockPanel.Controls.Add(stockSearchBtn);
            stockPanel.Controls.Add(stockSearchBox);
            stockPanel.Controls.Add(stockGridView);
            stockPanel.Location = new Point(164, 80);
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
            // showBtn
            // 
            showBtn.Location = new Point(616, 4);
            showBtn.Name = "showBtn";
            showBtn.Size = new Size(75, 23);
            showBtn.TabIndex = 3;
            showBtn.Text = "Show All";
            showBtn.UseVisualStyleBackColor = true;
            showBtn.Click += showBtn_Click;
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
            stockGridView.Location = new Point(5, 39);
            stockGridView.MultiSelect = false;
            stockGridView.Name = "stockGridView";
            stockGridView.ReadOnly = true;
            stockGridView.RowHeadersVisible = false;
            stockGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            stockGridView.Size = new Size(813, 576);
            stockGridView.TabIndex = 3;
            // 
            // generatePanel
            // 
            generatePanel.Controls.Add(label2);
            generatePanel.Controls.Add(label1);
            generatePanel.Controls.Add(genBtn);
            generatePanel.Controls.Add(dateTimePickerEnd);
            generatePanel.Controls.Add(dateTimePickerStart);
            generatePanel.Location = new Point(164, 80);
            generatePanel.Name = "generatePanel";
            generatePanel.Size = new Size(850, 654);
            generatePanel.TabIndex = 57;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MS Reference Sans Serif", 9.75F);
            label2.Location = new Point(91, 91);
            label2.Name = "label2";
            label2.Size = new Size(73, 16);
            label2.TabIndex = 59;
            label2.Text = "End Date:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS Reference Sans Serif", 9.75F);
            label1.Location = new Point(81, 60);
            label1.Name = "label1";
            label1.Size = new Size(83, 16);
            label1.TabIndex = 58;
            label1.Text = "Start Date:";
            // 
            // genBtn
            // 
            genBtn.Font = new Font("Microsoft Sans Serif", 12F);
            genBtn.Location = new Point(170, 131);
            genBtn.Name = "genBtn";
            genBtn.Size = new Size(200, 30);
            genBtn.TabIndex = 57;
            genBtn.Text = "Generate";
            genBtn.UseVisualStyleBackColor = true;
            genBtn.Click += genBtn_Click;
            // 
            // dateTimePickerEnd
            // 
            dateTimePickerEnd.Location = new Point(170, 91);
            dateTimePickerEnd.Name = "dateTimePickerEnd";
            dateTimePickerEnd.Size = new Size(200, 23);
            dateTimePickerEnd.TabIndex = 61;
            // 
            // dateTimePickerStart
            // 
            dateTimePickerStart.Location = new Point(170, 62);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.Size = new Size(200, 23);
            dateTimePickerStart.TabIndex = 60;
            // 
            // orderHistoryPanelMD
            // 
            orderHistoryPanelMD.Controls.Add(stockHistoryGrid);
            orderHistoryPanelMD.Controls.Add(orderHistorySearchBox);
            orderHistoryPanelMD.Controls.Add(orderHistoryShowBtn);
            orderHistoryPanelMD.Controls.Add(orderHistorySearchBtn);
            orderHistoryPanelMD.Location = new Point(169, 81);
            orderHistoryPanelMD.Name = "orderHistoryPanelMD";
            orderHistoryPanelMD.Size = new Size(825, 652);
            orderHistoryPanelMD.TabIndex = 56;
            // 
            // managerDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 729);
            Controls.Add(generatePanel);
            Controls.Add(roleLabel);
            Controls.Add(managerName);
            Controls.Add(managerLabel);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(orderHistoryPanelMD);
            Controls.Add(stockPanel);
            Name = "managerDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manager Dashboard";
            Load += managerDashboard_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)stockHistoryGrid).EndInit();
            stockPanel.ResumeLayout(false);
            stockPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)stockGridView).EndInit();
            generatePanel.ResumeLayout(false);
            generatePanel.PerformLayout();
            orderHistoryPanelMD.ResumeLayout(false);
            orderHistoryPanelMD.PerformLayout();
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
        private Button stockBtn;
        private Panel stockPanel;
        private ComboBox stockSortComboBox;
        private Button showBtn;
        private Button stockSearchBtn;
        private TextBox stockSearchBox;
        private DataGridView stockGridView;
        private Button generateBtn;
        private Panel orderHistoryPanelMD;
        private Panel generatePanel;
        private DateTimePicker dateTimePickerEnd;
        private DateTimePicker dateTimePickerStart;
        private Label label2;
        private Label label1;
        private Button genBtn;
    }
}