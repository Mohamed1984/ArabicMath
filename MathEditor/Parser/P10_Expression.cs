

using MathEditor;




using System;
using System.Collections.Generic;
using System.Text;
using ParserUtilities;

namespace Parser
{
	class P10_Expression:  N_Expression
	{
		//production elements
				
		//runtime evaluation functions
		

		//recursive evaluation functions
		
		
		public override int OnParse(Stack<ParseElement> phraseStack,Environment env,NonTerminal baseNT )
		{
			N_Expression  Expression  = this;

						 Terminal  _2 = ( Terminal ) phraseStack.Pop();
						 N_Equations  Equations = ( N_Equations ) phraseStack.Pop();
						 Terminal  _1 = ( Terminal ) phraseStack.Pop();
						 Terminal  MultiLineMathDirective = ( Terminal ) phraseStack.Pop();
						 Terminal  _0 = ( Terminal ) phraseStack.Pop();
			
			
	MultiLineStatement statement = new MultiLineStatement {
		Statements = Equations.StmtList
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