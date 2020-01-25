using System;
using System.Windows;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Converters;
using System.Windows.Shapes;

namespace MathEditor
{
    public class Root : Statement
    {
        public Statement RootStatement
        {
            get;
            set;
        }
        public Statement Power
        {
            get;
            set;
        }
        public override Geometry DrawContent(Parser.Environment mathEnv)
        {
            if (this.Power != null)
            {
                var rootDrawing = this.RootStatement.DrawContent(mathEnv);
                var powerDrawing = this.Power.DrawContent(mathEnv);
                double rootHeight = rootDrawing.Bounds.Height + (double)mathEnv.Style.Padding;
                double rootTailWidth = rootHeight * 0.4;
                double rootTailHeight = rootHeight * 0.4;
                TranslateTransform rootTranslation = new TranslateTransform(-rootDrawing.Bounds.Right - mathEnv.Style.Padding - powerDrawing.Bounds.Width - mathEnv.Style.RootPowerMargin, 0.0);
                rootDrawing.Transform = rootTranslation;
                TranslateTransform powerTranslation = new TranslateTransform(-powerDrawing.Bounds.Right, -powerDrawing.Bounds.Bottom + rootDrawing.Bounds.Bottom - rootTailHeight - mathEnv.Style.RootPowerMargin);
                ScaleTransform powerScale = new ScaleTransform(mathEnv.Style.RootPowerScaling, mathEnv.Style.RootPowerScaling);
                
                powerDrawing.Transform =CombineTransforms(powerDrawing.Transform,powerScale,powerTranslation);


                PathGeometry rootLineGeometry = new PathGeometry();

                PathFigure rootFigure = new PathFigure();
                rootFigure.StartPoint = new Point((double)(-(double)mathEnv.Style.Padding) + rootDrawing.Bounds.Left, (double)(-(double)mathEnv.Style.Padding) + rootDrawing.Bounds.Top);
                rootFigure.Segments.Add(new LineSegment(new Point((double)mathEnv.Style.Padding + rootDrawing.Bounds.Right, (double)(-(double)mathEnv.Style.Padding) + rootDrawing.Bounds.Top), true));
                rootFigure.Segments.Add(new LineSegment(new Point((double)mathEnv.Style.Padding + rootDrawing.Bounds.Right + rootTailWidth / 2, (double)mathEnv.Style.Padding + rootDrawing.Bounds.Bottom), true));
                rootFigure.Segments.Add(new LineSegment(new Point((double)mathEnv.Style.Padding + rootDrawing.Bounds.Right + rootTailWidth, (double)mathEnv.Style.Padding + rootDrawing.Bounds.Bottom - rootTailHeight), true));
                rootFigure.IsFilled = false;
                rootLineGeometry.Figures.Add(rootFigure);

                var rootLines = rootLineGeometry.GetWidenedPathGeometry(new Pen(Brushes.Black, mathEnv.Style.LineWidth));
                

                var totalGeom = CombineGeometries(rootLines, powerDrawing, rootDrawing);

                //var str = totalGeom.ToString();

                return totalGeom; 
            }
            else
            {
                //double padding = mathEnv.Style.Padding;
                var rootDrawing = this.RootStatement.DrawContent(mathEnv);
                double rootHeight = rootDrawing.Bounds.Height + (double)mathEnv.Style.Padding;
                double rootTailWidth = rootHeight * 0.4;
                double rootTailHeight = rootHeight * 0.4;
                TranslateTransform rootTransform = new TranslateTransform(-rootDrawing.Bounds.Right - (double)mathEnv.Style.Padding, 0.0);
                rootDrawing.Transform = CombineTransforms(rootDrawing.Transform, rootTransform);
                PathGeometry rootLinesGeometry = new PathGeometry();
                PathFigure rootFigure = new PathFigure();
                rootFigure.StartPoint = new Point((double)(-(double)mathEnv.Style.Padding) + rootDrawing.Bounds.Left, (double)(-(double)mathEnv.Style.Padding) + rootDrawing.Bounds.Top);
                rootFigure.Segments.Add(new LineSegment(new Point((double)mathEnv.Style.Padding + rootDrawing.Bounds.Right, (double)(-(double)mathEnv.Style.Padding) + rootDrawing.Bounds.Top), true));
                rootFigure.Segments.Add(new LineSegment(new Point((double)mathEnv.Style.Padding + rootDrawing.Bounds.Right + rootTailWidth/2, (double)mathEnv.Style.Padding + rootDrawing.Bounds.Bottom), true));
                rootFigure.Segments.Add(new LineSegment(new Point((double)mathEnv.Style.Padding + rootDrawing.Bounds.Right + rootTailWidth, (double)mathEnv.Style.Padding + rootDrawing.Bounds.Bottom - rootTailHeight), true));
                rootFigure.IsFilled = false;
                
                rootLinesGeometry.Figures.Add(rootFigure);

                var rootLines = rootLinesGeometry.GetWidenedPathGeometry(new Pen(Brushes.Black, mathEnv.Style.LineWidth));


                //rootLinesGeometry.AddGeometry(rootDrawing);

                //var str1 = rootLinesGeometry.ToString();

                //GeometryDrawing rootLines = new GeometryDrawing(mathEnv.Style.FontColor, new Pen(mathEnv.Style.FontColor, (double)mathEnv.Style.LineWidth), rootLinesGeometry);
                var totalGeom = CombineGeometries(rootLines, rootDrawing);

                return totalGeom;


                //var rootLinesDrawing = new GeometryGroup();
                //rootLinesDrawing.Children.Add(rootLinesGeometry);

    //            return new GeometryGroup
    //            {
    //                Children = 
				//{
				//	rootLinesDrawing,
				//	rootDrawing
				//}
    //            };
            }


            /*
             if (this.Power != null)
            {
                DrawingGroup rootDrawing = this.RootStatement.DrawContent(mathEnv);
                DrawingGroup powerDrawing = this.Power.DrawContent(mathEnv);
                double rootHeight = rootDrawing.Bounds.Height + (double)mathEnv.Style.Padding;
                double rootTailWidth = rootHeight * 0.4;
                double rootTailHeight = rootHeight * 0.4;
                TranslateTransform rootTranslation = new TranslateTransform(-rootDrawing.Bounds.Right - (double)mathEnv.Style.Padding - powerDrawing.Bounds.Width - mathEnv.Style.RootPowerMargin, 0.0);
                rootDrawing.Transform = rootTranslation;
                TranslateTransform value = new TranslateTransform(-powerDrawing.Bounds.Right, -powerDrawing.Bounds.Bottom + rootDrawing.Bounds.Bottom - rootTailHeight - mathEnv.Style.RootPowerMargin);
                ScaleTransform value2 = new ScaleTransform(mathEnv.Style.RootPowerScaling, mathEnv.Style.RootPowerScaling);
                TransformGroup powerTransform = new TransformGroup();
                powerTransform.Children.Add(value);
                powerTransform.Children.Add(value2);
                if (powerDrawing.Transform != null)
                {
                    powerTransform.Children.Add(powerDrawing.Transform);
                }
                powerDrawing.Transform = powerTransform;
                PathGeometry rootLineGeometry = new PathGeometry();
                PathFigure rootFigure = new PathFigure();
                rootFigure.StartPoint = new Point((double)(-(double)mathEnv.Style.Padding) + rootDrawing.Bounds.Left, (double)(-(double)mathEnv.Style.Padding) + rootDrawing.Bounds.Top);
                rootFigure.Segments.Add(new LineSegment(new Point((double)mathEnv.Style.Padding + rootDrawing.Bounds.Right, (double)(-(double)mathEnv.Style.Padding) + rootDrawing.Bounds.Top), true));
                rootFigure.Segments.Add(new LineSegment(new Point((double)mathEnv.Style.Padding + rootDrawing.Bounds.Right, (double)mathEnv.Style.Padding + rootDrawing.Bounds.Bottom), true));
                rootFigure.Segments.Add(new LineSegment(new Point((double)mathEnv.Style.Padding + rootDrawing.Bounds.Right + rootTailWidth, (double)mathEnv.Style.Padding + rootDrawing.Bounds.Bottom - rootTailHeight), true));
                rootFigure.IsFilled = false;
                rootLineGeometry.Figures.Add(rootFigure);
                GeometryDrawing rootLines = new GeometryDrawing(mathEnv.Style.FillColor, new Pen(mathEnv.Style.LineColor, (double)mathEnv.Style.LineWidth), rootLineGeometry);
                DrawingGroup rootLineDrawing = new DrawingGroup();
                rootLineDrawing.Children.Add(rootLines);
                return new DrawingGroup
                {
                    Children = 
					{
						rootLineDrawing,
						powerDrawing,
						rootDrawing
					}
                };
            }
            else
            {

                DrawingGroup rootDrawing = this.RootStatement.DrawContent(mathEnv);
                double rootHeight = rootDrawing.Bounds.Height + (double)mathEnv.Style.Padding;
                double rootTailWidth = rootHeight * 0.4;
                double rootTailHeight = rootHeight * 0.4;
                TranslateTransform rootTransform = new TranslateTransform(-rootDrawing.Bounds.Right - (double)mathEnv.Style.Padding, 0.0);
                rootDrawing.Transform = rootTransform;
                PathGeometry rootLinesGeometry = new PathGeometry();
                PathFigure rootFigure = new PathFigure();
                rootFigure.StartPoint = new Point((double)(-(double)mathEnv.Style.Padding) + rootDrawing.Bounds.Left, (double)(-(double)mathEnv.Style.Padding) + rootDrawing.Bounds.Top);
                rootFigure.Segments.Add(new LineSegment(new Point((double)mathEnv.Style.Padding + rootDrawing.Bounds.Right, (double)(-(double)mathEnv.Style.Padding) + rootDrawing.Bounds.Top), true));
                rootFigure.Segments.Add(new LineSegment(new Point((double)mathEnv.Style.Padding + rootDrawing.Bounds.Right, (double)mathEnv.Style.Padding + rootDrawing.Bounds.Bottom), true));
                rootFigure.Segments.Add(new LineSegment(new Point((double)mathEnv.Style.Padding + rootDrawing.Bounds.Right + rootTailWidth, (double)mathEnv.Style.Padding + rootDrawing.Bounds.Bottom - rootTailHeight), true));
                rootFigure.IsFilled = false;
                rootLinesGeometry.Figures.Add(rootFigure);
                GeometryDrawing rootLines = new GeometryDrawing(mathEnv.Style.FillColor, new Pen(mathEnv.Style.LineColor, (double)mathEnv.Style.LineWidth), rootLinesGeometry);
                DrawingGroup rootLinesDrawing = new DrawingGroup();
                rootLinesDrawing.Children.Add(rootLines);
                return new DrawingGroup
                {
                    Children = 
				{
					rootLinesDrawing,
					rootDrawing
				}
                };
            }
            
             */
        }
    }
}
