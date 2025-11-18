namespace AppointmentApp.UserInterface
{
    partial class AddCustomerForm
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
            customerInfoLabel = new Label();
            nameTextBox = new TextBox();
            address1TextBox = new TextBox();
            address2TextBox = new TextBox();
            cityTextBox = new TextBox();
            postalTextBox = new TextBox();
            countryTextBox = new TextBox();
            phoneTextBox = new TextBox();
            cancelButton = new Button();
            addButton = new Button();
            SuspendLayout();
            // 
            // customerInfoLabel
            // 
            customerInfoLabel.AutoSize = true;
            customerInfoLabel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            customerInfoLabel.Location = new Point(130, 38);
            customerInfoLabel.Name = "customerInfoLabel";
            customerInfoLabel.Size = new Size(197, 25);
            customerInfoLabel.TabIndex = 7;
            customerInfoLabel.Text = "Customer Information";
            // 
            // nameTextBox
            // 
            nameTextBox.BorderStyle = BorderStyle.FixedSingle;
            nameTextBox.Location = new Point(68, 92);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.PlaceholderText = "Full Name";
            nameTextBox.Size = new Size(321, 27);
            nameTextBox.TabIndex = 8;
            // 
            // address1TextBox
            // 
            address1TextBox.BorderStyle = BorderStyle.FixedSingle;
            address1TextBox.Location = new Point(68, 138);
            address1TextBox.Name = "address1TextBox";
            address1TextBox.PlaceholderText = "Address";
            address1TextBox.Size = new Size(321, 27);
            address1TextBox.TabIndex = 9;
            // 
            // address2TextBox
            // 
            address2TextBox.BorderStyle = BorderStyle.FixedSingle;
            address2TextBox.Location = new Point(68, 184);
            address2TextBox.Name = "address2TextBox";
            address2TextBox.PlaceholderText = "Address 2";
            address2TextBox.Size = new Size(321, 27);
            address2TextBox.TabIndex = 10;
            // 
            // cityTextBox
            // 
            cityTextBox.BorderStyle = BorderStyle.FixedSingle;
            cityTextBox.Location = new Point(68, 230);
            cityTextBox.Name = "cityTextBox";
            cityTextBox.PlaceholderText = "City";
            cityTextBox.Size = new Size(321, 27);
            cityTextBox.TabIndex = 11;
            // 
            // postalTextBox
            // 
            postalTextBox.BorderStyle = BorderStyle.FixedSingle;
            postalTextBox.Location = new Point(68, 276);
            postalTextBox.Name = "postalTextBox";
            postalTextBox.PlaceholderText = "Postal Code";
            postalTextBox.Size = new Size(128, 27);
            postalTextBox.TabIndex = 12;
            // 
            // countryTextBox
            // 
            countryTextBox.BorderStyle = BorderStyle.FixedSingle;
            countryTextBox.Location = new Point(220, 276);
            countryTextBox.Name = "countryTextBox";
            countryTextBox.PlaceholderText = "Country";
            countryTextBox.Size = new Size(169, 27);
            countryTextBox.TabIndex = 13;
            // 
            // phoneTextBox
            // 
            phoneTextBox.BorderStyle = BorderStyle.FixedSingle;
            phoneTextBox.Location = new Point(68, 322);
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.PlaceholderText = "Phone";
            phoneTextBox.Size = new Size(321, 27);
            phoneTextBox.TabIndex = 14;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(316, 387);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(73, 29);
            cancelButton.TabIndex = 15;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // addButton
            // 
            addButton.Location = new Point(201, 387);
            addButton.Name = "addButton";
            addButton.Size = new Size(73, 29);
            addButton.TabIndex = 16;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // AddCustomerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(457, 453);
            Controls.Add(addButton);
            Controls.Add(cancelButton);
            Controls.Add(phoneTextBox);
            Controls.Add(countryTextBox);
            Controls.Add(postalTextBox);
            Controls.Add(cityTextBox);
            Controls.Add(address2TextBox);
            Controls.Add(address1TextBox);
            Controls.Add(nameTextBox);
            Controls.Add(customerInfoLabel);
            Name = "AddCustomerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Customer";
            Load += AddCustomerForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label customerInfoLabel;
        private TextBox nameTextBox;
        private TextBox address1TextBox;
        private TextBox address2TextBox;
        private TextBox cityTextBox;
        private TextBox postalTextBox;
        private TextBox countryTextBox;
        private TextBox phoneTextBox;
        private Button cancelButton;
        private Button addButton;
    }
}