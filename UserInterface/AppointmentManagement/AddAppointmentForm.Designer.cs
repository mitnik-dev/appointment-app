namespace AppointmentApp.UserInterface.AppointmentManagement
{
    partial class AddAppointmentForm
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
            customerDataGridView = new DataGridView();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            customerLabel = new Label();
            searchTextBox = new TextBox();
            searchButton = new Button();
            addButton = new Button();
            cancelButton = new Button();
            descriptionTextBox = new TextBox();
            urlTextBox = new TextBox();
            contactTextBox = new TextBox();
            locationTextBox = new TextBox();
            typeTextBox = new TextBox();
            titleTextBox = new TextBox();
            appointmentInfoLabel = new Label();
            startDateTimePicker = new DateTimePicker();
            endDateTimePicker = new DateTimePicker();
            startLabel = new Label();
            endLabel = new Label();
            nameTextBox = new TextBox();
            addCustomerButton = new Button();
            ((System.ComponentModel.ISupportInitialize)customerDataGridView).BeginInit();
            SuspendLayout();
            // 
            // customerDataGridView
            // 
            customerDataGridView.AllowUserToAddRows = false;
            customerDataGridView.AllowUserToDeleteRows = false;
            customerDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            customerDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            customerDataGridView.Location = new Point(414, 96);
            customerDataGridView.Name = "customerDataGridView";
            customerDataGridView.RowHeadersVisible = false;
            customerDataGridView.RowHeadersWidth = 51;
            customerDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            customerDataGridView.Size = new Size(834, 352);
            customerDataGridView.TabIndex = 7;
            customerDataGridView.SelectionChanged += customerDataGridView_SelectionChanged;
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // customerLabel
            // 
            customerLabel.AutoSize = true;
            customerLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            customerLabel.Location = new Point(414, 58);
            customerLabel.Name = "customerLabel";
            customerLabel.Size = new Size(299, 23);
            customerLabel.TabIndex = 13;
            customerLabel.Text = "Select Customer for this Appointment";
            // 
            // searchTextBox
            // 
            searchTextBox.BorderStyle = BorderStyle.FixedSingle;
            searchTextBox.Location = new Point(975, 51);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(273, 27);
            searchTextBox.TabIndex = 12;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(861, 49);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(94, 29);
            searchButton.TabIndex = 11;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // addButton
            // 
            addButton.Location = new Point(1016, 529);
            addButton.Name = "addButton";
            addButton.Size = new Size(105, 35);
            addButton.TabIndex = 26;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(1143, 529);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(105, 35);
            cancelButton.TabIndex = 25;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.BorderStyle = BorderStyle.FixedSingle;
            descriptionTextBox.Location = new Point(45, 374);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.PlaceholderText = "Description";
            descriptionTextBox.Size = new Size(321, 27);
            descriptionTextBox.TabIndex = 23;
            // 
            // urlTextBox
            // 
            urlTextBox.BorderStyle = BorderStyle.FixedSingle;
            urlTextBox.Location = new Point(45, 328);
            urlTextBox.Name = "urlTextBox";
            urlTextBox.PlaceholderText = "URL";
            urlTextBox.Size = new Size(321, 27);
            urlTextBox.TabIndex = 22;
            // 
            // contactTextBox
            // 
            contactTextBox.BorderStyle = BorderStyle.FixedSingle;
            contactTextBox.Location = new Point(45, 282);
            contactTextBox.Name = "contactTextBox";
            contactTextBox.PlaceholderText = "Contact";
            contactTextBox.Size = new Size(321, 27);
            contactTextBox.TabIndex = 21;
            // 
            // locationTextBox
            // 
            locationTextBox.BorderStyle = BorderStyle.FixedSingle;
            locationTextBox.Location = new Point(45, 236);
            locationTextBox.Name = "locationTextBox";
            locationTextBox.PlaceholderText = "Location";
            locationTextBox.Size = new Size(321, 27);
            locationTextBox.TabIndex = 20;
            // 
            // typeTextBox
            // 
            typeTextBox.BorderStyle = BorderStyle.FixedSingle;
            typeTextBox.Location = new Point(45, 190);
            typeTextBox.Name = "typeTextBox";
            typeTextBox.PlaceholderText = "Type";
            typeTextBox.Size = new Size(321, 27);
            typeTextBox.TabIndex = 19;
            // 
            // titleTextBox
            // 
            titleTextBox.BorderStyle = BorderStyle.FixedSingle;
            titleTextBox.Location = new Point(45, 144);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.PlaceholderText = "Title";
            titleTextBox.Size = new Size(321, 27);
            titleTextBox.TabIndex = 18;
            // 
            // appointmentInfoLabel
            // 
            appointmentInfoLabel.AutoSize = true;
            appointmentInfoLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            appointmentInfoLabel.Location = new Point(77, 46);
            appointmentInfoLabel.Name = "appointmentInfoLabel";
            appointmentInfoLabel.Size = new Size(247, 28);
            appointmentInfoLabel.TabIndex = 17;
            appointmentInfoLabel.Text = "Appointment Information";
            // 
            // startDateTimePicker
            // 
            startDateTimePicker.Location = new Point(116, 421);
            startDateTimePicker.Name = "startDateTimePicker";
            startDateTimePicker.Size = new Size(250, 27);
            startDateTimePicker.TabIndex = 27;
            startDateTimePicker.ValueChanged += startDateTimePicker_ValueChanged;
            // 
            // endDateTimePicker
            // 
            endDateTimePicker.Location = new Point(116, 468);
            endDateTimePicker.Name = "endDateTimePicker";
            endDateTimePicker.Size = new Size(250, 27);
            endDateTimePicker.TabIndex = 28;
            // 
            // startLabel
            // 
            startLabel.AutoSize = true;
            startLabel.Location = new Point(55, 426);
            startLabel.Name = "startLabel";
            startLabel.Size = new Size(40, 20);
            startLabel.TabIndex = 29;
            startLabel.Text = "Start";
            // 
            // endLabel
            // 
            endLabel.AutoSize = true;
            endLabel.Location = new Point(55, 473);
            endLabel.Name = "endLabel";
            endLabel.Size = new Size(34, 20);
            endLabel.TabIndex = 30;
            endLabel.Text = "End";
            // 
            // nameTextBox
            // 
            nameTextBox.BorderStyle = BorderStyle.FixedSingle;
            nameTextBox.Enabled = false;
            nameTextBox.Location = new Point(45, 96);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.PlaceholderText = "Customer Name";
            nameTextBox.ReadOnly = true;
            nameTextBox.Size = new Size(321, 27);
            nameTextBox.TabIndex = 31;
            // 
            // addCustomerButton
            // 
            addCustomerButton.Location = new Point(1097, 469);
            addCustomerButton.Name = "addCustomerButton";
            addCustomerButton.Size = new Size(151, 29);
            addCustomerButton.TabIndex = 32;
            addCustomerButton.Text = "Add New Customer";
            addCustomerButton.UseVisualStyleBackColor = true;
            addCustomerButton.Click += addCustomerButton_Click;
            // 
            // AddAppointmentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1285, 595);
            Controls.Add(addCustomerButton);
            Controls.Add(nameTextBox);
            Controls.Add(endLabel);
            Controls.Add(startLabel);
            Controls.Add(endDateTimePicker);
            Controls.Add(startDateTimePicker);
            Controls.Add(addButton);
            Controls.Add(cancelButton);
            Controls.Add(descriptionTextBox);
            Controls.Add(urlTextBox);
            Controls.Add(contactTextBox);
            Controls.Add(locationTextBox);
            Controls.Add(typeTextBox);
            Controls.Add(titleTextBox);
            Controls.Add(appointmentInfoLabel);
            Controls.Add(customerDataGridView);
            Controls.Add(customerLabel);
            Controls.Add(searchTextBox);
            Controls.Add(searchButton);
            Name = "AddAppointmentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Appointment";
            Load += AddAppointmentForm_Load;
            ((System.ComponentModel.ISupportInitialize)customerDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView customerDataGridView;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private Label customerLabel;
        private TextBox searchTextBox;
        private Button searchButton;
        private Button addButton;
        private Button cancelButton;
        private TextBox phoneTextBox;
        private TextBox descriptionTextBox;
        private TextBox urlTextBox;
        private TextBox contactTextBox;
        private TextBox locationTextBox;
        private TextBox typeTextBox;
        private TextBox titleTextBox;
        private Label appointmentInfoLabel;
        private DateTimePicker startDateTimePicker;
        private DateTimePicker endDateTimePicker;
        private Label startLabel;
        private Label endLabel;
        private TextBox nameTextBox;
        private Button addCustomerButton;
    }
}