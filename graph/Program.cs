namespace graph
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Graph adalah struktur data yang terdiri dari node (disebut vertices) dan hubungan antar node (disebut edges). Graph dapat berbentuk directed atau undirected.
            // Contoh (Graph Adjacency List):

            Graph graph = new Graph();
            graph.AddEdge(0, 1);
            graph.AddEdge(0, 2);
            graph.AddEdge(1, 2);
            graph.AddEdge(2, 0);
            graph.AddEdge(2, 3);
            graph.AddEdge(3, 3);

            graph.PrintGraph();
        }
    }
    public class Graph
    {
        private Dictionary<int, List<int>> adjList = new Dictionary<int, List<int>>();

        public void AddEdge(int vertex, int edge)
        {
            if (!adjList.ContainsKey(vertex))
            {
                adjList[vertex] = new List<int>();
            }
            adjList[vertex].Add(edge);
        }

        public void PrintGraph()
        {
            foreach (var vertex in adjList)
            {
                Console.Write(vertex.Key + ": ");
                foreach (var edge in vertex.Value)
                {
                    Console.Write(edge + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
