using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Media;
namespace MathEditor
{
    public class SequenceStatement : Statement
    {
        //public delegate void f1();
        private double[] aligns = new double[0];
        public List<Statement> Statements
        {
            get;
            set;
        }
        public SequenceStatement()
        {
            this.Statements = new List<Statement>();
        }
        public override Geometry DrawContent(Parser.Environment mathEnv)
        {
            
            //Put statements side by side
            double alignOffset = 0.0;
            int alignIndex = 0;
            var drawings = new List<Geometry>();
            for (int i = 0; i < this.Statements.Count; i++)
            {
                Statement statement = this.Statements[i];
                if (statement.Type == StatementTypes.Align)
                {
                    alignOffset = this.aligns[alignIndex];
                    alignIndex++;
                }
                else
                {
                    var drawing = this.Statements[i].DrawContent(mathEnv);
                    drawings.Add(drawing);
                    TranslateTransform drawingTransform = new TranslateTransform(alignOffset-drawing.Bounds.Right, 0.0);
                    drawing.Transform =CombineTransforms(drawing.Transform, drawingTransform);
                    alignOffset -= drawing.Bounds.Width;

                    //double statementPadding = mathEnv.Style.Padding;

                    alignOffset -= mathEnv.Style.GetSpaceWidth();//statementPadding;
                }
            }
            var totalDrawing = new PathGeometry();
            foreach (var drawing in drawings)
            {
                totalDrawing.AddGeometry(drawing);
                //totalDrawing.Children.Add(drawing);
            }
            return totalDrawing;
        }
        public double[] GetAlignments(Parser.Environment mathEnv)
        {
            List<double> alignments = new List<double>();
            double num = 0.0;
            new List<DrawingGroup>();
            for (int i = 0; i < this.Statements.Count; i++)
            {
                Statement statement = this.Statements[i];
                if (statement.Type == StatementTypes.Align)
                {
                    num -= mathEnv.Style.AlignPadding;
                    alignments.Add(num);
                }
                else
                {
                    var drawingGroup = this.Statements[i].DrawContent(mathEnv);
                    num -= drawingGroup.Bounds.Width;
                    num -= (double)mathEnv.Style.Padding;
                }
            }
            return alignments.ToArray();
        }
        public void AdjustAlignments(double[] alignsOffsets)
        {
            this.aligns = alignsOffsets;
        }
    }
}
