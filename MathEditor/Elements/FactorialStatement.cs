namespace MathEditor
{
    using System.Windows;
    using System.Windows.Media;

    public class FactorialStatement : Statement
    {
        public override Geometry DrawContent(Parser.Environment mathEnv)
        {
            var contentDrawing = this.Content.DrawContent(mathEnv);
            TranslateTransform contentTransform = new TranslateTransform(-contentDrawing.Bounds.Right - mathEnv.Style.Padding, 0.0);
            contentDrawing.Transform =CombineTransforms(contentDrawing.Transform, contentTransform);
           
        
            PathFigure factorialFigure = new PathFigure();
            Point[] points = new Point[] { new Point(0.0, contentDrawing.Bounds.Top - mathEnv.Style.Padding),
                new Point(0.0, contentDrawing.Bounds.Bottom + mathEnv.Style.Padding),
                new Point(-contentDrawing.Bounds.Width - (2 * mathEnv.Style.Padding), contentDrawing.Bounds.Bottom + mathEnv.Style.Padding) };

            factorialFigure.StartPoint = points[0];
            factorialFigure.Segments.Add(new LineSegment(points[1], true));
            factorialFigure.Segments.Add(new LineSegment(points[2], true));
            
            factorialFigure.IsFilled = false;
            var factorialLinesDrawing = new PathGeometry(new PathFigure[] { factorialFigure });

            var factorialLines = factorialLinesDrawing.GetWidenedPathGeometry(new Pen(Brushes.Black, mathEnv.Style.LineWidth));

            return CombineGeometries(contentDrawing, factorialLines);
        }

        public Statement Content { get; set; }
    }
}

