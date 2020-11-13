using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program.Folder_Receptionist
{
    public partial class Receptionist : Form
    {
        public Receptionist()
        {
            InitializeComponent();
        }

        private void Receptionist_Load(object sender, EventArgs e)
        {

        }

        Reservation reservation;
        private void reservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reservation = new Reservation();
            reservation.Show();
        }

        Login login;
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login = new Login();
            login.Show();
            this.Dispose();
        }

        AddGuest addguest;
        private void addGuestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addguest = new AddGuest();
            addguest.Show();
        }

        SendReport srp;
        private void sendReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            srp = new SendReport();
            srp.Show();
        }
    }
}
