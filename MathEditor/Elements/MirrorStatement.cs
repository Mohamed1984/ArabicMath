namespace MathEditor
{
    using System.Globalization;
    using System.Windows;
    using System.Windows.Media;

    public class MirrorStatement : StringStatement
    {
        public override Geometry DrawContent(Parser.Environment mathEnv)
        {
            //FormattedText formattedText = new FormattedText(base.Text, CultureInfo.GetCultureInfo("ar-sa"), FlowDirection.RightToLeft, new Typeface(mathEnv.Style.FontFamily, mathEnv.Style.FontStyle, mathEnv.Style.FontWeight, mathEnv.Style.FontStretch), mathEnv.Style.FontSize, mathEnv.Style.FontColor);
            //var group = formattedText.BuildGeometry(new Point(0.0, -formattedText.Baseline));//new DrawingGroup();

            var g = base.DrawContent(mathEnv);

            g.Transform = CombineTransforms(g.Transform,
                new ScaleTransform(-1, 1));
            return g;
        }
    }
}

