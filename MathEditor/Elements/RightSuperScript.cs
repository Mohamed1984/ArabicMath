namespace MathEditor
{
    using System.Windows.Media;

    public class RightSuperScript : SuperScript
    {
        public override Geometry DrawContent(Parser.Environment mathEnv)
        {
            var baseDrawing = base.BaseStatement.DrawContent(mathEnv);
            var superDrawing = base.SuperStatement.DrawContent(mathEnv);
            ScaleTransform scale = new ScaleTransform(mathEnv.Style.SuperscriptXScaling, mathEnv.Style.SuperscriptYScaling);
            TranslateTransform translate =   new TranslateTransform(((-superDrawing.Bounds.Left * mathEnv.Style.SuperscriptXScaling) + baseDrawing.Bounds.Right) + mathEnv.Style.ScriptXPadding, (baseDrawing.Bounds.Top - (superDrawing.Bounds.Bottom * mathEnv.Style.SuperscriptYScaling)) + mathEnv.Style.ScriptYPadding);


            superDrawing.Transform = CombineTransforms(superDrawing.Transform, scale, translate);

            return CombineGeometries(baseDrawing, superDrawing);



            //TransformGroup superTransform = new TransformGroup {
            //    Children = { scale, translate }
            //};
            //if (superDrawing.Transform != null)
            //{
            //    superTransform.Children.Add(superDrawing.Transform);
            //}
            //superDrawing.Transform = superTransform;
            //return new GeometryGroup { Children = { baseDrawing, superDrawing } };
        }
    }
}

