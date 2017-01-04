using System;
using System.Collections.Generic;

namespace csharp_graphs
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<List<int>>();

            for (var i = 0; i < 7; i++)
            {
                list.Add(new List<int>());
            }

            list[0].Add(1);
            list[0].Add(2);
            list[0].Add(3);

            list[1].Add(5);
            list[1].Add(6);

            list[2].Add(4);

            list[3].Add(2);
            list[3].Add(4);

            list[4].Add(1);

            list[6].Add(4);

            var dfs = new DFS(list);
            dfs.Traverse(0); // (0, 6) traversing stop when value is equal to 6 and prints path to this value

            Console.ReadLine();
        }
    }
}
