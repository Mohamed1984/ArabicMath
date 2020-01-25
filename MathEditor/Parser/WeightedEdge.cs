using System.Collections.Generic;
using System.Text;

namespace ParserUtilities
{
    public class WeightedEdge<T> : Edge
    {
        public WeightedEdge(Vertex v0, Vertex v1, T theKey)
            : base(v0, v1)
        {
            key = theKey;
        }
        public T Key
        {
            set
            {
                key = value;
            }
            get
            {
                return key;
            }
        }
        T key;
        public override object Clone()
        {
            WeightedEdge<T> edge = new WeightedEdge<T>(v0, v1, key);
            return edge;
        }
        public override string ToString()
        {
            return "[" + base.ToString() + ":" + key + "]";
        }
    }

}