namespace MathEditor
{
    using System.Windows.Media;

    public class LeftSubScript : SubScript
    {
        public override Geometry DrawContent(Parser.Environment mathEnv)
        {
            var baseDrawing = base.BaseStatement.DrawContent(mathEnv);

            var subDrawing = base.SubStatement.DrawContent(mathEnv);

            ScaleTransform scale = new ScaleTransform(mathEnv.Style.SubscriptXScaling, mathEnv.Style.SubscriptYScaling);
            TranslateTransform translation = new TranslateTransform(
                ((-subDrawing.Bounds.Right * mathEnv.Style.SuperscriptXScaling) + baseDrawing.Bounds.Left) - mathEnv.Style.ScriptXPadding,
                ((-subDrawing.Bounds.Top * mathEnv.Style.SuperscriptYScaling) + baseDrawing.Bounds.Bottom) - mathEnv.Style.ScriptYPadding);
            
            //TransformGroup subTransform = new TransformGroup {
            //    Children = { scale, translation }
            //};
            //if (subDrawing.Transform != null)
            //{
            //    subTransform.Children.Add(subDrawing.Transform);
            //}
            subDrawing.Transform = CombineTransforms(subDrawing.Transform,
                scale, translation);

            //var g1 = Geometry.Combine(subDrawing, baseDrawing, GeometryCombineMode.Union, new TranslateTransform());

            //var str = g1.ToString();
            
            return CombineGeometries(baseDrawing, subDrawing);
        }
    }
}

