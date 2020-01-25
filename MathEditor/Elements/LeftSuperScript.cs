namespace MathEditor
{
    using System.Windows.Media;

    public class LeftSuperScript : SuperScript
    {
        public override Geometry DrawContent(Parser.Environment mathEnv)
        {
            var baseDrawing = base.BaseStatement.DrawContent(mathEnv);
            var superDrawing = base.SuperStatement.DrawContent(mathEnv);
            ScaleTransform scale = new ScaleTransform(mathEnv.Style.SuperscriptXScaling, mathEnv.Style.SuperscriptYScaling);
            TranslateTransform translate = new TranslateTransform(((-superDrawing.Bounds.Right * mathEnv.Style.SuperscriptXScaling) + baseDrawing.Bounds.Left) - mathEnv.Style.ScriptXPadding, (baseDrawing.Bounds.Top - (superDrawing.Bounds.Bottom * mathEnv.Style.SuperscriptYScaling)) + mathEnv.Style.ScriptYPadding);
            
                
                
            //    TransformGroup supertransform = new TransformGroup {
            //    Children = { scale, translate }
            //};
            //if (superDrawing.Transform != null)
            //{
            //    supertransform.Children.Add(superDrawing.Transform);
            //}
            superDrawing.Transform = CombineTransforms(superDrawing.Transform, scale, translate);

            return CombineGeometries(baseDrawing, superDrawing);


            //return new GeometryGroup { Children = { baseDrawing, superDrawing } };
        }
    }
}

