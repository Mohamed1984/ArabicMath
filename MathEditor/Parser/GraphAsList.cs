using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;



namespace ParserUtilities
{
    public class GraphAsList : ParserUtilities.Graph
    {
        public GraphAsList()
        {
            vertexComparer = Comparer<Vertex>.Create((Vertex v1, Vertex v2) => { return v1.Number.CompareTo(v2.Number); });
        }

        protected IComparer<Vertex> vertexComparer;

        public virtual void AddVertex(Vertex vert)
        {

            vert.Number = vertexList.Count;
            vertexList.Add(vert);
            
            emanatingAdjacenyList.Add(new SortedDictionary<Vertex,Edge>(vertexComparer));
        }

        //implementation of non directed graphs
        public virtual void AddEdge(Edge edge)
        {
            //verify the two vertices are here
            if (edge.V0.number >= vertexList.Count || edge.V1.number >= vertexList.Count)
                throw new GraphException("Edge vertices not found in graph");
            foreach (Edge e in EmanatingEdges(edge.V0))
            {
                if (e.V1 == edge.V1)
                    throw new GraphException("Edge already added to the graph");
            }
            emanatingAdjacenyList[edge.V0.Number].Add(edge.V1,edge);
            emanatingAdjacenyList[edge.V1.Number].Add(edge.V0,edge);
            
            edgesList.Add(edge);

            numberOfEdges++;
        }


        

        public IEnumerable<Vertex> Vertices()
        {
            return vertexList;
        }

        public IEnumerable<Edge> Edges()
        {
            return edgesList;
            //EdgesEnumerator edgeEnumerator = new EdgesEnumerator(vertexList, adjacenyLists);
            //return new EdgesEnumerable(edgeEnumerator);
        }

        public bool IsEdge(Vertex vert0, Vertex vert1)
        {
            if (vert0.Number >= vertexList.Count || vert1.Number >= vertexList.Count)
                return false;
            var vList = emanatingAdjacenyList[vert0.Number];

            if (vList.ContainsKey(vert1))
                return true;
            
            return false;
        }


        public Vertex this[int i]
        {
            get
            {
                return vertexList[i];
            }
        }

        public Edge GetEdge(Vertex vert0, Vertex vert1)
        {
            if (IsEdge(vert0, vert1))
            {
                return emanatingAdjacenyList[vert0.Number][vert1];
            }
            throw new GraphException("trial to get Edge not found in graph");
        }

        public void DepthFirstTraversal(Vertex vert, Visitor<Vertex> visitor)
        {

            BitArray verticesVisited = new BitArray(vertexList.Count, false);
            DepthFirstTraversal(vert, visitor, verticesVisited);
        }

        private void DepthFirstTraversal(Vertex vert, Visitor<Vertex> visitor, BitArray verticesVisited)
        {
            if (visitor.HasDone())
                return;

            foreach (Edge e in EmanatingEdges(vert))
            {
                if (verticesVisited[e.V1.Number] == false)
                {
                    DepthFirstTraversal((Vertex)e.V1, visitor, verticesVisited);
                    verticesVisited[e.V1.Number] = true;
                }

            }
            visitor.Visit(vert);
        }

        public void BreadthFirstTraversal(Vertex vert, Visitor<Vertex> visitor)
        {
            BitArray visited = new BitArray(NumberOfVertices, false);
            Queue<Vertex> queue = new Queue<Vertex>();

            queue.Enqueue(vert);

            Vertex current = null;
            while (queue.Count != 0)
            {
                if (visitor.HasDone())
                    return;

                current = queue.Dequeue();

                visitor.Visit(current);
                visited[current.Number] = true;
                foreach (Edge e in EmanatingEdges(current))
                {
                    if (visited[e.V1.Number] == false)
                        queue.Enqueue((Vertex)e.V1);
                }


            }
        }
        protected int numberOfEdges = 0;
        protected List<Vertex> vertexList = new List<Vertex>();
        protected List<IDictionary<Vertex,Edge>> emanatingAdjacenyList = new List<IDictionary<Vertex, Edge>>();

        protected List<Edge> edgesList = new List<Edge>();

        //private class EdgesEnumerator : IEnumerator<Edge>
        //{
        //    public EdgesEnumerator(List<Vertex> vList, List<LinkedList<Edge>> eList)
        //    {
        //        vertList = vList;
        //        adjacenyLists = eList;
        //    }
        //    public Edge Current
        //    {
        //        get
        //        {
        //            return curNode.Value;
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
        //        if (curVertexIndex == -1)
        //        {
        //            if (adjacenyLists.Count == 0)
        //                return false;
        //            int i = 0;
        //            for (i = 0; i < adjacenyLists.Count; i++)
        //            {
        //                if (adjacenyLists[i].Count != 0)
        //                    break;
        //            }
        //            if (i >= adjacenyLists.Count)
        //                return false;
        //            curVertexIndex = i;
        //            curNode = adjacenyLists[i].First;
        //            return true;
        //        }
        //        else
        //        {
        //            LinkedListNode<Edge> nextNode = curNode.Next;
        //            if (nextNode == null)
        //            {
        //                int j = 0;
        //                for (j = curVertexIndex + 1; j < adjacenyLists.Count; j++)
        //                {
        //                    if (adjacenyLists[j].Count != 0)
        //                        break;
        //                }
        //                curVertexIndex = j;
        //                if (curVertexIndex >= vertList.Count)
        //                {
        //                    return false;
        //                }
        //                else
        //                {
        //                    curNode = adjacenyLists[curVertexIndex].First;
        //                    return true;
        //                }
        //            }
        //            else
        //            {
        //                curNode = nextNode;
        //                return true;
        //            }
        //        }
        //    }
        //    public void Reset()
        //    {
        //        curVertexIndex = -1;
        //    }
        //    protected int curVertexIndex = -1;
        //    protected LinkedListNode<Edge> curNode;
        //    protected List<Vertex> vertList = null;
        //    protected List<LinkedList<Edge>> adjacenyLists = null;

