namespace MathEditor
{
    using System.Windows.Media;

    public class OverScript : SuperScript
    {
        public override Geometry DrawContent(Parser.Environment mathEnv)
        {
            Geometry baseDrawing = base.BaseStatement.DrawContent(mathEnv);
            Geometry superDrawing = base.SuperStatement.DrawContent(mathEnv);
            ScaleTransform scale = new ScaleTransform(mathEnv.Style.SuperscriptXScaling, mathEnv.Style.SuperscriptYScaling);
            TranslateTransform translation = new TranslateTransform(-superDrawing.Bounds.Right + baseDrawing.Bounds.Right, ((-superDrawing.Bounds.Bottom * mathEnv.Style.SuperscriptYScaling) + baseDrawing.Bounds.Top) - mathEnv.Style.OverScriptYPadding);

            superDrawing.Transform = CombineTransforms(superDrawing.Transform, scale,translation);

            //TransformGroup superTransform = new TransformGroup {
            //    Children = { scale, translation }
            //};
            //if (superDrawing.Transform != null)
            //{
            //    superTransform.Children.Add(superDrawing.Transform);
            //}
            //superDrawing.Transform = superTransform;

            
            return CombineGeometries(baseDrawing, superDrawing);


            //return new GeometryGroup { Children = { baseDrawing, superDrawing } };
        }
    }
}

