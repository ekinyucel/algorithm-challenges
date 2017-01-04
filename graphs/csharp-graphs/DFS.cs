using System;
using System.Collections.Generic;

namespace csharp_graphs
{
    public class DFS
    {
        private static List<List<int>> _list;

        public DFS(List<List<int>> list)
        {
            _list = list;
        }

        public void Iterative(int s)
        {
            var visited = new bool[_list.Count];
            var stack = new Stack<int>();
            stack.Push(s);

            while (stack.Count != 0)
            {
                var v = stack.Pop();
                if (!visited[v])
                {
                    visited[v] = true;
                    Console.Write(v + " ");
                    var secondStack = new Stack<int>();
                    foreach (var w in _list[v])
                    {
                        if (!visited[w])
                            secondStack.Push(w);
                    }
                    while (secondStack.Count != 0)
                    {
                        stack.Push(secondStack.Pop());
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
