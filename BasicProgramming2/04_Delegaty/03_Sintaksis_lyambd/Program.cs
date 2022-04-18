/*
Поупражняйтесь в создании лямбда-выражений

Подсказки
Лямбда-выражения нужно присвоить полям класса, как это показано в шаблоне
Лямбда-выражение от нуля аргументов имеет вид () => ...
Лямбда-выражение от нескольких аргументов имеет вид (a, b, c, d) => ...
 */

using System;

namespace _03_Sintaksis_lyambd
{
    internal class Program
    {
        private static readonly Func<int> zero = () => 0;
        private static readonly Func<int, string> toString = x => x.ToString();
        private static readonly Func<double, double, double> add = (x, y) => x + y;
        private static readonly Action<string> print = s => Console.WriteLine(s);

        private static void Main(string[] args)
        {

        }
    }
}