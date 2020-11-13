using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Program.Folder_HouseKeeeping;

namespace Program.House_Keeeping
{
    public partial class HouseKeeping : Form
    {
        public HouseKeeping()
        {
            InitializeComponent();
        }

        Login login;
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login = new Login();
            login.Show();
            this.Dispose();
        }

        AllRoom ar;
        private void viewAllRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ar = new AllRoom();
            ar.Show();
        }

        CheckSupply ss;
        private void supplyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ss = new CheckSupply();
            ss.Show();
        }
    }
}
