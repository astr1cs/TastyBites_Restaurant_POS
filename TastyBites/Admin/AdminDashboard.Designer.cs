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
            usernameLabel = new Label();
            pictureBox1 = new PictureBox();
            logoutBtn = new Button();
            userName = new Label();
            adminLabel = new Label();
            manageUserBtn = new Button();
            userPanel = new Panel();
            label8 = new Label();
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
            menuPanel = new Panel();
            label1 = new Label();
            label6 = new Label();
            menuShowDetailsBtn = new Button();
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
            menuSearchBtn = new Button();
            menuSearchBox = new TextBox();
            menuListBtn = new Button();
            stockBtn = new Button();
            stockPanel = new Panel();
            stockSortComboBox = new ComboBox();
            button1 = new Button();
            stockSearchBtn = new Button();
            stockGridView = new DataGridView();
            stockSearchBox = new TextBox();
            dataPanel = new Panel();
            dataPanelLabel = new Label();
            dataBtn = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            userPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)userTableGrid).BeginInit();
            menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)menuGrid).BeginInit();
            stockPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)stockGridView).BeginInit();
            dataPanel.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
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
            pictureBox1.Size = new Size(137, 70);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // logoutBtn
            // 
            logoutBtn.BackColor = Color.FromArgb(27, 160, 156);
            logoutBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logoutBtn.ForeColor = Color.White;
            logoutBtn.Location = new Point(12, 659);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.Size = new Size(128, 31);
            logoutBtn.TabIndex = 10;
            logoutBtn.Text = "Logout";
            logoutBtn.UseVisualStyleBackColor = false;
            logoutBtn.Click += LogoutBtn_Click;
            // 
            // userName
            // 
            userName.AutoSize = true;
            userName.Font = new Font("MS Reference Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userName.ImageAlign = ContentAlignment.MiddleLeft;
            userName.Location = new Point(801, 7);
            userName.Name = "userName";
            userName.Padding = new Padding(10, 0, 10, 0);
            userName.Size = new Size(149, 24);
            userName.TabIndex = 16;
            userName.Text = "Meraz Uddin";
            userName.TextAlign = ContentAlignment.MiddleLeft;
            userName.Click += userName_Click;
            // 
            // adminLabel
            // 
            adminLabel.AutoSize = true;
            adminLabel.Font = new Font("Microsoft Sans Serif", 8.25F);
            adminLabel.ForeColor = SystemColors.ControlDarkDark;
            adminLabel.ImageAlign = ContentAlignment.MiddleLeft;
            adminLabel.Location = new Point(804, 31);
            adminLabel.Name = "adminLabel";
            adminLabel.Padding = new Padding(10, 0, 10, 0);
            adminLabel.Size = new Size(56, 13);
            adminLabel.TabIndex = 17;
            adminLabel.Text = "Admin";
            adminLabel.Click += adminLabel_Click;
            // 
            // manageUserBtn
            // 
            manageUserBtn.Font = new Font("Microsoft Sans Serif", 12F);
            manageUserBtn.Location = new Point(25, 100);
            manageUserBtn.Name = "manageUserBtn";
            manageUserBtn.Size = new Size(87, 28);
            manageUserBtn.TabIndex = 18;
            manageUserBtn.Text = "Manage User";
            manageUserBtn.TextAlign = ContentAlignment.MiddleLeft;
            manageUserBtn.UseVisualStyleBackColor = true;
            manageUserBtn.Click += manageUserBtn_Click;
            // 
            // userPanel
            // 
            userPanel.Controls.Add(label8);
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
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("MS Reference Sans Serif", 15.75F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label8.Location = new Point(16, 16);
            label8.Name = "label8";
            label8.Size = new Size(204, 26);
            label8.TabIndex = 49;
            label8.Text = "User Management";
            // 
            // userShowBtn
            // 
            userShowBtn.Location = new Point(721, 15);
            userShowBtn.Name = "userShowBtn";
            userShowBtn.Size = new Size(106, 23);
            userShowBtn.TabIndex = 44;
            userShowBtn.Text = "Show All Users";
            userShowBtn.UseVisualStyleBackColor = true;
            userShowBtn.Click += userShowBtn_Click;
            // 
            // userSearchBox
            // 
            userSearchBox.Location = new Point(304, 16);
            userSearchBox.Name = "userSearchBox";
            userSearchBox.Size = new Size(230, 23);
            userSearchBox.TabIndex = 43;
            userSearchBox.Text = "Search User";
            // 
            // userSearchBtn
            // 
            userSearchBtn.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userSearchBtn.Location = new Point(550, 16);
            userSearchBtn.Name = "userSearchBtn";
            userSearchBtn.Size = new Size(75, 23);
            userSearchBtn.TabIndex = 42;
            userSearchBtn.Text = "Go";
            userSearchBtn.UseVisualStyleBackColor = true;
            userSearchBtn.Click += userSearchBtn_Click;
            // 
            // passwordFieldBox
            // 
            passwordFieldBox.Location = new Point(120, 139);
            passwordFieldBox.Name = "passwordFieldBox";
            passwordFieldBox.PasswordChar = '*';
            passwordFieldBox.Size = new Size(120, 23);
            passwordFieldBox.TabIndex = 41;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Microsoft Sans Serif", 12F);
            passwordLabel.Location = new Point(17, 142);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(82, 20);
            passwordLabel.TabIndex = 40;
            passwordLabel.Text = "Password:";
            // 
            // roleComboBox
            // 
            roleComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            roleComboBox.FormattingEnabled = true;
            roleComboBox.Items.AddRange(new object[] { "Admin", "Manager", "Staff" });
            roleComboBox.Location = new Point(119, 189);
            roleComboBox.Name = "roleComboBox";
            roleComboBox.Size = new Size(121, 23);
            roleComboBox.TabIndex = 39;
            // 
            // userNameTextBox
            // 
            userNameTextBox.Location = new Point(119, 92);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.Size = new Size(120, 23);
            userNameTextBox.TabIndex = 38;
            // 
            // deleteUser
            // 
            deleteUser.Font = new Font("Microsoft Sans Serif", 12F);
            deleteUser.Location = new Point(132, 300);
            deleteUser.Name = "deleteUser";
            deleteUser.Size = new Size(107, 36);
            deleteUser.TabIndex = 36;
            deleteUser.Text = "Delete";
            deleteUser.UseVisualStyleBackColor = true;
            deleteUser.Click += deleteUser_Click;
            // 
            // editUser
            // 
            editUser.Font = new Font("Microsoft Sans Serif", 12F);
            editUser.Location = new Point(17, 300);
            editUser.Name = "editUser";
            editUser.Size = new Size(109, 36);
            editUser.TabIndex = 35;
            editUser.Text = "Edit";
            editUser.UseVisualStyleBackColor = true;
            editUser.Click += editUser_Click;
            // 
            // addUser
            // 
            addUser.BackColor = Color.FromArgb(27, 160, 156);
            addUser.Font = new Font("Microsoft Sans Serif", 12F);
            addUser.ForeColor = Color.White;
            addUser.Location = new Point(17, 246);
            addUser.Name = "addUser";
            addUser.Size = new Size(223, 41);
            addUser.TabIndex = 34;
            addUser.Text = "Add";
            addUser.UseVisualStyleBackColor = false;
            addUser.Click += addUser_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F);
            label3.Location = new Point(17, 192);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 33;
            label3.Text = "Role:";
            // 
            // userLabel
            // 
            userLabel.AutoSize = true;
            userLabel.Font = new Font("Microsoft Sans Serif", 12F);
            userLabel.Location = new Point(17, 92);
            userLabel.Name = "userLabel";
            userLabel.Size = new Size(87, 20);
            userLabel.TabIndex = 32;
            userLabel.Text = "Username:";
            // 
            // userTableGrid
            // 
            userTableGrid.BackgroundColor = SystemColors.ButtonHighlight;
            userTableGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            userTableGrid.Location = new Point(275, 51);
            userTableGrid.MultiSelect = false;
            userTableGrid.Name = "userTableGrid";
            userTableGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            userTableGrid.Size = new Size(578, 603);
            userTableGrid.TabIndex = 30;
            userTableGrid.CellContentClick += userTableGrid_CellContentClick_1;
            userTableGrid.SelectionChanged += userTableGrid_SelectionChanged;
            // 
            // menuPanel
            // 
            menuPanel.Controls.Add(menuSearchBox);
            menuPanel.Controls.Add(menuSearchBtn);
            menuPanel.Controls.Add(label1);
            menuPanel.Controls.Add(label6);
            menuPanel.Controls.Add(menuShowDetailsBtn);
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
            menuPanel.Location = new Point(146, 75);
            menuPanel.Name = "menuPanel";
            menuPanel.Size = new Size(862, 654);
            menuPanel.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS Reference Sans Serif", 15.75F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(345, 314);
            label1.Name = "label1";
            label1.Size = new Size(172, 26);
            label1.TabIndex = 47;
            label1.Text = "Manage Dishes";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("MS Reference Sans Serif", 15.75F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label6.Location = new Point(25, 10);
            label6.Name = "label6";
            label6.Size = new Size(172, 26);
            label6.TabIndex = 45;
            label6.Text = "Manage Dishes";
            // 
            // menuShowDetailsBtn
            // 
            menuShowDetailsBtn.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuShowDetailsBtn.Location = new Point(730, 7);
            menuShowDetailsBtn.Name = "menuShowDetailsBtn";
            menuShowDetailsBtn.Size = new Size(120, 23);
            menuShowDetailsBtn.TabIndex = 44;
            menuShowDetailsBtn.Text = "Show All Details";
            menuShowDetailsBtn.UseVisualStyleBackColor = true;
            // 
            // categoryComboBox
            // 
            categoryComboBox.FormattingEnabled = true;
            categoryComboBox.Items.AddRange(new object[] { "Drinks", "Main", "Desserts" });
            categoryComboBox.Location = new Point(120, 290);
            categoryComboBox.Name = "categoryComboBox";
            categoryComboBox.Size = new Size(121, 23);
            categoryComboBox.TabIndex = 41;
            // 
            // deleteMenuBtn
            // 
            deleteMenuBtn.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deleteMenuBtn.Location = new Point(137, 404);
            deleteMenuBtn.Name = "deleteMenuBtn";
            deleteMenuBtn.Size = new Size(105, 33);
            deleteMenuBtn.TabIndex = 40;
            deleteMenuBtn.Text = "Delete";
            deleteMenuBtn.UseVisualStyleBackColor = true;
            deleteMenuBtn.Click += deleteMenuBtn_Click;
            // 
            // editMenuBtn
            // 
            editMenuBtn.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            editMenuBtn.Location = new Point(25, 404);
            editMenuBtn.Name = "editMenuBtn";
            editMenuBtn.Size = new Size(104, 33);
            editMenuBtn.TabIndex = 39;
            editMenuBtn.Text = "Edit";
            editMenuBtn.UseVisualStyleBackColor = true;
            editMenuBtn.Click += editMenuBtn_Click;
            // 
            // addMenuBtn
            // 
            addMenuBtn.BackColor = Color.FromArgb(27, 160, 156);
            addMenuBtn.FlatStyle = FlatStyle.Popup;
            addMenuBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addMenuBtn.ForeColor = Color.White;
            addMenuBtn.Location = new Point(25, 355);
            addMenuBtn.Name = "addMenuBtn";
            addMenuBtn.Size = new Size(216, 30);
            addMenuBtn.TabIndex = 38;
            addMenuBtn.Text = "Add New Dishes";
            addMenuBtn.UseVisualStyleBackColor = false;
            addMenuBtn.Click += addMenuBtn_Click;
            // 
            // menuGrid
            // 
            menuGrid.AllowUserToAddRows = false;
            menuGrid.AllowUserToDeleteRows = false;
            menuGrid.AllowUserToResizeColumns = false;
            menuGrid.AllowUserToResizeRows = false;
            menuGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            menuGrid.Location = new Point(284, 38);
            menuGrid.Name = "menuGrid";
            menuGrid.ReadOnly = true;
            menuGrid.Size = new Size(578, 616);
            menuGrid.TabIndex = 37;
            menuGrid.CellClick += menuGrid_CellClick;
            menuGrid.CellContentClick += dataGridView1_CellContentClick;
            menuGrid.SelectionChanged += menuGrid_SelectionChanged;
            // 
            // menuPriceTextBox
            // 
            menuPriceTextBox.Location = new Point(120, 240);
            menuPriceTextBox.Name = "menuPriceTextBox";
            menuPriceTextBox.Size = new Size(121, 23);
            menuPriceTextBox.TabIndex = 9;
            // 
            // menuQuantityTextBox
            // 
            menuQuantityTextBox.Location = new Point(120, 190);
            menuQuantityTextBox.Name = "menuQuantityTextBox";
            menuQuantityTextBox.Size = new Size(121, 23);
            menuQuantityTextBox.TabIndex = 8;
            // 
            // menuDescriptionTextBox
            // 
            menuDescriptionTextBox.Location = new Point(120, 140);
            menuDescriptionTextBox.Name = "menuDescriptionTextBox";
            menuDescriptionTextBox.Size = new Size(121, 23);
            menuDescriptionTextBox.TabIndex = 7;
            // 
            // menuNameTextBox
            // 
            menuNameTextBox.Location = new Point(120, 90);
            menuNameTextBox.Name = "menuNameTextBox";
            menuNameTextBox.Size = new Size(121, 23);
            menuNameTextBox.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F);
            label5.Location = new Point(25, 140);
            label5.Name = "label5";
            label5.Size = new Size(93, 20);
            label5.TabIndex = 5;
            label5.Text = "Description:";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F);
            label4.Location = new Point(25, 290);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 4;
            label4.Text = "Category:";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F);
            label2.Location = new Point(25, 240);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 3;
            label2.Text = "Price:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Font = new Font("Microsoft Sans Serif", 12F);
            quantityLabel.Location = new Point(25, 190);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new Size(72, 20);
            quantityLabel.TabIndex = 2;
            quantityLabel.Text = "Quantity:";
            quantityLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // menuName
            // 
            menuName.AutoSize = true;
            menuName.BackColor = SystemColors.ButtonHighlight;
            menuName.Font = new Font("Microsoft Sans Serif", 12F);
            menuName.Location = new Point(25, 90);
            menuName.Name = "menuName";
            menuName.Size = new Size(59, 20);
            menuName.TabIndex = 1;
            menuName.Text = "Name: ";
            menuName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // menuSearchBtn
            // 
            menuSearchBtn.BackColor = Color.FromArgb(27, 160, 156);
            menuSearchBtn.Font = new Font("Microsoft Sans Serif", 8.25F);
            menuSearchBtn.ForeColor = Color.White;
            menuSearchBtn.Location = new Point(583, 8);
            menuSearchBtn.Name = "menuSearchBtn";
            menuSearchBtn.Size = new Size(45, 23);
            menuSearchBtn.TabIndex = 43;
            menuSearchBtn.Text = "Go";
            menuSearchBtn.UseVisualStyleBackColor = false;
            menuSearchBtn.Click += menuSearchBtn_Click;
            // 
            // menuSearchBox
            // 
            menuSearchBox.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuSearchBox.ForeColor = Color.Gray;
            menuSearchBox.Location = new Point(345, 9);
            menuSearchBox.Name = "menuSearchBox";
            menuSearchBox.Size = new Size(232, 22);
            menuSearchBox.TabIndex = 42;
            menuSearchBox.Text = "Search Menu Items";
            menuSearchBox.TextChanged += menuSearchBox_TextChanged;
            // 
            // menuListBtn
            // 
            menuListBtn.Font = new Font("Microsoft Sans Serif", 12F);
            menuListBtn.Location = new Point(25, 50);
            menuListBtn.Name = "menuListBtn";
            menuListBtn.Size = new Size(87, 33);
            menuListBtn.TabIndex = 31;
            menuListBtn.Text = "Menu";
            menuListBtn.TextAlign = ContentAlignment.MiddleLeft;
            menuListBtn.UseVisualStyleBackColor = true;
            menuListBtn.Click += menuListBtn_Click;
            // 
            // stockBtn
            // 
            stockBtn.Font = new Font("Microsoft Sans Serif", 12F);
            stockBtn.Location = new Point(25, 150);
            stockBtn.Name = "stockBtn";
            stockBtn.Size = new Size(87, 32);
            stockBtn.TabIndex = 33;
            stockBtn.Text = "Stock Manage";
            stockBtn.TextAlign = ContentAlignment.MiddleLeft;
            stockBtn.UseVisualStyleBackColor = true;
            stockBtn.Click += stockBtn_Click;
            // 
            // stockPanel
            // 
            stockPanel.Controls.Add(stockSortComboBox);
            stockPanel.Controls.Add(button1);
            stockPanel.Controls.Add(stockSearchBtn);
            stockPanel.Controls.Add(stockGridView);
            stockPanel.Controls.Add(stockSearchBox);
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
            // stockGridView
            // 
            stockGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            stockGridView.Location = new Point(17, 49);
            stockGridView.Name = "stockGridView";
            stockGridView.Size = new Size(850, 605);
            stockGridView.TabIndex = 3;
            stockGridView.CellContentClick += stockGridView_CellContentClick;
            // 
            // stockSearchBox
            // 
            stockSearchBox.Location = new Point(5, 4);
            stockSearchBox.Name = "stockSearchBox";
            stockSearchBox.Size = new Size(524, 23);
            stockSearchBox.TabIndex = 1;
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
            dataBtn.Font = new Font("Microsoft Sans Serif", 12F);
            dataBtn.Location = new Point(25, 200);
            dataBtn.Name = "dataBtn";
            dataBtn.Size = new Size(87, 33);
            dataBtn.TabIndex = 35;
            dataBtn.Text = "Data";
            dataBtn.TextAlign = ContentAlignment.MiddleLeft;
            dataBtn.UseVisualStyleBackColor = true;
            dataBtn.Click += dataBtn_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(dataBtn);
            panel1.Controls.Add(stockBtn);
            panel1.Controls.Add(manageUserBtn);
            panel1.Controls.Add(menuListBtn);
            panel1.Location = new Point(-1, 76);
            panel1.Name = "panel1";
            panel1.Size = new Size(150, 653);
            panel1.TabIndex = 44;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.Location = new Point(0, -1);
            panel2.Name = "panel2";
            panel2.Size = new Size(1008, 75);
            panel2.TabIndex = 45;
            panel2.Paint += panel2_Paint;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1008, 729);
            Controls.Add(adminLabel);
            Controls.Add(userName);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Controls.Add(logoutBtn);
            Controls.Add(panel1);
            Controls.Add(usernameLabel);
            Controls.Add(menuPanel);
            Controls.Add(userPanel);
            Controls.Add(dataPanel);
            Controls.Add(stockPanel);
            Name = "AdminDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Dashboard";
            Load += AdminDashboard_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            userPanel.ResumeLayout(false);
            userPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)userTableGrid).EndInit();
            menuPanel.ResumeLayout(false);
            menuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)menuGrid).EndInit();
            stockPanel.ResumeLayout(false);
            stockPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)stockGridView).EndInit();
            dataPanel.ResumeLayout(false);
            dataPanel.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label usernameLabel;
        private PictureBox pictureBox1;
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
        private Label label6;
        private Panel panel1;
        private Panel panel2;
        private Label label8;
        private Label label1;
    }
}