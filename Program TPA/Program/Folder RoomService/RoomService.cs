using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program.Folder_RoomService
{
    public partial class RoomService : Form
    {
        public RoomService()
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

        AddOrder ao;
        private void addOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ao = new AddOrder();
            ao.Show();
        }
    }
}
