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
    public partial class ViewOrder : Form
    {
        public ViewOrder()
        {
            InitializeComponent();
        }

        RoomServiceController rs = new RoomServiceController();
        DiningRoomController drc = new DiningRoomController();

        private void ViewOrder_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = rs.ViewAllOrder();
            dataGridView2.DataSource = drc.ViewAllOrder();
        }
    }
}
