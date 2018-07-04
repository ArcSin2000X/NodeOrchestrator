using System;
using System.Collections.Generic;
using System.Text;

namespace NodeBot.API.Abstraction
{
    class Mnemonic
    {
        public MnemonicData Create { get; } = new MnemonicData();

        public Mnemonic Language(string language)
        {
            Create.Language = language;
            return this;
        }

        public Mnemonic WordCount(string wordCount)
        {
            Create.WordCount = wordCount;
            return this;
        }
    }
}
