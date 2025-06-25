using System;
using System.Windows.Forms;
using BookMyStyleClient.SalonServiceReference;
using System.Linq;

namespace BookMyStyleClient
{
    public partial class ManageBookingsForm : Form
    {
        public ManageBookingsForm()
        {
            InitializeComponent();
        }

        private void ManageBookingsForm_Load(object sender, EventArgs e)
        {
            LoadBookings();
        }

        private void LoadBookings()
        {
            lstBookings.Items.Clear();
            var service = new SalonServiceSoapClient();

            var bookings = service.GetAllBookings();

            if (bookings == null || bookings.Count == 0)
            {
                lblStatus.Text = "Status: No bookings found.";
                return;
            }

            foreach (var booking in bookings)
            {
                lstBookings.Items.Add(booking);
            }

            lblStatus.Text = "Status: Bookings loaded.";
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadBookings();
        }

        private void btnCancelBooking_Click(object sender, EventArgs e)
        {
            if (lstBookings.SelectedItem == null)
            {
                MessageBox.Show("Please select a booking to cancel.");
                return;
            }

            string selected = lstBookings.SelectedItem.ToString();

            string bookingId = "";
            if (selected.Contains("Booking ID:"))
            {
                int start = selected.IndexOf("Booking ID:") + "Booking ID:".Length;
                int end = selected.IndexOf(',', start);
                if (end == -1) end = selected.Length;
                bookingId = selected.Substring(start, end - start).Trim();
            }

            if (string.IsNullOrWhiteSpace(bookingId))
            {
                MessageBox.Show("Unable to extract Booking ID.");
                return;
            }

            var service = new SalonServiceSoapClient();
            string result = service.CancelBooking(bookingId);

            MessageBox.Show(result, "Cancel Booking", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lblStatus.Text = $"Status: {result}";
            LoadBookings();
        }
    }
}
