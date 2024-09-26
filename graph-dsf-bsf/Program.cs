using System;
using System.Collections.Generic;

namespace GraphExample
{
    public class Graph
    {
        // Dictionary untuk menyimpan adjacency list, 
        // di mana kuncinya adalah node (vertex), dan nilainya adalah daftar tetangga (neighbors).
        private Dictionary<int, List<int>> adjacencyList;

        // Konstruktor untuk menginisialisasi graph sebagai adjacency list kosong.
        public Graph()
        {
            adjacencyList = new Dictionary<int, List<int>>();
        }

        // Method untuk menambahkan edge (sisi) antara dua node (vertex dan neighbor).
        public void AddEdge(int vertex, int neighbor)
        {
            // Jika vertex belum ada dalam adjacency list, tambahkan vertex dengan tetangga kosong.
            if (!adjacencyList.ContainsKey(vertex))
            {
                adjacencyList[vertex] = new List<int>();
            }

            // Jika neighbor belum ada dalam adjacency list, tambahkan neighbor dengan tetangga kosong.
            if (!adjacencyList.ContainsKey(neighbor))
            {
                adjacencyList[neighbor] = new List<int>();
            }

            // Menambahkan neighbor ke daftar tetangga vertex (hubungkan vertex ke neighbor).
            adjacencyList[vertex].Add(neighbor);
        }

        // Method untuk mencetak adjacency list (menunjukkan semua node dan tetangganya).
        public void PrintGraph()
        {
            foreach (var vertex in adjacencyList)
            {
                // Cetak node (vertex).
                Console.Write(vertex.Key + " -> ");

                // Cetak setiap tetangga (neighbor) dari node tersebut.
                foreach (var neighbor in vertex.Value)
                {
                    Console.Write(neighbor + " ");
                }
                Console.WriteLine(); // Pindah ke baris berikutnya setelah mencetak semua tetangga.
            }
        }

        // Method untuk memulai penelusuran DFS dari node tertentu.
        public void DFS(int start)
        {
            // Menggunakan HashSet untuk melacak node yang sudah dikunjungi agar tidak berulang.
            HashSet<int> visited = new HashSet<int>();

            // Panggil fungsi rekursif DFSUtil untuk memulai penelusuran.
            DFSUtil(start, visited);
        }

        // Fungsi utilitas untuk penelusuran DFS secara rekursif.
        private void DFSUtil(int vertex, HashSet<int> visited)
        {
            // Tandai node saat ini sebagai dikunjungi.
            visited.Add(vertex);
            Console.Write(vertex + " "); // Cetak node yang sedang dikunjungi.

            // Kunjungi semua tetangga dari vertex yang belum dikunjungi.
            foreach (var neighbor in adjacencyList[vertex])
            {
                if (!visited.Contains(neighbor))
                {
                    DFSUtil(neighbor, visited); // Panggil DFS secara rekursif untuk tetangga.
                }
            }
        }

        // Method untuk memulai penelusuran BFS dari node tertentu.
        public void BFS(int start)
        {
            // Menggunakan HashSet untuk melacak node yang sudah dikunjungi agar tidak berulang.
            HashSet<int> visited = new HashSet<int>();

            // Queue untuk melacak node yang harus diproses.
            Queue<int> queue = new Queue<int>();

            // Tandai node awal sebagai dikunjungi dan tambahkan ke queue.
            visited.Add(start);
            queue.Enqueue(start);

            // Lakukan penelusuran selama queue tidak kosong.
            while (queue.Count > 0)
            {
                // Ambil node dari depan queue dan proses.
                int vertex = queue.Dequeue();
                Console.Write(vertex + " "); // Cetak node yang sedang diproses.

                // Kunjungi semua tetangga dari vertex yang belum dikunjungi.
                foreach (var neighbor in adjacencyList[vertex])
                {
                    if (!visited.Contains(neighbor))
                    {
                        visited.Add(neighbor); // Tandai sebagai dikunjungi.
                        queue.Enqueue(neighbor); // Tambahkan ke queue untuk diproses.
                    }
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Inisialisasi objek graph.
            Graph graph = new Graph();

            // Menambahkan edges ke graph.
            graph.AddEdge(1, 2);
            graph.AddEdge(1, 3);
            graph.AddEdge(2, 4);
            graph.AddEdge(3, 5);
            graph.AddEdge(4, 6);
            graph.AddEdge(5, 6);

            // Menampilkan adjacency list dari graph.
            Console.WriteLine("Graph Adjacency List:");
            graph.PrintGraph();

            // Melakukan DFS mulai dari node 1.
            Console.WriteLine("\nDFS Traversal starting from node 1:");
            graph.DFS(1);

            // Melakukan BFS mulai dari node 1.
            Console.WriteLine("\n\nBFS Traversal starting from node 1:");
            graph.BFS(1);

            Console.WriteLine();
            Console.WriteLine();
        }
    }
}