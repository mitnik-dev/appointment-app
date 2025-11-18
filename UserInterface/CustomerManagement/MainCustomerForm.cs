using AppointmentApp.Core.Data;
using AppointmentApp.Core.DataTransfer;
using AppointmentApp.Core.Models;
using AppointmentApp.UserInterface.CustomerManagement;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppointmentApp.UserInterface
{
    public partial class MainCustomerForm : Form
    {
        private User CurrentUser { get; set; }
        public MainCustomerForm(User user)
        {
            InitializeComponent();

            CurrentUser = user;

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
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddCustomerForm addCustomerForm = new(CurrentUser);
            addCustomerForm.ShowDialog();

            customerDataGridView.DataSource = CustomerRepository.GetAllCustomers();
        }

        private void modifyButton_Click(Object sender, EventArgs e)
        {
            if (customerDataGridView.CurrentRow == null)
            {
                MessageBox.Show("Please select a customer to modify.",
                                "Modify Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            CustomerRecord customerRecord = (CustomerRecord)customerDataGridView.CurrentRow.DataBoundItem;
            if (customerRecord == null)
            {
                MessageBox.Show("Invalid selection.",
                                "Modify Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }
            ModifyCustomerForm modifyCustomerForm = new(CurrentUser, customerRecord);
            modifyCustomerForm.ShowDialog();

            customerDataGridView.DataSource = CustomerRepository.GetAllCustomers();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (customerDataGridView.CurrentRow == null)
                {
                    MessageBox.Show("Please select a customer to delete.",
                                    "Delete Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }

                CustomerRecord customerRecord = (CustomerRecord)customerDataGridView.CurrentRow.DataBoundItem;
                if (customerRecord == null)
                {
                    MessageBox.Show("Invalid selection.",
                                    "Delete Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    return;
                }

                DialogResult confirm = MessageBox.Show(
                    $"Are you sure you want to delete {customerRecord.CustomerName}?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirm != DialogResult.Yes)
                    return;

                CustomerRepository.DeleteCustomer(customerRecord.CustomerId);
                customerDataGridView.DataSource = CustomerRepository.GetAllCustomers();
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
                customerDataGridView.DataSource = CustomerRepository.GetAllCustomers();
            }
            else
            {
                customerDataGridView.DataSource = CustomerRepository.SearchCustomers(searchTextBox.Text);
            }
        }
    }
}
