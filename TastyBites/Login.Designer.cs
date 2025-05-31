namespace TastyBites
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label1 = new Label();
            label2 = new Label();
            userNameField = new TextBox();
            passwordField = new TextBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS Reference Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(62, 172);
            label1.Name = "label1";
            label1.Size = new Size(77, 16);
            label1.TabIndex = 0;
            label1.Text = "Username:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MS Reference Sans Serif", 9.75F);
            label2.Location = new Point(62, 230);
            label2.Name = "label2";
            label2.Size = new Size(75, 16);
            label2.TabIndex = 1;
            label2.Text = "Password:";
            // 
            // userNameField
            // 
            userNameField.AccessibleName = "";
            userNameField.Font = new Font("MS Reference Sans Serif", 9.75F);
            userNameField.Location = new Point(64, 191);
            userNameField.Name = "userNameField";
            userNameField.Size = new Size(200, 23);
            userNameField.TabIndex = 3;
            userNameField.Text = "fd";
            userNameField.TextChanged += textBox2_TextChanged;
            // 
            // passwordField
            // 
            passwordField.AccessibleName = "";
            passwordField.Font = new Font("MS Reference Sans Serif", 9.75F);
            passwordField.Location = new Point(64, 249);
            passwordField.Name = "passwordField";
            passwordField.PasswordChar = '*';
            passwordField.Size = new Size(200, 23);
            passwordField.TabIndex = 4;
            passwordField.TextChanged += passwordField_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(232, 128, 23);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(64, 295);
            button1.Name = "button1";
            button1.Size = new Size(200, 28);
            button1.TabIndex = 5;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(64, 49);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 90);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(344, 441);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(passwordField);
            Controls.Add(userNameField);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox userNameField;
        private TextBox passwordField;
        private Button button1;
        private PictureBox pictureBox1;
    }
}
