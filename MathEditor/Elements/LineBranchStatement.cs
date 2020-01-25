namespace MathEditor
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Windows.Media;

    public class LineBranchStatement : Statement
    {
        public LineBranchStatement()
        {
            this.Statements = new List<Statement>();
        }

        public override Geometry DrawContent(Parser.Environment mathEnv)
        {
            var list = new List<Geometry>();
            double negativeInfinity = double.NegativeInfinity;
            foreach (Statement statement in this.Statements)
            {
                if (statement.Type != StatementTypes.Align)
                {
                    var item = statement.DrawContent(mathEnv);
                    list.Add(item);
                    if (item.Bounds.Height > negativeInfinity)
                    {
                        negativeInfinity = item.Bounds.Height;
                    }
                }
            }
            double offsetX = 0.0;
            for (int i = 0; i < this.Statements.Count; i++)
            {
                Statement stmt = this.Statements[i];
                if (stmt.Type != StatementTypes.Align)
                {
                    var group2 = list[i];
                    double height = group2.Bounds.Height;
                    ScaleTransform transform = new ScaleTransform(1.0, negativeInfinity / height);
                    group2.Transform = CombineTransforms(group2.Transform,transform);
                    double offsetY = -(group2.Bounds.Top + group2.Bounds.Bottom) / 2.0;
                    TranslateTransform transform2 = new TranslateTransform(offsetX, offsetY);
                    var group3 = CombineTransforms(group2.Transform, transform2);
                    
                    
                    group2.Transform = group3;
                    offsetX -= group2.Bounds.Width;
                    offsetX -= mathEnv.Style.Padding;
                }
            }
            var totalGeom = new PathGeometry();
            foreach (var g in list)
            {
                totalGeom.AddGeometry(g);
            }
            return totalGeom;
        }

        public List<Statement> Statements { get; set; }
    }
}

