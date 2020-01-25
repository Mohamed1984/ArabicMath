

using MathEditor;




using System;
using System.Collections.Generic;
using System.Text;
using ParserUtilities;

namespace Parser
{
	class P_Expressions:  N_Expressions
	{
		//production elements
				
		//runtime evaluation functions
		

		//recursive evaluation functions
		
		
		public override int OnParse(Stack<ParseElement> phraseStack,Environment env,NonTerminal baseNT )
		{
			N_Expressions  Expressions  = this;

						 N_Expressions  Expressions_2 = ( N_Expressions ) phraseStack.Pop();
						 Terminal  _0 = ( Terminal ) phraseStack.Pop();
						 N_Expressions  Expressions_1 = ( N_Expressions ) phraseStack.Pop();
			
			
	TextStatement item = new TextStatement {
		Text = "+"
	};
	Expressions_1.Value.Add(item);
	foreach (Statement s in Expressions_2.Value)
	{
		Expressions_1.Value.Add(s);
	}
	Expressions.Value = Expressions_1.Value;
	


			
			
			
			
			
			return 3;
		}


		public override int GetPopNum()
        {
            return 3;
        }
	}
}