

using MathEditor;


using System;
using System.Collections.Generic;
using System.Text;
using ParserUtilities;

namespace Parser
{
	public class N_MathTextContent:NonTerminal 
    {
		//this property will be implemented in each nonterminal class
		public override NonTerminalTypes NonTerminalType
		{
			get{
			return NonTerminalTypes.N_MathTextContent;
			}
		}
	
		public override ELEMENT_TYPE Type
        {
            get
            {
                return ELEMENT_TYPE.NONTERMINAL;
            }
        }
        //declare nonterminal attributes here
        
		
		public string  Value ;
		
		
		
		
	}
}