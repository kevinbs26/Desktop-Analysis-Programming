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
    public partial class HireStaff : Form
    {
        public HireStaff()
        {
            InitializeComponent();
        }

        HumanCapitalController hcc = new HumanCapitalController();

        public void Refresh()
        {
            dataGridView1.DataSource = hcc.ViewAllCandidate();
            dataGridView2.DataSource = hcc.ViewAllInterview();
            dataGridView3.DataSource = hcc.ViewAllTraining();
        }

        public void deleteCandidate()
        {
            int id = int.Parse(textBox3.Text);

            hcc.DeleteCandidate(id);
            MessageBox.Show("Done");
            Refresh();
        }

        public void deleteInterview()
        {
            int id = int.Parse(textBox3.Text);

            hcc.DeleteInterview(id);
            MessageBox.Show("Done");
            Refresh();
        }

        public void deleteTraining()
        {
            int id = int.Parse(textBox3.Text);

            hcc.DeleteTraining(id);
            MessageBox.Show("Done");
            Refresh();
        }

        private void HireStaff_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            String name = textBox1.Text;
            String position = textBox2.Text;
            hcc.AddCadidate(name, position);

            MessageBox.Show("Done");
            Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox3.Text);
            hcc.AddInterview(id);

            MessageBox.Show("Done");
            deleteCandidate();
            Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox3.Text);
            hcc.AddTraining(id);

            MessageBox.Show("Done");
            deleteInterview();
            Refresh();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox3.Text);

            hcc.DeleteCandidate(id);
            MessageBox.Show("Done");
            Refresh();
            Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox3.Text);

            hcc.DeleteInterview(id);
            MessageBox.Show("Done");
            Refresh();
            Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox3.Text);

            hcc.DeleteTraining(id);
            MessageBox.Show("Done");
            Refresh();
            Refresh();
        }
    }
}
