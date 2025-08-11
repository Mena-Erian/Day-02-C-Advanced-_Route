using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public static class Helper
    {
        //public static void Print<T>(this T value) => Console.WriteLine(value);
        public static void Print<T>(this IEnumerable<T> values) where T : IEnumerable
        {
            foreach (T item in values) Console.WriteLine(item);
        }
        /// public static void Print<T>(this List<T> values)
        /// {
        ///     foreach (T item in values) Console.WriteLine(item);
        /// }
        public static void Print<T>(this ICollection<T> values)
        {
            foreach (T item in values) Console.WriteLine(item);
        }

    }
}
