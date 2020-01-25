using System;
using System.Collections.Generic;
using System.Text;

namespace ParserUtilities
{
    public class Vertex : ICloneable
    {
        internal int number = int.MaxValue;

        public int Number
        {
            get { return number; }
            set { number = value; }
        }



        public virtual object Clone()
        {
            return new Vertex();
        }
        public override string ToString()
        {
            return "V" + number;
        }
    }
}