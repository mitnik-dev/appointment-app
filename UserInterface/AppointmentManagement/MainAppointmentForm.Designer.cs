namespace AppointmentApp.UserInterface.AppointmentManagement
{
    partial class MainAppointmentForm
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
            appointmentDataGridView = new DataGridView();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            appointmentLabel = new Label();
            searchTextBox = new TextBox();
            searchButton = new Button();
            deleteButton = new Button();
            modifyButton = new Button();
            addButton = new Button();
            ((System.ComponentModel.ISupportInitialize)appointmentDataGridView).BeginInit();
            SuspendLayout();
            // 
            // appointmentDataGridView
            // 
            appointmentDataGridView.AllowUserToAddRows = false;
            appointmentDataGridView.AllowUserToDeleteRows = false;
            appointmentDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            appointmentDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            appointmentDataGridView.Location = new Point(61, 87);
            appointmentDataGridView.MultiSelect = false;
            appointmentDataGridView.Name = "appointmentDataGridView";
            appointmentDataGridView.RowHeadersVisible = false;
            appointmentDataGridView.RowHeadersWidth = 51;
            appointmentDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            appointmentDataGridView.Size = new Size(1174, 338);
            appointmentDataGridView.TabIndex = 7;
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // appointmentLabel
            // 
            appointmentLabel.AutoSize = true;
            appointmentLabel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            appointmentLabel.Location = new Point(64, 44);
            appointmentLabel.Name = "appointmentLabel";
            appointmentLabel.Size = new Size(132, 25);
            appointmentLabel.TabIndex = 13;
            appointmentLabel.Text = "Appointments";
            // 
            // searchTextBox
            // 
            searchTextBox.BorderStyle = BorderStyle.FixedSingle;
            searchTextBox.Location = new Point(962, 46);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(273, 27);
            searchTextBox.TabIndex = 12;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(848, 44);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(94, 29);
            searchButton.TabIndex = 11;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(1140, 456);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(94, 29);
            deleteButton.TabIndex = 10;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // modifyButton
            // 
            modifyButton.Location = new Point(1034, 456);
            modifyButton.Name = "modifyButton";
            modifyButton.Size = new Size(94, 29);
            modifyButton.TabIndex = 9;
            modifyButton.Text = "Modify";
            modifyButton.UseVisualStyleBackColor = true;
            modifyButton.Click += modifyButton_Click;
            // 
            // addButton
            // 
            addButton.Location = new Point(928, 456);
            addButton.Name = "addButton";
            addButton.Size = new Size(94, 29);
            addButton.TabIndex = 8;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // MainAppointmentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1289, 522);
            Controls.Add(appointmentDataGridView);
            Controls.Add(appointmentLabel);
            Controls.Add(searchTextBox);
            Controls.Add(searchButton);
            Controls.Add(deleteButton);
            Controls.Add(modifyButton);
            Controls.Add(addButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MainAppointmentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Appointment Management";
            Load += MainAppointmentForm_Load;
            ((System.ComponentModel.ISupportInitialize)appointmentDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView appointmentDataGridView;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private Label appointmentLabel;
        private TextBox searchTextBox;
        private Button searchButton;
        private Button deleteButton;
        private Button modifyButton;
        private Button addButton;
    }
}