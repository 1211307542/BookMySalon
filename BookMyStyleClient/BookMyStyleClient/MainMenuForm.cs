using System;
using System.Windows.Forms;

namespace BookMyStyleClient
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }
        private void MainMenuForm_Load(object sender, EventArgs e)
        {
            // Optional: any setup code on form load
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Open booking form (Form1)
            Form1 bookingForm = new Form1();
            bookingForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UpdatePreferencesForm form = new UpdatePreferencesForm();
            form.ShowDialog();
        }

        private void btnViewHistory_Click(object sender, EventArgs e)
        {
            string name = Prompt.ShowDialog("Enter your name to view history:", "View Appointments");

            if (!string.IsNullOrWhiteSpace(name))
            {
                var historyForm = new AppointmentHistoryForm(name);
                historyForm.ShowDialog();
            }
        }
    }
}
