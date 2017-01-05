using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace csharp_graphs
{
    class Program
    {
        static void Main(string[] args)
        {
            /*var list = new List<List<int>>();

            for (var i = 0; i < 10; i++)
                list.Add(new List<int>());

            list[0].Add(1);
            list[0].Add(2);
            list[0].Add(3);

            list[2].Add(4);

            list[1].Add(5);
            list[1].Add(6);
            
            list[3].Add(9);
            list[3].Add(11);
            
            list[4].Add(12);

            list[6].Add(7);*/

            // DEPTH FİRST SEARCH
            /*Console.WriteLine("DEPTH FİRST SEARCH");
            var dfs = new DFS(list);
            dfs.Traverse(0);

            while (true)
            {
                Console.WriteLine("Enter search value:");
                var searchedValue = Convert.ToInt32(Console.ReadLine());
                if(searchedValue == -1) break;
                Console.WriteLine($"Searched value is in the graph: {dfs.Search(0, searchedValue)}");
            }*/

            // BREADTH FİRST SEARCH
            //var bfs = new BFS(list);
            //bfs.Traverse(0);
            var bfs = new BFS(15);

            bfs.addEdge(2, 4);
            bfs.addEdge(3, 9);
            bfs.addEdge(3, 11);
            bfs.addEdge(0, 1);
            bfs.addEdge(0, 2);
            bfs.addEdge(0, 3);
            bfs.addEdge(1, 5);
            bfs.addEdge(1, 6);
            bfs.addEdge(6, 7);
            bfs.addEdge(6, 12);

            bfs.Traverse(0);

            Console.ReadLine();
        }
    }
}
