namespace MathEditor
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.CompilerServices;
    using System.Windows.Media;
    using System.Windows.Media.Imaging;

    public class Interpreter
    {
        
        
        private List<ErrorMessage> errors = new List<ErrorMessage>();
        private List<ErrorMessage> infos = new List<ErrorMessage>();
        private List<ErrorMessage> warnings = new List<ErrorMessage>();

        public bool Interpret()
        {
            bool flag = true;
            StringReader code = new StringReader(this.SourceText);
            Parser.Environment environ = new Parser.Environment();

            environ.Style = Style;

            Parser.Parser parser = new Parser.Parser(code, environ);
            try
            {
                parser.Parse();

                Image = environ.CreateImage();
                this.errors = environ.Errors;
                this.warnings = environ.Warnings;
                this.infos = environ.Infos;

            }
            catch (Parser.ErrorException)
            {
                this.errors = environ.Errors;
                this.warnings = environ.Warnings;
                this.infos = environ.Infos;
                flag = false;
            }
            return flag;
        }

        public GeometryDrawing Image
        { set; get;
        }

        public List<ErrorMessage> Errors
        {
            get
            {
                return this.errors;
            }
        }

        public List<ErrorMessage> Infos
        {
            get
            {
                return this.infos;
            }
        }



        public string SourceText { get; set; }

        public List<ErrorMessage> Warnings
        {
            get
            {
                return this.warnings;
            }
        }

        public MathStyle Style{set; get;}
    }
}

