using AppointmentApp.Core.Data;
using AppointmentApp.Core.DataTransfer;
using AppointmentApp.Core.Models;
using AppointmentApp.Core.Utilities;
using MySql.Data.MySqlClient;
using System.ComponentModel;

namespace AppointmentApp.UserInterface.AppointmentManagement
{
    public partial class AddAppointmentForm : Form
    {
        private User CurrentUser { get; set; }
        public AddAppointmentForm(User user, DateTime? selectedDate = null)
        {
            CurrentUser = user;
            InitializeComponent();

            customerDataGridView.AutoGenerateColumns = false;

            customerDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CustomerName",
                HeaderText = "Customer Name"
            });
            customerDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "FullAddress",
                DataPropertyName = "FullAddress",
                HeaderText = "Address"
            });
            customerDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CityName",
                HeaderText = "City"
            });
            customerDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CountryName",
                HeaderText = "Country"
            });
            customerDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Phone",
                HeaderText = "Phone"
            });

            customerDataGridView.DataSource = CustomerRepository.GetAllCustomers();
            foreach (DataGridViewColumn col in customerDataGridView.Columns)
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

            customerDataGridView.Columns["FullAddress"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            startDateTimePicker.Format = DateTimePickerFormat.Custom;
            startDateTimePicker.CustomFormat = "ddd, MM/dd/yyyy hh:mm tt";
            startDateTimePicker.ShowUpDown = true;

            endDateTimePicker.Format = DateTimePickerFormat.Custom;
            endDateTimePicker.CustomFormat = "ddd, MM/dd/yyyy hh:mm tt";
            endDateTimePicker.ShowUpDown = true;

            if (selectedDate.HasValue)
            {
                startDateTimePicker.Value = selectedDate.Value.Date.AddHours(9);
                endDateTimePicker.Value = selectedDate.Value.Date.AddHours(10);
            }
            else
            {
                startDateTimePicker.Value = DateTime.Now.AddHours(1);
                endDateTimePicker.Value = DateTime.Now.AddHours(2);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(searchTextBox.Text))
            {
                customerDataGridView.DataSource = CustomerRepository.GetAllCustomers();
            }
            else
            {
                customerDataGridView.DataSource = CustomerRepository.SearchCustomers(searchTextBox.Text);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (customerDataGridView.CurrentRow == null)
                {
                    MessageBox.Show("Please select a customer for this appointment.",
                                    "Customer Selection Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }

                CustomerRecord selectedCustomer = (CustomerRecord)customerDataGridView.CurrentRow.DataBoundItem;
                if (selectedCustomer == null)
                {
                    MessageBox.Show("Invalid customer selection.",
                                    "Customer Selection Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    return;
                }

                var appointment = new Appointment
                {
                    CustomerID = selectedCustomer.CustomerId,
                    UserID = CurrentUser.UserId,
                    Title = titleTextBox.Text,
                    Description = descriptionTextBox.Text,
                    Location = locationTextBox.Text,
                    Contact = contactTextBox.Text,
                    Url = urlTextBox.Text,
                    Type = typeTextBox.Text,
                    Start = startDateTimePicker.Value,
                    End = endDateTimePicker.Value
                };

                string? error = AppointmentValidator.ValidateAppointment(appointment);
                if (error != null)
                {
                    MessageBox.Show(error, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                error = AppointmentValidator.CheckForOverlappingAppointments(appointment);
                if (error != null)
                {
                    MessageBox.Show(error, "Scheduling Conflict", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                AppointmentRepository.AddAppointment(CurrentUser.UserName, appointment);

                MessageBox.Show("Appointment added successfully.",
                                "Success",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                this.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Database error: {ex.Message}",
                                "Database Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error: {ex.Message}",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void AddAppointmentForm_Load(object sender, EventArgs e)
        {
            CustomerRecord customerSelected = (CustomerRecord)customerDataGridView.CurrentRow.DataBoundItem;
            nameTextBox.Text = customerSelected.CustomerName;
        }

        private void customerDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            CustomerRecord customerSelected = (CustomerRecord)customerDataGridView.CurrentRow.DataBoundItem;
            nameTextBox.Text = customerSelected.CustomerName;
        }

        private void addCustomerButton_Click(object sender, EventArgs e)
        {
            AddCustomerForm addCustomerForm = new(CurrentUser);
            addCustomerForm.ShowDialog();

            if (addCustomerForm.NewCustomer != null)
            {
                customerDataGridView.DataSource = new BindingList<CustomerRecord> { addCustomerForm.NewCustomer }; ;
            }
        }

        private void startDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime start = startDateTimePicker.Value;
            DateTime end = endDateTimePicker.Value;

            if (end < start)
            {
                endDateTimePicker.Value = start.AddHours(1);
            }
        }
    }
}
