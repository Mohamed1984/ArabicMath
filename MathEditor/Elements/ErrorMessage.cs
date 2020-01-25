namespace MathEditor
{
    using System;
    using System.Runtime.CompilerServices;

    public class ErrorMessage
    {
        public ErrorMessage()
        {
        }

        public ErrorMessage(int lineNumber, string message)
        {
            this.LineNumber = lineNumber;
            this.Message = message;
        }

        public int LineNumber { get; set; }

        public string Message { get; set; }
    }
}

