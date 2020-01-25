namespace MathEditor
{
    using System.Windows.Media;

    public class RightSubScript : SubScript
    {
        public override Geometry DrawContent(Parser.Environment mathEnv)
        {
            var baseDrawing = base.BaseStatement.DrawContent(mathEnv);
            var subDrawing = base.SubStatement.DrawContent(mathEnv);
            ScaleTransform scale = new ScaleTransform(mathEnv.Style.SubscriptXScaling, mathEnv.Style.SubscriptYScaling);
            TranslateTransform translation =  new TranslateTransform(
                ((-subDrawing.Bounds.Left * mathEnv.Style.SuperscriptXScaling) + baseDrawing.Bounds.Right) + mathEnv.Style.ScriptXPadding,
                ((-subDrawing.Bounds.Top * mathEnv.Style.SuperscriptYScaling) + baseDrawing.Bounds.Bottom) - mathEnv.Style.ScriptYPadding);


            subDrawing.Transform = CombineTransforms(subDrawing.Transform,
                scale, translation);

            return CombineGeometries(baseDrawing, subDrawing);


            //TransformGroup subtransform = new TransformGroup {
            //    Children = { scale, translation }
            //};
            //if (subDrawing.Transform != null)
            //{
            //    subtransform.Children.Add(subDrawing.Transform);
            //}
            //subDrawing.Transform = subtransform;
            //return new GeometryGroup { Children = { baseDrawing, subDrawing } };
        }
    }
}

