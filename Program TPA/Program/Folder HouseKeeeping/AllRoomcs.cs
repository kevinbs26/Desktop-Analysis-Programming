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
    public partial class AllRoomcs : Form
    {
        public AllRoomcs()
        {
            InitializeComponent();
        }

        HouseKeepingController hkc = new HouseKeepingController();
        public void Refresh()
        {
            dataGridView1.DataSource = hkc.ViewAllReservation();
        }

        private void AllRoomcs_Load(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}
