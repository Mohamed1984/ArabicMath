

using MathEditor;




using System;
using System.Collections.Generic;
using System.Text;
using ParserUtilities;

namespace Parser
{
	class P12_Expression:  N_Expression
	{
		//production elements
				
		//runtime evaluation functions
		

		//recursive evaluation functions
		
		
		public override int OnParse(Stack<ParseElement> phraseStack,Environment env,NonTerminal baseNT )
		{
			N_Expression  Expression  = this;

						 Terminal  _1 = ( Terminal ) phraseStack.Pop();
						 N_Expressions  Expressions = ( N_Expressions ) phraseStack.Pop();
						 Terminal  _0 = ( Terminal ) phraseStack.Pop();
			
			
	TextStatement txtStmt1=new TextStatement();
	txtStmt1.Text="(";
	TextStatement txtStmt2=new TextStatement();
	txtStmt2.Text=")";
	SequenceStatement stmt=new SequenceStatement();
	
	stmt.Statements.Add(txtStmt1);
	foreach (Statement s in Expressions.Value)
	{
		stmt.Statements.Add(s);
	}
	stmt.Statements.Add(txtStmt2);

	Expression.Value=stmt;



			
			
			
			
			
			return 3;
		}


		public override int GetPopNum()
        {
            return 3;
        }
	}
}