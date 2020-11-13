namespace Program.Folder_Receptionist
{
    partial class Receptionist
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.reservationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addGuestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allDeductionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renewTicketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reservationToolStripMenuItem,
            this.addGuestToolStripMenuItem,
            this.sendReportToolStripMenuItem,
            this.allDeductionToolStripMenuItem,
            this.renewTicketToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // reservationToolStripMenuItem
            // 
            this.reservationToolStripMenuItem.Name = "reservationToolStripMenuItem";
            this.reservationToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.reservationToolStripMenuItem.Text = "Reservation";
            this.reservationToolStripMenuItem.Click += new System.EventHandler(this.reservationToolStripMenuItem_Click);
            // 
            // addGuestToolStripMenuItem
            // 
            this.addGuestToolStripMenuItem.Name = "addGuestToolStripMenuItem";
            this.addGuestToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.addGuestToolStripMenuItem.Text = "AddGuest";
            this.addGuestToolStripMenuItem.Click += new System.EventHandler(this.addGuestToolStripMenuItem_Click);
            // 
            // sendReportToolStripMenuItem
            // 
            this.sendReportToolStripMenuItem.Name = "sendReportToolStripMenuItem";
            this.sendReportToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.sendReportToolStripMenuItem.Text = "SendReport";
            this.sendReportToolStripMenuItem.Click += new System.EventHandler(this.sendReportToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // allDeductionToolStripMenuItem
            // 
            this.allDeductionToolStripMenuItem.Name = "allDeductionToolStripMenuItem";
            this.allDeductionToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.allDeductionToolStripMenuItem.Text = "All Deduction";
            this.allDeductionToolStripMenuItem.Click += new System.EventHandler(this.allDeductionToolStripMenuItem_Click);
            // 
            // renewTicketToolStripMenuItem
            // 
            this.renewTicketToolStripMenuItem.Name = "renewTicketToolStripMenuItem";
            this.renewTicketToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.renewTicketToolStripMenuItem.Text = "RenewTicket";
            this.renewTicketToolStripMenuItem.Click += new System.EventHandler(this.renewTicketToolStripMenuItem_Click);
            // 
            // Receptionist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Receptionist";
            this.Text = "Receptionist";
            this.Load += new System.EventHandler(this.Receptionist_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem reservationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addGuestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allDeductionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renewTicketToolStripMenuItem;
    }
}