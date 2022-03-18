/*
Необходимо реализовать функцию ZipSum с использованием yield return, 
которая принимает на вход две последовательности целых чисел и возвращает последовательность, 
состоящую из попарных сумм их элементов. Можете считать, что входные последовательности одинаковой длины.
*/

using System;
using System.Collections.Generic;

namespace _02_ZipSum
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine(string.Join(" ", ZipSum(new[] { 1 }, new[] { 0 })));
            Console.WriteLine(string.Join(" ", ZipSum(new[] { 1, 2 }, new[] { 1, 2 })));
            Console.WriteLine(string.Join(" ", ZipSum(new int[0], new int[0])));
            Console.WriteLine(string.Join(" ", ZipSum(new[] { 1, 3, 5 }, new[] { 5, 3, -1 })));

            Console.ReadKey();
        }

        private static IEnumerable<int> ZipSum(IEnumerable<int> first, IEnumerable<int> second)
        {
            var e1 = first.GetEnumerator();
            var e2 = second.GetEnumerator();
            
            while (e1.MoveNext() && e2.MoveNext())
                yield return e1.Current + e2.Current;
        }
    }
}
