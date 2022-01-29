/*
Продолжаем разработку геометрической библиотеки.

Создайте класс Segment, представляющий отрезок прямой. 
Концы его отрезков должны задаваться двумя публичными полями: Begin и End типа Vector.

Добавьте метод Geometry.GetLength, вычисляющий длину сегмента, 
и метод Geometry.IsVectorInSegment(Vector, Segment), проверяющий, что задаваемая вектором точка лежит в отрезке.

Сохраните функциональность предыдущего этапа.
 */

using System;

namespace GeometryTasks
{
    public class Vector
    {
        public double X;

        public double Y;
    }

    public class Segment
    {
        public Vector Begin;

        public Vector End;
    }

    public class Geometry
    {
        public static double GetLength(Vector vector)
        {
            return Math.Sqrt(vector.X * vector.X + vector.Y * vector.Y);
        }

        public static double GetLength(Segment segment)
        {
            var differenceX = segment.End.X - segment.Begin.X;
            var differenceY = segment.End.Y - segment.Begin.Y;

            return Math.Sqrt(differenceX * differenceX + differenceY * differenceY);
        }

        public static Vector Add(Vector vector1, Vector vector2)
        {
            return new Vector {X = vector1.X + vector2.X, Y = vector1.Y + vector2.Y};
        }

        public static bool IsVectorInSegment(Vector vector, Segment segment)
        {
            var distance = GetLength(segment);

            // Точка принадлежит отрезку, если сумма расстояний от этой точки до конечных точек отрезка равна длине отрезка.
            var distance1 = GetLength(new Segment {Begin = segment.Begin, End = vector});
            var distance2 = GetLength(new Segment {Begin = vector, End = segment.End});

            return Math.Abs(distance - (distance1 + distance2)) < 0.0000001;
        }
    }
}