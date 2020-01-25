namespace Parser
{
    using MathEditor;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Windows.Media;
    using System.Windows.Media.Imaging;

    public class Environment : EnvironmentBase
    {
        private bool errFlag;
        private List<ErrorMessage> errors = new List<ErrorMessage>();
        private List<ErrorMessage> infos = new List<ErrorMessage>();
        private List<ErrorMessage> warnings = new List<ErrorMessage>();

        public Environment()
        {
            this.Equations = new MultiLineStatement();

            Style = new MathStyle();
           
            this.FatalErrorFlag = false;
        }

        public void ReportError(int lineNo, ERROR_TYPE type, string msg)
        {
            this.errors.Add(new ErrorMessage(lineNo, msg));
        }

        public void ReportInfo(int lineNo, ERROR_TYPE type, string msg)
        {
            this.infos.Add(new ErrorMessage(lineNo, msg));
        }

        public void ReportWarning(int lineNo, ERROR_TYPE type, string msg)
        {
            this.warnings.Add(new ErrorMessage(lineNo, msg));
        }



        public MathStyle Style
        {
            get;
            set;
        }
        public MultiLineStatement Equations
        {
            get;
            set;
        }


        public override bool ErrorFlag
        {
            get
            {
                return this.errFlag;
            }
            set
            {
                this.errFlag = value;
            }
        }

        public List<ErrorMessage> Errors
        {
            get
            {
                return this.errors;
            }
        }

        public bool FatalErrorFlag { get; set; }

        public List<ErrorMessage> Infos
        {
            get
            {
                return this.infos;
            }
        }

        public List<ErrorMessage> Warnings
        {
            get
            {
                return this.warnings;
            }
        }

        //public MemoryStream ResultImage { set; get; }

        //public void GenerateMathImage()
        //{
        //    var img = CreateImage();

        //    DrawingVisual visual = new DrawingVisual();
        //    DrawingContext context = visual.RenderOpen();
        //    context.DrawImage(img, new System.Windows.Rect(20.0, 20.0, img.Width, img.Height));
        //    context.Close();
        //    RenderTargetBitmap source = new RenderTargetBitmap(((int)img.Width) + 40, ((int)img.Height) + 40, 96.0, 96.0, PixelFormats.Default);
        //    source.Render(visual);
        //    BitmapFrame frame = BitmapFrame.Create(source);
        //    PngBitmapEncoder encoder = new PngBitmapEncoder
        //    {
        //        Frames = { frame }
        //    };
        //    encoder.Save(ResultImage);
        //    ResultImage.Close();

        //}

        public GeometryDrawing CreateImage()
        {
            Geometry geom = this.Equations.DrawContent(this);

            //var translation = new TranslateTransform(-geom.Bounds.Left, -geom.Bounds.Top);

            //geom.Transform = Statement.CombineTransforms(geom.Transform,translation);

            PathGeometry g = new PathGeometry();

            g.AddGeometry(geom);

            var ret= new GeometryDrawing(new SolidColorBrush(Style.FontColor), new Pen(Brushes.Black, 0), g);

            return ret;
        }
    }

    public enum ERROR_TYPE
    {
        LEXICAL,
        SYNTAX,
        SEMANTIC
    }
}

