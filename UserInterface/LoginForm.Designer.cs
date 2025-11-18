namespace AppointmentApp.UserInterface
{
    partial class LoginForm
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
            usernameLabel = new Label();
            passwordLabel = new Label();
            usernameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            loginButton = new Button();
            loginLabel = new Label();
            SuspendLayout();
            // 
            // usernameLabel
            // 
            usernameLabel.Location = new Point(72, 109);
            usernameLabel.Margin = new Padding(0);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(82, 25);
            usernameLabel.TabIndex = 0;
            usernameLabel.Text = "User Name";
            usernameLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // passwordLabel
            // 
            passwordLabel.Location = new Point(72, 179);
            passwordLabel.Margin = new Padding(0);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(82, 25);
            passwordLabel.TabIndex = 1;
            passwordLabel.Text = "Password";
            passwordLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // usernameTextBox
            // 
            usernameTextBox.BorderStyle = BorderStyle.FixedSingle;
            usernameTextBox.Location = new Point(192, 109);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(170, 27);
            usernameTextBox.TabIndex = 2;
            // 
            // passwordTextBox
            // 
            passwordTextBox.BorderStyle = BorderStyle.FixedSingle;
            passwordTextBox.Location = new Point(192, 179);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(170, 27);
            passwordTextBox.TabIndex = 3;
            // 
            // loginButton
            // 
            loginButton.BackColor = SystemColors.ButtonFace;
            loginButton.Location = new Point(268, 257);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(94, 29);
            loginButton.TabIndex = 4;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginLabel.Location = new Point(187, 43);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(59, 25);
            loginLabel.TabIndex = 5;
            loginLabel.Text = "Login";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 328);
            Controls.Add(loginLabel);
            Controls.Add(loginButton);
            Controls.Add(passwordTextBox);
            Controls.Add(usernameTextBox);
            Controls.Add(passwordLabel);
            Controls.Add(usernameLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label usernameLabel;
        private Label passwordLabel;
        private TextBox usernameTextBox;
        private TextBox passwordTextBox;
        private Button loginButton;
        private Label loginLabel;
    }
}
