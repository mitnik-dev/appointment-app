namespace AppointmentApp.UserInterface
{
    partial class ReportsForm
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
            appointmentsByMonthButton = new Button();
            scheduleByUserButton = new Button();
            appointmentsByCustomerButton = new Button();
            reportsDataGridView = new DataGridView();
            reportButtonsPanel = new Panel();
            ((System.ComponentModel.ISupportInitialize)reportsDataGridView).BeginInit();
            reportButtonsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // appointmentsByMonthButton
            // 
            appointmentsByMonthButton.BackColor = SystemColors.Control;
            appointmentsByMonthButton.ForeColor = SystemColors.ControlText;
            appointmentsByMonthButton.Location = new Point(0, 7);
            appointmentsByMonthButton.Name = "appointmentsByMonthButton";
            appointmentsByMonthButton.Size = new Size(230, 29);
            appointmentsByMonthButton.TabIndex = 0;
            appointmentsByMonthButton.Text = "Appointment Types by Month";
            appointmentsByMonthButton.UseVisualStyleBackColor = false;
            appointmentsByMonthButton.Click += appointmentsByMonthButton_Click;
            // 
            // scheduleByUserButton
            // 
            scheduleByUserButton.Location = new Point(470, 7);
            scheduleByUserButton.Name = "scheduleByUserButton";
            scheduleByUserButton.Size = new Size(145, 29);
            scheduleByUserButton.TabIndex = 1;
            scheduleByUserButton.Text = "Schedule by User";
            scheduleByUserButton.UseVisualStyleBackColor = true;
            scheduleByUserButton.Click += scheduleByUserButton_Click;
            // 
            // appointmentsByCustomerButton
            // 
            appointmentsByCustomerButton.Location = new Point(245, 7);
            appointmentsByCustomerButton.Name = "appointmentsByCustomerButton";
            appointmentsByCustomerButton.Size = new Size(210, 29);
            appointmentsByCustomerButton.TabIndex = 2;
            appointmentsByCustomerButton.Text = "Appointments by Customer";
            appointmentsByCustomerButton.UseVisualStyleBackColor = true;
            appointmentsByCustomerButton.Click += appointmentsByCustomerButton_Click;
            // 
            // reportsDataGridView
            // 
            reportsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            reportsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            reportsDataGridView.Location = new Point(64, 81);
            reportsDataGridView.MultiSelect = false;
            reportsDataGridView.Name = "reportsDataGridView";
            reportsDataGridView.RowHeadersVisible = false;
            reportsDataGridView.RowHeadersWidth = 51;
            reportsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            reportsDataGridView.Size = new Size(668, 316);
            reportsDataGridView.TabIndex = 4;
            // 
            // reportButtonsPanel
            // 
            reportButtonsPanel.Controls.Add(appointmentsByMonthButton);
            reportButtonsPanel.Controls.Add(appointmentsByCustomerButton);
            reportButtonsPanel.Controls.Add(scheduleByUserButton);
            reportButtonsPanel.Location = new Point(64, 25);
            reportButtonsPanel.Name = "reportButtonsPanel";
            reportButtonsPanel.Size = new Size(668, 41);
            reportButtonsPanel.TabIndex = 6;
            // 
            // ReportsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(reportsDataGridView);
            Controls.Add(reportButtonsPanel);
            Name = "ReportsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reports";
            ((System.ComponentModel.ISupportInitialize)reportsDataGridView).EndInit();
            reportButtonsPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button appointmentsByMonthButton;
        private Button scheduleByUserButton;
        private Button appointmentsByCustomerButton;
        private DataGridView reportsDataGridView;
        private Panel reportButtonsPanel;
    }
}