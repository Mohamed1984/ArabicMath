

using MathEditor;




using System;
using System.Collections.Generic;
using System.Text;
using ParserUtilities;

namespace Parser
{
	class P1_Equations:  N_Equations
	{
		//production elements
				
		//runtime evaluation functions
		

		//recursive evaluation functions
		
		
		public override int OnParse(Stack<ParseElement> phraseStack,Environment env,NonTerminal baseNT )
		{
			N_Equations  Equations  = this;

						 N_Equation  Equation = ( N_Equation ) phraseStack.Pop();
			
			
	Equations.StmtList=new List<SequenceStatement>();
	Equations.StmtList.Add(Equation.Value);


			
			
			
			
			
			return 1;
		}


		public override int GetPopNum()
        {
            return 1;
        }
	}
}