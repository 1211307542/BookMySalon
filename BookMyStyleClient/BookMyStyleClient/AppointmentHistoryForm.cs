using BookMyStyleClient.SalonServiceReference;
using System;
using System.Windows.Forms;

namespace BookMyStyleClient
{
    public partial class AppointmentHistoryForm : Form
    {
        private string customerName;

        public AppointmentHistoryForm(string customerName)
        {
            InitializeComponent();
            this.customerName = customerName;
        }

        private void AppointmentHistoryForm_Load(object sender, EventArgs e)
        {
            LoadAppointments(customerName);
        }
        private void LoadAppointments(string customerName)
        {
            var service = new SalonServiceReference.SalonServiceSoapClient();
            lstAppointments.Items.Clear();

            var appointments = service.GetAppointmentsByCustomer(customerName)?.ToArray();

            if (appointments == null || appointments.Length == 0)
            {
                lstAppointments.Items.Add("No appointment history found.");
                return;
            }

            foreach (var appointment in appointments)
            {
                lstAppointments.Items.Add(appointment);
            }
        }

        private void btnCancelSelected_Click(object sender, EventArgs e)
        {
            if (lstAppointments.SelectedItem == null)
            {
                MessageBox.Show("Please select an appointment to cancel.");
                return;
            }

            string selected = lstAppointments.SelectedItem.ToString();

            // Extract Booking ID from string
            string bookingId = "";
            if (selected.Contains("Booking ID:"))
            {
                int start = selected.IndexOf("Booking ID:") + "Booking ID:".Length;
                bookingId = selected.Substring(start).Trim();
            }

            if (string.IsNullOrWhiteSpace(bookingId))
            {
                MessageBox.Show("Unable to extract Booking ID.");
                return;
            }

            var service = new SalonServiceReference.SalonServiceSoapClient();
            string result = service.CancelBooking(bookingId);

            MessageBox.Show(result, "Cancel Booking", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadAppointments(customerName); // Refresh list
        }


    }
}
