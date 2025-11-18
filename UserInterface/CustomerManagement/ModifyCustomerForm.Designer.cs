namespace AppointmentApp.UserInterface.CustomerManagement
{
    partial class ModifyCustomerForm
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
            modifyButton = new Button();
            cancelButton = new Button();
            phoneTextBox = new TextBox();
            countryTextBox = new TextBox();
            postalTextBox = new TextBox();
            cityTextBox = new TextBox();
            address2TextBox = new TextBox();
            address1TextBox = new TextBox();
            nameTextBox = new TextBox();
            customerInfoLabel = new Label();
            SuspendLayout();
            // 
            // modifyButton
            // 
            modifyButton.Location = new Point(201, 386);
            modifyButton.Name = "modifyButton";
            modifyButton.Size = new Size(73, 29);
            modifyButton.TabIndex = 26;
            modifyButton.Text = "Modify";
            modifyButton.UseVisualStyleBackColor = true;
            modifyButton.Click += modifyButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(316, 386);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(73, 29);
            cancelButton.TabIndex = 25;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // phoneTextBox
            // 
            phoneTextBox.BorderStyle = BorderStyle.FixedSingle;
            phoneTextBox.Location = new Point(68, 321);
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.PlaceholderText = "Phone";
            phoneTextBox.Size = new Size(321, 27);
            phoneTextBox.TabIndex = 24;
            // 
            // countryTextBox
            // 
            countryTextBox.BorderStyle = BorderStyle.FixedSingle;
            countryTextBox.Location = new Point(220, 275);
            countryTextBox.Name = "countryTextBox";
            countryTextBox.PlaceholderText = "Country";
            countryTextBox.Size = new Size(169, 27);
            countryTextBox.TabIndex = 23;
            // 
            // postalTextBox
            // 
            postalTextBox.BorderStyle = BorderStyle.FixedSingle;
            postalTextBox.Location = new Point(68, 275);
            postalTextBox.Name = "postalTextBox";
            postalTextBox.PlaceholderText = "Postal Code";
            postalTextBox.Size = new Size(128, 27);
            postalTextBox.TabIndex = 22;
            // 
            // cityTextBox
            // 
            cityTextBox.BorderStyle = BorderStyle.FixedSingle;
            cityTextBox.Location = new Point(68, 229);
            cityTextBox.Name = "cityTextBox";
            cityTextBox.PlaceholderText = "City";
            cityTextBox.Size = new Size(321, 27);
            cityTextBox.TabIndex = 21;
            // 
            // address2TextBox
            // 
            address2TextBox.BorderStyle = BorderStyle.FixedSingle;
            address2TextBox.Location = new Point(68, 183);
            address2TextBox.Name = "address2TextBox";
            address2TextBox.PlaceholderText = "Address 2";
            address2TextBox.Size = new Size(321, 27);
            address2TextBox.TabIndex = 20;
            // 
            // address1TextBox
            // 
            address1TextBox.BorderStyle = BorderStyle.FixedSingle;
            address1TextBox.Location = new Point(68, 137);
            address1TextBox.Name = "address1TextBox";
            address1TextBox.PlaceholderText = "Address";
            address1TextBox.Size = new Size(321, 27);
            address1TextBox.TabIndex = 19;
            // 
            // nameTextBox
            // 
            nameTextBox.BorderStyle = BorderStyle.FixedSingle;
            nameTextBox.Location = new Point(68, 91);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.PlaceholderText = "Full Name";
            nameTextBox.Size = new Size(321, 27);
            nameTextBox.TabIndex = 18;
            // 
            // customerInfoLabel
            // 
            customerInfoLabel.AutoSize = true;
            customerInfoLabel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            customerInfoLabel.Location = new Point(130, 37);
            customerInfoLabel.Name = "customerInfoLabel";
            customerInfoLabel.Size = new Size(197, 25);
            customerInfoLabel.TabIndex = 17;
            customerInfoLabel.Text = "Customer Information";
            // 
            // ModifyCustomerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(457, 453);
            Controls.Add(modifyButton);
            Controls.Add(cancelButton);
            Controls.Add(phoneTextBox);
            Controls.Add(countryTextBox);
            Controls.Add(postalTextBox);
            Controls.Add(cityTextBox);
            Controls.Add(address2TextBox);
            Controls.Add(address1TextBox);
            Controls.Add(nameTextBox);
            Controls.Add(customerInfoLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "ModifyCustomerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Modify Customer";
            Load += ModifyCustomerForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button modifyButton;
        private Button cancelButton;
        private TextBox phoneTextBox;
        private TextBox countryTextBox;
        private TextBox postalTextBox;
        private TextBox cityTextBox;
        private TextBox address2TextBox;
        private TextBox address1TextBox;
        private TextBox nameTextBox;
        private Label customerInfoLabel;
    }
}