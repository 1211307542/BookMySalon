namespace BookMyStyleClient
{
    partial class MainMenuForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnBook = new System.Windows.Forms.Button();
            this.btnViewHistory = new System.Windows.Forms.Button();
            this.btnPreferences = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(451, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(430, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Book My Style!";
            // 
            // btnBook
            // 
            this.btnBook.BackColor = System.Drawing.Color.MistyRose;
            this.btnBook.Location = new System.Drawing.Point(245, 530);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(181, 81);
            this.btnBook.TabIndex = 1;
            this.btnBook.Text = "Book Appointment";
            this.btnBook.UseVisualStyleBackColor = false;
            this.btnBook.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnViewHistory
            // 
            this.btnViewHistory.BackColor = System.Drawing.Color.MistyRose;
            this.btnViewHistory.Location = new System.Drawing.Point(533, 530);
            this.btnViewHistory.Name = "btnViewHistory";
            this.btnViewHistory.Size = new System.Drawing.Size(174, 81);
            this.btnViewHistory.TabIndex = 2;
            this.btnViewHistory.Text = "View Appointments";
            this.btnViewHistory.UseVisualStyleBackColor = false;
            this.btnViewHistory.Click += new System.EventHandler(this.btnViewHistory_Click);
            // 
            // btnPreferences
            // 
            this.btnPreferences.BackColor = System.Drawing.Color.MistyRose;
            this.btnPreferences.Location = new System.Drawing.Point(806, 530);
            this.btnPreferences.Name = "btnPreferences";
            this.btnPreferences.Size = new System.Drawing.Size(163, 81);
            this.btnPreferences.TabIndex = 3;
            this.btnPreferences.Text = "Update Preferences";
            this.btnPreferences.UseVisualStyleBackColor = false;
            this.btnPreferences.Click += new System.EventHandler(this.button3_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.BackgroundImage = global::BookMyStyleClient.Properties.Resources.nails1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1240, 668);
            this.Controls.Add(this.btnPreferences);
            this.Controls.Add(this.btnViewHistory);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "MainMenuForm";
            this.Text = "MainMenuForm";
            this.Load += new System.EventHandler(this.MainMenuForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Button btnViewHistory;
        private System.Windows.Forms.Button btnPreferences;
    }
}