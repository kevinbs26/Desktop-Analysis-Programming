using QRCoder;
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
    public partial class ViewTicket : Form
    {
        public ViewTicket()
        {
            InitializeComponent();
        }

        DiningRoomController drc = new DiningRoomController();

        private void button1_Click(object sender, EventArgs e)
        {
            QRCodeGenerator qr = new QRCodeGenerator();
            QRCodeData data = qr.CreateQrCode(textBox1.Text, QRCodeGenerator.ECCLevel.Q);
            QRCode code = new QRCode(data);
            pictureBox1.Image = code.GetGraphic(5);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox1.Text);
            String cek = drc.checkTicket(id);
            MessageBox.Show(cek);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox1.Text);
            String cek = drc.checkTicket(id);

            if (cek.Equals("ticket is not available"))
            {
                MessageBox.Show("Error");
            }
            else
            {
                drc.useTicket(id);
                MessageBox.Show("Done");
            }
        }
    }
}
