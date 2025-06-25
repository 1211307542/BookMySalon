namespace BookMyStyleClient
{
    partial class AppointmentHistoryForm
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
            this.lstAppointments = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelSelected = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstAppointments
            // 
            this.lstAppointments.BackColor = System.Drawing.Color.White;
            this.lstAppointments.Font = new System.Drawing.Font("Maiandra GD", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstAppointments.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lstAppointments.FormattingEnabled = true;
            this.lstAppointments.ItemHeight = 19;
            this.lstAppointments.Location = new System.Drawing.Point(30, 133);
            this.lstAppointments.Name = "lstAppointments";
            this.lstAppointments.Size = new System.Drawing.Size(1288, 251);
            this.lstAppointments.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(522, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Your Appointment History:";
            // 
            // btnCancelSelected
            // 
            this.btnCancelSelected.Location = new System.Drawing.Point(790, 326);
            this.btnCancelSelected.Name = "btnCancelSelected";
            this.btnCancelSelected.Size = new System.Drawing.Size(489, 40);
            this.btnCancelSelected.TabIndex = 0;
            this.btnCancelSelected.Text = "Cancel Selected Booking";
            this.btnCancelSelected.Click += new System.EventHandler(this.btnCancelSelected_Click);
            // 
            // AppointmentHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1338, 506);
            this.Controls.Add(this.btnCancelSelected);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstAppointments);
            this.Name = "AppointmentHistoryForm";
            this.Text = "AppointmentHistoryForm";
            this.Load += new System.EventHandler(this.AppointmentHistoryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstAppointments;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelSelected;
    }
}