/*
 * Помните задачу нахождения максимума в массиве?
 * Пришло время повторить ее для общего случая!
 */

using System;
using System.Collections;
using System.Globalization;

namespace _01_Maksimum_v_massive
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine(Max(new int[0]));
            Console.WriteLine(Max(new[] { 3 }));
            Console.WriteLine(Max(new[] { 3, 1, 2 }));
            Console.WriteLine(Max(new[] { "A", "B", "C" }));

            Console.ReadKey();
        }

        static T Max<T>(T[] source) where T : IComparable
        {
            if (source.Length == 0)
                return default;

            var max = source[0];

            for (var i = 1; i < source.Length; i++)
            {
                if (source[i].CompareTo(max) > 0) 
                    max = source[i];
            }

            return max;
        }
    }
}