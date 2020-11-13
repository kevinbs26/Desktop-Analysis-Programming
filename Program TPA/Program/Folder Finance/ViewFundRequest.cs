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

namespace Program.Folder_Finance
{
    public partial class ViewFundRequest : Form
    {
        public ViewFundRequest()
        {
            InitializeComponent();
        }

        AccountingAndFinanceController afc = new AccountingAndFinanceController();

        public void Refresh()
        {
            dataGridView1.DataSource = afc.ViewAllFundRequest();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox1.Text);

            afc.ApprovalRequest(id);
            MessageBox.Show("done");
            Refresh();
        }

        private void ViewFundRequest_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox1.Text);

            afc.RejectApproval(id);
            MessageBox.Show("done");
            Refresh();
        }
    }
}
