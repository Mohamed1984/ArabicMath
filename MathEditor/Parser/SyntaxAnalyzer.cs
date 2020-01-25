

using MathEditor;



using System;
using System.Collections.Generic;
using System.Text;
using ParserUtilities;
using System.Diagnostics;
using System.IO;
using AttributeVertex = ParserUtilities.WeightedVertex<Parser.NonTerminal.EvaluateAttribute>;


namespace Parser
{
    public class SyntaxAnalyzer
    {
        public SyntaxAnalyzer(TextReader code, Environment environ)
        {
            env = environ;
            la = new LexicalAnalyzer(code, environ);
						                inlineTokenMap["_ERROR"] = TOKENS._ERROR;
                            inlineTokenMap["_EOF"] = TOKENS._EOF;
                            inlineTokenMap["Word"] = TOKENS.Word;
                            inlineTokenMap["QuotedText"] = TOKENS.QuotedText;
                            inlineTokenMap["Ws"] = TOKENS.Ws;
                            inlineTokenMap["NewLine"] = TOKENS.NewLine;
                            inlineTokenMap["IntegralMathDirective"] = TOKENS.IntegralMathDirective;
                            inlineTokenMap["DoubleIntegralMathDirective"] = TOKENS.DoubleIntegralMathDirective;
                            inlineTokenMap["TripleIntegralMathDirective"] = TOKENS.TripleIntegralMathDirective;
                            inlineTokenMap["ClosedIntegralMathDirective"] = TOKENS.ClosedIntegralMathDirective;
                            inlineTokenMap["LineBarnchMathDirective"] = TOKENS.LineBarnchMathDirective;
                            inlineTokenMap["MultiLineMathDirective"] = TOKENS.MultiLineMathDirective;
                            inlineTokenMap["MirrorMathDirective"] = TOKENS.MirrorMathDirective;
                            inlineTokenMap["RootMathDirective"] = TOKENS.RootMathDirective;
                            inlineTokenMap["FactorialMathDirective"] = TOKENS.FactorialMathDirective;
                            inlineTokenMap["SumMathDirective"] = TOKENS.SumMathDirective;
                            inlineTokenMap["؛"] = TOKENS._0;
                            inlineTokenMap["_"] = TOKENS._1;
                            inlineTokenMap["^"] = TOKENS._2;
                            inlineTokenMap["__"] = TOKENS._3;
                            inlineTokenMap["^^"] = TOKENS._4;
                            inlineTokenMap["___"] = TOKENS._5;
                            inlineTokenMap["^^^"] = TOKENS._6;
                            inlineTokenMap["$"] = TOKENS._7;
                            inlineTokenMap["{"] = TOKENS._8;
                            inlineTokenMap["}"] = TOKENS._9;
                            inlineTokenMap["("] = TOKENS._10;
                            inlineTokenMap[")"] = TOKENS._11;
                            inlineTokenMap["\\"] = TOKENS._12;
                            inlineTokenMap["&"] = TOKENS._13;
                            inlineTokenMap["+"] = TOKENS._14;
                            inlineTokenMap["-"] = TOKENS._15;
                            inlineTokenMap["*"] = TOKENS._16;
                            inlineTokenMap["="] = TOKENS._17;
            		}
		
