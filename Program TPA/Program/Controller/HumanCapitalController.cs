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

        public Staff UpdateStaff(int StaffId, String Name, String position, String username, String password, int salary)
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



        public object ViewAllCandidate()
        {
            var data = (from candidate in db.Candidates
                        where candidate.DeleteCandidate == 0
                        select new
                        {
                            Id = candidate.CandidateId,
                            Name = candidate.CandidateName,
                            Position = candidate.CandidatePosition,

                        }).ToList();
            return data;
        }

        public Candidate AddCadidate(String Name, String position)
        {
            Candidate c = new Candidate()
            {
                CandidateName = Name,
                CandidatePosition = position,
               
            };
            db.Candidates.Add(c);
            db.SaveChanges();

            return c;
        }

        public Candidate DeleteCandidate(int id)
        {
            Candidate t = db.Candidates.Find(id);
            t.DeleteCandidate = 1;

            return t;
        }



        public object ViewAllInterview()
        {
            var data = (from interview in db.Interviews
                        where interview.DeleteInterview == 0
                        select new
                        {
                            Id = interview.InterviewId,
                            Name = interview.InterviewName,
                            Position = interview.InterviewPosition,

                        }).ToList();
            return data;
        }

        public Interview AddInterview(int id)
        {
            Candidate t = db.Candidates.Find(id);

            Interview c = new Interview()
            {
                InterviewName = t.CandidateName,
                InterviewPosition = t.CandidatePosition,

            };
            db.Interviews.Add(c);
            db.SaveChanges();

            return c;
        }

        public Interview DeleteInterview(int id)
        {
            Interview t = db.Interviews.Find(id);
            t.DeleteInterview = 1;

            return t;
        }


        public object ViewAllTraining()
        {
            var data = (from training in db.Trainings
                        where training.DeleteTraining == 0
                        select new
                        {
                            Id = training.TrainingId,
                            Name = training.TrainingId,
                            Position = training.TrainingPosition,

                        }).ToList();
            return data;
        }

        public Training AddTraining(int id)
        {
            Interview t = db.Interviews.Find(id);

            Training c = new Training()
            {
                TrainingName = t.InterviewName,
                TrainingPosition = t.InterviewPosition,

            };
            db.Trainings.Add(c);
            db.SaveChanges();

            return c;
        }

        public Training DeleteTraining(int id)
        {
            Training t = db.Trainings.Find(id);
            t.DeleteTraining = 1;

            return t;
        }

    }
}
