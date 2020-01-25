using System;

namespace Parser
{
    public abstract class EnvironmentBase
    {
        protected EnvironmentBase()
        {
        }

        public abstract bool ErrorFlag { get; set; }
    }
}

