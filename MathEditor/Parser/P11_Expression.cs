

using MathEditor;




using System;
using System.Collections.Generic;
using System.Text;
using ParserUtilities;

namespace Parser
{
	class P11_Expression:  N_Expression
	{
		//production elements
				
		//runtime evaluation functions
		

		//recursive evaluation functions
		
		
		public override int OnParse(Stack<ParseElement> phraseStack,Environment env,NonTerminal baseNT )
		{
			N_Expression  Expression  = this;

						 Terminal  _2 = ( Terminal ) phraseStack.Pop();
						 N_MathTextContent  MathTextContent = ( N_MathTextContent ) phraseStack.Pop();
						 Terminal  _1 = ( Terminal ) phraseStack.Pop();
						 Terminal  MirrorMathDirective = ( Terminal ) phraseStack.Pop();
						 Terminal  _0 = ( Terminal ) phraseStack.Pop();
			
			
	MirrorStatement statement = new MirrorStatement {
		Text = MathTextContent.Value
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