using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using WebApplication1.Functions;
using System.Net.Http.Formatting;
using Core;
using System.Net.Http;

namespace WebApplication1.Controllers
{
    public class StudentController : Controller
    {
        
        public ActionResult Index()
        {
            List<Student> studentList = null;

            var result = CoreHttpClientMethods.GetData(new HttpClientRequestModel()
            {
                BaseUrl = WebConstants.MicroSvcApiEndPoint,
                MethodNameOrUrl = "Student/GetAllStudents"

            });
            if (result.IsSuccessStatusCode)
            {
                var readTask = result.Content.ReadAsAsync<List<Student>>();
                studentList = readTask.Result;
            }

            return View(studentList);
        }
    }
}