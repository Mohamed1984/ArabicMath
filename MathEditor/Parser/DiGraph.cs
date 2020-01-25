
using System.Collections.Generic;
using System.Text;
using GraphVisitor = ParserUtilities.Visitor<ParserUtilities.Vertex>;

namespace ParserUtilities
{
    public interface DiGraph : Graph
    {
        void TopologicalOrderSort(GraphVisitor visitor);
        bool IsCyclic();

        IEnumerable<Edge> IncidentEdges(Vertex vert);
        
    }
}