// Напишите метод Min, который бы вычислял минимум из элементов массива.

using System;

namespace _04_Poisk_minimuma
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Min(new[] { 3, 6, 2, 4 }));
            Console.WriteLine(Min(new[] { "B", "A", "C", "D" }));
            Console.WriteLine(Min(new[] { '4', '2', '7' }));

            Console.ReadKey();
        }

        private static object Min(Array args)
        {
            var min = (IComparable)args.GetValue(0);
            
            foreach (var argument in args)
            {
                var comparableArgument = (IComparable)argument;
                
                if (comparableArgument.CompareTo(min) < 0)
                    min = comparableArgument;
            }

            return min;
        }
    }
}