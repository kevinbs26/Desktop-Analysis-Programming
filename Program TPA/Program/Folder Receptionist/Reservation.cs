using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Program.Controller;

namespace Program.Folder_Receptionist
{
    public partial class Reservation : Form
    {
        public Reservation()
        {
            InitializeComponent();
        }

        ReceptionistController rc = new ReceptionistController();

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        public void Refresh()
        {
            dataGridView1.DataSource = rc.ViewAllReservation();
        }

        private void Reservation_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime checkIn = dateTimePicker1.Value;
            DateTime checkOut = dateTimePicker2.Value;
            int room = int.Parse(textBox1.Text);
            int Deposit = int.Parse(textBox2.Text);
            int fee = int.Parse(textBox3.Text);
            rc.CreateReservation(checkIn, checkOut, room, Deposit, fee);

            MessageBox.Show("done");
            Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int ReservationId = int.Parse(textBox4.Text);
            DateTime checkIn = dateTimePicker1.Value;
            DateTime checkOut = dateTimePicker2.Value;
            int room = int.Parse(textBox1.Text);
            int Deposit = int.Parse(textBox2.Text);
            int fee = int.Parse(textBox3.Text);
            rc.UpdateReservation(ReservationId, checkIn, checkOut, room, Deposit, fee);

            MessageBox.Show("done");
            Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int ReservationId = int.Parse(textBox4.Text);
            rc.DeleteReservation(ReservationId);

            MessageBox.Show("done");
            Refresh();
        }
    }
}
