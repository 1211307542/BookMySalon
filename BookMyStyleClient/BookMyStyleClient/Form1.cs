using BookMyStyleClient.SalonServiceReference;
using System;
using System.Windows.Forms;

namespace BookMyStyleClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Populate ComboBox with service types
            cmbServiceType.Items.AddRange(new string[]
            {
                "Manicure",
                "Pedicure",
                "Makeup",
                "Threading",
                "Haircut",
                "Hair Wash",
                "Dye Hair"
            });

            cmbServiceType.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var service = new SalonServiceSoapClient();

            string customerName = txtCustomerName.Text;
            string serviceType = cmbServiceType.SelectedItem?.ToString();
            DateTime combinedDateTime = dtpAppointment.Value.Date + dtpAppointmentTime.Value.TimeOfDay;
            string dateTime = combinedDateTime.ToString("yyyy-MM-dd HH:mm");

            string result = service.BookAppointment(customerName, serviceType, dateTime);

            lblStatusMessage.Text = result;

            // Extract and show Booking ID
            string bookingId = "";
            if (result.Contains("ID:"))
            {
                int index = result.IndexOf("ID:") + 3;
                bookingId = result.Substring(index).Trim();
            }

            if (!string.IsNullOrEmpty(bookingId))
            {
                MessageBox.Show($"Your Booking ID is: {bookingId}", "Booking Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(result, "Booking Response", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
