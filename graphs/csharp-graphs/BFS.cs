using System;
using System.Collections.Generic;

namespace csharp_graphs
{
    public class BFS
    {
        private int _v;
        private static List<List<int>> _list;

        public BFS(int v)
        {
            _v = v;
            _list = new List<List<int>>();
            for(var i=0; i < v; i++)
                _list.Add(new List<int>());
        }

        public void addEdge(int v, int w)
        {
            _list[v].Add(w);
        }

        #region traverse
        public void Traverse(int s)
        {
            var visited = new bool[_v];

            for (var i = 0; i < _v; i++)
                visited[i] = false;

            var queue = new Queue<int>();
            queue.Enqueue(s);
            visited[s] = true;

            while (queue.Count != 0)
            {
                var v = queue.Dequeue();
                Console.WriteLine(v);

                foreach (var w in _list[v])
                {
                    if (!visited[w])
                    {
                        visited[w] = true;
                        queue.Enqueue(w);
                    }
                }
            }
        }
        #endregion

        #region search
        public bool Search(int s, int data)
        {
            var visited = new bool[_v];

            for (var i = 0; i < _v; i++)
                visited[i] = false;

            var queue = new Queue<int>();
            queue.Enqueue(s);
            visited[s] = true;

            while (queue.Count != 0)
            {
                var v = queue.Dequeue();

                if (v == data) return true;

                foreach (var w in _list[v])
                {
                    if (!visited[w])
                    {
                        visited[w] = true;
                        queue.Enqueue(w);
                    }
                }
            }
        }
        #endregion
    }
}
