using AppointmentApp.Core.Data;
using AppointmentApp.Core.DataTransfer;
using AppointmentApp.Core.Models;
using AppointmentApp.Core.Utilities;
using MySql.Data.MySqlClient;
using System.ComponentModel;

namespace AppointmentApp.UserInterface.AppointmentManagement
{
    public partial class ModifyAppointmentForm : Form
    {
        private User CurrentUser { get; set; }
        private Appointment OriginalAppointment { get; set; }
        private BindingList<CustomerRecord> Customers { get; set; }
        public ModifyAppointmentForm(User user, AppointmentRecord appointmentRecord, String query)
        {
            Customers = CustomerRepository.SearchCustomers(query);
            CurrentUser = user;
            OriginalAppointment = appointmentRecord.ToAppointment();
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

            customerDataGridView.DataSource = Customers;

            foreach (DataGridViewColumn col in customerDataGridView.Columns)
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

            customerDataGridView.Columns["FullAddress"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            customerDataGridView.ClearSelection();
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (customerDataGridView.CurrentRow == null)
                {
                    MessageBox.Show("Please select a customer for this OriginalAppointment.",
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

                Appointment NewAppointment = new Appointment
                {
                    AppointmentID = OriginalAppointment.AppointmentID,
                    CustomerID = selectedCustomer.CustomerId,
                    UserID = CurrentUser.UserId,
                    Title = titleTextBox.Text,
                    Description = descriptionTextBox.Text,
                    Location = locationTextBox.Text,
                    Contact = contactTextBox.Text,
                    Type = typeTextBox.Text,
                    Url = urlTextBox.Text,
                    Start = startDateTimePicker.Value,
                    End = endDateTimePicker.Value
                };

                string? error = AppointmentValidator.ValidateAppointment(NewAppointment);
                if (error != null)
                {
                    MessageBox.Show(error, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                error = AppointmentValidator.CheckForOverlappingAppointments(NewAppointment, NewAppointment.AppointmentID);
                if (error != null)
                {
                    MessageBox.Show(error, "Scheduling Conflict", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                AppointmentRepository.UpdateAppointment(CurrentUser.UserName, NewAppointment);

                MessageBox.Show("Appointment updated successfully.",
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
        private void ModifyAppointmentForm_Load(object sender, EventArgs e)
        {
            CustomerRecord originalCustomer = Customers.Single(c => c.CustomerId == OriginalAppointment.CustomerID);
            customerDataGridView.CurrentCell = customerDataGridView.Rows[Customers.IndexOf(originalCustomer)].Cells[0];

            nameTextBox.Text = Customers.Single(c => c.CustomerId == OriginalAppointment.CustomerID).CustomerName;
            titleTextBox.Text = OriginalAppointment.Title;
            descriptionTextBox.Text = OriginalAppointment.Description;
            locationTextBox.Text = OriginalAppointment.Location;
            contactTextBox.Text = OriginalAppointment.Contact;
            typeTextBox.Text = OriginalAppointment.Type;
            startDateTimePicker.Value = OriginalAppointment.Start;
            endDateTimePicker.Value = OriginalAppointment.End;

            startDateTimePicker.Format = DateTimePickerFormat.Custom;
            startDateTimePicker.CustomFormat = "ddd, MM/dd/yyyy hh:mm tt";

            endDateTimePicker.Format = DateTimePickerFormat.Custom;
            endDateTimePicker.CustomFormat = "ddd, MM/dd/yyyy hh:mm tt";
        }

        private void customerDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            CustomerRecord? customerSelected = (CustomerRecord)customerDataGridView.CurrentRow.DataBoundItem;
            nameTextBox.Text = customerSelected.CustomerName;
            contactTextBox.Text = "";
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
