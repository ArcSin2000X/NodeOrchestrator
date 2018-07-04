using System;
using System.Collections.Generic;
using System.Text;
using NodeBot.API.Calls;

namespace NodeBotPlayground.Test
{
    static class TestWalletRestore
    {
        public static void RunTest()
        {
            RestoreWallet rw = new RestoreWallet("a");
            rw.CallAPI();
        }

    }
}
