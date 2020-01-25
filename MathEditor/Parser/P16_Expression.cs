

using MathEditor;




using System;
using System.Collections.Generic;
using System.Text;
using ParserUtilities;

namespace Parser
{
	class P16_Expression:  N_Expression
	{
		//production elements
				
		//runtime evaluation functions
		

		//recursive evaluation functions
		
		
		public override int OnParse(Stack<ParseElement> phraseStack,Environment env,NonTerminal baseNT )
		{
			N_Expression  Expression  = this;

						 Terminal  _4 = ( Terminal ) phraseStack.Pop();
						 N_Expressions  Expressions_1 = ( N_Expressions ) phraseStack.Pop();
						 Terminal  _3 = ( Terminal ) phraseStack.Pop();
						 Terminal  _2 = ( Terminal ) phraseStack.Pop();
						 N_Expressions  Expressions = ( N_Expressions ) phraseStack.Pop();
						 Terminal  _1 = ( Terminal ) phraseStack.Pop();
						 Terminal  RootMathDirective = ( Terminal ) phraseStack.Pop();
						 Terminal  _0 = ( Terminal ) phraseStack.Pop();
			
			
	Root root = new Root();
	SequenceStatement power = new SequenceStatement{
		Statements = Expressions_1.Value
	};
	root.Power = power;
	SequenceStatement stmts = new SequenceStatement {
		Statements = Expressions_1.Value
	};
	root.RootStatement = stmts;
	Expression.Value = root;


			
			
			
			
			
			return 8;
		}


		public override int GetPopNum()
        {
            return 8;
        }
	}
}