using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program.Folder_Kitchen
{
    public partial class Kitchen : Form
    {
        public Kitchen()
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

        CheckIngredient ci;
        private void checkIngredientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ci = new CheckIngredient();
            ci.Show();
        }

        ViewOrder vo;
        private void viewOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vo = new ViewOrder();
            vo.Show();
        }
    }
}
