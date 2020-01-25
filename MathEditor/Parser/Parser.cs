
using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.IO;
using ParserUtilities;
using AttributeVertex = ParserUtilities.WeightedVertex<Parser.NonTerminal.EvaluateAttribute>;



namespace Parser
{
    class Parser
    {
        public Parser(TextReader code,Environment environ)
        {
			env = environ;
            sa = new SyntaxAnalyzer(code,environ);
        }
        public void Parse()
        {
            N_Goal sret = sa.AnalyzeSyntax();
            if (env.ErrorFlag)
                throw new ErrorException("Errors Occured during syntax analysis");
			
			
			
		}
        protected Environment env = null;
        protected SyntaxAnalyzer sa;
    }
    public class ErrorException : Exception
    {
        public ErrorException(string errDesc)
            :
            base(errDesc)
        {
        }
    }



	}

