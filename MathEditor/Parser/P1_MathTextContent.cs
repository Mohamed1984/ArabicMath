

using MathEditor;




using System;
using System.Collections.Generic;
using System.Text;
using ParserUtilities;

namespace Parser
{
	class P1_MathTextContent:  N_MathTextContent
	{
		//production elements
				
		//runtime evaluation functions
		

		//recursive evaluation functions
		
		
		public override int OnParse(Stack<ParseElement> phraseStack,Environment env,NonTerminal baseNT )
		{
			N_MathTextContent  MathTextContent  = this;

						 Terminal  QuotedText = ( Terminal ) phraseStack.Pop();
			
			
	MathTextContent.Value=new string(QuotedText.LexVal);


			
			
			
			
			
			return 1;
		}


		public override int GetPopNum()
        {
            return 1;
        }
	}
}