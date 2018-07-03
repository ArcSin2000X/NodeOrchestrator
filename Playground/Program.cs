using System;

namespace Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            RestoreWallet rw = new RestoreWallet("a");
            rw.callAPI();

            Console.ReadKey();
        }



    }
}
