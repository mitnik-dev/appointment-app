namespace AppointmentApp.UserInterface
{
    partial class MainForm
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
            manageCustomersButton = new Button();
            manageAppointmentsButton = new Button();
            appointmentCalendar = new MonthCalendar();
            appointmentDataGridView = new DataGridView();
            summaryLabel = new Label();
            moreDetailsButton = new Button();
            searchTextBox = new TextBox();
            searchButton = new Button();
            addNewButton = new Button();
            reportsButton = new Button();
            userLabel = new Label();
            locationLabel = new Label();
            todayLabel = new Label();
            dashboardLabel = new Label();
            locationTextBox = new Label();
            todayTextBox = new Label();
            userTextBox = new Label();
            folderBrowserDialog1 = new FolderBrowserDialog();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)appointmentDataGridView).BeginInit();
            SuspendLayout();
            // 
            // manageCustomersButton
            // 
            manageCustomersButton.Location = new Point(352, 28);
            manageCustomersButton.Margin = new Padding(3, 2, 3, 2);
            manageCustomersButton.Name = "manageCustomersButton";
            manageCustomersButton.Size = new Size(131, 22);
            manageCustomersButton.TabIndex = 0;
            manageCustomersButton.Text = "Manage Customers";
            manageCustomersButton.UseVisualStyleBackColor = true;
            manageCustomersButton.Click += manageCustomersButton_Click;
            // 
            // manageAppointmentsButton
            // 
            manageAppointmentsButton.Location = new Point(499, 28);
            manageAppointmentsButton.Margin = new Padding(3, 2, 3, 2);
            manageAppointmentsButton.Name = "manageAppointmentsButton";
            manageAppointmentsButton.Size = new Size(157, 22);
            manageAppointmentsButton.TabIndex = 2;
            manageAppointmentsButton.Text = "Manage Appointments";
            manageAppointmentsButton.UseVisualStyleBackColor = true;
            manageAppointmentsButton.Click += manageAppointmentsButton_Click;
            // 
            // appointmentCalendar
            // 
            appointmentCalendar.Location = new Point(20, 102);
            appointmentCalendar.Margin = new Padding(8, 7, 8, 7);
            appointmentCalendar.Name = "appointmentCalendar";
            appointmentCalendar.TabIndex = 3;
            appointmentCalendar.DateSelected += appointmentCalendar_DateSelected;
            // 
            // appointmentDataGridView
            // 
            appointmentDataGridView.AllowUserToAddRows = false;
            appointmentDataGridView.AllowUserToDeleteRows = false;
            appointmentDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            appointmentDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            appointmentDataGridView.Location = new Point(287, 102);
            appointmentDataGridView.Margin = new Padding(3, 2, 3, 2);
            appointmentDataGridView.MultiSelect = false;
            appointmentDataGridView.Name = "appointmentDataGridView";
            appointmentDataGridView.ReadOnly = true;
            appointmentDataGridView.RowHeadersVisible = false;
            appointmentDataGridView.RowHeadersWidth = 51;
            appointmentDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            appointmentDataGridView.Size = new Size(468, 155);
            appointmentDataGridView.TabIndex = 4;
            // 
            // summaryLabel
            // 
            summaryLabel.AutoSize = true;
            summaryLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            summaryLabel.Location = new Point(287, 70);
            summaryLabel.Name = "summaryLabel";
            summaryLabel.Size = new Size(161, 19);
            summaryLabel.TabIndex = 5;
            summaryLabel.Text = "Appointments Summary";
            // 
            // moreDetailsButton
            // 
            moreDetailsButton.Location = new Point(648, 272);
            moreDetailsButton.Margin = new Padding(3, 2, 3, 2);
            moreDetailsButton.Name = "moreDetailsButton";
            moreDetailsButton.Size = new Size(108, 22);
            moreDetailsButton.TabIndex = 6;
            moreDetailsButton.Text = "More Details...";
            moreDetailsButton.UseVisualStyleBackColor = true;
            moreDetailsButton.Click += moreDetailsButton_Click;
            // 
            // searchTextBox
            // 
            searchTextBox.BorderStyle = BorderStyle.FixedSingle;
            searchTextBox.Location = new Point(579, 70);
            searchTextBox.Margin = new Padding(3, 2, 3, 2);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(176, 23);
            searchTextBox.TabIndex = 14;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(499, 68);
            searchButton.Margin = new Padding(3, 2, 3, 2);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(64, 22);
            searchButton.TabIndex = 13;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // addNewButton
            // 
            addNewButton.Location = new Point(547, 272);
            addNewButton.Margin = new Padding(3, 2, 3, 2);
            addNewButton.Name = "addNewButton";
            addNewButton.Size = new Size(84, 22);
            addNewButton.TabIndex = 15;
            addNewButton.Text = "Add New";
            addNewButton.UseVisualStyleBackColor = true;
            addNewButton.Click += addNewButton_Click;
            // 
            // reportsButton
            // 
            reportsButton.Location = new Point(669, 28);
            reportsButton.Margin = new Padding(3, 2, 3, 2);
            reportsButton.Name = "reportsButton";
            reportsButton.Size = new Size(82, 22);
            reportsButton.TabIndex = 16;
            reportsButton.Text = "Reports";
            reportsButton.UseVisualStyleBackColor = true;
            reportsButton.Click += reportsButton_Click;
            // 
            // userLabel
            // 
            userLabel.AutoSize = true;
            userLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            userLabel.Location = new Point(26, 308);
            userLabel.Name = "userLabel";
            userLabel.Size = new Size(33, 15);
            userLabel.TabIndex = 17;
            userLabel.Text = "User:";
            // 
            // locationLabel
            // 
            locationLabel.AutoSize = true;
            locationLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            locationLabel.Location = new Point(132, 308);
            locationLabel.Name = "locationLabel";
            locationLabel.Size = new Size(56, 15);
            locationLabel.TabIndex = 18;
            locationLabel.Text = "Location:";
            // 
            // todayLabel
            // 
            todayLabel.AutoSize = true;
            todayLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            todayLabel.Location = new Point(628, 308);
            todayLabel.Name = "todayLabel";
            todayLabel.Size = new Size(42, 15);
            todayLabel.TabIndex = 19;
            todayLabel.Text = "Today:";
            // 
            // dashboardLabel
            // 
            dashboardLabel.AutoSize = true;
            dashboardLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dashboardLabel.Location = new Point(20, 26);
            dashboardLabel.Name = "dashboardLabel";
            dashboardLabel.Size = new Size(93, 21);
            dashboardLabel.TabIndex = 20;
            dashboardLabel.Text = "Dashboard";
            // 
            // locationTextBox
            // 
            locationTextBox.AutoSize = true;
            locationTextBox.Location = new Point(200, 308);
            locationTextBox.Name = "locationTextBox";
            locationTextBox.Size = new Size(167, 15);
            locationTextBox.TabIndex = 21;
            locationTextBox.Text = "en-US (Eastern Standard Time)";
            // 
            // todayTextBox
            // 
            todayTextBox.AutoSize = true;
            todayTextBox.Location = new Point(681, 308);
            todayTextBox.Name = "todayTextBox";
            todayTextBox.Size = new Size(65, 15);
            todayTextBox.TabIndex = 22;
            todayTextBox.Text = "10/10/2025";
            // 
            // userTextBox
            // 
            userTextBox.AutoSize = true;
            userTextBox.Location = new Point(66, 308);
            userTextBox.Name = "userTextBox";
            userTextBox.Size = new Size(41, 15);
            userTextBox.TabIndex = 23;
            userTextBox.Text = "admin";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(20, 68);
            label8.Name = "label8";
            label8.Size = new Size(161, 19);
            label8.TabIndex = 24;
            label8.Text = "Appointments Summary";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(789, 338);
            Controls.Add(label8);
            Controls.Add(userTextBox);
            Controls.Add(todayTextBox);
            Controls.Add(locationTextBox);
            Controls.Add(dashboardLabel);
            Controls.Add(todayLabel);
            Controls.Add(locationLabel);
            Controls.Add(userLabel);
            Controls.Add(reportsButton);
            Controls.Add(addNewButton);
            Controls.Add(searchTextBox);
            Controls.Add(searchButton);
            Controls.Add(moreDetailsButton);
            Controls.Add(summaryLabel);
            Controls.Add(appointmentDataGridView);
            Controls.Add(appointmentCalendar);
            Controls.Add(manageAppointmentsButton);
            Controls.Add(manageCustomersButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)appointmentDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button manageCustomersButton;
        private Button manageAppointmentsButton;
        private MonthCalendar appointmentCalendar;
        private DataGridView appointmentDataGridView;
        private Label summaryLabel;
        private Button moreDetailsButton;
        private TextBox searchTextBox;
        private Button searchButton;
        private Button addNewButton;
        private Button reportsButton;
        private Label userLabel;
        private Label locationLabel;
        private Label todayLabel;
        private Label dashboardLabel;
        private Label locationTextBox;
        private Label todayTextBox;
        private Label userTextBox;
        private FolderBrowserDialog folderBrowserDialog1;
        private Label label8;
    }
}