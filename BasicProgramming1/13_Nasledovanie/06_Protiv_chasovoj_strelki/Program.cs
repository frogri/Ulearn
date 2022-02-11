/*А как насчет того, чтобы отсортировать точки в порядке следования против часовой стрелки,
 считая первой ту, что находится на 3:00? */

using System;
using System.Collections;

namespace _06_Protiv_chasovoj_strelki
{
    public class Program
    {
        public static void Main()
        {
            var array = new[]
            {
                new Point { X = 1, Y = 0 },
                new Point { X = -1, Y = 0 },
                new Point { X = 0, Y = 1 },
                new Point { X = 0, Y = -1 },
                new Point { X = 0.01, Y = 1 }
            };
            
            Array.Sort(array, new ClockwiseComparer());
            
            foreach (var e in array)
                Console.WriteLine("{0} {1}", e.X, e.Y);

            Console.ReadKey();
        }
    }

    public class Point
    {
        public double X;
        
        public double Y;
    }

    public class ClockwiseComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            var point1 = x as Point;
            var point2 = y as Point;

            var angle1 = Adding2PiIfNegative(Math.Atan2(point1.Y, point1.X));
            var angle2 = Adding2PiIfNegative(Math.Atan2(point2.Y, point2.X));

            return angle1.CompareTo(angle2);
        }

        private double Adding2PiIfNegative(double angle)
        {
            return angle < 0 ? angle + Math.PI * 2 : angle;
        } 
    }
}