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
            menuPanel = new Panel();
            menuShowDetailsBtn = new Button();
            menuSearchBtn = new Button();
            menuSearchBox = new TextBox();
            categoryComboBox = new ComboBox();
            deleteMenuBtn = new Button();
            editMenuBtn = new Button();
            addMenuBtn = new Button();
            menuGrid = new DataGridView();
            menuPriceTextBox = new TextBox();
            menuQuantityTextBox = new TextBox();
            menuDescriptionTextBox = new TextBox();
            menuNameTextBox = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            quantityLabel = new Label();
            menuName = new Label();
            menuLabel = new Label();
            userShowBtn = new Button();
            userSearchBox = new TextBox();
            userSearchBtn = new Button();
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
            menuListBtn = new Button();
            stockBtn = new Button();
            stockPanel = new Panel();
            stockSortComboBox = new ComboBox();
            button1 = new Button();
            stockSearchBtn = new Button();
            stockSearchBox = new TextBox();
            stockGridView = new DataGridView();
            dataPanel = new Panel();
            dataPanelLabel = new Label();
            dataBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            userPanel.SuspendLayout();
            menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)menuGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userTableGrid).BeginInit();
            stockPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)stockGridView).BeginInit();
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
            this.Controls.Add(userPanel);
            this.Controls.Add(menuPanel);
            this.Controls.Add(stockPanel);
            this.Controls.Add(dataPanel);

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
            //userPanel.Controls.Add(menuPanel);    
            userPanel.Controls.Add(userShowBtn);
            userPanel.Controls.Add(userSearchBox);
            userPanel.Controls.Add(userSearchBtn);
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
            userPanel.TabIndex = 2;
            // 
            // menuPanel
            // 
            menuPanel.Controls.Add(menuShowDetailsBtn);
            menuPanel.Controls.Add(menuSearchBtn);
            menuPanel.Controls.Add(menuSearchBox);
            menuPanel.Controls.Add(categoryComboBox);
            menuPanel.Controls.Add(deleteMenuBtn);
            menuPanel.Controls.Add(editMenuBtn);
            menuPanel.Controls.Add(addMenuBtn);
            menuPanel.Controls.Add(menuGrid);
            menuPanel.Controls.Add(menuPriceTextBox);
            menuPanel.Controls.Add(menuQuantityTextBox);
            menuPanel.Controls.Add(menuDescriptionTextBox);
            menuPanel.Controls.Add(menuNameTextBox);
            menuPanel.Controls.Add(label5);
            menuPanel.Controls.Add(label4);
            menuPanel.Controls.Add(label2);
            menuPanel.Controls.Add(quantityLabel);
            menuPanel.Controls.Add(menuName);
            menuPanel.Controls.Add(menuLabel);
            menuPanel.Location = new Point(155, 75);
            menuPanel.Name = "menuPanel";
            menuPanel.Size = new Size(853, 654);
            menuPanel.TabIndex = 1;
          
            // 
            // menuShowDetailsBtn
            // 
            menuShowDetailsBtn.Location = new Point(610, 228);
            menuShowDetailsBtn.Name = "menuShowDetailsBtn";
            menuShowDetailsBtn.Size = new Size(120, 23);
            menuShowDetailsBtn.TabIndex = 44;
            menuShowDetailsBtn.Text = "Show All Details";
            menuShowDetailsBtn.UseVisualStyleBackColor = true;
            // 
            // menuSearchBtn
            // 
            menuSearchBtn.Location = new Point(224, 227);
            menuSearchBtn.Name = "menuSearchBtn";
            menuSearchBtn.Size = new Size(45, 23);
            menuSearchBtn.TabIndex = 43;
            menuSearchBtn.Text = "Go";
            menuSearchBtn.UseVisualStyleBackColor = true;
            menuSearchBtn.Click += menuSearchBtn_Click;
            // 
            // menuSearchBox
            // 
            menuSearchBox.Location = new Point(32, 227);
            menuSearchBox.Name = "menuSearchBox";
            menuSearchBox.Size = new Size(186, 23);
            menuSearchBox.TabIndex = 42;
            menuSearchBox.Text = "Search Menu Items";
            menuSearchBox.TextChanged += menuSearchBox_TextChanged;
            // 
            // categoryComboBox
            // 
            categoryComboBox.FormattingEnabled = true;
            categoryComboBox.Items.AddRange(new object[] { "Drinks", "Main", "Desserts" });
            categoryComboBox.Location = new Point(128, 152);
            categoryComboBox.Name = "categoryComboBox";
            categoryComboBox.Size = new Size(121, 23);
            categoryComboBox.TabIndex = 41;
            // 
            // deleteMenuBtn
            // 
            deleteMenuBtn.Location = new Point(194, 190);
            deleteMenuBtn.Name = "deleteMenuBtn";
            deleteMenuBtn.Size = new Size(75, 23);
            deleteMenuBtn.TabIndex = 40;
            deleteMenuBtn.Text = "Delete";
            deleteMenuBtn.UseVisualStyleBackColor = true;
            deleteMenuBtn.Click += deleteMenuBtn_Click;
            // 
            // editMenuBtn
            // 
            editMenuBtn.Location = new Point(113, 190);
            editMenuBtn.Name = "editMenuBtn";
            editMenuBtn.Size = new Size(75, 23);
            editMenuBtn.TabIndex = 39;
            editMenuBtn.Text = "Edit";
            editMenuBtn.UseVisualStyleBackColor = true;
            editMenuBtn.Click += editMenuBtn_Click;
            // 
            // addMenuBtn
            // 
            addMenuBtn.Location = new Point(32, 190);
            addMenuBtn.Name = "addMenuBtn";
            addMenuBtn.Size = new Size(75, 23);
            addMenuBtn.TabIndex = 38;
            addMenuBtn.Text = "Add";
            addMenuBtn.UseVisualStyleBackColor = true;
            addMenuBtn.Click += addMenuBtn_Click;
            // 
            // menuGrid
            // 
            menuGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            menuGrid.Location = new Point(0, 257);
            menuGrid.Name = "menuGrid";
            menuGrid.Size = new Size(853, 397);
            menuGrid.TabIndex = 37;
            menuGrid.CellClick += menuGrid_CellClick;
            menuGrid.CellContentClick += dataGridView1_CellContentClick;
            menuGrid.SelectionChanged += menuGrid_SelectionChanged;
            // 
            // menuPriceTextBox
            // 
            menuPriceTextBox.Location = new Point(128, 117);
            menuPriceTextBox.Name = "menuPriceTextBox";
            menuPriceTextBox.Size = new Size(100, 23);
            menuPriceTextBox.TabIndex = 9;
            // 
            // menuQuantityTextBox
            // 
            menuQuantityTextBox.Location = new Point(128, 87);
            menuQuantityTextBox.Name = "menuQuantityTextBox";
            menuQuantityTextBox.Size = new Size(100, 23);
            menuQuantityTextBox.TabIndex = 8;
            // 
            // menuDescriptionTextBox
            // 
            menuDescriptionTextBox.Location = new Point(128, 58);
            menuDescriptionTextBox.Name = "menuDescriptionTextBox";
            menuDescriptionTextBox.Size = new Size(100, 23);
            menuDescriptionTextBox.TabIndex = 7;
            // 
            // menuNameTextBox
            // 
            menuNameTextBox.Location = new Point(128, 29);
            menuNameTextBox.Name = "menuNameTextBox";
            menuNameTextBox.Size = new Size(100, 23);
            menuNameTextBox.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 66);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 5;
            label5.Text = "Description";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 155);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 4;
            label4.Text = "Category";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 128);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 3;
            label2.Text = "Price";
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Location = new Point(32, 95);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new Size(56, 15);
            quantityLabel.TabIndex = 2;
            quantityLabel.Text = "Quantity:";
            // 
            // menuName
            // 
            menuName.AutoSize = true;
            menuName.Location = new Point(32, 37);
            menuName.Name = "menuName";
            menuName.Size = new Size(45, 15);
            menuName.TabIndex = 1;
            menuName.Text = "Name: ";
            // 
            // menuLabel
            // 
            menuLabel.AutoSize = true;
            menuLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuLabel.Location = new Point(481, 46);
            menuLabel.Name = "menuLabel";
            menuLabel.Size = new Size(165, 30);
            menuLabel.TabIndex = 0;
            menuLabel.Text = "Menu Panel Test";
            // 
            // userShowBtn
            // 
            userShowBtn.Location = new Point(657, 289);
            userShowBtn.Name = "userShowBtn";
            userShowBtn.Size = new Size(106, 23);
            userShowBtn.TabIndex = 44;
            userShowBtn.Text = "Show All Users";
            userShowBtn.UseVisualStyleBackColor = true;
            userShowBtn.Click += userShowBtn_Click;
            // 
            // userSearchBox
            // 
            userSearchBox.Location = new Point(88, 229);
            userSearchBox.Name = "userSearchBox";
            userSearchBox.Size = new Size(100, 23);
            userSearchBox.TabIndex = 43;
            userSearchBox.Text = "Search User";
            // 
            // userSearchBtn
            // 
            userSearchBtn.Location = new Point(214, 228);
            userSearchBtn.Name = "userSearchBtn";
            userSearchBtn.Size = new Size(75, 23);
            userSearchBtn.TabIndex = 42;
            userSearchBtn.Text = "Go";
            userSearchBtn.UseVisualStyleBackColor = true;
            userSearchBtn.Click += userSearchBtn_Click;
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
            userTableGrid.MultiSelect = false;
            userTableGrid.Name = "userTableGrid";
            userTableGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            userTableGrid.Size = new Size(853, 319);
            userTableGrid.TabIndex = 30;
            userTableGrid.CellContentClick += userTableGrid_CellContentClick_1;
            userTableGrid.SelectionChanged += userTableGrid_SelectionChanged;
            // 
            // menuListBtn
            // 
            menuListBtn.Location = new Point(23, 113);
            menuListBtn.Name = "menuListBtn";
            menuListBtn.Size = new Size(75, 23);
            menuListBtn.TabIndex = 31;
            menuListBtn.Text = "Menu";
            menuListBtn.UseVisualStyleBackColor = true;
            menuListBtn.Click += menuListBtn_Click;
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
            stockPanel.Controls.Add(stockSortComboBox);
            stockPanel.Controls.Add(button1);
            stockPanel.Controls.Add(stockSearchBtn);
            stockPanel.Controls.Add(stockSearchBox);
            stockPanel.Controls.Add(stockGridView);
            stockPanel.Location = new Point(155, 75);
            stockPanel.Name = "stockPanel";
            stockPanel.Size = new Size(850, 654);
            stockPanel.TabIndex = 4;
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
            stockSortComboBox.SelectedIndexChanged += stockSortComboBox_SelectedIndexChanged_1;
            // 
            // button1
            // 
            button1.Location = new Point(616, 4);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Show All";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // stockSearchBtn
            // 
            stockSearchBtn.Location = new Point(535, 4);
            stockSearchBtn.Name = "stockSearchBtn";
            stockSearchBtn.Size = new Size(75, 23);
            stockSearchBtn.TabIndex = 2;
            stockSearchBtn.Text = "Search";
            stockSearchBtn.UseVisualStyleBackColor = true;
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
            stockGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            stockGridView.Location = new Point(17, 49);
            stockGridView.Name = "stockGridView";
            stockGridView.Size = new Size(850, 605);
            stockGridView.TabIndex = 3;
            stockGridView.CellContentClick += stockGridView_CellContentClick;
            // 
            // dataPanel
            // 
            dataPanel.Controls.Add(dataPanelLabel);
            dataPanel.Location = new Point(155, 75);
            dataPanel.Name = "dataPanel";
            dataPanel.Size = new Size(867, 654);
            dataPanel.TabIndex = 5;
            dataPanel.Paint += dataPanel_Paint;
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
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 729);
            Controls.Add(menuListBtn);
            Controls.Add(manageUserBtn);
            Controls.Add(dataBtn);
            Controls.Add(stockBtn);
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
            Name = "AdminDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Dashboard";
            Load += AdminDashboard_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            userPanel.ResumeLayout(false);
            userPanel.PerformLayout();
            menuPanel.ResumeLayout(false);
            menuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)menuGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)userTableGrid).EndInit();
            stockPanel.ResumeLayout(false);
            stockPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)stockGridView).EndInit();
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
        private Button menuListBtn;
        private Panel menuPanel;
        private Label menuLabel;
        private Button stockBtn;
        private Panel stockPanel;
        private Button dataBtn;
        private Panel dataPanel;
        private Label dataPanelLabel;
        private TextBox passwordFieldBox;
        private Label passwordLabel;
        private Label label4;
        private Label label2;
        private Label quantityLabel;
        private Label menuName;
        private Button editMenuBtn;
        private Button addMenuBtn;
        private DataGridView menuGrid;
        private TextBox menuPriceTextBox;
        private TextBox menuQuantityTextBox;
        private TextBox menuDescriptionTextBox;
        private TextBox menuNameTextBox;
        private Label label5;
        private Button deleteMenuBtn;
        private ComboBox categoryComboBox;
        private TextBox menuSearchBox;
        private Button menuSearchBtn;
        private Button menuShowDetailsBtn;
        private TextBox userSearchBox;
        private Button userSearchBtn;
        private Button userShowBtn;
        private TextBox stockSearchBox;
        private ComboBox stockSortComboBox;
        private Button button1;
        private Button stockSearchBtn;
        private DataGridView stockGridView;
    }
}