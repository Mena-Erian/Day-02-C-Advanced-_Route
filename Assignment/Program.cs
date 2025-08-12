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

        }
    }
}
