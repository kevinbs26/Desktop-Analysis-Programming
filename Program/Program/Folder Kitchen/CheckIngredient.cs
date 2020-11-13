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

namespace Program.Folder_Kitchen
{
    public partial class CheckIngredient : Form
    {
        public CheckIngredient()
        {
            InitializeComponent();
        }

        KitchenController kc = new KitchenController();
        public void Refresh()
        {
            dataGridView1.DataSource = kc.ViewAllIngredient();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String name = textBox2.Text;
            int stock = int.Parse(textBox3.Text);
            int minimum = int.Parse(textBox4.Text);

            kc.CreateIngredient(name, stock, minimum);

            MessageBox.Show("done");
            Refresh();
        }

        private void CheckIngredient_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox1.Text);
            String name = textBox2.Text;
            int stock = int.Parse(textBox3.Text);
            int minimum = int.Parse(textBox4.Text);

            kc.UpdateIngredient(id, name, stock, minimum);

            MessageBox.Show("done");
            Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            int id = int.Parse(textBox1.Text);

            kc.DeleteIngredient(id);

            MessageBox.Show("done");
            Refresh();
        }
    }
}
