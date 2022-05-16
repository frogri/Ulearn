/*
Одно из не совсем очевидных применений SelectMany — это вычисление декартова произведения двух множеств. 
Опробуйте этот трюк на следующей задаче:

Вычислить координаты всех восьми соседей заданной точки.

Можете полагаться на то, что в классе Point переопределен метод Equals, 
сравнивающий точки покоординатно.

Подсказки:
1. Декартово произведение множества {-1, 0, 1} на себя даст все возможные относительные координаты соседей
2. Используйте вызов Select внутри вызова SelectMany
*/

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace _04_Dekartovo_proizvedenie
{
    class Program
    {
        static void Main(string[] args)
        {
            var res = GetNeighbours(new Point(1, 2));

            Console.ReadKey();
        }

        public static IEnumerable<Point> GetNeighbours(Point p)
        {
            int[] d = { -1, 0, 1 };

            // то же самое, что делает и Linq
            // var neighbours = new List<Point>();
            // foreach (var k in d)
            // {
            //    foreach (var l in d)
            //    {
            //        var neighbour = new Point(p.X + l, p.Y + k);
            //        if (!neighbour.Equals(p))
            //            neighbours.Add(neighbour);
            //    }
            // }

            return d.SelectMany(x => d.Select(y => new Point(p.X + x, p.Y + y))).Where(point => !point.Equals(p));
        }
    }
}
