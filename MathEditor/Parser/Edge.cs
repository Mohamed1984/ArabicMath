using System;
using System.Collections.Generic;
using System.Text;

namespace ParserUtilities
{
    public class Edge : ICloneable
    {
        protected Vertex v0;

        public Vertex V0
        {
            get { return v0; }
        }
        protected Vertex v1;

        public Vertex V1
        {
            get { return v1; }
        }

        public Edge(Vertex vertex0, Vertex vertex1)
        {
            v0 = vertex0;
            v1 = vertex1;
        }

        public Vertex Mate(Vertex vert)
        {
            if (v0 == vert)
                return v1;
            else if (v1 == vert)
                return v0;
            else
                throw new GraphException("Vertex is not in the edge");
        }



        public virtual object Clone()
        {
            return new Edge(V0, V1);
        }
        public override string ToString()
        {
            return "(" + v0 + "," + v1 + ")";
        }


    }
}
