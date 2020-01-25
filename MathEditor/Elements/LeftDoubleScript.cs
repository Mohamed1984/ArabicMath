namespace MathEditor
{
    using System.Windows.Media;

    public class LeftDoubleScript : DoubleScript
    {
        public override Geometry DrawContent(Parser.Environment mathEnv)
        {
            var baseDrawing = base.BaseStatement.DrawContent(mathEnv);

            var subDrawing = base.SubStatement.DrawContent(mathEnv);

            var superDrawing = base.SuperStatement.DrawContent(mathEnv);

            ScaleTransform scale = new ScaleTransform(mathEnv.Style.SubscriptXScaling, mathEnv.Style.SubscriptYScaling);

            TranslateTransform subtranslation = new TranslateTransform(
                ((-subDrawing.Bounds.Right * mathEnv.Style.SuperscriptXScaling) + baseDrawing.Bounds.Left) - mathEnv.Style.ScriptXPadding,
                ((-subDrawing.Bounds.Top * mathEnv.Style.SuperscriptYScaling) + baseDrawing.Bounds.Bottom) - mathEnv.Style.ScriptYPadding);


            //(-subDrawing.Bounds.Right + baseDrawing.Bounds.Left) - mathEnv.Style.ScriptXPadding,
                //(-subDrawing.Bounds.Top + baseDrawing.Bounds.Bottom) + mathEnv.Style.ScriptYPadding);

            TranslateTransform supertranslation =new TranslateTransform(
                ((-superDrawing.Bounds.Right * mathEnv.Style.SuperscriptXScaling) + baseDrawing.Bounds.Left) - mathEnv.Style.ScriptXPadding,
                (baseDrawing.Bounds.Top - (superDrawing.Bounds.Bottom * mathEnv.Style.SuperscriptYScaling)) + mathEnv.Style.ScriptYPadding);

            //TransformGroup subtransform = new TransformGroup
            //{
            //    Children = { scale, subtranslation }
            //};
            //if (subDrawing.Transform != null)
            //{
            //    subtransform.Children.Add(subDrawing.Transform);
            //}
            subDrawing.Transform = CombineTransforms(subDrawing.Transform, scale, subtranslation);
            //TransformGroup superTransform = new TransformGroup
            //{
            //    Children = { scale, supertranslation }
            //};
            //if (superDrawing.Transform != null)
            //{
            //    superTransform.Children.Add(superDrawing.Transform);
            //}
            superDrawing.Transform = CombineTransforms(superDrawing.Transform, scale, supertranslation);

            return CombineGeometries(baseDrawing,subDrawing, superDrawing);

            //return new GeometryGroup { Children = { baseDrawing, subDrawing, superDrawing } };
        }
    }
}

