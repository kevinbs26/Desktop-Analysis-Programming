using Program.Folder_Receptionist;
using Program.House_Keeeping;
using Program.Folder_DiningRoom;
using Program.Folder_RoomService;
using Program.Folder_Kitchen;
using Program.Folder_Purchasing;
using Program.Folder_Finance;
using Program.Folder_Marketing;
using Program.Folder_Manager;
using Program.Folder_HumanCapital;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program
{
    public partial class Login : Form
    {
        DatabaseHotelEntities db = new DatabaseHotelEntities();

        public Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        Receptionist receptionist;
        HouseKeeping housekeeping;
        DiningRoom diningroom;
        RoomService roomservice;
        Kitchen kitchen;
        Purchasing purchasing;
        Finance finance;
        Marketing marketing;
        HumanCapital humancapital;
        Manager manager;
        private void button1_Click(object sender, EventArgs e)
        {
            var a = (from x in db.Staffs where x.Username == textBox1.Text && x.Password == textBox2.Text select x).FirstOrDefault();

            if (a != null && a.StaffPosition.Equals("Receptionist"))
            {
                receptionist = new Receptionist();
                receptionist.Show();
                this.Hide();
            }
            else if (a != null && a.StaffPosition.Equals("HouseKeeping"))
            {
                housekeeping = new HouseKeeping();
                housekeeping.Show();
                this.Hide();
            }
            else if (a != null && a.StaffPosition.Equals("DiningRoom"))
            {
                diningroom = new DiningRoom();
                diningroom.Show();
                this.Hide();
            }
            else if (a != null && a.StaffPosition.Equals("RoomService"))
            {
                roomservice = new RoomService();
                roomservice.Show();
                this.Hide();
            }
            else if (a != null && a.StaffPosition.Equals("Kitchen"))
            {
                kitchen = new Kitchen();
                kitchen.Show();
                this.Hide();
            }
            else if (a != null && a.StaffPosition.Equals("Purchasing"))
            {
                purchasing = new Purchasing();
                purchasing.Show();
                this.Hide();
            }
            else if (a != null && a.StaffPosition.Equals("Finance"))
            {
                finance = new Finance();
                finance.Show();
                this.Hide();
            }
            else if (a != null && a.StaffPosition.Equals("Marketing"))
            {
                marketing = new Marketing();
                marketing.Show();
                this.Hide();
            }
            else if (a != null && a.StaffPosition.Equals("HumanCapital"))
            {
                humancapital = new HumanCapital();
                humancapital.Show();
                this.Hide();
            }
            else if(a != null && a.StaffPosition.Equals("Manager"))
            {
                manager = new Manager();
                manager.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username and Password not valid");
            }
            
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
