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

namespace Program.Folder_RoomService
{
    public partial class AddOrder : Form
    {
        public AddOrder()
        {
            InitializeComponent();
        }

        RoomServiceController rs = new RoomServiceController();

        public void Refresh()
        {
            dataGridView1.DataSource = rs.ViewAllOrder();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String Type = textBox1.Text;
            String foodnname = textBox2.Text;
            int quantity = int.Parse(textBox3.Text);
            rs.AddOrder(Type, foodnname, quantity);

            MessageBox.Show("done");
            Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox4.Text);
            rs.DeleteOrder(id);

            MessageBox.Show("done");
            Refresh();
        }

        private void AddOrder_Load(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}
