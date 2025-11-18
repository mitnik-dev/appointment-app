using AppointmentApp.Core.Data;
using AppointmentApp.Core.DataTransfer;
using AppointmentApp.Core.Models;
using AppointmentApp.UserInterface.AppointmentManagement;
using System.ComponentModel;
using System.Globalization;

namespace AppointmentApp.UserInterface
{
    public partial class MainForm : Form
    {
        User CurrentUser { get; set; }
        public MainForm(User user)
        {
            CurrentUser = user;
            InitializeComponent();
            appointmentDataGridView.AutoGenerateColumns = false;

            appointmentDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CustomerName",
                HeaderText = "Customer"
            });
            appointmentDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Title",
                HeaderText = "Title"
            });
            appointmentDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Location",
                HeaderText = "Location"
            });
            appointmentDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "FormatTime",
                DataPropertyName = "FormatTime",
                HeaderText = "Time"
            });

            appointmentDataGridView.DataSource = AppointmentRepository.SearchAppointmentsByDate(appointmentCalendar.SelectionStart);

            foreach (DataGridViewColumn col in appointmentDataGridView.Columns)
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void manageCustomersButton_Click(object sender, EventArgs e)
        {
            MainCustomerForm mainCustomerForm = new(CurrentUser);
            mainCustomerForm.ShowDialog();
            appointmentDataGridView.DataSource = AppointmentRepository.SearchAppointmentsByDate(appointmentCalendar.SelectionStart);
        }

        private void manageAppointmentsButton_Click(object sender, EventArgs e)
        {
            MainAppointmentForm mainappointmentForm = new(CurrentUser);
            mainappointmentForm.ShowDialog();
            appointmentDataGridView.DataSource = AppointmentRepository.SearchAppointmentsByDate(appointmentCalendar.SelectionStart);
        }

        private void moreDetailsButton_Click(object sender, EventArgs e)
        {
            AppointmentRecord appointmentRecord = (AppointmentRecord)appointmentDataGridView.CurrentRow.DataBoundItem;

            MainAppointmentForm mainappointmentForm = new(CurrentUser, appointmentRecord.AppointmentID);
            mainappointmentForm.ShowDialog();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(searchTextBox.Text))
            {
                appointmentDataGridView.DataSource = AppointmentRepository.GetAllAppointments();
            }
            else
            {
                appointmentDataGridView.DataSource = AppointmentRepository.SearchAppointments(searchTextBox.Text);
            }
        }

        private void appointmentCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            appointmentDataGridView.DataSource = AppointmentRepository.SearchAppointmentsByDate(appointmentCalendar.SelectionStart);
        }

        private void addNewButton_Click(object sender, EventArgs e)
        {
            AddAppointmentForm addAppointmentForm = new(CurrentUser, appointmentCalendar.SelectionStart);
            addAppointmentForm.ShowDialog();
            appointmentDataGridView.DataSource = AppointmentRepository.SearchAppointmentsByDate(appointmentCalendar.SelectionStart);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            userTextBox.Text = CurrentUser.UserName;
            locationTextBox.Text = $"{CultureInfo.CurrentCulture.Name} ({TimeZoneInfo.Local.StandardName})";
            todayTextBox.Text = DateTime.Now.ToShortDateString();

            BindingList<AppointmentRecord> appointments = new(AppointmentRepository.SearchAppointmentsByUser(CurrentUser.UserId));

            foreach (AppointmentRecord appointment in appointments)
            {
                if (appointment.Start <= DateTime.Now.AddMinutes(15) && appointment.Start >= DateTime.Now)
                {
                    MessageBox.Show($"You have an upcoming appointment at {appointment.Start:t} today.",
                                    "Upcoming Appointment",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    return;
                }
            }
        }

        private void reportsButton_Click(object sender, EventArgs e)
        {
            ReportsForm reportsForm = new(CurrentUser);
            reportsForm.ShowDialog();
        }
    }
}
