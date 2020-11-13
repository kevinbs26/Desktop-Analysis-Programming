using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program.Folder_HumanCapital
{
    public partial class HumanCapital : Form
    {
        public HumanCapital()
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

        Hire_Staff hs;
        private void hireStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hs = new Hire_Staff();
            hs.Show();
        }
    }
}
