/*
Напишите функцию Combine, комбинирующую действие двух своих аргументов, 
чтобы ее можно было использовать вот так:

Подсказка:
1. Функция должна лямбда-выражение, совместимое с типом Func<T1, T3>
 */

using System;

namespace _04_Sintaksis_lyambd_2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Func<double, int> round = x => (int)Math.Round(x);
            Func<int, string> toString = x => x.ToString("X"); // hex
            var f1 = Combine(round, toString);
            Console.WriteLine(f1(3.14)); // 3
            Console.WriteLine(f1(10.9)); // B 

            Func<int, int> minusOne = x => x - 1;
            Func<int, int> doubleValue = x => 2 * x;
            var f2 = Combine(minusOne, doubleValue);
            Console.WriteLine(f2(2)); // 2
            Console.WriteLine(f2(5)); // 8

            Console.ReadKey();
        }

        static Func<T1, T3> Combine<T1, T2, T3>(Func<T1, T2> f, Func<T2, T3> g)
        {
            return x => g(f(x));
        }
    }
}