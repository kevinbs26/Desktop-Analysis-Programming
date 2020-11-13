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
    public partial class RenewTicket : Form
    {
        public RenewTicket()
        {
            InitializeComponent();
        }

        ReceptionistController rc = new ReceptionistController();

        private void button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox1.Text);
            int quantity = int.Parse(textBox2.Text);
            int price = int.Parse(textBox3.Text);

            rc.TicketDeduction(id, quantity, price);
            MessageBox.Show("done");
        }
    }
}
