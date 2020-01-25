namespace MathEditor
{
    using System;
    using System.Globalization;
    using System.Runtime.CompilerServices;
    using System.Windows;
    using System.Windows.Media;

    public abstract class StringStatement : Statement
    {
        protected StringStatement()
        {
        }

        public override Geometry DrawContent(Parser.Environment mathEnv)
        {
            Typeface typeface = new Typeface(mathEnv.Style.FontFamily, mathEnv.Style.FontStyle, mathEnv.Style.FontWeight, mathEnv.Style.FontStretch);

            FormattedText formattedText = new FormattedText(Text,
                CultureInfo.GetCultureInfo("ar-sa"),
                FlowDirection.RightToLeft, typeface, mathEnv.Style.FontSize,
                new SolidColorBrush(mathEnv.Style.FontColor));

            var geom = formattedText.BuildGeometry(new Point(0.0, -formattedText.Baseline));


            return geom;

        }

        public string Text { get; set; }
    }
}

