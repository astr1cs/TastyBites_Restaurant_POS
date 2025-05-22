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
            label4 = new Label();
            label5 = new Label();
            usernameLabel = new Label();
            pictureBox1 = new PictureBox();
            dataGridView2 = new DataGridView();
            logoutBtn = new Button();
            userName = new Label();
            adminLabel = new Label();
            manageUserBtn = new Button();
            userTableGrid = new DataGridView();
            userID = new Label();
            userLabel = new Label();
            label3 = new Label();
            addUser = new Button();
            editUser = new Button();
            deleteUser = new Button();
            userIdTextBox = new TextBox();
            userNameTextBox = new TextBox();
            roleComboBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userTableGrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(411, 25);
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
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(-1, 75);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(150, 654);
            dataGridView2.TabIndex = 9;
            // 
            // logoutBtn
            // 
            logoutBtn.Location = new Point(12, 667);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.Size = new Size(98, 23);
            logoutBtn.TabIndex = 10;
            logoutBtn.Text = "Logout";
            logoutBtn.UseVisualStyleBackColor = true;
            logoutBtn.Click += LogoutBtn_Click;
            // 
            // userName
            // 
            userName.AutoSize = true;
            userName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userName.Location = new Point(809, 9);
            userName.Name = "userName";
            userName.Padding = new Padding(10, 0, 10, 0);
            userName.Size = new Size(20, 21);
            userName.TabIndex = 16;
            // 
            // adminLabel
            // 
            adminLabel.AutoSize = true;
            adminLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            adminLabel.Location = new Point(811, 30);
            adminLabel.Name = "adminLabel";
            adminLabel.Padding = new Padding(10, 0, 10, 0);
            adminLabel.Size = new Size(65, 17);
            adminLabel.TabIndex = 17;
            adminLabel.Text = "Admin";
            // 
            // manageUserBtn
            // 
            manageUserBtn.Location = new Point(23, 142);
            manageUserBtn.Name = "manageUserBtn";
            manageUserBtn.Size = new Size(87, 23);
            manageUserBtn.TabIndex = 18;
            manageUserBtn.Text = "Manage User";
            manageUserBtn.UseVisualStyleBackColor = true;
            manageUserBtn.Click += manageUserBtn_Click;
            // 
            // userTableGrid
            // 
            userTableGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            userTableGrid.Location = new Point(155, 421);
            userTableGrid.Name = "userTableGrid";
            userTableGrid.Size = new Size(853, 308);
            userTableGrid.TabIndex = 19;
            userTableGrid.CellContentClick += userTableGrid_CellContentClick;
            // 
            // userID
            // 
            userID.AutoSize = true;
            userID.Location = new Point(212, 101);
            userID.Name = "userID";
            userID.Size = new Size(43, 15);
            userID.TabIndex = 20;
            userID.Text = "User Id";
            userID.Click += label3_Click_1;
            // 
            // userLabel
            // 
            userLabel.AutoSize = true;
            userLabel.Location = new Point(212, 142);
            userLabel.Name = "userLabel";
            userLabel.Size = new Size(60, 15);
            userLabel.TabIndex = 21;
            userLabel.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(212, 181);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 22;
            label3.Text = "Role";
            // 
            // addUser
            // 
            addUser.Location = new Point(604, 148);
            addUser.Name = "addUser";
            addUser.Size = new Size(75, 48);
            addUser.TabIndex = 23;
            addUser.Text = "Add";
            addUser.UseVisualStyleBackColor = true;
            // 
            // editUser
            // 
            editUser.Location = new Point(695, 148);
            editUser.Name = "editUser";
            editUser.Size = new Size(75, 48);
            editUser.TabIndex = 24;
            editUser.Text = "Edit";
            editUser.UseVisualStyleBackColor = true;
            // 
            // deleteUser
            // 
            deleteUser.Location = new Point(785, 148);
            deleteUser.Name = "deleteUser";
            deleteUser.Size = new Size(75, 48);
            deleteUser.TabIndex = 25;
            deleteUser.Text = "Delete";
            deleteUser.UseVisualStyleBackColor = true;
            // 
            // userIdTextBox
            // 
            userIdTextBox.Location = new Point(283, 98);
            userIdTextBox.Name = "userIdTextBox";
            userIdTextBox.Size = new Size(100, 23);
            userIdTextBox.TabIndex = 26;
            // 
            // userNameTextBox
            // 
            userNameTextBox.Location = new Point(283, 139);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.Size = new Size(100, 23);
            userNameTextBox.TabIndex = 28;
            // 
            // roleComboBox
            // 
            roleComboBox.FormattingEnabled = true;
            roleComboBox.Items.AddRange(new object[] { "Admin", "Manager", "Staff" });
            roleComboBox.Location = new Point(283, 181);
            roleComboBox.Name = "roleComboBox";
            roleComboBox.Size = new Size(121, 23);
            roleComboBox.TabIndex = 29;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 729);
            Controls.Add(roleComboBox);
            Controls.Add(userNameTextBox);
            Controls.Add(userIdTextBox);
            Controls.Add(deleteUser);
            Controls.Add(editUser);
            Controls.Add(addUser);
            Controls.Add(label3);
            Controls.Add(userLabel);
            Controls.Add(userID);
            Controls.Add(userTableGrid);
            Controls.Add(manageUserBtn);
            Controls.Add(adminLabel);
            Controls.Add(userName);
            Controls.Add(logoutBtn);
            Controls.Add(pictureBox1);
            Controls.Add(usernameLabel);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView2);
            Name = "AdminDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Dashboard";
            Load += AdminDashboard_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)userTableGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label usernameLabel;
        private PictureBox pictureBox1;
        private DataGridView dataGridView2;
        private Button logoutBtn;
        private Label userName;
        private Label adminLabel;
        private Button manageUserBtn;
        private DataGridView userTableGrid;
        private Label userID;
        private Label userLabel;
        private Label label3;
        private Button addUser;
        private Button editUser;
        private Button deleteUser;
        private TextBox userIdTextBox;
        private TextBox userNameTextBox;
        private ComboBox roleComboBox;
    }
}