using MathEditor.ViewModel;
using Microsoft.Win32;
using System;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Threading;
using System.Windows.Media.Converters;
using System.Windows.Converters;
using MathEditor.TextTemplates;
//using System.Windows.Documents;
//using Microsoft.Office.Interop.Word;

namespace MathEditor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : System.Windows.Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("ar-sa");
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("ar-sa");
        }

        private void InsertAlgebraOp_Click(object sender, EventArgs e)
        {
            EditorViewModel model = this.DataContext as EditorViewModel;
            model.InsertionIndex = UserTextTxt.CaretIndex;
            model.InsertAlgebraOperator();
            UserTextTxt.CaretIndex = model.InsertionIndex + 1;
            UserTextTxt.Focus();
        }

        private void InsertCalculusOp_Click(object sender, EventArgs e)
        {
            EditorViewModel model = this.DataContext as EditorViewModel;
            model.InsertionIndex = UserTextTxt.CaretIndex;
            model.InsertCalculusOperator();
            UserTextTxt.CaretIndex = model.InsertionIndex + 1;
            UserTextTxt.Focus();
        }


        private void InsertEquality_Click(object sender, EventArgs e)
        {
            EditorViewModel model = this.DataContext as EditorViewModel;
            model.InsertionIndex = UserTextTxt.CaretIndex;
            model.InsertEqualityOperator();
            UserTextTxt.CaretIndex = model.InsertionIndex + 1;
            UserTextTxt.Focus();
        }

        private void InsertGroupOp_Click(object sender, EventArgs e)
        {
            EditorViewModel model = this.DataContext as EditorViewModel;
            model.InsertionIndex = UserTextTxt.CaretIndex;
            model.InsertGroupOperator();
            UserTextTxt.CaretIndex = model.InsertionIndex + 1;
            UserTextTxt.Focus();
        }



        private void InsertOverDownOp_Click(object sender, EventArgs e)
        {
            EditorViewModel model = this.DataContext as EditorViewModel;
            model.InsertionIndex = UserTextTxt.CaretIndex;
            model.InsertOverDownScript();
            UserTextTxt.CaretIndex = model.InsertionIndex + 1;
            UserTextTxt.Focus();
        }



        private void InsertProofOp_Click(object sender, EventArgs e)
        {
            EditorViewModel model = this.DataContext as EditorViewModel;
            model.InsertionIndex = UserTextTxt.CaretIndex;
            model.InsertProofOperator();
            UserTextTxt.CaretIndex = model.InsertionIndex + 1;
            UserTextTxt.Focus();
        }

        private void InsertQuickAccessSymbol_Click(object sender, RoutedEventArgs e)
        {

            EditorViewModel model = this.DataContext as EditorViewModel;
            model.InsertionIndex = UserTextTxt.CaretIndex;
            model.InsertQuickAccessChar();
            UserTextTxt.CaretIndex = model.InsertionIndex + 1;
            UserTextTxt.Focus();
        }



        private void InsertRelationalOp_Click(object sender, EventArgs e)
        {
            EditorViewModel model = this.DataContext as EditorViewModel;
            model.InsertionIndex = UserTextTxt.CaretIndex;
            model.InsertRelationalOperator();
            UserTextTxt.CaretIndex = model.InsertionIndex + 1;
            UserTextTxt.Focus();
        }

        private void InsertSpecialSymbolOp_Click(object sender, EventArgs e)
        {
            EditorViewModel model = this.DataContext as EditorViewModel;
            model.InsertionIndex = UserTextTxt.CaretIndex;
            model.InsertSpecialSymbol();
            UserTextTxt.CaretIndex = model.InsertionIndex + 1;
            UserTextTxt.Focus();
        }





        private void RemoveQuickAccessChar_Click(object sender, MouseButtonEventArgs e)
        {
            EditorViewModel model = this.DataContext as EditorViewModel;
            
            model.RemoveQuickAccessChar();

            quickAccessList.Items.Refresh();
        }

        private void UpdateBtn_Click(object sender, RoutedEventArgs e)
        {
            EditorViewModel model = this.DataContext as EditorViewModel;

            this.UserTextTxt.GetBindingExpression(TextBox.TextProperty).UpdateSource();
            UserTextTxt.Focus();
        }

        private void UserTextTxt_KeyDown(object sender, KeyEventArgs e)
        {
            EditorViewModel model = this.DataContext as EditorViewModel;

            if (Keyboard.Modifiers == ModifierKeys.Control)
            {
                if (e.Key == Key.F1)
                {
                    model.SelectedQuickAccessIndex = 0;
                }
                else if (e.Key == Key.F2)
                {
                    model.SelectedQuickAccessIndex = 1;
                }
                else if (e.Key == Key.F3)
                {
                    model.SelectedQuickAccessIndex = 2;
                }
                else if (e.Key == Key.F4)
                {
                    model.SelectedQuickAccessIndex = 3;
                }
                else if (e.Key == Key.F5)
                {
                    model.SelectedQuickAccessIndex = 4;
                }
                else if (e.Key == Key.F6)
                {
                    model.SelectedQuickAccessIndex = 5;
                }
                else if (e.Key == Key.F7)
                {
                    model.SelectedQuickAccessIndex = 6;
                }
                else if (e.Key == Key.F8)
                {
                    model.SelectedQuickAccessIndex = 7;
                }
                else if (e.Key == Key.F9)
                {
                    model.SelectedQuickAccessIndex = 8;
                }
                else if (e.Key == Key.F10)
                {
                    model.SelectedQuickAccessIndex = 9;
                }
                else if (e.Key == Key.F11)
                {
                    model.SelectedQuickAccessIndex = 10;
                }
                else if (e.Key == Key.F12)
                {
                    model.SelectedQuickAccessIndex = 11;
                }
                else
                {
                    return;
                }
                model.InsertionIndex = UserTextTxt.CaretIndex;
                model.InsertQuickAccessChar();
                UserTextTxt.CaretIndex = model.InsertionIndex + 1;
            }
        }

        private void UserTextTxt_SelectionChanged(object sender, RoutedEventArgs e)
        {
            EditorViewModel model = this.DataContext as EditorViewModel;

            int num = this.UserTextTxt.SelectionStart;
            int num2 = 1;
            int num3 = 1;
            string str = this.UserTextTxt.Text;
            for (int i = 0; i < num; i++)
            {
                num3++;
                if (str[i] == '\r')
                {
                    num2++;
                    num3 = 1;
                }
            }
            model.EditorLineNumber = num2;
            model.EditorColNumber = num3;
        }

        private void Compile_Click(object sender, RoutedEventArgs e)
        {
            EditorViewModel model = this.DataContext as EditorViewModel;

            model.ParseText();

            UserTextTxt.Focus();
        }

        private void Copy_Click(object sender, RoutedEventArgs e)
        {


            //Clipboard.SetDataObject(d1);

            //var d1 = Clipboard.GetDataObject();

            //var x1 = d1.GetFormats();

            //var x2 = d1.GetData("image/svg+xml");

            //var x3 = x2 as MemoryStream;

            //StreamReader sr = new StreamReader(x3);

            //var x4 = sr.ReadToEnd();



            var bitmap = createImageBitmap();

            var svg = createSvgImage();

            DataObject d = new DataObject();

            d.SetData("image/svg+xml", svg);

            d.SetImage(bitmap);

            Clipboard.SetDataObject(d);

            UserTextTxt.Focus();

        }
        private void Options_Click(object sender, RoutedEventArgs e)
        {
            Options o = new Options
            {
                Owner = this
            };

            o.ShowDialog();
        }
        private void Save_Click(object sender, RoutedEventArgs e)
        {
            

            SaveFileDialog dlg = new SaveFileDialog();
            dlg.AddExtension = true;
            dlg.Filter = "SVG Image (*.svg)|*.svg|Png Image (*.png) |*.png";
            dlg.Title = "حفظ النص الرياضي كصورة";
            dlg.FileName = "نص رياضي";
            dlg.ValidateNames = true;
            if (dlg.ShowDialog() == true)
            {
                if(dlg.FilterIndex==1)
                {
                    var svg = createSvgImage();
                    FileStream fs = new FileStream(dlg.FileName, FileMode.Create);
                    svg.CopyTo(fs);
                    fs.Close();
                }
                else if (dlg.FilterIndex == 2)
                {
                    var bitmap = createImageBitmap();

                    BitmapFrame frame = BitmapFrame.Create(bitmap);

                    PngBitmapEncoder encoder = new PngBitmapEncoder
                    {
                        Frames = { frame }
                    };
                    FileStream fs = new FileStream(dlg.FileName, FileMode.Create);
                    encoder.Save(fs);
                    fs.Close();
                }
            }
        }

        private BitmapSource createImageBitmap()
        {
            EditorViewModel model = this.DataContext as EditorViewModel;

            var img = model.ResultImage;

            DrawingVisual drawPanel = new DrawingVisual();

            DrawingContext drawContext = drawPanel.RenderOpen();

            drawContext.DrawRectangle(new SolidColorBrush(model.Style.BackgroundColor), new Pen(),
            new Rect(0, 0,
           (int)Math.Ceiling(img.Bounds.Width),
            (int)Math.Ceiling(img.Bounds.Height)));

            drawContext.DrawGeometry(img.Brush, img.Pen, img.Geometry);

            drawContext.Close();
            
            RenderTargetBitmap bitmap = new RenderTargetBitmap((
                (int)Math.Ceiling(drawPanel.Drawing.Bounds.Width)), (
                (int)Math.Ceiling(drawPanel.Drawing.Bounds.Height)), 96.0, 96.0, PixelFormats.Default);

            bitmap.Render(drawPanel);

            return bitmap;
        }

        private MemoryStream createSvgImage()
        {
            EditorViewModel model = this.DataContext as EditorViewModel;

            var img = model.ResultImage;

            SVGTemplate svg=new SVGTemplate();
            
            svg.Drawing = img;

            var text = svg.TransformText();

            byte[] bytes = Encoding.UTF8.GetBytes(text);

            var svgStream = new MemoryStream(bytes);

            return svgStream;
        }

        //private void Test_Click(object sender, RoutedEventArgs e)
        //{
        //    //Clipboard.SetDataObject(d1);

        //    //var d1 = Clipboard.GetDataObject();

        //    //var x1 = d1.GetFormats();

        //    //foreach (var item in x1)
        //    //{
        //    //    var x2 = d1.GetData(item);

        //    //    int cc = 1;


        //    //}


        //    //using (MemoryStream ms = new MemoryStream())
        //    //{
        //    //    using (var doc = WordprocessingDocument.Create(ms, WordprocessingDocumentType.Document, true))
        //    //    {
        //    //        MainDocumentPart mainPart = doc.AddMainDocumentPart();

        //    //        // Create the document structure and add some text.
        //    //        mainPart.Document = new Document();
        //    //        Body docBody = new Body();
        //    //        Paragraph p = new Paragraph();
        //    //        Run r = new Run();
        //    //        Text t = new Text("Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent quam augue, tempus id metus in, laoreet viverra quam. Sed vulputate risus lacus, et dapibus orci porttitor non.");
        //    //        r.Append(t);
        //    //        p.Append(r);
        //    //        docBody.Append(p);


        //    //    }
        //    //}

        //    var svg = createSvgImage();

        //    DataObject d = new DataObject();

        //    d.SetData("image/svg+xml", svg);

        //    Clipboard.SetDataObject(d);

        //    var app = System.Runtime.InteropServices.Marshal.GetActiveObject("Word.Application") as Microsoft.Office.Interop.Word.Application;

        //    app.ActiveDocument.Select();
        //    app.ActiveDocument.Content.InsertAfter("Test Text");

        //    app.Selection.Paste();



        //    app.Selection.Font.Position = 20; 
        //}
    }
}