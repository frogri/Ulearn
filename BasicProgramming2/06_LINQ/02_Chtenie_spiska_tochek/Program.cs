/*
Теперь у вас есть список строк, в каждой из которой написаны две координаты точки (X, Y), разделенные пробелом.

Реализуйте метод ParsePoints в одно LINQ-выражение.

Постарайтесь не использовать функцию преобразования строки в число более одного раза.
 */

using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_Chtenie_spiska_tochek
{
    public class Program
    {
        public static void Main()
        {
            // Функция тестирования ParsePoints

            foreach (var point in ParsePoints(new[] { "1 -2", "-3 4", "0 2" }))
                Console.WriteLine(point.X + " " + point.Y);
            foreach (var point in ParsePoints(new List<string> { "+01 -0042" }))
                Console.WriteLine(point.X + " " + point.Y);

            Console.ReadKey();
        }

        public static List<Point> ParsePoints(IEnumerable<string> lines)
        {
            return lines
                .Select(x => x.Split(' '))
                .Select(x => x.Select(y => int.Parse(y)).ToArray())
                .Select(x => new Point(x[0], x[1]))
                .ToList();
        }

        public class Point
        {
            public int X, Y;

            public Point(int x, int y)
            {
                X = x;
                Y = y;
            }
        }
    }
}