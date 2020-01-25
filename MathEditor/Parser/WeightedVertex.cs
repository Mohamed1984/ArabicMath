using System.Collections.Generic;
using System.Text;

namespace ParserUtilities
{
    public class WeightedVertex<T> : Vertex
    {
        protected T key;

        public WeightedVertex(T obj)
        {
            key = obj;
        }
        public T Key
        {
            get
            {
                return key;
            }
            set
            {
                key = value;
            }
        }
        public override object Clone()
        {
            WeightedVertex<T> vertex = new WeightedVertex<T>(key);
            return vertex;
        }
        public override string ToString()
        {
            return "[" + base.ToString() + ":" + key + "]";
        }
    }
}
