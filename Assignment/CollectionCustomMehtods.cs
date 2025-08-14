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
        internal static List<T> EliminatDuplicate<T>(ICollection<T> values, out Dictionary<T, int> DublicatedElemnts) where T : IComparable<T>
        {
            List<T> list = new List<T>(values.Count);
            DublicatedElemnts = new Dictionary<T, int>(values.Count / 2);
            bool isAdded = false;
            foreach (T item in values)
            {
                if (!list.Contains(item)) list.Add(item);
                isAdded = DublicatedElemnts.TryAdd(item, 1);
                if (isAdded == false) DublicatedElemnts[item] += 1;
            }
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
        internal static int GetLessCount<T>(ICollection<T> arr1, ICollection<T> arr2, out ICollection<T> bigestCount)
        {
            if (arr1.Count.CompareTo(arr2.Count) == -1)
            {
                bigestCount = arr2;
                return arr1.Count;
            }
            else
            {
                bigestCount = arr1;
                return arr2.Count;
            }
        }
        static void DictionaryRemoveAt<TKey, TValue>(this Dictionary<TKey, TValue> dictionary, TKey key)
         => dictionary?.Remove(key);
        public static Dictionary<TKey, TValue> SortDictionaryByKey<TKey, TValue>(this Dictionary<TKey, TValue> dic)
        {
            Dictionary<TKey, TValue> Result = new Dictionary<TKey, TValue>(dic.Count);
            List<TKey> Keys = new List<TKey>(dic.Keys);
            Keys.Sort();

            foreach (TKey key in Keys)
            {
                dic.TryGetValue(key, out TValue value);
                Result.Add(key, value);
            }
            return Result;
        }
        static Dictionary<Tkey, int> GetLessRowByLessValueHaveSamePosition<Tkey>(Dictionary<Tkey, int> dic1, Dictionary<Tkey, int> dic2)
        {
            GetLessCount(dic1, dic2, out /*ICollection<KeyValuePair<Tkey, int>>*/ var bigestDicCount);
            Dictionary<Tkey, int> Result = new Dictionary<Tkey, int>(bigestDicCount.Count);

            foreach (var kvp in dic1) Result.Add(kvp.Key, kvp.Value);

            foreach (var Kvp in dic2) Result[Kvp.Key] = Result[Kvp.Key] < dic2[Kvp.Key] ? Result[Kvp.Key] : dic2[Kvp.Key];

            return Result;
        }
        internal static ICollection<Tkey> GenerateCollectionByDictionary<Tkey>(Dictionary<Tkey, int> dic)
        {
            ICollection<Tkey> Result = new List<Tkey>(dic.Values.Sum());
            foreach (var kvp in dic)
            {
                for (int i = 0; i < kvp.Value; i++) Result.Add(kvp.Key);
            }
            return Result;
        }
        internal static  ICollection<T> GetIntersection<T>(ICollection<T> arr1, ICollection<T> arr2) where T : IComparable<T>
        {
            
            EliminatDuplicate<T>(arr1, out Dictionary<T, int> DublicatedElemntsArr1);
            EliminatDuplicate<T>(arr2, out Dictionary<T, int> DublicatedElemntsArr2);

            foreach (var item in DublicatedElemntsArr1)
            {
                if (item.Value == 1) DublicatedElemntsArr1.DictionaryRemoveAt(item.Key);
            }
            foreach (var item in DublicatedElemntsArr2)
            {
                if (item.Value == 1) DublicatedElemntsArr2.DictionaryRemoveAt(item.Key);
            }

            DublicatedElemntsArr1 = DublicatedElemntsArr1.SortDictionaryByKey();
            DublicatedElemntsArr2 = DublicatedElemntsArr2.SortDictionaryByKey();

            Dictionary<T, int> DictionaryResult = GetLessRowByLessValueHaveSamePosition(DublicatedElemntsArr1, DublicatedElemntsArr2);

            return GenerateCollectionByDictionary<T>(DictionaryResult);

           /// // Final Output = [2, 2, 5, 5]
           ///
           /// //DictionaryResult = [2, 2]
           /// ///                  [5, 2]
           ///
           /// DublicatedElemntsArr1.PrintAll();
           /// "-------------------------------------".Print();
           /// DublicatedElemntsArr2.PrintAll();
           /// "-------------------------------------".Print();
           /// DictionaryResult.PrintAll();
        }
    }
}
