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
            FavIcon = new PictureBox();
            dataGridView1 = new DataGridView();
            placeOrderBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            comboBox1 = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            palestineTextBox = new TextBox();
            roleNameLabel = new Label();
            Staff = new Label();
            dataGridView2 = new DataGridView();
            logoutBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)FavIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
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
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(756, 69);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(240, 662);
            dataGridView1.TabIndex = 1;
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
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(781, 125);
            label6.Name = "label6";
            label6.Size = new Size(134, 15);
            label6.TabIndex = 11;
            label6.Text = "2x Pasta with Roast Beef";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(929, 125);
            label7.Name = "label7";
            label7.Size = new Size(40, 15);
            label7.TabIndex = 12;
            label7.Text = "$45.62";
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
            logoutBtn.Location = new Point(12, 679);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.Size = new Size(124, 23);
            logoutBtn.TabIndex = 19;
            logoutBtn.Text = "Logout";
            logoutBtn.UseVisualStyleBackColor = true;
            logoutBtn.Click += logoutBtn_Click;
            // 
            // StaffDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 729);
            Controls.Add(logoutBtn);
            Controls.Add(dataGridView2);
            Controls.Add(Staff);
            Controls.Add(roleNameLabel);
            Controls.Add(palestineTextBox);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(placeOrderBtn);
            Controls.Add(dataGridView1);
            Controls.Add(FavIcon);
            Name = "StaffDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Staff";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)FavIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox FavIcon;
        private DataGridView dataGridView1;
        private Button placeOrderBtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private ComboBox comboBox1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox palestineTextBox;
        private Label roleNameLabel;
        private Label Staff;
        private DataGridView dataGridView2;
        private Button logoutBtn;
    }
}