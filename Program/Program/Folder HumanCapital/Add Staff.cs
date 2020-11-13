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

namespace Program.Folder_HumanCapital
{
    public partial class Hire_Staff : Form
    {
        public Hire_Staff()
        {
            InitializeComponent();
        }

        HumanCapitalController hc = new HumanCapitalController();
        public void Refresh()
        {
            dataGridView1.DataSource = hc.ViewAllStaff();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String name = textBox1.Text;
            String Position = textBox2.Text;
            String Username = textBox3.Text;
            String Password = textBox4.Text;
            int salaray = int.Parse(textBox5.Text);
            hc.AddStaff(name,Position,Username,Password,salaray);

            MessageBox.Show("done");
            Refresh();
        }

        private void Hire_Staff_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox6.Text);
            String name = textBox1.Text;
            String Position = textBox2.Text;
            String Username = textBox3.Text;
            String Password = textBox4.Text;
            int salaray = int.Parse(textBox5.Text);
            hc.UpdateStaff(id,name, Position, Username, Password, salaray);

            MessageBox.Show("done");
            Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox6.Text);
            
            hc.UpdateStaff(id);

            MessageBox.Show("done");
            Refresh();
        }
    }
}
