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
    public partial class AddGuest : Form
    {
        public AddGuest()
        {
            InitializeComponent();
        }

        ReceptionistController rc = new ReceptionistController();

        public void Refresh()
        {
            dataGridView1.DataSource = rc.ViewAllGuest();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String name = textBox1.Text;
            String data = textBox2.Text;
            rc.AddGuest(name, data);

            MessageBox.Show("Done");
            Refresh();

         }

        private void AddGuest_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String name = textBox1.Text;
            String data = textBox2.Text;
            int id = int.Parse(textBox3.Text);

            rc.UpdateGuest(id,name,data);
            MessageBox.Show("Done");
            Refresh();
        }
    }
}
