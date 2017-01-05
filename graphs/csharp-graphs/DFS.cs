using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;

namespace csharp_graphs
{
    public class DFS
    {
        private static List<List<int>> _list;

        public DFS(List<List<int>> list)
        {
            _list = list;
        }

        public void Traverse(int s, int searchVal = -1)
        {
            var visited = new bool[_list.Count];
            var stack = new Stack<int>();
            stack.Push(s);

            while (stack.Count != 0)
            {
                var v = stack.Pop();

                if (v == searchVal && searchVal != -1) break;

                if (!visited[v])
                {
                    visited[v] = true;
                    Console.Write(v + " ");
                    var neighbor = new Stack<int>();

                    foreach (var w in _list[v])
                    {
                        if (!visited[w])
                            neighbor.Push(w);
                    }
                    
                    while (neighbor.Count != 0)
                    {
                        stack.Push(neighbor.Pop());
                    }
                }
            }
            Console.WriteLine();
        }

        public bool Search(int s, int data)
        {
            var visited = new bool[_list.Count];
            var stack = new Stack<int>();
            stack.Push(s);

            while (stack.Count != 0)
            {
                var v = stack.Pop();

                if (v == data) return true;

                if (!visited[v])
                {
                    visited[v] = true;
                    var neighbor = new Stack<int>();

                    foreach (var w in _list[v])
                    {
                        if (!visited[w])
                            neighbor.Push(w);
                    }

                    while (neighbor.Count != 0)
                    {
                        stack.Push(neighbor.Pop());
                    }
                }
            }
            return false;
        }
    }
}
