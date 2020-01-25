namespace MathEditor
{
    using System;
    using System.Globalization;
    using System.Windows;
    using System.Windows.Media;

    public class ClosedIntegralStatement :MirrorStatement
    {
        public override Geometry DrawContent(Parser.Environment mathEnv)
        {
            char ch = '∮';
            Text = "" + ch;
            var g= base.DrawContent(mathEnv);

            g.Transform = CombineTransforms(g.Transform,
                new ScaleTransform(1.5, 1.5));

            return g;


            //FormattedText formattedText = new FormattedText(""+ch, CultureInfo.GetCultureInfo("ar-sa"), FlowDirection.RightToLeft, new Typeface(mathEnv.Style.FontFamily, mathEnv.Style.FontStyle, mathEnv.Style.FontWeight, mathEnv.Style.FontStretch), mathEnv.Style.FontSize * 1.5, mathEnv.Style.FontColor);
            
            
            //var group = formattedText.BuildGeometry(new Point(0.0, -formattedText.Baseline));//new DrawingGroup();
            ////DrawingContext context = group.Open();
            ////context.DrawText(formattedText, new Point(0.0,-formattedText.Baseline));
            ////context.Close();
            //TransformGroup group2 = new TransformGroup();
            //ScaleTransform transform = new ScaleTransform(-1.0, 1.0);
            //group.Transform = transform;
            //TranslateTransform transform2 = new TranslateTransform(-group.Bounds.Right, 0.0);
            //group2.Children.Add(transform);
            //group2.Children.Add(transform2);
            //group.Transform = group2;
            //return new GeometryGroup { Children = { group } };
        }
    }
}

