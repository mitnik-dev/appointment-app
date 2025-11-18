using AppointmentApp.Core.Data;
using AppointmentApp.Core.DataTransfer;
using AppointmentApp.Core.Models;
using MySql.Data.MySqlClient;

namespace AppointmentApp.UserInterface.AppointmentManagement
{
    public partial class MainAppointmentForm : Form
    {
        private User CurrentUser { get; set; }
        public MainAppointmentForm(User user, int? appointmentId = null)
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
                Name = "Description",
                DataPropertyName = "Description",
                HeaderText = "Description"
            });
            appointmentDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Location",
                HeaderText = "Location"
            });
            appointmentDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Contact",
                HeaderText = "Contact"
            });
            appointmentDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Url",
                HeaderText = "URL"
            });
            appointmentDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Type",
                HeaderText = "Type"
            });
            appointmentDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Start",
                HeaderText = "Date",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "d" }
            });
            appointmentDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "FormatTime",
                HeaderText = "Time"
            });

            appointmentDataGridView.DataSource = appointmentId.HasValue ? AppointmentRepository.SearchAppointmentsById(appointmentId) : AppointmentRepository.GetAllAppointments();

            foreach (DataGridViewColumn col in appointmentDataGridView.Columns)
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            var description = appointmentDataGridView.Columns["Description"];

            if (description.Width < 150)
            {
                description.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

            description.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            AddAppointmentForm addAppointmentForm = new(CurrentUser);
            addAppointmentForm.ShowDialog();
            appointmentDataGridView.DataSource = AppointmentRepository.GetAllAppointments();
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            if (appointmentDataGridView.CurrentRow == null)
            {
                MessageBox.Show("Please select an appointment to modify.",
                                "Modify Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            AppointmentRecord appointmentRecord = (AppointmentRecord)appointmentDataGridView.CurrentRow.DataBoundItem;
            if (appointmentRecord == null)
            {
                MessageBox.Show("Invalid selection.",
                                "Modify Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            ModifyAppointmentForm modifyAppointmentForm = new(CurrentUser, appointmentRecord, searchTextBox.Text);
            modifyAppointmentForm.ShowDialog();
            appointmentDataGridView.DataSource = AppointmentRepository.GetAllAppointments();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (appointmentDataGridView.CurrentRow == null)
                {
                    MessageBox.Show("Please select an appointment to delete.",
                                    "Delete Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }

                AppointmentRecord appointmentRecord = (AppointmentRecord)appointmentDataGridView.CurrentRow.DataBoundItem;
                if (appointmentRecord == null)
                {
                    MessageBox.Show("Invalid selection.",
                                    "Delete Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    return;
                }

                DialogResult confirm = MessageBox.Show(
                    $"Are you sure you want to delete the appointment \"{appointmentRecord.Title}\"?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirm != DialogResult.Yes)
                    return;

                AppointmentRepository.DeleteAppointment(appointmentRecord.AppointmentID);
                appointmentDataGridView.DataSource = AppointmentRepository.GetAllAppointments();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Database error: {ex.Message}",
                                "Delete Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error: {ex.Message}",
                                "Delete Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
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

        private void MainAppointmentForm_Load(object sender, EventArgs e)
        {

        }
    }
}
