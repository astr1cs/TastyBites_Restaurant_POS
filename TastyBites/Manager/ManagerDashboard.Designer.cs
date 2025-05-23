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
            pictureBox1 = new PictureBox();
            managerLabel = new Label();
            label1 = new Label();
            roleLabel = new Label();
            managerName = new Label();
            managerLogoutBtn = new Button();
            dataGridView2 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 0);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(363, 26);
            label1.Name = "label1";
            label1.Size = new Size(231, 32);
            label1.TabIndex = 20;
            label1.Text = "Manager Dashboard";
            // 
            // roleLabel
            // 
            roleLabel.AutoSize = true;
            roleLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roleLabel.Location = new Point(846, 38);
            roleLabel.Name = "roleLabel";
            roleLabel.Padding = new Padding(10, 0, 10, 0);
            roleLabel.Size = new Size(81, 17);
            roleLabel.TabIndex = 22;
            roleLabel.Text = "Manager";
            // 
            // managerName
            // 
            managerName.AutoSize = true;
            managerName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            managerName.Location = new Point(844, 17);
            managerName.Name = "managerName";
            managerName.Padding = new Padding(10, 0, 10, 0);
            managerName.Size = new Size(20, 21);
            managerName.TabIndex = 21;
            // 
            // managerLogoutBtn
            // 
            managerLogoutBtn.Location = new Point(13, 668);
            managerLogoutBtn.Name = "managerLogoutBtn";
            managerLogoutBtn.Size = new Size(98, 23);
            managerLogoutBtn.TabIndex = 24;
            managerLogoutBtn.Text = "Logout";
            managerLogoutBtn.UseVisualStyleBackColor = true;
            managerLogoutBtn.Click += managerLogoutBtn_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(0, 76);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(150, 654);
            dataGridView2.TabIndex = 23;
            // 
            // managerDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 729);
            Controls.Add(managerLogoutBtn);
            Controls.Add(dataGridView2);
            Controls.Add(roleLabel);
            Controls.Add(managerName);
            Controls.Add(label1);
            Controls.Add(managerLabel);
            Controls.Add(pictureBox1);
            Name = "managerDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manager Dashboard";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label managerLabel;
        private Label label1;
        private Label roleLabel;
        private Label managerName;
        private Button managerLogoutBtn;
        private DataGridView dataGridView2;
    }
}