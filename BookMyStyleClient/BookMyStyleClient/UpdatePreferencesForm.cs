using BookMyStyleClient.SalonServiceReference;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookMyStyleClient
{
    public partial class UpdatePreferencesForm : Form
    {
        public UpdatePreferencesForm()
        {
            InitializeComponent();

            cmbService.Items.AddRange(new string[]
            {
                "Haircut", "Pedicure", "Manicure", "Makeup", "Threading", "Hair Wash", "Dye Hair"
            });

            cmbNotification.Items.AddRange(new string[] { "Email", "SMS", "None" });
            cmbService.SelectedIndex = 0;
            cmbNotification.SelectedIndex = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var service = new SalonServiceSoapClient();

            string result = service.SavePreferences(
                txtCustomerName.Text,
                cmbStylist.Text,
                cmbService.SelectedItem.ToString(),
                cmbNotification.SelectedItem.ToString(),
                txtNotes.Text
            );

            lblStatus.Text = result;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
