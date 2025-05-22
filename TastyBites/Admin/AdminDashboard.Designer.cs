namespace TastyBites
{
    public partial class AdminDashboard 
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            usernameLabel = new Label();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(258, 59);
            label1.Name = "label1";
            label1.Size = new Size(119, 15);
            label1.TabIndex = 0;
            label1.Text = "ADMIN DASHBOARD";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 101);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 1;
            label2.Text = "MENU ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 141);
            label3.Name = "label3";
            label3.Size = new Size(87, 15);
            label3.TabIndex = 2;
            label3.Text = "MANAGE USER";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 181);
            label4.Name = "label4";
            label4.Size = new Size(95, 15);
            label4.TabIndex = 3;
            label4.Text = "STOCK MANAGE";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 223);
            label5.Name = "label5";
            label5.Size = new Size(35, 15);
            label5.TabIndex = 4;
            label5.Text = "DATA";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new Point(459, 40);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(0, 15);
            usernameLabel.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(137, 74);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(768, 46);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(215, 596);
            dataGridView1.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(837, 601);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 8;
            button1.Text = "Place Order";
            button1.UseVisualStyleBackColor = true;
         
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 729);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox1);
            Controls.Add(usernameLabel);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AdminDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            Load += AdminDashboard_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label usernameLabel;
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private Button button1;
    }
}