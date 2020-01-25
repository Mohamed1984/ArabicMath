

using MathEditor;




using System;
using System.Collections.Generic;
using System.Text;
using ParserUtilities;

namespace Parser
{
	class P6_Expressions:  N_Expressions
	{
		//production elements
				
		//runtime evaluation functions
		

		//recursive evaluation functions
		
		
		public override int OnParse(Stack<ParseElement> phraseStack,Environment env,NonTerminal baseNT )
		{
			N_Expressions  Expressions  = this;

						 N_Expression  Expression = ( N_Expression ) phraseStack.Pop();
			
			
	List<Statement> list = new List<Statement>();
	Expressions.Value = list;
	Expressions.Value.Add(Expression.Value);


			
			
			
			
			
			return 1;
		}


		public override int GetPopNum()
        {
            return 1;
        }
	}
}