using System;
using System.Collections.Generic;
using System.Text;
using GraphVisitor = ParserUtilities.Visitor<ParserUtilities.Vertex>;

namespace ParserUtilities
{
    public interface Graph : ICloneable
    {

        int NumberOfVertices
        {
            get;
        }
        int NumberOfEdges
        {
            get;
        }
        void AddVertex(Vertex vert);
        void AddEdge(Edge edge);
        IEnumerable<Vertex> Vertices();
        IEnumerable<Edge> Edges();
        bool IsEdge(Vertex vert0, Vertex vert1);

        Vertex this[int i]
        {
            get;
        }

        Edge GetEdge(Vertex vert0, Vertex vert1);

        bool IsConnected();

        void DepthFirstTraversal(Vertex vert, GraphVisitor visitor);

        void BreadthFirstTraversal(Vertex vert, GraphVisitor visitor);

        IEnumerable<Edge> EmanatingEdges(Vertex vert);

    }
}
