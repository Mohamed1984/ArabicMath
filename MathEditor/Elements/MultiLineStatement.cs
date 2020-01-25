namespace MathEditor
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Windows.Media;
    using System.Windows.Shapes;

    public class MultiLineStatement : Statement
    {
        public MultiLineStatement()
        {
            this.Statements = new List<SequenceStatement>();
        }

        public override Geometry DrawContent(Parser.Environment mathEnv)
        {
            List<double> list = new List<double>();
            foreach (SequenceStatement statement in this.Statements)
            {
                double[] alignments = statement.GetAlignments(mathEnv);
                int index = 0;
                for (index = 0; index < alignments.Length; index++)
                {
                    if (index < list.Count)
                    {
                        if (alignments[index] < list[index])
                        {
                            list[index] = alignments[index];
                        }
                    }
                    else
                    {
                        list.Add(alignments[index]);
                    }
                }
            }
            foreach (SequenceStatement statement2 in this.Statements)
            {
                statement2.AdjustAlignments(list.ToArray());
            }
            double lineVerticalOffset = 0.0;
            List<Geometry> linesGeom = new List<Geometry>();
            for (int i = 0; i < this.Statements.Count; i++)
            {
                var line = this.Statements[i].DrawContent(mathEnv);
                linesGeom.Add(line);
                
                TranslateTransform transform = new TranslateTransform(-line.Bounds.Right, lineVerticalOffset);// - line.Bounds.Top);
                line.Transform = CombineTransforms(line.Transform,transform);
                lineVerticalOffset += line.Bounds.Height;
                lineVerticalOffset += mathEnv.Style.Padding;
            }
            var totalGeom = new PathGeometry();
            foreach (var group3 in linesGeom)
            {
                totalGeom.AddGeometry(group3);
            }
            return totalGeom;
        }

        public List<SequenceStatement> Statements { get; set; }

        public override StatementTypes Type
        {
            get
            {
                return StatementTypes.MultiLine;
            }
        }
    }
}

