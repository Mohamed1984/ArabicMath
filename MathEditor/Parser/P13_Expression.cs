

using MathEditor;




using System;
using System.Collections.Generic;
using System.Text;
using ParserUtilities;

namespace Parser
{
	class P13_Expression:  N_Expression
	{
		//production elements
				
		//runtime evaluation functions
		

		//recursive evaluation functions
		
		
		public override int OnParse(Stack<ParseElement> phraseStack,Environment env,NonTerminal baseNT )
		{
			N_Expression  Expression  = this;

						 Terminal  _1 = ( Terminal ) phraseStack.Pop();
						 N_Expressions  Expressions = ( N_Expressions ) phraseStack.Pop();
						 Terminal  _0 = ( Terminal ) phraseStack.Pop();
			
			
	SequenceStatement stmt=new SequenceStatement();
	
	stmt.Statements=Expressions.Value;

	Expression.Value=stmt;


			
			
			
			
			
			return 3;
		}


		public override int GetPopNum()
        {
            return 3;
        }
	}
}