namespace MathEditor
{
    using System;
    using System.Runtime.CompilerServices;

    public abstract class Script : Statement
    {
        protected Script()
        {
        }

        public Statement BaseStatement { get; set; }
    }
}

