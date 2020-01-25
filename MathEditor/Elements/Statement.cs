namespace MathEditor
{
    using System;
    using System.Windows.Media;

    public abstract class Statement
    {
        protected Statement()
        {
        }

        public abstract Geometry DrawContent(Parser.Environment mathEnv);

        public virtual StatementTypes Type
        {
            get
            {
                return StatementTypes.Normal;
            }
        }

        protected Geometry CombineGeometries(Geometry geom1, Geometry geom2)
        {
            PathGeometry pg = new PathGeometry();
            pg.AddGeometry(geom1);
            pg.AddGeometry(geom2);
            return pg;
            //var g = Geometry.Combine(geom1, geom2,
            //    GeometryCombineMode.Union, null);
            //return g;
        }

        protected Geometry CombineGeometries(Geometry geom1, Geometry geom2,Geometry geom3)
        {
            PathGeometry pg = new PathGeometry();
            pg.AddGeometry(geom1);
            pg.AddGeometry(geom2);
            pg.AddGeometry(geom3);
            return pg;
        }

        //Apply t1 transform then apply t2
        public static Transform CombineTransforms(Transform t1,Transform t2)
        {
            if (t1 == null)
                t1 = new TranslateTransform();
            if (t2 == null)
                t2 = new TranslateTransform();

            return new MatrixTransform(t1.Value * t2.Value);
        }

        public static Transform CombineTransforms(Transform t1, Transform t2,Transform t3)
        {
            if (t1 == null)
                t1 = new TranslateTransform();
            if (t2 == null)
                t2 = new TranslateTransform();
            if (t3 == null)
                t3 = new TranslateTransform();

            return new MatrixTransform(t1.Value*t2.Value * t3.Value);
        }


    }
}

