

using MathEditor;




using System;
using System.Collections.Generic;
using System.Text;
using ParserUtilities;

namespace Parser
{
	class P_Goal:  N_Goal
	{
		//production elements
				
		//runtime evaluation functions
		

		//recursive evaluation functions
		
		
		public override int OnParse(Stack<ParseElement> phraseStack,Environment env,NonTerminal baseNT )
		{
			N_Goal  Goal  = this;

						 N_Equations  Equations = ( N_Equations ) phraseStack.Pop();
			
			
	var stmts = new MultiLineStatement();
	stmts.Statements = Equations.StmtList;
	env.Equations=stmts;


			
			
			
			
			
			return 1;
		}


		public override int GetPopNum()
        {
            return 1;
        }
	}
}