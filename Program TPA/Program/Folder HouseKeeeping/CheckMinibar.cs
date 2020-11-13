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
    public partial class CheckMinibar : Form
    {
        public CheckMinibar()
        {
            InitializeComponent();
        }

        HouseKeepingController hkc = new HouseKeepingController();
        private void button1_Click(object sender, EventArgs e)
        {
            int Rid = int.Parse(textBox1.Text);
            int Sid = int.Parse(textBox2.Text);

            int quantity = int.Parse(textBox4.Text);
            int price = int.Parse(textBox5.Text);

            hkc.UpdateDeduction(Rid, quantity, Sid, price);
            MessageBox.Show("done");
        }
    }
}
