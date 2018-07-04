using System;
using System.Collections.Generic;
using System.Text;

namespace NodeBot.API.Abstraction
{
    public class Wallet
    {
        public WalletData Create { get; } = new WalletData();

        public Wallet Mnemonic(string mnemonic)
        {
            Create.Mnemonic = mnemonic;
            return this;
        }

        public Wallet Password(string password)
        {
            Create.Password = password;
            return this;
        }

        public Wallet FolderPath(string folderPath)
        {
            Create.FolderPath = folderPath;
            return this;
        }

        public Wallet Name(string name)
        {
            Create.Name = name;
            return this;
        }

        public Wallet Network(string network)
        {
            Create.Network = network;
            return this;
        }

        public Wallet CreationDate(DateTime creationDate)
        {
            Create.CreationDate = creationDate;
            return this;
        }
    }
}
