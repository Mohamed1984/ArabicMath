namespace MathEditor
{
    using System;
    using System.Windows.Media;

    public class AlignStatement : Statement
    {
        public override Geometry DrawContent(Parser.Environment mathEnv)
        {
            throw new NotImplementedException();
        }

        public override StatementTypes Type
        {
            get
            {
                return StatementTypes.Align;
            }
        }
    }
}

