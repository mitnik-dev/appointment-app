using AppointmentApp.Core.Data;
using AppointmentApp.Core.DataTransfer;
using AppointmentApp.Core.Utilities;
using AppointmentApp.Core.Models;
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
    public partial class AddCustomerForm : Form
    {
        private User CurrentUser { get; set; }
        public CustomerRecord? NewCustomer { get; set; }
        public AddCustomerForm(User user)
        {
            CurrentUser = user;
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                var customerRecord = new CustomerRecord
                {
                    CustomerName = nameTextBox.Text,
                    Address1 = address1TextBox.Text,
                    Address2 = address2TextBox.Text,
                    PostalCode = postalTextBox.Text,
                    Phone = phoneTextBox.Text,
                    CityName = cityTextBox.Text,
                    CountryName = countryTextBox.Text,
                    Active = 1
                };

                RecordValidator.TrimFields(customerRecord);
                string? error = RecordValidator.RequiredFields(customerRecord);

                if (error != null)
                {
                    MessageBox.Show(error, "Empty Field Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                error = RecordValidator.ValidatePhone(customerRecord.Phone);

                if (error != null)
                {
                    MessageBox.Show(error, "Invalid Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                NewCustomer = CustomerRepository.AddCustomer(
                    CurrentUser.UserName,
                    customerRecord.ToAddress(),
                    customerRecord.ToCity(),
                    customerRecord.ToCountry(),
                    customerRecord.ToCustomer());

                MessageBox.Show("Customer added successfully.",
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

        private void AddCustomerForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = customerInfoLabel; 
        }
    }
}
