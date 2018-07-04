using System;
using System.Collections.Generic;
using System.Text;
using NodeBot.API.Abstraction;
using NodeBot.API.Calls;
using NodeBot.Utils;

namespace NodeBotPlayground.Test
{
    static class TestWalletRestore
    {
        public static void RunTest()
        {
            //RestoreWallet rw = new RestoreWallet("a");
            //rw.CallAPI();
            //WalletData wallet = new WalletData
            //{
            //    Mnemonic = "woman assume obscure neglect today real blue print wrap follow salad shadow",
            //    Password = "password",
            //    FolderPath = "",
            //    Name = "test2",
            //    Network = "StratisTest",
            //    CreationDate = new DateTime(2018, 7, 4, 0, 0, 0, DateTimeKind.Utc)
            //};

            WalletData wallet = new Wallet()
                .CreationDate(new DateTime(2018, 7, 4, 0, 0, 0, DateTimeKind.Utc))
                .FolderPath("")
                .Mnemonic("")
                .Name("")
                .Network("")
                .Password("")
                .Create;

            Console.WriteLine(FormatConvert.ObjToJSON(wallet));
            //Console.WriteLine("-");
            //Console.WriteLine(FormatConvert.ToQueryString(wallet));
        }

    }
}
