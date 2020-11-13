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
    public partial class ViewDeduction : Form
    {
        public ViewDeduction()
        {
            InitializeComponent();
        }

        ReceptionistController rc = new ReceptionistController();
        private void ViewDeduction_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = rc.ViewAllDeduction();
        }
    }
}
