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
    public partial class StaffDashboardForm : Form
    {
        private string staffName;

        public StaffDashboardForm(string name)
        {
            InitializeComponent();
            staffName = name;
            lblWelcome.Text = $"Welcome, {staffName}";
        }
        private void btnManageBookings_Click(object sender, EventArgs e)
        {
            ManageBookingsForm manageForm = new ManageBookingsForm();
            manageForm.ShowDialog();
        }
        private void btnViewPreferences_Click(object sender, EventArgs e)
        {
            ViewPreferencesForm form = new ViewPreferencesForm();
            form.ShowDialog();
        }
    }

}
