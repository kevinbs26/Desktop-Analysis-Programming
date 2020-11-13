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

namespace Program.Folder_DiningRoom
{
    public partial class RequestOrder : Form
    {
        public RequestOrder()
        {
            InitializeComponent();
        }

        DiningRoomController drc = new DiningRoomController();

        public void Refresh()
        {
            dataGridView1.DataSource = drc.ViewAllOrder();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String foodname = textBox2.Text;
            int quantity = int.Parse(textBox3.Text);
            drc.AddOrder(foodname, quantity);

            MessageBox.Show("done");
            Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox4.Text);
            drc.DeleteOrder(id);

            MessageBox.Show("done");
            Refresh();
        }
    }
}
