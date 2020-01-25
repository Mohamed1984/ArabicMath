


using MathEditor;



using System;
using System.Collections.Generic;
using System.Text;
using ParserUtilities;
//using AttributeVertex = Utilities.WeightedVertex<Parser.SyntaxAnalyzer.EvaluateAttribute>;

namespace Parser
{
    public abstract class NonTerminal : ParseElement
    {
        //this property will be implemented in each nonterminal class
        abstract public NonTerminalTypes NonTerminalType
        {
            get;
        }
        public override ELEMENT_TYPE Type
        {
            get
            {
                return ELEMENT_TYPE.NONTERMINAL;
            }
        }
        //declare nonterminal attributes here

        //fill nonterminal structure and do after detection processing
        //returns number of items to pop from stack
        public virtual int OnParse(Stack<ParseElement> phraseStack, Environment env, NonTerminal baseNT  )
		{
            return 0; 
        }

		
        public virtual int GetPopNum()
        {
            return 0;
        }
        //define virtual functions here that will evaluate the synthesized attributes

        public delegate void EvaluateAttribute(Environment env); 

        //define delegate vetex variables here that will carry references to evaluators of 
        //synthesized & inherited attributes they are in the form WeightedVertex<delegate type>
    }
    public enum NonTerminalTypes
    {
	 N_Equation,
	 N_Equations,
	 N_Expression,
	 N_Expressions,
	 N_Goal,
	 N_MathTextContent,
		}
}