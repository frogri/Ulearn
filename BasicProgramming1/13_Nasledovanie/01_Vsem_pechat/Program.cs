// Напишите метод, который печатает все, что угодно, через запятую.

using System;

namespace _01_Vsem_pechat
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Print(1, 2);
            Print("a", 'b');
            Print(1, "a");
            Print(true, "a", 1);

            Console.ReadKey();
        }

        public static void Print(params object[] elements)
        {
            for (var i = 0; i < elements.Length; i++)
            {
                if (i > 0)
                    Console.Write(", ");
                Console.Write(elements[i]);
            }

            Console.WriteLine();
        }
    }
}
