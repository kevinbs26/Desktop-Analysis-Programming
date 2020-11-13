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

namespace Program.Folder_HouseKeeeping
{
    public partial class supply : Form
    {
        public supply()
        {
            InitializeComponent();
        }

        HouseKeepingController hkc = new HouseKeepingController();
        public void Refresh()
        {
            dataGridView1.DataSource = hkc.ViewAllSupply();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String name = textBox2.Text;
            int stock = int.Parse(textBox3.Text);
            int minimum = int.Parse(textBox4.Text);

            hkc.CreateSupply(name, stock, minimum);

            MessageBox.Show("done");
            Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox1.Text);
            String name = textBox2.Text;
            int stock = int.Parse(textBox3.Text);
            int minimum = int.Parse(textBox4.Text);

            hkc.UpdateSupply(id, name, stock, minimum);

            MessageBox.Show("done");
            Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox1.Text);

            hkc.DeleteSupply(id);

            MessageBox.Show("done");
            Refresh();
        }

        private void supply_Load(object sender, EventArgs e)
        {
            Refresh();
            
        }
    }
}
