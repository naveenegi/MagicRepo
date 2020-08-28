using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
   public class HttpClientRequestModel
    {
        public string BaseUrl { get; set; }
        public string MethodNameOrUrl { get; set; }
        public string ResponseDataType { get; set; } = "application/json";
        public string PostDataType { get; set; } = "application/json";
    }
}
