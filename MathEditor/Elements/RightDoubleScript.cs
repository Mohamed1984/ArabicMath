namespace MathEditor
{
    using System.Windows.Media;

    public class RightDoubleScript : DoubleScript
    {
        public override Geometry DrawContent(Parser.Environment mathEnv)
        {
            var baseDrawing = base.BaseStatement.DrawContent(mathEnv);
            TranslateTransform transform = new TranslateTransform(-baseDrawing.Bounds.Right, -baseDrawing.Bounds.Top);
            baseDrawing.Transform = transform;
            var subDrawing = base.SubStatement.DrawContent(mathEnv);
            var superDrawing = base.SuperStatement.DrawContent(mathEnv);
            ScaleTransform scale = new ScaleTransform(mathEnv.Style.SubscriptXScaling, mathEnv.Style.SubscriptYScaling);
            TranslateTransform subTranslation = new TranslateTransform(((-subDrawing.Bounds.Left * mathEnv.Style.SuperscriptXScaling) + baseDrawing.Bounds.Right) + mathEnv.Style.ScriptXPadding, ((-subDrawing.Bounds.Top * mathEnv.Style.SuperscriptYScaling) + baseDrawing.Bounds.Bottom) - mathEnv.Style.ScriptYPadding);
            
            TranslateTransform superTranslation = new TranslateTransform(((-superDrawing.Bounds.Left * mathEnv.Style.SuperscriptXScaling) + baseDrawing.Bounds.Right) + mathEnv.Style.ScriptXPadding, (baseDrawing.Bounds.Top - (superDrawing.Bounds.Bottom * mathEnv.Style.SuperscriptYScaling)) + mathEnv.Style.ScriptYPadding);


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

