using System;
namespace MathEditor
{
    public abstract class DoubleScript : Script
    {
        public Statement SubStatement
        {
            get;
            set;
        }
        public Statement SuperStatement
        {
            get;
            set;
        }
    }
}
