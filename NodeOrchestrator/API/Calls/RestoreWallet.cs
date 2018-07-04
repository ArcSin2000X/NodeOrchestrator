using System;
using System.IO;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;
using NodeBot.API.Abstraction;

namespace NodeBot.API.Calls
{
    public class RestoreWallet
    {
        private string _url;
        private static readonly HttpClient client = new HttpClient();
        public RestoreWallet(string URL)
        {
            _url = URL;
        }

        public void CallAPI()
        {
            string tempURL1 = "http://localhost:38221/api/Node/status";
            string tempURL2 = "http://localhost:38221/api/Wallet/recover";

            Wallet wallet = new Wallet
            {
                Mnemonic = "woman assume obscure neglect today real blue print wrap follow salad shadow",
                Password = "password",
                FolderPath = "",
                Name = "test2",
                Network = "StratisTest",
                CreationDate = new DateTime(2018,7,4,0,0,0,DateTimeKind.Utc)
            };

            string payload = JsonConvert.SerializeObject(wallet, Formatting.None);
            //string payload = string.Empty;
            Console.WriteLine(payload);

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

            Console.WriteLine("end");

        }
    }
}
