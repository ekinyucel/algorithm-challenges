using System;
using System.Collections.Generic;

namespace csharp_graphs
{
    public class BFS
    {
        private static List<List<int>> _list;

        public BFS(List<List<int>> list)
        {
            _list = list;
        }

        public void Traverse(int s, int searchVal = -1)
        {
            var visited = new bool[_list.Count];
            var queue = new Queue<int>();
            queue.Enqueue(s);

            while (queue.Count != 0)
            {
                var v = queue.Dequeue();

                if (!visited[v])
                {
                    
                }
            }
        }
    }
}
