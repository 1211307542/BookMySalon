namespace BookMyStyleClient
{
    partial class StaffDashboardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnManageBookings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(324, 59);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(0, 20);
            this.lblWelcome.TabIndex = 0;
            // 
            // btnManageBookings
            // 
            this.btnManageBookings.Location = new System.Drawing.Point(328, 224);
            this.btnManageBookings.Name = "btnManageBookings";
            this.btnManageBookings.Size = new System.Drawing.Size(135, 63);
            this.btnManageBookings.TabIndex = 1;
            this.btnManageBookings.Text = "Manage Bookings";
            this.btnManageBookings.UseVisualStyleBackColor = true;
            this.btnManageBookings.Click += new System.EventHandler(this.btnManageBookings_Click);
            // 
            // btnViewPreferences
            this.btnViewPreferences = new System.Windows.Forms.Button();
            this.btnViewPreferences.Location = new System.Drawing.Point(328, 310); // adjust Y as needed
            this.btnViewPreferences.Name = "btnViewPreferences";
            this.btnViewPreferences.Size = new System.Drawing.Size(135, 63);
            this.btnViewPreferences.TabIndex = 2;
            this.btnViewPreferences.Text = "View Preferences";
            this.btnViewPreferences.UseVisualStyleBackColor = true;
            this.btnViewPreferences.Click += new System.EventHandler(this.btnViewPreferences_Click);
            // StaffDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnManageBookings);
            this.Controls.Add(this.btnViewPreferences);
            this.Controls.Add(this.lblWelcome);
            this.Name = "StaffDashboardForm";
            this.Text = "StaffDashboardForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnManageBookings;
        private System.Windows.Forms.Button btnViewPreferences;
    }
}