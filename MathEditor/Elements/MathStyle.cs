using System;
using System.Globalization;
using System.Windows;
using System.Windows.Media;
namespace MathEditor
{
    public class MathStyle : FormatStyle
    {
        public double Padding
        {
            get
            {
                return GetSpaceWidth();
            }
        }
        public double VerticalPadding
        {
            get
            {
                return GetSpaceWidth();
            }
        }

        public double LineWidth
        {
            get
            {
                return FontSize * 0.06;
            }
            
        }

        public Color BackgroundColor { set; get; }
        
        public double SubscriptXScaling
        {
            get;
            set;
        }
        public double SuperscriptXScaling
        {
            get;
            set;
        }
        public double SubscriptYScaling
        {
            get;
            set;
        }
        public double SuperscriptYScaling
        {
            get;
            set;
        }
        public double ScriptXPadding
        {
            get;
            set;
        }
        public double ScriptYPadding
        {
            get;
            set;
        }
        public double DivisionVerticalPadding
        {
            get;
            set;
        }
        public double RootPowerScaling
        {
            get;
            set;
        }
        public double RootPowerMargin
        {
            get;
            set;
        }
        
        public double DownScriptYPadding
        {
            get;
            set;
        }
        public double OverScriptYPadding
        {
            get;
            set;
        }
        public double AlignPadding
        {
            get;
            set;
        }
        public MathStyle()
        {
            //this.Padding = 10;
            //this.VerticalPadding = 10.0;
            //this.LineWidth = 1;
            this.BackgroundColor = Colors.White;
            //this.LineColor = Brushes.Black;
            //this.FillColor = Brushes.Black;
            this.SubscriptXScaling = 0.6;
            this.SubscriptYScaling = 0.6;
            this.SuperscriptXScaling = 0.6;
            this.SuperscriptYScaling = 0.6;
            this.ScriptXPadding = 2.0;
            this.ScriptYPadding = 2.0;
            this.DivisionVerticalPadding = 4.0;
            this.RootPowerScaling = 0.6;
            this.RootPowerMargin = 4.0;
            this.DownScriptYPadding = 2.0;
            this.OverScriptYPadding = 2.0;
            this.AlignPadding = 20.0;
            base.FontFamily = new FontFamily("Arial");
        }

        public double GetSpaceWidth()
        {
            //Create font
            Typeface typeface = new Typeface(FontFamily, FontStyle, FontWeight, FontStretch);

            FormattedText formattedText = new FormattedText(" ",
                CultureInfo.GetCultureInfo("ar-sa"),
                FlowDirection.RightToLeft, typeface, FontSize,
                new SolidColorBrush(FontColor));

            return formattedText.WidthIncludingTrailingWhitespace;

        }
    }
}
