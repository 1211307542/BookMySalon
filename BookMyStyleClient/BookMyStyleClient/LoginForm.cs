// LoginForm.cs
using System;
using System.Windows.Forms;

namespace BookMyStyleClient
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter your name.");
                return;
            }

            if (rdoCustomer.Checked)
            {
                MainMenuForm customerForm = new MainMenuForm();
                customerForm.Show();
                this.Hide();
            }
            else if (rdoStaff.Checked)
            {
                StaffDashboardForm staffForm = new StaffDashboardForm(name);
                staffForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please select a role.");
            }
        }
    }
}
