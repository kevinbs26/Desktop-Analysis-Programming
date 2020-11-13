using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.Controller
{
    class HumanCapitalController
    {
        DatabaseHotelEntities db = new DatabaseHotelEntities();

        public Staff AddStaff(String Name, String position, String username, String password, int salary)
        {
            Staff staff = new Staff()
            {
                StaffName = Name,
                StaffPosition = position,
                Username = username,
                Password = password,
                StaffSalary = salary,
            };
            db.Staffs.Add(staff);
            db.SaveChanges();

            return staff;
        }

        public Staff UpdateStaff(int StaffId,String Name, String position, String username, String password, int salary)
        {
            Staff staff = db.Staffs.Find(StaffId);

            staff.StaffName = Name;
            staff.StaffPosition = position;
            staff.Username = username;
            staff.Password = password;
            staff.StaffSalary = salary;
          
            db.Staffs.Add(staff);
            db.SaveChanges();

            return staff;
        }

        public Staff DeleteStaff(int StaffId)
        {
            Staff staff = db.Staffs.Find(StaffId);
            staff.DeleteStaff = 1;

            return staff;
        }

        public object ViewAllStaff()
        {
            var data = (from staff in db.Staffs
                        where staff.DeleteStaff == 0
                        select new
                        {
                            StaffId = staff.StaffId,
                            StaffName = staff.StaffName,
                            StaffPosition = staff.StaffPosition,
                            staffSalary = staff.StaffSalary,
                            Username = staff.Username,
                            Password = staff.Password,

                        }).ToList();
            return data;
        }
    }
}
