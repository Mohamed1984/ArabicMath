namespace MathEditor
{
    using System.Windows.Media;

    public class OverDownScript : DoubleScript
    {
        public override Geometry DrawContent(Parser.Environment mathEnv)
        {
            var baseDrawing = base.BaseStatement.DrawContent(mathEnv);
            var subDrawing = base.SubStatement.DrawContent(mathEnv);
            var superDrawing = base.SuperStatement.DrawContent(mathEnv);
            ScaleTransform scale = new ScaleTransform(mathEnv.Style.SubscriptXScaling, mathEnv.Style.SubscriptYScaling);
            TranslateTransform subTranslation =new TranslateTransform(-subDrawing.Bounds.Right + baseDrawing.Bounds.Right, -subDrawing.Bounds.Top * mathEnv.Style.SubscriptYScaling + baseDrawing.Bounds.Bottom + mathEnv.Style.DownScriptYPadding);
            TranslateTransform superTranslation = new TranslateTransform(-superDrawing.Bounds.Right + baseDrawing.Bounds.Right, ((-superDrawing.Bounds.Bottom * mathEnv.Style.SuperscriptYScaling) + baseDrawing.Bounds.Top) - mathEnv.Style.OverScriptYPadding);


            subDrawing.Transform = CombineTransforms(subDrawing.Transform, scale, subTranslation);
            
            superDrawing.Transform = CombineTransforms(superDrawing.Transform, scale, superTranslation);

            return CombineGeometries(baseDrawing, subDrawing, superDrawing);


            //TransformGroup subTransform = new TransformGroup {
            //    Children = { scale, subTranslation }
            //};
            //if (subDrawing.Transform != null)
            //{
            //    subTransform.Children.Add(subDrawing.Transform);
            //}
            //subDrawing.Transform = subTransform;
            //TransformGroup superTransform = new TransformGroup {
            //    Children = { scale, superTranslation }
            //};
            //if (superDrawing.Transform != null)
            //{
            //    superTransform.Children.Add(superDrawing.Transform);
            //}
            //superDrawing.Transform = superTransform;
            //return new GeometryGroup { Children = { baseDrawing, subDrawing, superDrawing } };
        }
    }
}

