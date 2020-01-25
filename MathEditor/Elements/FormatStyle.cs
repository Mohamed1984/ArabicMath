using System;
using System.Text;
using System.Windows;
using System.Windows.Media;
namespace MathEditor
{
    public class FormatStyle
    {
        public FontFamily FontFamily
        {
            get;
            set;
        }
        public Color FontColor
        {
            get;
            set;
        }
        public double FontSize
        {
            get;
            set;
        }
        public int FontSizeInPoints
        {
            get
            {
                return (int)(FontSize * 72.0 / 96.0);
            }
        }
        public FontStyle FontStyle
        {
            get;
            set;
        }
        public FontStretch FontStretch
        {
            get;
            set;
        }
        public FontWeight FontWeight
        {
            get;
            set;
        }
        public FormatStyle()
        {
            this.FontFamily = new FontFamily("Arial");
            this.FontColor = Colors.Black;
            this.FontSize = 40.0;
            this.FontStyle = FontStyles.Normal;
            this.FontStretch = FontStretches.Normal;
            this.FontWeight = FontWeights.Normal;
        }
    }
}
