

using MathEditor;




using System;
using System.Collections.Generic;
using System.Text;
using ParserUtilities;

namespace Parser
{
	class P_MathTextContent:  N_MathTextContent
	{
		//production elements
				
		//runtime evaluation functions
		

		//recursive evaluation functions
		
		
		public override int OnParse(Stack<ParseElement> phraseStack,Environment env,NonTerminal baseNT )
		{
			N_MathTextContent  MathTextContent  = this;

						 Terminal  Word = ( Terminal ) phraseStack.Pop();
			
			
	string str = new string(Word.LexVal);
	str = str.Trim(new char[] { ' ', '\r', '\n' });
	MathTextContent.Value = str;


			
			
			
			
			
			return 1;
		}


		public override int GetPopNum()
        {
            return 1;
        }
	}
}