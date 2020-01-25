

using MathEditor;




using System;
using System.Collections.Generic;
using System.Text;
using ParserUtilities;

namespace Parser
{
	class P_Equations:  N_Equations
	{
		//production elements
				
		//runtime evaluation functions
		

		//recursive evaluation functions
		
		
		public override int OnParse(Stack<ParseElement> phraseStack,Environment env,NonTerminal baseNT )
		{
			N_Equations  Equations  = this;

						 N_Equation  Equation = ( N_Equation ) phraseStack.Pop();
						 N_Equations  Equations_1 = ( N_Equations ) phraseStack.Pop();
			
			
	Equations.StmtList = Equations_1.StmtList;
	Equations.StmtList.Add(Equation.Value);


			
			
			
			
			
			return 2;
		}


		public override int GetPopNum()
        {
            return 2;
        }
	}
}