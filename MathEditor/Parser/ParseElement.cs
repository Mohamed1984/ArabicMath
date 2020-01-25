using System.Collections.Generic;
using System.Text;

namespace Parser
{
    public abstract class ParseElement
    {
        public virtual ELEMENT_TYPE Type
        {
            get
            {
                return ELEMENT_TYPE.TERMINAL;

            }
        }

		public int LineNo;
    }
    public enum ELEMENT_TYPE
    {
        TERMINAL, NONTERMINAL
    }
}