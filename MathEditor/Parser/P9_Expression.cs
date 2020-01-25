

using MathEditor;




using System;
using System.Collections.Generic;
using System.Text;
using ParserUtilities;

namespace Parser
{
	class P9_Expression:  N_Expression
	{
		//production elements
				
		//runtime evaluation functions
		

		//recursive evaluation functions
		
		
		public override int OnParse(Stack<ParseElement> phraseStack,Environment env,NonTerminal baseNT )
		{
			N_Expression  Expression  = this;

						 Terminal  _2 = ( Terminal ) phraseStack.Pop();
						 N_Expressions  Expressions = ( N_Expressions ) phraseStack.Pop();
						 Terminal  _1 = ( Terminal ) phraseStack.Pop();
						 Terminal  LineBarnchMathDirective = ( Terminal ) phraseStack.Pop();
						 Terminal  _0 = ( Terminal ) phraseStack.Pop();
			
			
	LineBranchStatement statement = new LineBranchStatement {
		Statements = Expressions.Value
	};
	Expression.Value = statement;



			
			
			
			
			
			return 5;
		}


		public override int GetPopNum()
        {
            return 5;
        }
	}
}