        //}

        //private class EdgesEnumerable : IEnumerable<Edge>
        //{
        //    public EdgesEnumerable(EdgesEnumerator ee)
        //    {
        //        edgeEnum = ee;
        //    }

        //    public IEnumerator<Edge> GetEnumerator()
        //    {
        //        return edgeEnum;
        //    }

        //    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        //    {
        //        return GetEnumerator();
        //    }
        //    EdgesEnumerator edgeEnum;
        //}


        //private class EmanatingEdgesEnumerator : IEnumerator<Edge>
        //{
        //    public EmanatingEdgesEnumerator(LinkedList<Edge> list, Vertex vert)
        //    {
        //        vertex = vert;
        //        enumerator = list.GetEnumerator();
        //    }

        //    public Edge Current
        //    {
        //        get
        //        {
        //            return new Edge(vertex, enumerator.Current.V1);
        //        }
        //    }



        //    public void Dispose()
        //    {
        //        enumerator.Dispose();
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
        //        return enumerator.MoveNext();
        //    }

        //    public void Reset()
        //    {
        //        enumerator.Reset();
        //    }
        //    IEnumerator<Edge> enumerator = null;
        //    Vertex vertex = null;
        //}



        public IEnumerable<Edge> EmanatingEdges(Vertex vert)
        {
            if (vert.Number >= vertexList.Count)
                throw new GraphException("Trial to get emanating edges from nonexistant vertex");


            //return new EmanatingEdgesEnumerable(adjacenyLists[vert.Number], vert);


            return emanatingAdjacenyList[vert.Number].Values;
        }

        public IEnumerable<Vertex> EmanatingVertices(Vertex vert)
        {
            if (vert.Number >= vertexList.Count)
                throw new GraphException("Trial to get emanating edges from nonexistant vertex");


            //return new EmanatingEdgesEnumerable(adjacenyLists[vert.Number], vert);


            return emanatingAdjacenyList[vert.Number].Keys;
        }

        //public IEnumerable<Vertex> EmanatingVertices(Vertex vert)
        //{
        //    if (vert.Number >= vertexList.Count)
        //        throw new GraphException("Trial to get emanating edges from nonexistant vertex");


        //    //return new EmanatingEdgesEnumerable(adjacenyLists[vert.Number], vert);


        //    return emanatingAdjacenyList[vert.Number].Keys;
        //}

        //private class EmanatingEdgesEnumerable : IEnumerable<Edge>
        //{
        //    public EmanatingEdgesEnumerable(LinkedList<Edge> list, Vertex vert)
        //    {
        //        enumerator = new EmanatingEdgesEnumerator(list, vert);
        //    }

        //    public IEnumerator<Edge> GetEnumerator()
        //    {
        //        return enumerator;
        //    }
        //    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        //    {
        //        return GetEnumerator();
        //    }
        //    EmanatingEdgesEnumerator enumerator = null;
        //}



        public bool IsConnected()
        {
            CountingVisitor cv = new CountingVisitor();
            if (vertexList.Count == 0)
                return true;
            BreadthFirstTraversal(vertexList[0], cv);
            if (cv.Count == vertexList.Count)
                return true;
            return false;
        }


        public int NumberOfVertices
        {
            get
            {
                return vertexList.Count;
            }
        }
        public int NumberOfEdges
        {
            get
            {
                return numberOfEdges;
            }
        }



        public object Clone()
        {
            GraphAsList graph = new GraphAsList();

            foreach (Vertex v in vertexList)
            {
                graph.AddVertex((Vertex)v.Clone());
            }
            
            foreach (var edge in edgesList)
            {
                graph.AddEdge(edge);
            }

            return graph;
        }

        public override string ToString()
        {
            string str = "G(" + NumberOfVertices + ")= {";
            foreach (LinkedList<Edge> eList in emanatingAdjacenyList)
            {
                foreach (Edge edge in eList)
                {
                    str = str + edge;
                }
                str = str + "}";
            }
            return str;
        }


    }
    internal class CountingVisitor : Visitor<Vertex>
    {
        public void Visit(Vertex obj)
        {
            count++;
        }

        public bool HasDone()
        {
            return false;
        }

        private int count = 0;

        public int Count
        {
            get { return count; }
        }
    }
}
