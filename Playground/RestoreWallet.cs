using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Web;

namespace Playground
{
    class RestoreWallet
    {
        private string _url;
        public RestoreWallet(string URL)
        {
            _url = URL;
        }

        public void callAPI()
        {
            string tempURL1 = "http://localhost:38221/api/Node/status";
            string valueString = string.Empty;
            string payload = string.Empty;


            //"mnemonic": "string"
            //"password": "string"
            //"folderPath": "string"
            //"name": "string"
            //"network": "string"
            //"creationDate": "2018-07-03T09:11:49.324Z"
        

            try
            {
                WebRequest webRequest = WebRequest.Create(tempURL1);
                webRequest.Timeout = 5000;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }


        }
    }
}
