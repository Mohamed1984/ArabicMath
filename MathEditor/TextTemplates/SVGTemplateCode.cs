using System.Linq;
using System.Text;
using System.Collections.Generic;
using System;
using System.Windows.Media;

namespace MathEditor.TextTemplates
{
    public partial class SVGTemplate
    {
        
        public GeometryDrawing Drawing { set; get; }

        public string Data
        {
            get
            {
                var text= Drawing.Geometry.ToString();
                return text;
            }
        }
        public double Left
        {
            get
            {
                return Drawing.Geometry.Bounds.Left;
            }
        }
        public double Top
        {
            get
            {
                return Drawing.Geometry.Bounds.Top;
            }
        }
        public double Right
        {
            get
            {
                return Drawing.Geometry.Bounds.Right;
            }
        }
        public double Bottom
        {
            get
            {
                return Drawing.Geometry.Bounds.Bottom;
            }
        }

        public double Width
        {
            get
            {
                return Drawing.Geometry.Bounds.Width;
            }
        }
        public double Height
        {
            get
            {
                return Drawing.Geometry.Bounds.Height;
            }
        }

        public double ImageVerticalAlign
        {
            get
            {
                return -Bottom;
            }
        }
        public Pen Stroke
        {
            get
            {
                return Drawing.Pen;
            }
        }

        public Color FillColor
        {
            get
            {
                var brush = Drawing.Brush as SolidColorBrush;
                if (brush != null)
                    return brush.Color;
                else
                    return Colors.Black;
            }
        }
        public string FillColorText
        {
            get
            {
                var c = FillColor;
                var ret = c.R.ToString("x2") +
                    c.G.ToString("x2") +
                    c.B.ToString("x2");
                return ret;
                
            }
        }

        public int ToLargestIntegerMagnitude(double x)
        {
            if (x >= 0)
                return (int)Math.Ceiling(x);
            else
                return (int)Math.Floor(x);
        }
    }
}