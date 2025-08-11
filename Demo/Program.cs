//using System.Collections;
//using System.Collections.Generic;

using Assignment;
using System.Collections;

namespace Demo
{
    internal class Program
    {
        public static int SumOfArrayList(ArrayList numbers)
        {
            int Sum = 0;

            if (numbers is not null)
                for (int i = 0; i < numbers.Count; i++)
                    Sum += (int?)numbers[i] ?? 0;
            //             Casting From Object[ReferecneType] to int[ValueType]
            //             UnBoxing [Unsafe Casting: May Throw InvalidCast Exception]

            return Sum;
        }
        static void Main()
        {
            #region Non-Generic Collections - ArrayList

            #region Normal Array - The Base
            /// /// This Ref `Numbers` allocate 4 bytes in Stack and 
            /// /// His value = Address of first element of arr in heap
            /// int[] Numbers = new int[4] { 1, 2, 3, 4 }; /// allocate 16 bytes
            /// 
            /// // How they Access index 2 that have value = 3??!
            /// /// 2 * 4 + base Address `address in ref = address of first element of arr`
            /// Numbers[2] = 1; 
            #endregion

            #region Part 02 NonGeneric Collections - ArrayList
            //Array List 

            /// /// built on normal array of objects
            /// ArrayList numbers = new ArrayList();// Boxes and UnBoxes for value types Very Cost for Memory
            /// 
            /// Console.WriteLine($"Count = {numbers.Count}, Capacity = {numbers.Capacity}");
            /// 
            /// numbers.Add(1); // 
            /// numbers.Add(2);
            /// numbers.AddRange(new int[] { 3, 4 });
            /// Console.WriteLine($"Count = {numbers.Count}, Capacity = {numbers.Capacity}");
            /// numbers.Add(5);
            /// Console.WriteLine($"Count = {numbers.Count}, Capacity = {numbers.Capacity}");
            /// 
            /// numbers.TrimToSize(); // Free | Delete | Release | Deallocate Unused Bytes = 12 Bytes.
            /// Console.WriteLine($"Count = {numbers.Count}, Capacity = {numbers.Capacity}");

            /// ArrayList numbers = new ArrayList(10) { 1, 2, 3, 4, 5 };
            /// //numbers.Capacity = 21;
            /// 
            /// if (numbers.Capacity < 21) numbers.Capacity = 21;
            /// 
            /// for (int i = 6; i < 21; i++)
            /// {
            ///     numbers.Add(i);
            /// }
            /// 
            /// //foreach (int i in numbers) Console.WriteLine(i);
            /// 
            /// Console.WriteLine($"Count = {numbers.Count}, Capacity = {numbers.Capacity}");

            /// ArrayList Numbers01 = new ArrayList();
            /// ArrayList Numbers02 = new ArrayList();
            /// ArrayList Numbers03 = new ArrayList();
            /// ArrayList Numbers04 = new ArrayList();
            /// ArrayList Numbers05 = new ArrayList();
            /// /// when i maked this that each array that allocate empty arr
            /// /// rather than make each ref pointer to just one allocate empty arr 
            /// /// to make it StaticReadOnly arr and it maked it in List
            #endregion

            #region Part 03 NonGeneric Collections Cons
            /// ArrayList Numbers = new ArrayList(4);
            /// 
            /// Numbers.Add(1); // Casting from int[ValueType] to object[ReferenceType] --> Boxing
            /// Numbers.Add(2); // Casting from int[ValueType] to object[ReferenceType] --> Boxing
            /// Numbers.Add(3); // Casting from int[ValueType] to object[ReferenceType] --> Boxing
            /// Numbers.Add(4); // Casting from int[ValueType] to object[ReferenceType] --> Boxing
            /// Numbers.Add("Hamada");// Compiler Can't Can't Enforce Type Type Safety
            /// 
            /// /// Use Array = if we have heterogeneous[valuse with diffrente dataType] and know the size 
            /// and it fixed, so Array is a good choice
            /// 
            /// /// Use ArrayList = if you have the same case in Array but they dosn't fixed size
            /// /// So ArrayList it will be good choice
            /// 
            /// Console.WriteLine(SumOfArrayList(Numbers));///System.InvalidCastException: 'Unable to cast object of type 'System.String' to type 'System.Nullable`1[System.Int32]'.'
            #endregion

            #endregion

            #region Generic Collections - List
            /// List<int> Numbers = new List<int>(10);
            /// 
            /// Console.WriteLine($"Count = {Numbers.Count}, Capacity = {Numbers.Capacity}");
            /// 
            /// Numbers.Add(1);
            /// Numbers.Add(2);
            /// 
            /// Numbers.AddRange([3, 4]);
            /// Console.WriteLine($"Count = {Numbers.Count}, Capacity = {Numbers.Capacity}");
            /// 
            /// Numbers.Add(5);
            /// //Numbers.AddRange([6, 7, 8, 9]); // thershold //90%
            /// Console.WriteLine($"Count = {Numbers.Count}, Capacity = {Numbers.Capacity}");
            /// 
            /// Numbers.TrimExcess(); // Free | Deallocate | Release Unused Bytes = 12 Bytes
            /// Console.WriteLine($"Count = {Numbers.Count}, Capacity = {Numbers.Capacity}");

            /// List<int> numbers = new List<int>(5) { 1, 2, 3, 4 };
            /// 
            /// ///numbers[4] = 1; // Can't Used to set the non intilize values // or out of Current Count
            /// numbers.EnsureCapacity(21);

            /// Also Type Safte with Generic
            #region List Methods
            /// List<int> numbers = new List<int>(6) { 1, 2, 3, 4, 5 };

            ///numbers.Insert(0, 100);
            ///numbers.InsertRange(1, [-3,-2,-1]);

            //numbers.ConvertAll<long>(delegate (int N)
            //{
            //    N += 100;
            //    return N;
            //}).Print();

            /// numbers.Select<int, long>(i => i);
            /// numbers.CopyTo()
            /// numbers.Find((n) => n % 2 == 0).Print();
            /// numbers.FindAll((n) => n % 2 == 0).Print(); // like fileter in js
            /// numbers.FindIndex((n) => n % 2 == 0).Print();
            /// numbers.FindLast((n) => n % 2 == 0).Print();
            /// numbers.FindLastIndex((n) => n % 2 == 0).Print();

            /// numbers.Exists((n) => n % 2 == 0).Print(); // like  some() in js
            /// numbers.TrueForAll((n) => n % 2 == 0).Print(); // like every() in js

            ///numbers.ForEach((n) => { Console.WriteLine(++n); });

            /// numbers.GetRange(0, 3).Print();
            ///
            /// numbers.Print();
            ///  "----------------------------".Print();
            ///
            /// numbers.Slice(0, 3).Print();
            /// numbers.Print();
            /// "----------------------------".Print();

            /// numbers.IndexOf(2);

            /// "----------------------------".Print();
            /// IReadOnlyCollection<int> ReadOnlyCollection = numbers.AsReadOnly();
            /// foreach (int i in ReadOnlyCollection) Console.WriteLine(i);

            /// List<Employee> employees = new List<Employee>()
            /// {
            ///     new Employee(10,"Mena",5_000),
            ///     new Employee(20,"Amany",2_000),
            ///     new Employee(30,"Ahmed",8_000),
            ///     new Employee(40,"Nadia",3_000)
            /// };
            /// 
            /// ///employees.BinarySearch(new Employee() { Salary = 8000 }).Print();
            /// 
            /// employees.Sort(new EmployeeComparerByName());
            /// 
            /// employees.BinarySearch(new Employee() { Name = "Ahmed" },
            ///                     new EmployeeComparerByName()).Print();
            /// 
            /// employees.BinarySearch(1,2,new Employee() { Name = "Ahmed" },
            ///                     new EmployeeComparerByName()).Print();

            #endregion

            #endregion

            #region Generic Collections - LinkedList
            /// LinkedList<int> numbers = new LinkedList<int>();
            /// 
            /// LinkedListNode<int> firstNode = numbers.AddFirst(1);
            /// numbers.AddLast(1557);
            /// //firstNode.Next!.Value.Print();
            /// 
            /// numbers.AddAfter(firstNode, 88);
            /// numbers.AddBefore(numbers.Last ?? firstNode, 20);
            /// 
            /// numbers.Print();

            /// //String Builder it build based on linkedlist datastructre
            #endregion

            #region Generic Collections - Stack
            /// // Last In First Out
            /// Stack<int> stack = new Stack<int>();
            /// 
            /// stack.Push(1);
            /// stack.Push(2);
            /// stack.Push(3);
            /// 
            /// stack.TryPeek(out _).Print();
            /// stack.TryPeek(out _).Print();
            /// stack.TryPeek(out _).Print();
            /// stack.TryPeek(out _).Print();
            /// 
            /// stack.Clear();
            /// 
            /// /// stack.TryPop(out _).Print();
            /// /// stack.TryPop(out _).Print();
            /// /// stack.TryPop(out _).Print();
            /// /// stack.TryPop(out _).Print();
            /// "----------------".Print();
            /// stack.PrintAll<int>();
            #endregion

            #region Generic Collections - Queue
            /// // First In First Out
            /// 
            /// Queue<int> queue = new Queue<int>();
            /// 
            /// // add form the back 
            /// queue.Enqueue(1);
            /// queue.Enqueue(2);
            /// queue.Enqueue(3);
            /// 
            /// queue.PrintAll<int>();
            /// "----------------".Print();
            /// 
            /// /// queue.Dequeue().Print();
            /// /// queue.Dequeue().Print();
            /// /// queue.Dequeue().Print();
            /// /// queue.TryDequeue(out _).Print();
            /// 
            /// /// queue.Peek().Print();
            /// /// queue.Peek().Print();
            /// /// queue.Peek().Print();
            /// /// queue.TryPeek(out _).Print();
            #endregion
        }
    }
}
