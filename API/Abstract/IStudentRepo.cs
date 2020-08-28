using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using API.Models;

namespace API.Abstract
{
  public  interface IStudentRepo
    {
        List<Student> GetAllStudents();
        List<Enrollment> GetAllStudentEnrollments(string StudentId);
        List<Service> GetAllStudentServices(string StudentId);
    }
}
