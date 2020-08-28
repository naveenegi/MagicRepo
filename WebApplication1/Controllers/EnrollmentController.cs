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
    public class EnrollmentController : Controller
    {
        // GET: Enrollment
        public ActionResult Index(string StudentId)
        {
            List<Enrollment> enrollmentList = null;

            var result = CoreHttpClientMethods.GetData(new HttpClientRequestModel()
            {
                BaseUrl = WebConstants.MicroSvcApiEndPoint,
                MethodNameOrUrl = "Student/GetAllStudentEnrollments?StudentId="+ StudentId

            });
            if (result.IsSuccessStatusCode)
            {
                var readTask = result.Content.ReadAsAsync<List<Enrollment>>();
                enrollmentList = readTask.Result;
            }

            return View(enrollmentList);
        }
    }
}