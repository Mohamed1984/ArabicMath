

using MathEditor;




using System;
using System.Collections.Generic;
using System.Text;
using ParserUtilities;

namespace Parser
{
	class P3_Expressions:  N_Expressions
	{
		//production elements
				
		//runtime evaluation functions
		

		//recursive evaluation functions
		
		
		public override int OnParse(Stack<ParseElement> phraseStack,Environment env,NonTerminal baseNT )
		{
			N_Expressions  Expressions  = this;

						 N_Expressions  Expressions_1 = ( N_Expressions ) phraseStack.Pop();
						 Terminal  _0 = ( Terminal ) phraseStack.Pop();
			
			
	TextStatement item = new TextStatement {
		Text = "-"
	};
	Expressions.Value = new List<Statement>();
	Expressions.Value.Add(item);
	foreach (Statement s in Expressions_1.Value)
	{
		Expressions.Value.Add(s);
	}


			
			
			
			
			
			return 2;
		}


		public override int GetPopNum()
        {
            return 2;
        }
	}
}