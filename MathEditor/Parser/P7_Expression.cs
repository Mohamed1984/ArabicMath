

using MathEditor;




using System;
using System.Collections.Generic;
using System.Text;
using ParserUtilities;

namespace Parser
{
	class P7_Expression:  N_Expression
	{
		//production elements
				
		//runtime evaluation functions
		

		//recursive evaluation functions
		
		
		public override int OnParse(Stack<ParseElement> phraseStack,Environment env,NonTerminal baseNT )
		{
			N_Expression  Expression  = this;

						 N_Expression  Expression_2 = ( N_Expression ) phraseStack.Pop();
						 Terminal  _0 = ( Terminal ) phraseStack.Pop();
						 N_Expression  Expression_1 = ( N_Expression ) phraseStack.Pop();
			
			
	RightSubScript script = new RightSubScript {
		BaseStatement = Expression_1.Value,
		SubStatement = Expression_2.Value
	};
	Expression.Value = script;


			
			
			
			
			
			return 3;
		}


		public override int GetPopNum()
        {
            return 3;
        }
	}
}