using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace Skyline.BeerViet.App
{
    public class HttpHelper
    {
        private string applicationKey;
        public string ApplicationKey
        {
            get { return applicationKey; }
            set { applicationKey = value; }
        }

        private string applicationSecret;
        public string ApplicationSecret
        {
            get { return applicationSecret; }
            set { applicationSecret = value; }
        }

        private string webRequestContentType = "application/json; charset=UTF-8";
        public string WebRequestContentType
        {
            get { return webRequestContentType; }
            set { webRequestContentType = value; }
        }

        private string webRequestAccept = "application/json";
        public string WebRequestAccept
        {
            get { return webRequestAccept; }
            set { webRequestAccept = value; }
        }

        private int webRequestTimeout = 3600000; //1 hour
        public int WebRequestTimeout
        {
            get { return webRequestTimeout; }
            set { webRequestTimeout = value; }
        }

        private Dictionary<string, string> customHeaders;
        public Dictionary<string, string> CustomHeaders
        {
            get { return customHeaders; }
            set { customHeaders = value; }
        }

        public string CallRestService(string url, string method, string args)
        {
            HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
            if (request == null) return string.Empty;

            request.Method = method;
            request.ContentType = webRequestContentType;
            request.Accept = webRequestAccept;
            request.PreAuthenticate = !String.IsNullOrEmpty(ApplicationKey);
            request.Timeout = WebRequestTimeout;
            request.ReadWriteTimeout = WebRequestTimeout;

            if (CustomHeaders != null)
            {
                foreach (KeyValuePair<string, string> header in CustomHeaders)
                {
                    request.Headers.Add(header.Key, header.Value);
                }
            }

            if (!String.IsNullOrEmpty(args))
            {
                byte[] postBytes = Encoding.UTF8.GetBytes(args);
                request.ContentLength = postBytes.Length;
                using (Stream postStream = request.GetRequestStream())
                {
                    postStream.Write(postBytes, 0, postBytes.Length);
                    postStream.Close();
                }
            }

            HttpWebResponse respone = request.GetResponse() as HttpWebResponse;
            if (respone == null) return string.Empty;

            string result = string.Empty;
            using (Stream responeStream = respone.GetResponseStream())
            {
                if (responeStream != null)
                {
                    using (StreamReader streamReader = new StreamReader(responeStream))
                    {
                        result = streamReader.ReadToEnd();
                    }
                }
            }

            respone.Close();
            respone = null;

            return result;
        }

        public string GETRestService(string url)
        {
            return CallRestService(url, "GET", string.Empty);
        }

        public string POSTRestService(string url, string args)
        {
            return CallRestService(url, "POST", args);
        }
    }

}
