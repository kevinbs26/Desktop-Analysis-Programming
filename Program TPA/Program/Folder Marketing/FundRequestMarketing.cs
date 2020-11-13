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

namespace Program.Folder_Marketing
{
    public partial class FundRequestMarketing : Form
    {
        public FundRequestMarketing()
        {
            InitializeComponent();
        }

        SalesAndMarketingController smc = new SalesAndMarketingController();

        public void Refresh()
        {
            dataGridView1.DataSource = smc.ViewAllMarketingRequest();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ammount = int.Parse(textBox1.Text);
            String reason = textBox2.Text;

            smc.addFundRequest(ammount, reason);
            MessageBox.Show("Done");
            Refresh();
        }

        private void FundRequestMarketing_Load(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}
