

using MathEditor;




using System;
using System.Collections.Generic;
using System.Text;
using ParserUtilities;

namespace Parser
{
	class P15_Expression:  N_Expression
	{
		//production elements
				
		//runtime evaluation functions
		

		//recursive evaluation functions
		
		
		public override int OnParse(Stack<ParseElement> phraseStack,Environment env,NonTerminal baseNT )
		{
			N_Expression  Expression  = this;

						 Terminal  _2 = ( Terminal ) phraseStack.Pop();
						 N_Expressions  Expressions = ( N_Expressions ) phraseStack.Pop();
						 Terminal  _1 = ( Terminal ) phraseStack.Pop();
						 Terminal  RootMathDirective = ( Terminal ) phraseStack.Pop();
						 Terminal  _0 = ( Terminal ) phraseStack.Pop();
			
			
	Root root = new Root();
	SequenceStatement statement = new SequenceStatement();
	statement.Statements=Expressions.Value;
	
	root.RootStatement = statement;
	Expression.Value = root;


			
			
			
			
			
			return 5;
		}


		public override int GetPopNum()
        {
            return 5;
        }
	}
}