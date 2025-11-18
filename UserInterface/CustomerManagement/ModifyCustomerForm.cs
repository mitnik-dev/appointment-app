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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AppointmentApp.UserInterface.CustomerManagement
{
    public partial class ModifyCustomerForm : Form
    {
        private User CurrentUser { get; set; }
        private CustomerRecord CurrentCustomerRecord { get; set; }
        public ModifyCustomerForm(User user, CustomerRecord customerRecord)
        {
            CurrentCustomerRecord = customerRecord;
            CurrentUser = user;
            InitializeComponent();

            nameTextBox.Text = customerRecord.CustomerName;
            address1TextBox.Text = customerRecord.Address1;
            address2TextBox.Text = customerRecord.Address2;
            postalTextBox.Text = customerRecord.PostalCode;
            phoneTextBox.Text = customerRecord.Phone;
            cityTextBox.Text = customerRecord.CityName;
            countryTextBox.Text = customerRecord.CountryName;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            try
            {
                CustomerRecord customerRecord = new CustomerRecord
                {
                    CustomerName = nameTextBox.Text,
                    CustomerId = CurrentCustomerRecord.CustomerId,
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

                CustomerRepository.ModifyCustomer(
                    CurrentUser.UserName,
                    customerRecord.ToAddress(),
                    customerRecord.ToCity(),
                    customerRecord.ToCountry(),
                    customerRecord.ToCustomer());

                MessageBox.Show("Customer updated successfully.",
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

        private void ModifyCustomerForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = customerInfoLabel;
        }
    }
}
