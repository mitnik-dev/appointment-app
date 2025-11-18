using AppointmentApp.Core.Data;
using AppointmentApp.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppointmentApp.UserInterface
{
    public partial class ReportsForm : Form
    {
        User CurrentUser { get; set; }
        public ReportsForm(User user)
        {
            InitializeComponent();
            CurrentUser = user;
        }

        private void HighlightButton(Button activeButton)
        {
            foreach (Control control in reportButtonsPanel.Controls)
            {
                if (control is Button button)
                {  
                    if (button == activeButton)
                    {
                        button.BackColor = Color.FromArgb(235, 222, 244, 250);
                        button  .FlatAppearance.BorderColor = Color.FromArgb(0, 100, 180); ;
                    }
                    else
                    {
                        button.FlatAppearance.BorderColor = Color.FromArgb(200, 200, 200);
                        button.BackColor = Color.Transparent;
                    }
                }
            }
        }

        private void appointmentsByMonthButton_Click(object sender, EventArgs e)
        {
            HighlightButton(appointmentsByMonthButton);

           reportsDataGridView.DataSource = AppointmentRepository.GetAllAppointments()
                                            .GroupBy(a => new { a.Start.Month, a.Type })
                                            .Select(g => new
                                            {
                                                Month = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(g.Key.Month),
                                                Type = g.Key.Type,
                                                Count = g.Count()
                                            })
                                            .OrderBy(r => DateTime.ParseExact(r.Month, "MMMM", CultureInfo.CurrentCulture).Month)
                                            .ToList();
        }

        private void appointmentsByCustomerButton_Click(object sender, EventArgs e)
        {
            HighlightButton(appointmentsByCustomerButton);

            reportsDataGridView.DataSource = AppointmentRepository.GetAllAppointments()
                                            .OrderBy(a => a.CustomerID)
                                            .ThenBy(a => a.Start)
                                            .Select(a => new
                                            {
                                                Customer = a.CustomerName,
                                                a.Title,
                                                a.Type,
                                                a.Description,
                                                a.Start.Date,
                                                Time = TimeZoneInfo.ConvertTime(a.Start, TimeZoneInfo.Local).ToShortTimeString(),
                                            })
                                            .ToList();
        }

        private void scheduleByUserButton_Click(object sender, EventArgs e)
        {
            HighlightButton(scheduleByUserButton);

            reportsDataGridView.DataSource = AppointmentRepository.GetAllAppointments()
                                            .OrderBy(a => a.UserID)
                                            .ThenBy(a => a.Start)
                                            .Select(a => new
                                            {
                                                ID = a.UserID,
                                                Customer = a.CustomerName,
                                                a.Title,
                                                a.Type,
                                                a.Start.Date,
                                                Time = TimeZoneInfo.ConvertTime(a.Start, TimeZoneInfo.Local).ToShortTimeString(),
                                            })
                                            .ToList();

            reportsDataGridView.Columns["ID"].DisplayIndex = 0;
        }
    }
}
