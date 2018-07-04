using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace NodeBot.Web
{
    public class NodeWeb : WebRequest
    {
        //private HttpWebRequest httpWebRequest;
        public string Payload { get; set; }
        public string Port { get; set; }
        public string Path { get; set; }
        public string Host { get; set; }

        public NodeWeb Request()
        {
            //string tempURL1 = "http://localhost:38221/api/Node/status";
            string url = $"http://{Host}:{Port}/{Path}";
            //string payload = string.Empty;
            //base.

            try
            {
                var httpWebRequest = (HttpWebRequest)Create(url);

                httpWebRequest.ContentType = "application/json";
                ////httpWebRequest.Accept = "application/json";
                httpWebRequest.Method = "POST";

                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    streamWriter.Write(Payload);
                }

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            return this;
        }
    }
}
