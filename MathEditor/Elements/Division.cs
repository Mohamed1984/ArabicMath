using System;
using System.Windows;
using System.Windows.Media;
namespace MathEditor
{
    public class Division : Statement
    {
        public Statement Numerator
        {
            get;
            set;
        }
        public Statement Denominator
        {
            get;
            set;
        }
        public override Geometry DrawContent(Parser.Environment mathEnv)
        {
            var numDrawing = this.Numerator.DrawContent(mathEnv);
            var denDrawing = this.Denominator.DrawContent(mathEnv);
            //TranslateTransform totalTransform = new TranslateTransform(0.0, (numDrawing.Bounds.Top + numDrawing.Bounds.Bottom) / 2.0);


            //TranslateTransform totalTransform = new TranslateTransform(0.0, -numDrawing.Bounds.Bottom - (double)((double)mathEnv.Style.Padding / 2));


            double numWidth = denDrawing.Bounds.Width + (double)mathEnv.Style.Padding;
            double denNumDiff = denDrawing.Bounds.Width - numDrawing.Bounds.Width;
            TranslateTransform numTransform;
            TranslateTransform denTransform;
            if (denDrawing.Bounds.Width > numDrawing.Bounds.Width)
            {
                
                numTransform = new TranslateTransform(-mathEnv.Style.Padding / 2 - denNumDiff / 2.0 - numDrawing.Bounds.Right, -mathEnv.Style.DivisionVerticalPadding - numDrawing.Bounds.Bottom);
                denTransform = new TranslateTransform(-(double)mathEnv.Style.Padding / 2 - denDrawing.Bounds.Right, mathEnv.Style.DivisionVerticalPadding - denDrawing.Bounds.Top);
            
            }
            else
            {
                numWidth = numDrawing.Bounds.Width + (double)mathEnv.Style.Padding;
                denNumDiff = -denNumDiff;
                numTransform = new TranslateTransform(-mathEnv.Style.Padding / 2 - numDrawing.Bounds.Right, -mathEnv.Style.DivisionVerticalPadding - numDrawing.Bounds.Bottom);
                denTransform = new TranslateTransform(-mathEnv.Style.Padding / 2 - denNumDiff / 2.0 - denDrawing.Bounds.Right, mathEnv.Style.DivisionVerticalPadding - denDrawing.Bounds.Top);
           
            
            }
            numDrawing.Transform = CombineTransforms(numDrawing.Transform,numTransform);
            denDrawing.Transform = CombineTransforms(denDrawing.Transform, denTransform);
            
            
            
            LineGeometry divGeometry = new LineGeometry(new Point(0.0, 0.0), new Point(-numWidth, 0.0));
            
            var g=divGeometry.GetWidenedPathGeometry(new Pen(Brushes.Black, mathEnv.Style.LineWidth));

            var totalDrawing = CombineGeometries(numDrawing, denDrawing, g);

            return totalDrawing;
            //totalDrawing.Children.Add(numDrawing);
            //totalDrawing.Children.Add(denDrawing);
            //totalDrawing.Children.Add(divDrawing);
            
            //totalDrawing.Transform = totalTransform;
            //return new GeometryGroup
            //{
             //   Children = 
			//	{
			//		totalDrawing
			//	}
            //};
        }
    }
}
