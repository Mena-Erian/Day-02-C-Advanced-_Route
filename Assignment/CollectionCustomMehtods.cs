using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal static class CollectionCustomMehtods
    {
        internal static Queue<T> Reverse<T>(ref Queue<T> queue)
        {
            int queueCount = queue.Count;
            // Last In Frist OUt
            Stack<T> stack = new Stack<T>(queue.Count);

            for (int i = 0; i < queueCount; i++)
                stack.Push(queue.Dequeue());
            
            for (int i = 0; i < queueCount; i++)
                queue.Enqueue(stack.Pop());

            return queue;
        }
    }
}
