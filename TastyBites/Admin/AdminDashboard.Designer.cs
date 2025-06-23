using System.ComponentModel;

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
            ComponentResourceManager resources = new ComponentResourceManager(typeof(AdminDashboard));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            usernameLabel = new Label();
            pictureBox1 = new PictureBox();
            logoutBtn = new Button();
            userName = new Label();
            adminLabel = new Label();
            manageUserBtn = new Button();
            userPanel = new Panel();
            userShowBtn = new Button();
            userManageLabel = new Label();
            userSearchBox = new TextBox();
            userSearchBtn = new Button();
            passwordFieldBox = new TextBox();
            passwordLabel = new Label();
            roleComboBox = new ComboBox();
            userNameTextBox = new TextBox();
            deleteUser = new Button();
            editUser = new Button();
            label3 = new Label();
            userLabel = new Label();
            userTableGrid = new DataGridView();
            addUser = new Button();
            saveChangesButton = new Button();
            menuPanel = new Panel();
            saveChangesMenu = new Button();
            menuSearchBox = new TextBox();
            menuSearchBtn = new Button();
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
            menuListBtn = new Button();
            stockBtn = new Button();
            stockPanel = new Panel();
            stockSortComboBox = new ComboBox();
            button1 = new Button();
            stockSearchBtn = new Button();
            stockSearchBox = new TextBox();
            stockGridView = new DataGridView();
            dataPanel = new Panel();
            label1 = new Label();
            orderHistoryShowBtn = new Button();
            orderHistorySearchBtn = new Button();
            orderHistorySearchBox = new TextBox();
            stockHistoryGrid = new DataGridView();
            orderHistoryBtn = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            ((ISupportInitialize)pictureBox1).BeginInit();
            userPanel.SuspendLayout();
            ((ISupportInitialize)userTableGrid).BeginInit();
            menuPanel.SuspendLayout();
            ((ISupportInitialize)menuGrid).BeginInit();
            stockPanel.SuspendLayout();
            ((ISupportInitialize)stockGridView).BeginInit();
            dataPanel.SuspendLayout();
            ((ISupportInitialize)stockHistoryGrid).BeginInit();
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
            // 
            // manageUserBtn
            // 
            manageUserBtn.Font = new Font("Microsoft Sans Serif", 12F);
            manageUserBtn.Location = new Point(25, 150);
            manageUserBtn.Name = "manageUserBtn";
            manageUserBtn.Size = new Size(115, 30);
            manageUserBtn.TabIndex = 18;
            manageUserBtn.Text = "Manage User";
            manageUserBtn.UseVisualStyleBackColor = true;
            manageUserBtn.Click += manageUserBtn_Click;
            // 
            // userPanel
            // 
            userPanel.Controls.Add(userShowBtn);
            userPanel.Controls.Add(userManageLabel);
            userPanel.Controls.Add(userSearchBox);
            userPanel.Controls.Add(userSearchBtn);
            userPanel.Controls.Add(passwordFieldBox);
            userPanel.Controls.Add(passwordLabel);
            userPanel.Controls.Add(roleComboBox);
            userPanel.Controls.Add(userNameTextBox);
            userPanel.Controls.Add(deleteUser);
            userPanel.Controls.Add(editUser);
            userPanel.Controls.Add(label3);
            userPanel.Controls.Add(userLabel);
            userPanel.Controls.Add(userTableGrid);
            userPanel.Controls.Add(addUser);
            userPanel.Controls.Add(saveChangesButton);
            userPanel.Location = new Point(155, 75);
            userPanel.Name = "userPanel";
            userPanel.Size = new Size(853, 654);
            userPanel.TabIndex = 2;
            // 
            // userShowBtn
            // 
            userShowBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userShowBtn.Location = new Point(697, 9);
            userShowBtn.Name = "userShowBtn";
            userShowBtn.Size = new Size(106, 29);
            userShowBtn.TabIndex = 44;
            userShowBtn.Text = "Show All";
            userShowBtn.UseVisualStyleBackColor = true;
            userShowBtn.Click += userShowBtn_Click;
            // 
            // userManageLabel
            // 
            userManageLabel.AutoSize = true;
            userManageLabel.Font = new Font("MS Reference Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userManageLabel.Location = new Point(25, 15);
            userManageLabel.Name = "userManageLabel";
            userManageLabel.Size = new Size(204, 26);
            userManageLabel.TabIndex = 49;
            userManageLabel.Text = "User Management";
            // 
            // userSearchBox
            // 
            userSearchBox.Location = new Point(304, 14);
            userSearchBox.Name = "userSearchBox";
            userSearchBox.Size = new Size(230, 23);
            userSearchBox.TabIndex = 43;
            userSearchBox.Text = "Search User";
            // 
            // userSearchBtn
            // 
            userSearchBtn.BackColor = Color.FromArgb(27, 160, 156);
            userSearchBtn.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userSearchBtn.ForeColor = Color.White;
            userSearchBtn.Location = new Point(540, 10);
            userSearchBtn.Name = "userSearchBtn";
            userSearchBtn.Size = new Size(57, 29);
            userSearchBtn.TabIndex = 42;
            userSearchBtn.Text = "Go";
            userSearchBtn.UseVisualStyleBackColor = false;
            userSearchBtn.Click += userSearchBtn_Click;
            // 
            // passwordFieldBox
            // 
            passwordFieldBox.Location = new Point(128, 124);
            passwordFieldBox.Name = "passwordFieldBox";
            passwordFieldBox.PasswordChar = '*';
            passwordFieldBox.Size = new Size(120, 23);
            passwordFieldBox.TabIndex = 41;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Microsoft Sans Serif", 12F);
            passwordLabel.Location = new Point(25, 127);
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
            roleComboBox.Location = new Point(127, 174);
            roleComboBox.Name = "roleComboBox";
            roleComboBox.Size = new Size(121, 23);
            roleComboBox.TabIndex = 39;
            // 
            // userNameTextBox
            // 
            userNameTextBox.Location = new Point(127, 77);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.Size = new Size(120, 23);
            userNameTextBox.TabIndex = 38;
            // 
            // deleteUser
            // 
            deleteUser.Font = new Font("Microsoft Sans Serif", 12F);
            deleteUser.Location = new Point(140, 285);
            deleteUser.Name = "deleteUser";
            deleteUser.Size = new Size(109, 35);
            deleteUser.TabIndex = 36;
            deleteUser.Text = "Delete";
            deleteUser.UseVisualStyleBackColor = true;
            deleteUser.Click += deleteUser_Click;
            // 
            // editUser
            // 
            editUser.Font = new Font("Microsoft Sans Serif", 12F);
            editUser.Location = new Point(25, 285);
            editUser.Name = "editUser";
            editUser.Size = new Size(109, 35);
            editUser.TabIndex = 35;
            editUser.Text = "Edit";
            editUser.UseVisualStyleBackColor = true;
            editUser.Click += editUser_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F);
            label3.Location = new Point(25, 177);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 33;
            label3.Text = "Role:";
            // 
            // userLabel
            // 
            userLabel.AutoSize = true;
            userLabel.Font = new Font("Microsoft Sans Serif", 12F);
            userLabel.Location = new Point(25, 77);
            userLabel.Name = "userLabel";
            userLabel.Size = new Size(87, 20);
            userLabel.TabIndex = 32;
            userLabel.Text = "Username:";
            // 
            // userTableGrid
            // 
            userTableGrid.AllowUserToAddRows = false;
            userTableGrid.AllowUserToDeleteRows = false;
            userTableGrid.AllowUserToResizeColumns = false;
            userTableGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            userTableGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            userTableGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            userTableGrid.BackgroundColor = Color.WhiteSmoke;
            userTableGrid.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.SteelBlue;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            userTableGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            userTableGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.LightSteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            userTableGrid.DefaultCellStyle = dataGridViewCellStyle3;
            userTableGrid.EnableHeadersVisualStyles = false;
            userTableGrid.GridColor = Color.LightGray;
            userTableGrid.Location = new Point(275, 51);
            userTableGrid.MultiSelect = false;
            userTableGrid.Name = "userTableGrid";
            userTableGrid.ReadOnly = true;
            userTableGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            userTableGrid.Size = new Size(546, 564);
            userTableGrid.TabIndex = 45;
            // 
            // addUser
            // 
            addUser.BackColor = Color.FromArgb(27, 160, 156);
            addUser.Font = new Font("Microsoft Sans Serif", 12F);
            addUser.ForeColor = Color.White;
            addUser.Location = new Point(25, 231);
            addUser.Name = "addUser";
            addUser.Size = new Size(223, 40);
            addUser.TabIndex = 55;
            addUser.Text = "Add";
            addUser.UseVisualStyleBackColor = false;
            addUser.Click += addUser_Click;
            // 
            // saveChangesButton
            // 
            saveChangesButton.BackColor = Color.FromArgb(27, 160, 156);
            saveChangesButton.Font = new Font("Microsoft Sans Serif", 12F);
            saveChangesButton.ForeColor = Color.White;
            saveChangesButton.Location = new Point(25, 231);
            saveChangesButton.Name = "saveChangesButton";
            saveChangesButton.Size = new Size(223, 41);
            saveChangesButton.TabIndex = 46;
            saveChangesButton.Text = "Save Changes";
            saveChangesButton.UseVisualStyleBackColor = false;
            saveChangesButton.Click += saveChangesButton_Click;
            // 
            // menuPanel
            // 
            menuPanel.Controls.Add(saveChangesMenu);
            menuPanel.Controls.Add(menuSearchBox);
            menuPanel.Controls.Add(menuSearchBtn);
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
            // saveChangesMenu
            // 
            saveChangesMenu.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            saveChangesMenu.Location = new Point(565, 48);
            saveChangesMenu.Name = "saveChangesMenu";
            saveChangesMenu.Size = new Size(128, 33);
            saveChangesMenu.TabIndex = 46;
            saveChangesMenu.Text = "Save Changes";
            saveChangesMenu.UseVisualStyleBackColor = true;
            saveChangesMenu.Click += saveChangesMenu_Click;
            // 
            // menuSearchBox
            // 
            menuSearchBox.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuSearchBox.ForeColor = Color.Gray;
            menuSearchBox.Location = new Point(549, 190);
            menuSearchBox.Name = "menuSearchBox";
            menuSearchBox.Size = new Size(232, 22);
            menuSearchBox.TabIndex = 42;
            menuSearchBox.Text = "Search Menu Items";
            // 
            // menuSearchBtn
            // 
            menuSearchBtn.BackColor = Color.FromArgb(27, 160, 156);
            menuSearchBtn.Font = new Font("Microsoft Sans Serif", 8.25F);
            menuSearchBtn.ForeColor = Color.White;
            menuSearchBtn.Location = new Point(787, 185);
            menuSearchBtn.Name = "menuSearchBtn";
            menuSearchBtn.Size = new Size(45, 30);
            menuSearchBtn.TabIndex = 43;
            menuSearchBtn.Text = "Go";
            menuSearchBtn.UseVisualStyleBackColor = false;
            menuSearchBtn.Click += menuSearchBtn_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("MS Reference Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(25, 15);
            label6.Name = "label6";
            label6.Size = new Size(172, 26);
            label6.TabIndex = 45;
            label6.Text = "Manage Dishes";
            // 
            // menuShowDetailsBtn
            // 
            menuShowDetailsBtn.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuShowDetailsBtn.Location = new Point(566, 151);
            menuShowDetailsBtn.Name = "menuShowDetailsBtn";
            menuShowDetailsBtn.Size = new Size(128, 27);
            menuShowDetailsBtn.TabIndex = 44;
            menuShowDetailsBtn.Text = "Show All Details";
            menuShowDetailsBtn.UseVisualStyleBackColor = true;
            menuShowDetailsBtn.Click += menuShowDetailsBtn_Click;
            // 
            // categoryComboBox
            // 
            categoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            categoryComboBox.Font = new Font("Microsoft Sans Serif", 9F);
            categoryComboBox.FormattingEnabled = true;
            categoryComboBox.Items.AddRange(new object[] { "Drinks", "Main", "Desserts" });
            categoryComboBox.Location = new Point(388, 107);
            categoryComboBox.Name = "categoryComboBox";
            categoryComboBox.Size = new Size(121, 23);
            categoryComboBox.TabIndex = 41;
            // 
            // deleteMenuBtn
            // 
            deleteMenuBtn.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deleteMenuBtn.Location = new Point(566, 98);
            deleteMenuBtn.Name = "deleteMenuBtn";
            deleteMenuBtn.Size = new Size(128, 33);
            deleteMenuBtn.TabIndex = 40;
            deleteMenuBtn.Text = "Delete";
            deleteMenuBtn.UseVisualStyleBackColor = true;
            deleteMenuBtn.Click += deleteMenuBtn_Click;
            // 
            // editMenuBtn
            // 
            editMenuBtn.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            editMenuBtn.Location = new Point(566, 48);
            editMenuBtn.Name = "editMenuBtn";
            editMenuBtn.Size = new Size(128, 33);
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
            addMenuBtn.Location = new Point(293, 151);
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
            dataGridViewCellStyle4.BackColor = Color.White;
            menuGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            menuGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            menuGrid.BackgroundColor = Color.WhiteSmoke;
            menuGrid.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.SteelBlue;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            menuGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            menuGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = Color.LightSteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            menuGrid.DefaultCellStyle = dataGridViewCellStyle6;
            menuGrid.EnableHeadersVisualStyles = false;
            menuGrid.GridColor = Color.LightGray;
            menuGrid.Location = new Point(26, 219);
            menuGrid.MultiSelect = false;
            menuGrid.Name = "menuGrid";
            menuGrid.ReadOnly = true;
            menuGrid.RowHeadersVisible = false;
            menuGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            menuGrid.Size = new Size(815, 396);
            menuGrid.TabIndex = 37;
            menuGrid.CellClick += menuGrid_CellClick;
            // 
            // menuPriceTextBox
            // 
            menuPriceTextBox.Location = new Point(388, 58);
            menuPriceTextBox.Name = "menuPriceTextBox";
            menuPriceTextBox.Size = new Size(121, 23);
            menuPriceTextBox.TabIndex = 9;
            // 
            // menuQuantityTextBox
            // 
            menuQuantityTextBox.Location = new Point(123, 158);
            menuQuantityTextBox.Name = "menuQuantityTextBox";
            menuQuantityTextBox.Size = new Size(121, 23);
            menuQuantityTextBox.TabIndex = 8;
            // 
            // menuDescriptionTextBox
            // 
            menuDescriptionTextBox.Location = new Point(123, 108);
            menuDescriptionTextBox.Name = "menuDescriptionTextBox";
            menuDescriptionTextBox.Size = new Size(121, 23);
            menuDescriptionTextBox.TabIndex = 7;
            // 
            // menuNameTextBox
            // 
            menuNameTextBox.Location = new Point(123, 58);
            menuNameTextBox.Name = "menuNameTextBox";
            menuNameTextBox.Size = new Size(121, 23);
            menuNameTextBox.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F);
            label5.Location = new Point(28, 108);
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
            label4.Location = new Point(293, 107);
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
            label2.Location = new Point(293, 58);
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
            quantityLabel.Location = new Point(28, 158);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new Size(72, 20);
            quantityLabel.TabIndex = 2;
            quantityLabel.Text = "Quantity:";
            quantityLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // menuName
            // 
            menuName.AutoSize = true;
            menuName.BackColor = SystemColors.ButtonFace;
            menuName.Font = new Font("Microsoft Sans Serif", 12F);
            menuName.Location = new Point(28, 58);
            menuName.Name = "menuName";
            menuName.Size = new Size(59, 20);
            menuName.TabIndex = 1;
            menuName.Text = "Name: ";
            menuName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // menuListBtn
            // 
            menuListBtn.Font = new Font("Microsoft Sans Serif", 12F);
            menuListBtn.Location = new Point(25, 50);
            menuListBtn.Name = "menuListBtn";
            menuListBtn.Size = new Size(115, 30);
            menuListBtn.TabIndex = 31;
            menuListBtn.Text = "Menu Items";
            menuListBtn.UseVisualStyleBackColor = true;
            menuListBtn.Click += menuListBtn_Click;
            // 
            // stockBtn
            // 
            stockBtn.Font = new Font("Microsoft Sans Serif", 12F);
            stockBtn.Location = new Point(25, 100);
            stockBtn.Name = "stockBtn";
            stockBtn.Size = new Size(115, 30);
            stockBtn.TabIndex = 33;
            stockBtn.Text = "All Stock List";
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
            dataGridViewCellStyle7.BackColor = Color.WhiteSmoke;
            stockGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            stockGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            stockGridView.BackgroundColor = SystemColors.ButtonFace;
            stockGridView.BorderStyle = BorderStyle.None;
            stockGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.LightGray;
            dataGridViewCellStyle8.Font = new Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle8.ForeColor = Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = Color.LightGray;
            dataGridViewCellStyle8.SelectionForeColor = Color.Black;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            stockGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            stockGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = SystemColors.Window;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle9.SelectionForeColor = Color.White;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            stockGridView.DefaultCellStyle = dataGridViewCellStyle9;
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
            // dataPanel
            // 
            dataPanel.Controls.Add(label1);
            dataPanel.Controls.Add(orderHistoryShowBtn);
            dataPanel.Controls.Add(orderHistorySearchBtn);
            dataPanel.Controls.Add(orderHistorySearchBox);
            dataPanel.Controls.Add(stockHistoryGrid);
            dataPanel.Location = new Point(155, 75);
            dataPanel.Name = "dataPanel";
            dataPanel.Size = new Size(867, 654);
            dataPanel.TabIndex = 5;
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
            // orderHistoryShowBtn
            // 
            orderHistoryShowBtn.Location = new Point(636, 17);
            orderHistoryShowBtn.Name = "orderHistoryShowBtn";
            orderHistoryShowBtn.Size = new Size(75, 23);
            orderHistoryShowBtn.TabIndex = 49;
            orderHistoryShowBtn.Text = "Show All";
            orderHistoryShowBtn.UseVisualStyleBackColor = true;
            orderHistoryShowBtn.Click += orderHistoryShowBtn_Click;
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
            orderHistorySearchBtn.Click += orderHistorySearchBtn_Click;
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
            dataGridViewCellStyle10.BackColor = Color.White;
            stockHistoryGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            stockHistoryGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            stockHistoryGrid.BackgroundColor = Color.WhiteSmoke;
            stockHistoryGrid.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = Color.SteelBlue;
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle11.ForeColor = Color.White;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            stockHistoryGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            stockHistoryGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle12.ForeColor = Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = Color.LightSteelBlue;
            dataGridViewCellStyle12.SelectionForeColor = Color.Black;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.False;
            stockHistoryGrid.DefaultCellStyle = dataGridViewCellStyle12;
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
            // orderHistoryBtn
            // 
            orderHistoryBtn.Font = new Font("Microsoft Sans Serif", 12F);
            orderHistoryBtn.Location = new Point(25, 200);
            orderHistoryBtn.Name = "orderHistoryBtn";
            orderHistoryBtn.Size = new Size(115, 30);
            orderHistoryBtn.TabIndex = 35;
            orderHistoryBtn.Text = "Order History";
            orderHistoryBtn.UseVisualStyleBackColor = true;
            orderHistoryBtn.Click += dataBtn_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(orderHistoryBtn);
            panel1.Controls.Add(stockBtn);
            panel1.Controls.Add(manageUserBtn);
            panel1.Controls.Add(menuListBtn);
            panel1.Location = new Point(0, 76);
            panel1.Name = "panel1";
            panel1.Size = new Size(155, 653);
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
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1008, 729);
            Controls.Add(adminLabel);
            Controls.Add(userName);
            Controls.Add(pictureBox1);
            Controls.Add(logoutBtn);
            Controls.Add(panel1);
            Controls.Add(usernameLabel);
            Controls.Add(panel2);
            Controls.Add(dataPanel);
            Controls.Add(stockPanel);
            Controls.Add(menuPanel);
            Controls.Add(userPanel);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AdminDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Dashboard";
            Load += AdminDashboard_Load;
            ((ISupportInitialize)pictureBox1).EndInit();
            userPanel.ResumeLayout(false);
            userPanel.PerformLayout();
            ((ISupportInitialize)userTableGrid).EndInit();
            menuPanel.ResumeLayout(false);
            menuPanel.PerformLayout();
            ((ISupportInitialize)menuGrid).EndInit();
            stockPanel.ResumeLayout(false);
            stockPanel.PerformLayout();
            ((ISupportInitialize)stockGridView).EndInit();
            dataPanel.ResumeLayout(false);
            dataPanel.PerformLayout();
            ((ISupportInitialize)stockHistoryGrid).EndInit();
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
        private Button orderHistoryBtn;
        private Panel dataPanel;
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
        private Label userManageLabel;
        private Button saveChangesButton;
        private Button saveChangesMenu;
        private Button orderHistoryShowBtn;
        private Button orderHistorySearchBtn;
        private TextBox orderHistorySearchBox;
        private DataGridView stockHistoryGrid;
        private Label label1;
    }
}