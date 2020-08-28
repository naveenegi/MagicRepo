using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Core
{
 public static  class CoreHttpClientMethods
    {
        public static HttpResponseMessage GetData(HttpClientRequestModel oRequest, string QueryStringData = "")
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(oRequest.BaseUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(oRequest.ResponseDataType));
                if (!string.IsNullOrEmpty(QueryStringData))
                {
                    oRequest.MethodNameOrUrl = oRequest.MethodNameOrUrl + QueryStringData.ToString();
                }
                var response = client.GetAsync(oRequest.MethodNameOrUrl);
                response.Wait();
                return response.Result;
            }
        }
    }
}
