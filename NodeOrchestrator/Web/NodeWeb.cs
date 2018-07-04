using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace NodeBot.Web
{
    public class NodeWeb
    {
        public void Request()
        {
            string tempURL1 = "http://localhost:38221/api/Node/status";
            string tempURL2 = "http://localhost:38221/api/Wallet/recover";
            string payload = string.Empty;

            try
            {
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(tempURL2);

                httpWebRequest.ContentType = "application/json";
                //httpWebRequest.Accept = "application/json";
                httpWebRequest.Method = "POST";

                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    streamWriter.Write(payload);
                }

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    //Console.WriteLine(result.ToString());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

        }
    }
}