        public N_Goal AnalyzeSyntax()
        {
            actionTable = new ActionTable(this);
            stateStack.Push(0);
            tok = la.GetToken();
            bool errorRecoveryMode = false;
            int errorStackOffset = 0;
            while (true)
            {
                Action ac = actionTable.GetAction(stateStack.Peek(), tok.TokenType);
                switch (ac.ActionType)
                {
                    case ACTION_TYPE.Shift:
                        phraseStack.Push(tok);
                        ShiftAction sa = (ShiftAction)ac;
                        stateStack.Push(sa.ShiftState);
                        tok = la.GetToken();
                        if (errorRecoveryMode)
                            errorStackOffset++;
                        break;
                    case ACTION_TYPE.Accept:
                        return (N_Goal)phraseStack.Pop();

                    case ACTION_TYPE.Reduce:
                        ReduceAction ra = (ReduceAction)ac;
                        NonTerminal nt = ra.CreateNonTerminal();
                        int popnum;

                        if (env.ErrorFlag == false)
                            popnum = nt.OnParse(phraseStack, env, nt  );
                        else
                        {
                            popnum = nt.GetPopNum();
                            for (int i = 0; i < popnum; i++)
                                phraseStack.Pop();
                        }

                        for (int i = 0; i < popnum; i++)
                            stateStack.Pop();

                        int gotoState = gotoTable.Goto(stateStack.Peek(), nt.NonTerminalType);
                        phraseStack.Push(nt);
                        stateStack.Push(gotoState);
                        if (errorRecoveryMode)
                            errorStackOffset -= popnum - 1;
                        break;
                    case ACTION_TYPE.Error:
                        env.ErrorFlag = true;
                        if (errorRecoveryMode == false)
                        {
                            while (phraseStack.Count > 0)
                            {
                                int state = stateStack.Peek();
                                if (Array.BinarySearch<int>(syncList, state) > 0)
                                    break;

                                phraseStack.Pop();
                                stateStack.Pop();
                            }
                            errorRecoveryMode = true;
                            //push error keyword
                            tok.TokenType = TOKENS._ERROR;
                            errorStackOffset = -1;
                        }
                        else
                        {
                            for (int i = 0; i < errorStackOffset; i++)
                            {
                                stateStack.Pop();
                                phraseStack.Pop();
                            }
                            if (tok.TokenType == TOKENS._EOF && phraseStack.Count == 0)
                            {
                                throw new ErrorException("unexpected end of file");
                            }
                            if (tok.TokenType == TOKENS._EOF)
                            {
                                //remove error keyword and state
                                ParseElement errorTerm = phraseStack.Pop();
                                stateStack.Pop();
                                //remove all states until next synchronizing state or empty phrase stack
                                while (phraseStack.Count > 0)
                                {
                                    phraseStack.Pop();
                                    stateStack.Pop();
                                    int state = stateStack.Peek();
                                    if (Array.BinarySearch<int>(syncList, state) > 0)
                                        break;
                                }
                                tok = (Terminal)errorTerm;
                                errorStackOffset = -1;
                            }
                            else
                            {
                                tok = la.GetToken();
                                errorStackOffset = 0;
                            }
                        }
                        break;
                    case ACTION_TYPE.ErrorReduce:
                        //must be in error recovery state
                        Debug.Assert(errorRecoveryMode == true,
                            "illegal ErrorReduce", "Error reduction can occur only in error recovery mode");
                        errorRecoveryMode = false;
                        ErrorReduceAction erAction = (ErrorReduceAction)ac;
                        erAction.ErrRoutine();
                        break;
                    case ACTION_TYPE.ErrorPatternReduce:
                        if (errorRecoveryMode == false)
                        {
                            ErrorPatternReduceAction epr =
                                (ErrorPatternReduceAction)ac;



                            epr.ErrRoutine();
                        }
                        else
                            goto case ACTION_TYPE.Error;
                        break;
                }
            }
        }
        /*private string getTokenName(TOKENS tokenID)
        {
			int tokIndex=Array.BinarySearch(tokensIDs,tokenID);
			return tokensNames[tokIndex];
        }*/

        //put error routines here
		
		public void OnErrEquation_1 ()
        {
         
						N_Expressions Expressions = (N_Expressions) phraseStack.Pop(); 
			stateStack.Pop();
			            

			N_Equation Equation = new N_Equation ();

            int gotoState = gotoTable.Goto(stateStack.Peek(),NonTerminalTypes.N_Equation );

            env.ErrorFlag= true;


            
	this.env.ReportWarning(this.tok.LineNo, ERROR_TYPE.SYNTAX, "هل نسيت فصلة منقوطة فى نهاية النص الرياضى؟ ");
	SequenceStatement statement = new SequenceStatement {
		Statements = Expressions.Value
	};
	Equation.Value = statement;
	if (!this.env.FatalErrorFlag)
	{
		this.env.ErrorFlag = false;
	}



            phraseStack.Push(Equation );



            stateStack.Push(gotoState);

           
        }

		
		public void OnErrGoal_1 ()
        {
         
						Terminal Error = (Terminal) phraseStack.Pop(); 
			stateStack.Pop();
			            

			N_Goal Goal = new N_Goal ();

            int gotoState = gotoTable.Goto(stateStack.Peek(),NonTerminalTypes.N_Goal );

            env.ErrorFlag= true;


            
	this.env.ReportError(Error.LineNo, ERROR_TYPE.SYNTAX, "’" + new string(Error.LexVal) + "’ : كلمة غير متوقعة");
	this.env.FatalErrorFlag = true;



            phraseStack.Push(Goal );



            stateStack.Push(gotoState);

           
        }

		
		public void OnErrMathTextContent_2 ()
        {
         
						Terminal Word = (Terminal) phraseStack.Pop(); 
			stateStack.Pop();
						Terminal _0 = (Terminal) phraseStack.Pop(); 
			stateStack.Pop();
			            

			N_MathTextContent MathTextContent = new N_MathTextContent ();

            int gotoState = gotoTable.Goto(stateStack.Peek(),NonTerminalTypes.N_MathTextContent );

            env.ErrorFlag= true;


            
	this.env.ReportWarning(_0.LineNo, ERROR_TYPE.SYNTAX, "’" + new string(Word.LexVal) + "’ : يجب أن يكون موجها رياضيا");

	MathTextContent.Value = "$" + new string(Word.LexVal);
	if (!this.env.FatalErrorFlag)
	{
		this.env.ErrorFlag = false;
	}




            phraseStack.Push(MathTextContent );



            stateStack.Push(gotoState);

           
        }

		


				private LexicalAnalyzer la = null;
        private Terminal tok = null;
        private Stack<ParseElement> phraseStack = new Stack<ParseElement>();
        private Stack<int> stateStack = new Stack<int>();
        private ActionTable actionTable;
        private GotoTable gotoTable = new GotoTable();
        private const int ERROR_MAX = 40;
        private Environment env = null;

		private SortedDictionary<string, TOKENS> inlineTokenMap = new SortedDictionary<string, TOKENS>();
        
		//error states
        //must be sorted
		private int[] syncList = new int[]{
		 0,
        };
	}
}
