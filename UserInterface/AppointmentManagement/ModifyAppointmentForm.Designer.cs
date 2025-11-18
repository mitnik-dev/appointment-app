namespace AppointmentApp.UserInterface.AppointmentManagement
{
    partial class ModifyAppointmentForm
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
            nameTextBox = new TextBox();
            endLabel = new Label();
            startLabel = new Label();
            endDateTimePicker = new DateTimePicker();
            startDateTimePicker = new DateTimePicker();
            modifyButton = new Button();
            cancelButton = new Button();
            descriptionTextBox = new TextBox();
            urlTextBox = new TextBox();
            contactTextBox = new TextBox();
            locationTextBox = new TextBox();
            typeTextBox = new TextBox();
            titleTextBox = new TextBox();
            appointmentInfoLabel = new Label();
            customerLabel = new Label();
            searchTextBox = new TextBox();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            customerDataGridView = new DataGridView();
            searchButton = new Button();
            ((System.ComponentModel.ISupportInitialize)customerDataGridView).BeginInit();
            SuspendLayout();
            // 
            // nameTextBox
            // 
            nameTextBox.BorderStyle = BorderStyle.FixedSingle;
            nameTextBox.Enabled = false;
            nameTextBox.Location = new Point(52, 88);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.PlaceholderText = "Customer Name";
            nameTextBox.ReadOnly = true;
            nameTextBox.Size = new Size(321, 27);
            nameTextBox.TabIndex = 49;
            // 
            // endLabel
            // 
            endLabel.AutoSize = true;
            endLabel.Location = new Point(62, 465);
            endLabel.Name = "endLabel";
            endLabel.Size = new Size(34, 20);
            endLabel.TabIndex = 48;
            endLabel.Text = "End";
            // 
            // startLabel
            // 
            startLabel.AutoSize = true;
            startLabel.Location = new Point(62, 418);
            startLabel.Name = "startLabel";
            startLabel.Size = new Size(40, 20);
            startLabel.TabIndex = 47;
            startLabel.Text = "Start";
            // 
            // endDateTimePicker
            // 
            endDateTimePicker.Location = new Point(123, 460);
            endDateTimePicker.Name = "endDateTimePicker";
            endDateTimePicker.ShowUpDown = true;
            endDateTimePicker.Size = new Size(250, 27);
            endDateTimePicker.TabIndex = 46;
            // 
            // startDateTimePicker
            // 
            startDateTimePicker.Location = new Point(123, 413);
            startDateTimePicker.Name = "startDateTimePicker";
            startDateTimePicker.ShowUpDown = true;
            startDateTimePicker.Size = new Size(250, 27);
            startDateTimePicker.TabIndex = 45;
            startDateTimePicker.ValueChanged += startDateTimePicker_ValueChanged;
            // 
            // modifyButton
            // 
            modifyButton.Location = new Point(1030, 511);
            modifyButton.Name = "modifyButton";
            modifyButton.Size = new Size(94, 29);
            modifyButton.TabIndex = 44;
            modifyButton.Text = "Modify";
            modifyButton.UseVisualStyleBackColor = true;
            modifyButton.Click += modifyButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(1161, 511);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(94, 29);
            cancelButton.TabIndex = 43;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.BorderStyle = BorderStyle.FixedSingle;
            descriptionTextBox.Location = new Point(52, 366);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.PlaceholderText = "Description";
            descriptionTextBox.Size = new Size(321, 27);
            descriptionTextBox.TabIndex = 42;
            // 
            // urlTextBox
            // 
            urlTextBox.BorderStyle = BorderStyle.FixedSingle;
            urlTextBox.Location = new Point(52, 320);
            urlTextBox.Name = "urlTextBox";
            urlTextBox.PlaceholderText = "URL";
            urlTextBox.Size = new Size(321, 27);
            urlTextBox.TabIndex = 41;
            // 
            // contactTextBox
            // 
            contactTextBox.BorderStyle = BorderStyle.FixedSingle;
            contactTextBox.Location = new Point(52, 274);
            contactTextBox.Name = "contactTextBox";
            contactTextBox.PlaceholderText = "Contact";
            contactTextBox.Size = new Size(321, 27);
            contactTextBox.TabIndex = 40;
            // 
            // locationTextBox
            // 
            locationTextBox.BorderStyle = BorderStyle.FixedSingle;
            locationTextBox.Location = new Point(52, 228);
            locationTextBox.Name = "locationTextBox";
            locationTextBox.PlaceholderText = "Location";
            locationTextBox.Size = new Size(321, 27);
            locationTextBox.TabIndex = 39;
            // 
            // typeTextBox
            // 
            typeTextBox.BorderStyle = BorderStyle.FixedSingle;
            typeTextBox.Location = new Point(52, 182);
            typeTextBox.Name = "typeTextBox";
            typeTextBox.PlaceholderText = "Type";
            typeTextBox.Size = new Size(321, 27);
            typeTextBox.TabIndex = 38;
            // 
            // titleTextBox
            // 
            titleTextBox.BorderStyle = BorderStyle.FixedSingle;
            titleTextBox.Location = new Point(52, 136);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.PlaceholderText = "Title";
            titleTextBox.Size = new Size(321, 27);
            titleTextBox.TabIndex = 37;
            // 
            // appointmentInfoLabel
            // 
            appointmentInfoLabel.AutoSize = true;
            appointmentInfoLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            appointmentInfoLabel.Location = new Point(84, 38);
            appointmentInfoLabel.Name = "appointmentInfoLabel";
            appointmentInfoLabel.Size = new Size(247, 28);
            appointmentInfoLabel.TabIndex = 36;
            appointmentInfoLabel.Text = "Appointment Information";
            // 
            // customerLabel
            // 
            customerLabel.AutoSize = true;
            customerLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            customerLabel.Location = new Point(421, 50);
            customerLabel.Name = "customerLabel";
            customerLabel.Size = new Size(299, 23);
            customerLabel.TabIndex = 35;
            customerLabel.Text = "Select Customer for this Appointment";
            // 
            // searchTextBox
            // 
            searchTextBox.BorderStyle = BorderStyle.FixedSingle;
            searchTextBox.Location = new Point(982, 43);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(273, 27);
            searchTextBox.TabIndex = 34;
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // customerDataGridView
            // 
            customerDataGridView.AllowUserToAddRows = false;
            customerDataGridView.AllowUserToDeleteRows = false;
            customerDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            customerDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            customerDataGridView.Location = new Point(421, 88);
            customerDataGridView.Name = "customerDataGridView";
            customerDataGridView.RowHeadersVisible = false;
            customerDataGridView.RowHeadersWidth = 51;
            customerDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            customerDataGridView.Size = new Size(834, 397);
            customerDataGridView.TabIndex = 32;
            customerDataGridView.SelectionChanged += customerDataGridView_SelectionChanged;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(868, 41);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(94, 29);
            searchButton.TabIndex = 33;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // ModifyAppointmentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1298, 586);
            Controls.Add(nameTextBox);
            Controls.Add(endLabel);
            Controls.Add(startLabel);
            Controls.Add(endDateTimePicker);
            Controls.Add(startDateTimePicker);
            Controls.Add(modifyButton);
            Controls.Add(cancelButton);
            Controls.Add(descriptionTextBox);
            Controls.Add(urlTextBox);
            Controls.Add(contactTextBox);
            Controls.Add(locationTextBox);
            Controls.Add(typeTextBox);
            Controls.Add(titleTextBox);
            Controls.Add(appointmentInfoLabel);
            Controls.Add(customerLabel);
            Controls.Add(searchTextBox);
            Controls.Add(customerDataGridView);
            Controls.Add(searchButton);
            Name = "ModifyAppointmentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Modify Appointment";
            Load += ModifyAppointmentForm_Load;
            ((System.ComponentModel.ISupportInitialize)customerDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nameTextBox;
        private Label endLabel;
        private Label startLabel;
        private DateTimePicker endDateTimePicker;
        private DateTimePicker startDateTimePicker;
        private Button modifyButton;
        private Button cancelButton;
        private TextBox descriptionTextBox;
        private TextBox urlTextBox;
        private TextBox contactTextBox;
        private TextBox locationTextBox;
        private TextBox typeTextBox;
        private TextBox titleTextBox;
        private Label appointmentInfoLabel;
        private Label customerLabel;
        private TextBox searchTextBox;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private DataGridView customerDataGridView;
        private Button searchButton;
    }
}