using System;
using System.Windows.Media;
namespace MathEditor
{
    public class DownScript : SubScript
    {
        public override Geometry DrawContent(Parser.Environment mathEnv)
        {
            var baseDrawing = base.BaseStatement.DrawContent(mathEnv);
            var subDrawing = base.SubStatement.DrawContent(mathEnv);
            
            ScaleTransform scale = new ScaleTransform(mathEnv.Style.SubscriptXScaling, mathEnv.Style.SubscriptYScaling);
            TranslateTransform translation = new TranslateTransform(-subDrawing.Bounds.Right + baseDrawing.Bounds.Right, -subDrawing.Bounds.Top * mathEnv.Style.SubscriptYScaling + baseDrawing.Bounds.Bottom + mathEnv.Style.DownScriptYPadding);
            
            
            //TransformGroup subTransform = new TransformGroup();
            //subTransform.Children.Add(scale);
            //subTransform.Children.Add(translation);
            //if (subDrawing.Transform != null)
            //{
            //    subTransform.Children.Add(subDrawing.Transform);
            //}
            subDrawing.Transform = CombineTransforms(subDrawing.Transform,
                scale,translation);

            return CombineGeometries(baseDrawing, subDrawing);

    //        return new GeometryGroup
    //        {
    //            Children = 
				//{
				//	baseDrawing,
				//	subDrawing
				//}
    //        };
        }
    }
}
