using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    enum ParenthesesState { Balanced = 1, NotBalanced }
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
        //Still in Prograss
        internal static bool IsParenthesesBalanced(string userInput)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char ch in userInput)
            {
                if (ch == '(')
                {
                    stack.Push(ch);
                }
                else if (ch == ')')
                {
                    if (stack.Count == 0)
                        return false; // No matching opening parenthesis
                    stack.Pop();
                }
            }

            return stack.Count == 0; // True if all parentheses are matched
        }
        internal static List<T> EliminatDuplicate<T>(ICollection<T> values) where T : IComparable<T>
        {
            List<T> list = new List<T>(values.Count);
            foreach (T item in values)
                if (!list.Contains(item)) list.Add(item);
            return list;
        }
        internal static ArrayList RemoveOddsNumbers<T>(ArrayList values) where T : INumber<T>
        {
            ArrayList list = new ArrayList(values.Count);
            foreach (T item in values)
                if (item % T.CreateChecked(2) == T.Zero) list.Add(item);
            return list;
        }
        internal static (string stateMsg, bool isFounded) Search<T>(Stack<T> values, T target) where T : IComparable<T>
        {
            int countOfStepsToFound = 0;
            bool isFounded = false;
            string stateMsg = "Target was not found";
            int lengthOfValues = values.Count;
            for (int i = 0; i < lengthOfValues; i++)
            {
                countOfStepsToFound++;
                if (values.Pop().CompareTo(target) == 0)
                {
                    stateMsg = $"Target was found successfully and the count = {countOfStepsToFound}";
                    isFounded = true;
                    return (stateMsg, isFounded);
                }
            }
            return (stateMsg, isFounded);
        }

    }
}
