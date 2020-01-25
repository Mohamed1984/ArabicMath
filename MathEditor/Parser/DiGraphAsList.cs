using System.Collections.Generic;
using System.Text;

namespace ParserUtilities
{
    public class DiGraphAsList : GraphAsList, DiGraph
    {

        public override void AddVertex(Vertex vert)
        {
            vert.Number = vertexList.Count;
            vertexList.Add(vert);
            emanatingAdjacenyList.Add(new SortedDictionary<Vertex, Edge>(vertexComparer));
            incidentAdjacenyList.Add(new SortedDictionary<Vertex, Edge>(vertexComparer));
        }

        public override void AddEdge(ParserUtilities.Edge edge)
        {
            //verify the two vertices are here
            if (edge.V0.number >= vertexList.Count || edge.V1.number >= vertexList.Count)
                throw new GraphException("Edge vertices not found in graph");

            if (emanatingAdjacenyList[edge.V0.Number].ContainsKey(edge.V1))
                throw new GraphException("Edge already added to the graph");


            emanatingAdjacenyList[edge.V0.Number].Add(edge.V1, edge);
            incidentAdjacenyList[edge.V1.Number].Add(edge.V0, edge);
            numberOfEdges++;

        }


        public IEnumerable<Edge> IncidentEdges(Vertex vert)
        {
            return incidentAdjacenyList[vert.Number].Values;
            //return new IncidentEdgeEnumerable(vertexList, emanatingAdjacenyList, vert);
        }

        public IEnumerable<Vertex> IncidentVertices(Vertex vert)
        {
            return incidentAdjacenyList[vert.Number].Keys;
            //return new IncidentEdgeEnumerable(vertexList, emanatingAdjacenyList, vert);
        }


        public void TopologicalOrderSort(Visitor<Vertex> visitor)
        {
            ushort[] inDegrees = new ushort[vertexList.Count];

            foreach (Edge e in edgesList)
            {
                inDegrees[e.V1.Number]++;
            }

            Queue<Vertex> queue = new Queue<Vertex>();
            for (int i = 0; i < vertexList.Count; i++)
            {
                if (inDegrees[i] == 0)
                    queue.Enqueue(vertexList[i]);
            }
            while (queue.Count != 0)
            {
                Vertex curVertex = queue.Dequeue();
                visitor.Visit(curVertex);
                foreach (Edge edge in EmanatingEdges(curVertex))
                {
                    inDegrees[edge.V1.Number]--;
                    if (inDegrees[edge.V1.Number] == 0)
                        queue.Enqueue(edge.V1);
                }
            }

        }

        public bool IsCyclic()
        {
            CountingVisitor cv = new CountingVisitor();
            TopologicalOrderSort(cv);
            if (cv.Count < vertexList.Count)
                return true;
            return false;
        }
        public override string ToString()
        {
            string str = "G(" + NumberOfVertices + ")= {";
            foreach (Vertex v0 in vertexList)
            {
                foreach (Edge other in emanatingAdjacenyList[v0.number].Values)
                {
                    str = str + "(" + v0 + " --> " + other.V1 + "),";
                }
            }
            str = str + "}";
            return str;
        }

        protected List<IDictionary<Vertex, Edge>> incidentAdjacenyList = new List<IDictionary<Vertex, Edge>>();


        //private class IncidentEdgeEnumerator : IEnumerator<Edge>
        //{
        //    public IncidentEdgeEnumerator(List<Vertex> vList, List<LinkedList<Edge>> eList, Vertex vert)
        //    {
        //        vertList = vList;
        //        adjLists = eList;
        //        vertex = vert;
        //    }
        //    public Edge Current
        //    {
        //        get
        //        {
        //            return new Edge(vertList[verIndex], curNode.Value.V1);
        //        }
        //    }
        //    public void Dispose()
        //    {

        //    }
        //    object System.Collections.IEnumerator.Current
        //    {
        //        get
        //        {
        //            return Current;
        //        }
        //    }
        //    public bool MoveNext()
        //    {
        //        if (verIndex == -1)
        //        {
        //            if (adjLists.Count == 0)
        //                return false;

        //            int i = 0;
        //            for (i = 0; i < adjLists.Count; i++)
        //            {
        //                bool startFound = false;
        //                LinkedListNode<Edge> curNode = adjLists[i].First;
        //                while (curNode != null)
        //                {
        //                    if (curNode.Value.V1.Number == vertex.Number)
        //                    {
        //                        startFound = true;
        //                        break;
        //                    }
        //                    curNode = curNode.Next;
        //                }
        //                verIndex = i;
        //                if (startFound == true)
        //                    return true;

        //            }
        //            return false;
        //        }
        //        else
        //        {
        //            verIndex++;
        //            int j;
        //            for (j = verIndex; j < adjLists.Count; j++)
        //            {
        //                bool matchFound = false;
        //                curNode = adjLists[j].First;
        //                while (curNode != null)
        //                {
        //                    if (curNode.Value.V1.Number == vertex.Number)
        //                    {
        //                        matchFound = true;
        //                        break;
        //                    }
        //                    curNode = curNode.Next;
        //                }
        //                verIndex = j;
        //                if (matchFound == true)
        //                    return true;

        //            }
        //            return false;
        //        }
        //    }
        //    public void Reset()
        //    {
        //        verIndex = -1;
        //    }
        //    private int verIndex = -1;
        //    LinkedListNode<Edge> curNode;
        //    List<Vertex> vertList;
        //    List<LinkedList<Edge>> adjLists;
        //    Vertex vertex;
        //}

        //private class IncidentEdgeEnumerable : IEnumerable<Edge>
        //{

        //    public IncidentEdgeEnumerable(List<Vertex> vList, List<LinkedList<Edge>> eList, Vertex vert)
        //    {
        //        ie = new IncidentEdgeEnumerator(vList, eList, vert);
        //    }
        //    public IEnumerator<Edge> GetEnumerator()
        //    {
        //        return ie;
        //    }

        //    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        //    {
        //        return GetEnumerator();
        //    }

        //    private IncidentEdgeEnumerator ie;
        //}
    }
}