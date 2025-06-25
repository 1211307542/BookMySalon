using System;
using System.Windows.Forms;

namespace BookMyStyleClient
{
    public partial class ViewPreferencesForm : Form
    {
        public ViewPreferencesForm()
        {
            InitializeComponent();
        }

        private void ViewPreferencesForm_Load(object sender, EventArgs e)
        {
            LoadPreferences();
        }

        private void LoadPreferences()
        {
            var service = new SalonServiceReference.SalonServiceSoapClient();
            lstPreferences.Items.Clear();

            var rawResult = service.GetAllPreferences(); 
            var preferences = rawResult?.ToArray();      

            if (preferences == null || preferences.Length == 0)
            {
                lstPreferences.Items.Add("No preferences found.");
                lblStatus.Text = "Status: No preferences found.";
                return;
            }

            foreach (var line in preferences)
            {
                lstPreferences.Items.Add(line);
            }

            lblStatus.Text = "Status: Preferences loaded.";
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadPreferences();
        }
    }
}
