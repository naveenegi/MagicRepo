using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using API.Abstract;
using API.Models;
namespace API.Repository
{
    public class StudentRepo: IStudentRepo
    {
        private readonly SMSDBEntities _context;

        public StudentRepo(SMSDBEntities context)
        {
            _context = context;
        }


        public List<Student> GetAllStudents()
        {
            return _context.Students.OrderByDescending(x => x.DistrictId).ToList();

        }

        public List<Enrollment> GetAllStudentEnrollments(string StudentId)
        {
            return _context.Enrollments.Where(x=>x.StudentId== StudentId).OrderByDescending(x => x.SchoolYear).ToList();
        }
        public List<Service> GetAllStudentServices(string StudentId)
        {
            return _context.Services.Where(x => x.StudentId == StudentId).OrderByDescending(x => x.SchoolYear).ToList();
        }
    }
}