

using MathEditor;




using System;
using System.Collections.Generic;
using System.Text;
using ParserUtilities;

namespace Parser
{
	class P_Equation:  N_Equation
	{
		//production elements
				
		//runtime evaluation functions
		

		//recursive evaluation functions
		
		
		public override int OnParse(Stack<ParseElement> phraseStack,Environment env,NonTerminal baseNT )
		{
			N_Equation  Equation  = this;

						 Terminal  _0 = ( Terminal ) phraseStack.Pop();
						 N_Expressions  Expressions = ( N_Expressions ) phraseStack.Pop();
			
			
	SequenceStatement statement = new SequenceStatement
	{
		Statements = Expressions.Value
	};
	Equation.Value = statement;


			
			
			
			
			
			return 2;
		}


		public override int GetPopNum()
        {
            return 2;
        }
	}
}