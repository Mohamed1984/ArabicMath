

using MathEditor;




using System;
using System.Collections.Generic;
using System.Text;
using ParserUtilities;

namespace Parser
{
	class P5_Expressions:  N_Expressions
	{
		//production elements
				
		//runtime evaluation functions
		

		//recursive evaluation functions
		
		
		public override int OnParse(Stack<ParseElement> phraseStack,Environment env,NonTerminal baseNT )
		{
			N_Expressions  Expressions  = this;

						 N_Expression  Expression = ( N_Expression ) phraseStack.Pop();
						 N_Expressions  Expressions_1 = ( N_Expressions ) phraseStack.Pop();
			
			
	Expressions.Value = Expressions_1.Value;
    Expressions.Value.Add(Expression.Value);


			
			
			
			
			
			return 2;
		}


		public override int GetPopNum()
        {
            return 2;
        }
	}
}