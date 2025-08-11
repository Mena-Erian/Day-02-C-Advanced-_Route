//using System.Collections;
//using System.Collections.Generic;

using System.Collections;

namespace Demo
{
    internal class Program
    {
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

            #endregion

        }
    }
}
