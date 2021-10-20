using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace Skyline.BeerViet.App
{
    public class HttpHelper
    {

        public string CallRestService(string url, Method method, object args, string filePath = "")
        {
            try
            {
                var client = new RestClient(url);
                client.Timeout = -1;
                var restRequest = new RestRequest(method);

                if (args != null)
                {
                    restRequest.AddJsonBody(args);
                }

                if (!string.IsNullOrWhiteSpace(filePath))
                {
                    byte[] arrData = File.ReadAllBytes(filePath);
                    restRequest.AddFile("Files", arrData, Path.GetFileName(filePath));
                }


                IRestResponse response = client.Execute(restRequest);
                return response.Content;
            }
            catch (Exception ex)
            {
            }
            return "";
        }

        public string GETRestService(string url)
        {
            return CallRestService(url, Method.GET, string.Empty);
        }

        public string POSTRestService(string url, object args, string filePath = "")
        {
            return CallRestService(url, Method.POST, args, filePath);
        }
    }

}
