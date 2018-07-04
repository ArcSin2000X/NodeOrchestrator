using System;
using System.Collections.Generic;
using System.Text;
using NodeBot.API.Abstraction;
using NodeBot.API.Calls;
using NodeBot.Utils;
using NodeBot.Web;

namespace NodeBotPlayground.Test
{
    static class TestWalletRestore
    {
        public static void RunTest()
        {
            WalletData wallet = new Wallet()
                .CreationDate(new DateTime(2018, 7, 4, 0, 0, 0, DateTimeKind.Utc))
                .FolderPath("")
                .Mnemonic("woman assume obscure neglect today real blue print wrap follow salad shadow")
                .Name("test2")
                .Network("StratisTest")
                .Password("password")
                .Create;

            NodeWeb nodeWeb = new NodeWeb();
            nodeWeb.Payload = FormatConvert.ObjToJSON(wallet);
            nodeWeb.Port = "38221";
            nodeWeb.Path = "api/Wallet/recover";
            nodeWeb.Host = "localhost";
            nodeWeb.Request();

        }

    }
}
