using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
namespace WebApplication1.Functions
{
    public static class WebConstants
    {
        public static string MicroSvcApiEndPoint { get { return WebConfigurationManager.AppSettings["MicroSvcApiEndPoint"]; } }
    }
}