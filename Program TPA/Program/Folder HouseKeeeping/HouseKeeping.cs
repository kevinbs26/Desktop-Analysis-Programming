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

        AllRoomcs al = new AllRoomcs();
        private void viewAllRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            al = new AllRoomcs();
            al.Show();
        }

        supply sp ;
        private void supplyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sp = new supply();
            sp.Show();
        }

        CheckMinibar cm;
        private void checkMinibarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cm = new CheckMinibar();
            cm.Show();
        }
    }
}
