
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using API.Models;
using API.Repository;

namespace API.Controllers
{
    public class StudentController : ApiController
    {
        private static readonly SMSDBEntities context=new SMSDBEntities("data source=DELL3542ANSU;initial catalog=SMSDB;Trusted_Connection=True;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework");

        StudentRepo ostudent = new StudentRepo(context);

            [HttpGet]
        public HttpResponseMessage GetAllStudents()
        {
            var Getstudent = ostudent.GetAllStudents();
            return Request.CreateResponse(HttpStatusCode.OK, Getstudent);
        }
        [HttpGet]
        public HttpResponseMessage GetAllStudentEnrollments(string StudentId)
        {
            var Getstudent = ostudent.GetAllStudentEnrollments(StudentId);
            return Request.CreateResponse(HttpStatusCode.OK, Getstudent);
        }
        [HttpGet]
        public HttpResponseMessage GetAllStudentServices(string StudentId)
        {
            var Getstudent = ostudent.GetAllStudentServices(StudentId);
            return Request.CreateResponse(HttpStatusCode.OK, Getstudent);
        }

    }
}
