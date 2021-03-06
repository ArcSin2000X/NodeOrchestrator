﻿using System;

namespace NodeBot.API.Abstraction
{
    public class WalletData
    {
        public string Mnemonic{ get; set; }
        public string Password{ get; set; }
        public string FolderPath{ get; set; }
        public string Name{ get; set; }
        public string Network{ get; set; }
        public DateTime CreationDate{ get; set; }
    }
}