using System;
using System.Runtime.CompilerServices;

namespace Parser
{
    public class Terminal : ParseElement
    {
        public int FileOffset { get; set; }

        public char[] LexVal { get; set; }

        public TOKENS TokenType { get; set; }
    }
}

