// Помните задачу "Среднее трех"? Пришло время повторить ее для общего случая!

using System;

namespace _03_Snova_srednee_trekh
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(MiddleOfThree(2, 5, 4));
            Console.WriteLine(MiddleOfThree(3, 1, 2));
            Console.WriteLine(MiddleOfThree(3, 5, 9));
            Console.WriteLine(MiddleOfThree("B", "Z", "A"));
            Console.WriteLine(MiddleOfThree(3.45, 2.67, 3.12));

            Console.ReadKey();
        }

        private static IComparable MiddleOfThree(IComparable a, IComparable b, IComparable c)
        {
            if ((a.CompareTo(b) > 0 && a.CompareTo(c) < 0) 
                || (a.CompareTo(c) > 0 && a.CompareTo(b) < 0))
            {
                return a;
            }

            if ((b.CompareTo(a) > 0 && b.CompareTo(c) < 0)
                || (b.CompareTo(c) > 0 && b.CompareTo(a) < 0))
            {
                return b;
            }

            return c;
        }
    }
}
