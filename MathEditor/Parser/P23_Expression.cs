

using MathEditor;




using System;
using System.Collections.Generic;
using System.Text;
using ParserUtilities;

namespace Parser
{
	class P23_Expression:  N_Expression
	{
		//production elements
				
		//runtime evaluation functions
		

		//recursive evaluation functions
		
		
		public override int OnParse(Stack<ParseElement> phraseStack,Environment env,NonTerminal baseNT )
		{
			N_Expression  Expression  = this;

						 Terminal  _0 = ( Terminal ) phraseStack.Pop();
			
			
	Expression.Value = new AlignStatement();


			
			
			
			
			
			return 1;
		}


		public override int GetPopNum()
        {
            return 1;
        }
	}
}