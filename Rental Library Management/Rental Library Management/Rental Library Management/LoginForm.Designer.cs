namespace Rental_Library_Management
{
    partial class LoginForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LogInButton = new System.Windows.Forms.Button();
            this.UserTypeComboBox = new System.Windows.Forms.ComboBox();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.UserTypeLabel = new System.Windows.Forms.Label();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.ForestGreen;
            this.groupBox1.Controls.Add(this.LogInButton);
            this.groupBox1.Controls.Add(this.UserTypeComboBox);
            this.groupBox1.Controls.Add(this.UserNameTextBox);
            this.groupBox1.Controls.Add(this.PasswordTextBox);
            this.groupBox1.Controls.Add(this.UserTypeLabel);
            this.groupBox1.Controls.Add(this.UserNameLabel);
            this.groupBox1.Controls.Add(this.PasswordLabel);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox1.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(365, 284);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(753, 298);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Log In";
            // 
            // LogInButton
            // 
            this.LogInButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.LogInButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogInButton.ForeColor = System.Drawing.SystemColors.Control;
            this.LogInButton.Location = new System.Drawing.Point(324, 233);
            this.LogInButton.Name = "LogInButton";
            this.LogInButton.Size = new System.Drawing.Size(153, 53);
            this.LogInButton.TabIndex = 3;
            this.LogInButton.Text = "Log In";
            this.LogInButton.UseVisualStyleBackColor = false;
            this.LogInButton.Click += new System.EventHandler(this.LogInButton_Click_1);
            // 
            // UserTypeComboBox
            // 
            this.UserTypeComboBox.DisplayMember = "(none)";
            this.UserTypeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserTypeComboBox.FormattingEnabled = true;
            this.UserTypeComboBox.Items.AddRange(new object[] {
            "Admin",
            "Student"});
            this.UserTypeComboBox.Location = new System.Drawing.Point(378, 80);
            this.UserTypeComboBox.Name = "UserTypeComboBox";
            this.UserTypeComboBox.Size = new System.Drawing.Size(251, 33);
            this.UserTypeComboBox.TabIndex = 0;
            this.UserTypeComboBox.Text = "Admin";
            this.UserTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.SelectedIndexChange);
            this.UserTypeComboBox.Click += new System.EventHandler(this.user_Type);
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameTextBox.Location = new System.Drawing.Point(378, 129);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(251, 31);
            this.UserNameTextBox.TabIndex = 1;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextBox.Location = new System.Drawing.Point(378, 174);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(251, 31);
            this.PasswordTextBox.TabIndex = 2;
            // 
            // UserTypeLabel
            // 
            this.UserTypeLabel.AutoSize = true;
            this.UserTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserTypeLabel.Location = new System.Drawing.Point(223, 83);
            this.UserTypeLabel.Name = "UserTypeLabel";
            this.UserTypeLabel.Size = new System.Drawing.Size(134, 25);
            this.UserTypeLabel.TabIndex = 10;
            this.UserTypeLabel.Text = "User Type :";
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameLabel.Location = new System.Drawing.Point(215, 132);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(142, 25);
            this.UserNameLabel.TabIndex = 9;
            this.UserNameLabel.Text = "User Name :";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(229, 177);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(128, 25);
            this.PasswordLabel.TabIndex = 8;
            this.PasswordLabel.Text = "Password :";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = global::Rental_Library_Management.Properties.Resources.RLMS;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.groupBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.MinimumSize = new System.Drawing.Size(16, 300);
            this.Name = "LoginForm";
            this.Text = "Login Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Login_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button LogInButton;
        private System.Windows.Forms.ComboBox UserTypeComboBox;
        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label UserTypeLabel;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Label PasswordLabel;
    }
}

