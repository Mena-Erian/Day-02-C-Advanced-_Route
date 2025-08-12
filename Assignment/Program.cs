using System.Collections;
using System.Globalization;

namespace Assignment
{
    internal class Program
    {
        static void Main()
        {
            #region 1. Get The Output Of Query From User
            /// // Get Meta Data From User
            /// List<int> sizeAndQuerey = Helper.GetArrFormUser<int>(
            ///                                      "Size of Array and number of Queries, separat with Space",
            ///                                     2, Helper.DefaultformatProvider);
            /// List<int> numbers = Helper.GetArrFormUser<int>("Values of Array, separat with Space", sizeAndQuerey[0], Helper.DefaultformatProvider);
            /// 
            /// // Get Quereis From USER
            /// int[] quereis = new int[sizeAndQuerey[1]];
            /// Console.WriteLine("Enter the Queries: "); // I Keeped this To Guid the User (You Can Commit it to get the same output)
            /// for (int i = 0; i < sizeAndQuerey[1]; i++)
            ///     quereis[i] = Helper.GetIntFromUserUsingTryParse();
            /// 
            /// // OutPut to User
            /// for (int i = quereis.Length - 1; i >= 0; i--)
            /// {
            ///     int Count = 0;
            ///     foreach (int n in numbers) // [ 11 5 3 ]
            ///     {
            ///         if (quereis[i] > n) Count++;
            ///     }
            ///     //quereis[i] = Count;
            ///     $"Qurey[{i}] ({quereis[i]}): {Count} ".Print();
            /// }
            #endregion

            #region 2. Given a number N and an array of N numbers. Determine if it's palindrome or not
            /// int N = Helper.GetIntFromUserUsingTryParse("Number of Array Size");
            /// List<int> arr = Helper.GetArrFormUser<int>(N, AlertType.boolean, Helper.DefaultformatProvider);
            #endregion

            #region 3. Given a Queue, implement a function to reverse the elements of a queue using a stack.
            /// //First In First Out
            /// Queue<int> queue = new Queue<int>();
            /// queue.Enqueue(1);
            /// queue.Enqueue(2);
            /// queue.Enqueue(3);
            /// 
            /// CollectionCustomMehtods.Reverse(ref queue);
            /// 
            /// queue.PrintAll<int>();
            #endregion

            #region 4. Given a Stack, implement a function to check if a string of parentheses is balanced using a stack.
            //Still Not DONE
            /// string parentheses = Helper.GetStringFromUser("The parentheses");
            /// 
            /// CollectionCustomMehtods.IsParenthesesBalanced(parentheses).Print();
            #endregion

            #region 5. Given an array, implement a function to remove duplicate elements from an array.
            /// int[] numbers = { 1, 2, 3, 4, 5, 4, 5, 6, 5, 7, 8, 9, 10, 3 };
            /// numbers = CollectionCustomMehtods.EliminatDuplicate(numbers).ToArray();
            /// numbers.PrintAll();
            #endregion

            #region 6. Given an array list , implement a function to remove all odd numbers from it.
            /// ArrayList numbers = new ArrayList { 1, 2, 3, 4, 5, 4, 5, 6, 5, 7, 8, 9, 10, 3 };
            /// 
            /// numbers = CollectionCustomMehtods.RemoveOddsNumbers<int>(numbers);
            /// numbers.PrintAll<int>();
            #endregion

        }
    }
}
