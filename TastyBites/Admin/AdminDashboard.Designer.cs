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
            usernameLabel = new Label();
            pictureBox1 = new PictureBox();
            dataGridView2 = new DataGridView();
            logoutBtn = new Button();
            userName = new Label();
            adminLabel = new Label();
            manageUserBtn = new Button();
            userPanel = new Panel();
            passwordFieldBox = new TextBox();
            passwordLabel = new Label();
            roleComboBox = new ComboBox();
            userNameTextBox = new TextBox();
            deleteUser = new Button();
            editUser = new Button();
            addUser = new Button();
            label3 = new Label();
            userLabel = new Label();
            userTableGrid = new DataGridView();
            menuBtn = new Button();
            menuPanel = new Panel();
            menuLabel = new Label();
            stockBtn = new Button();
            stockPanel = new Panel();
            stockLabel = new Label();
            dataBtn = new Button();
            dataPanel = new Panel();
            dataPanelLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            userPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)userTableGrid).BeginInit();
            menuPanel.SuspendLayout();
            stockPanel.SuspendLayout();
            dataPanel.SuspendLayout();
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
            userName.Click += userName_Click;
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
            adminLabel.Click += adminLabel_Click;
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
            // userPanel
            // 
            userPanel.Controls.Add(passwordFieldBox);
            userPanel.Controls.Add(passwordLabel);
            userPanel.Controls.Add(roleComboBox);
            userPanel.Controls.Add(userNameTextBox);
            userPanel.Controls.Add(deleteUser);
            userPanel.Controls.Add(editUser);
            userPanel.Controls.Add(addUser);
            userPanel.Controls.Add(label3);
            userPanel.Controls.Add(userLabel);
            userPanel.Controls.Add(userTableGrid);
            userPanel.Location = new Point(155, 75);
            userPanel.Name = "userPanel";
            userPanel.Size = new Size(853, 654);
            userPanel.TabIndex = 30;
            // 
            // passwordFieldBox
            // 
            passwordFieldBox.Location = new Point(128, 87);
            passwordFieldBox.Name = "passwordFieldBox";
            passwordFieldBox.PasswordChar = '*';
            passwordFieldBox.Size = new Size(100, 23);
            passwordFieldBox.TabIndex = 41;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(57, 90);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(57, 15);
            passwordLabel.TabIndex = 40;
            passwordLabel.Text = "Password";
            // 
            // roleComboBox
            // 
            roleComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            roleComboBox.FormattingEnabled = true;
            roleComboBox.Items.AddRange(new object[] { "Admin", "Manager", "Staff" });
            roleComboBox.Location = new Point(128, 125);
            roleComboBox.Name = "roleComboBox";
            roleComboBox.Size = new Size(121, 23);
            roleComboBox.TabIndex = 39;
            // 
            // userNameTextBox
            // 
            userNameTextBox.Location = new Point(128, 53);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.Size = new Size(100, 23);
            userNameTextBox.TabIndex = 38;
            // 
            // deleteUser
            // 
            deleteUser.Location = new Point(630, 62);
            deleteUser.Name = "deleteUser";
            deleteUser.Size = new Size(75, 48);
            deleteUser.TabIndex = 36;
            deleteUser.Text = "Delete";
            deleteUser.UseVisualStyleBackColor = true;
            deleteUser.Click += deleteUser_Click;
            // 
            // editUser
            // 
            editUser.Location = new Point(540, 62);
            editUser.Name = "editUser";
            editUser.Size = new Size(75, 48);
            editUser.TabIndex = 35;
            editUser.Text = "Edit";
            editUser.UseVisualStyleBackColor = true;
            editUser.Click += editUser_Click;
            // 
            // addUser
            // 
            addUser.Location = new Point(449, 62);
            addUser.Name = "addUser";
            addUser.Size = new Size(75, 48);
            addUser.TabIndex = 34;
            addUser.Text = "Add";
            addUser.UseVisualStyleBackColor = true;
            addUser.Click += addUser_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 125);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 33;
            label3.Text = "Role";
            // 
            // userLabel
            // 
            userLabel.AutoSize = true;
            userLabel.Location = new Point(57, 56);
            userLabel.Name = "userLabel";
            userLabel.Size = new Size(60, 15);
            userLabel.TabIndex = 32;
            userLabel.Text = "Username";
            // 
            // userTableGrid
            // 
            userTableGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            userTableGrid.Location = new Point(0, 335);
            userTableGrid.Name = "userTableGrid";
            userTableGrid.Size = new Size(853, 319);
            userTableGrid.TabIndex = 30;
            userTableGrid.CellContentClick += userTableGrid_CellContentClick_1;
            userTableGrid.SelectionChanged += userTableGrid_SelectionChanged;
            // 
            // menuBtn
            // 
            menuBtn.Location = new Point(23, 113);
            menuBtn.Name = "menuBtn";
            menuBtn.Size = new Size(75, 23);
            menuBtn.TabIndex = 31;
            menuBtn.Text = "Menu";
            menuBtn.UseVisualStyleBackColor = true;
            menuBtn.Click += menuBtn_Click;
            // 
            // menuPanel
            // 
            menuPanel.Controls.Add(menuLabel);
            menuPanel.Location = new Point(155, 75);
            menuPanel.Name = "menuPanel";
            menuPanel.Size = new Size(853, 654);
            menuPanel.TabIndex = 32;
            // 
            // menuLabel
            // 
            menuLabel.AutoSize = true;
            menuLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuLabel.Location = new Point(295, 172);
            menuLabel.Name = "menuLabel";
            menuLabel.Size = new Size(165, 30);
            menuLabel.TabIndex = 0;
            menuLabel.Text = "Menu Panel Test";
            // 
            // stockBtn
            // 
            stockBtn.Location = new Point(23, 183);
            stockBtn.Name = "stockBtn";
            stockBtn.Size = new Size(98, 23);
            stockBtn.TabIndex = 33;
            stockBtn.Text = "Stock Manage";
            stockBtn.UseVisualStyleBackColor = true;
            stockBtn.Click += stockBtn_Click;
            // 
            // stockPanel
            // 
            stockPanel.Controls.Add(stockLabel);
            stockPanel.Location = new Point(155, 75);
            stockPanel.Name = "stockPanel";
            stockPanel.Size = new Size(853, 654);
            stockPanel.TabIndex = 34;
            // 
            // stockLabel
            // 
            stockLabel.AutoSize = true;
            stockLabel.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            stockLabel.Location = new Point(230, 160);
            stockLabel.Name = "stockLabel";
            stockLabel.Size = new Size(247, 45);
            stockLabel.TabIndex = 0;
            stockLabel.Text = "Stock Panel Test";
            // 
            // dataBtn
            // 
            dataBtn.Location = new Point(23, 221);
            dataBtn.Name = "dataBtn";
            dataBtn.Size = new Size(75, 23);
            dataBtn.TabIndex = 35;
            dataBtn.Text = "Data";
            dataBtn.UseVisualStyleBackColor = true;
            dataBtn.Click += dataBtn_Click;
            // 
            // dataPanel
            // 
            dataPanel.Controls.Add(dataPanelLabel);
            dataPanel.Location = new Point(155, 75);
            dataPanel.Name = "dataPanel";
            dataPanel.Size = new Size(853, 654);
            dataPanel.TabIndex = 36;
            // 
            // dataPanelLabel
            // 
            dataPanelLabel.AutoSize = true;
            dataPanelLabel.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataPanelLabel.Location = new Point(230, 190);
            dataPanelLabel.Name = "dataPanelLabel";
            dataPanelLabel.Size = new Size(235, 45);
            dataPanelLabel.TabIndex = 1;
            dataPanelLabel.Text = "Data Panel Test";
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 729);
            Controls.Add(dataBtn);
            Controls.Add(stockBtn);
            Controls.Add(menuBtn);
            Controls.Add(manageUserBtn);
            Controls.Add(adminLabel);
            Controls.Add(userName);
            Controls.Add(logoutBtn);
            Controls.Add(pictureBox1);
            Controls.Add(usernameLabel);
            Controls.Add(label1);
            Controls.Add(dataGridView2);
            Controls.Add(userPanel);
            Controls.Add(dataPanel);
            Controls.Add(stockPanel);
            Controls.Add(menuPanel);
            Name = "AdminDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Dashboard";
            Load += AdminDashboard_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            userPanel.ResumeLayout(false);
            userPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)userTableGrid).EndInit();
            menuPanel.ResumeLayout(false);
            menuPanel.PerformLayout();
            stockPanel.ResumeLayout(false);
            stockPanel.PerformLayout();
            dataPanel.ResumeLayout(false);
            dataPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label usernameLabel;
        private PictureBox pictureBox1;
        private DataGridView dataGridView2;
        private Button logoutBtn;
        private Label userName;
        private Label adminLabel;
        private Button manageUserBtn;
        private Panel userPanel;
        private ComboBox roleComboBox;
        private TextBox userNameTextBox;
        private Button deleteUser;
        private Button editUser;
        private Button addUser;
        private Label label3;
        private Label userLabel;
        private DataGridView userTableGrid;
        private Button menuBtn;
        private Panel menuPanel;
        private Label menuLabel;
        private Button stockBtn;
        private Panel stockPanel;
        private Label stockLabel;
        private Button dataBtn;
        private Panel dataPanel;
        private Label dataPanelLabel;
        private TextBox passwordFieldBox;
        private Label passwordLabel;
    }
}