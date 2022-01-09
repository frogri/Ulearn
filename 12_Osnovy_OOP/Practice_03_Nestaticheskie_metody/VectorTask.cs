/*
Вы вдруг поняли, что не очень-то удобно писать имя класса Geometry при выполнении любой операции с векторами и сегментами. 
Однако, отказаться от этого класса вы не можете, потому что за те несколько минут, 
пока вы сдавали предыдущую задачу, вашу библиотеку скачали и начали использовать в своих проектах тысячи человек.

Поэтому вы решили сохранить этот класс, но добавить методы Vector.GetLength(), 
Segment.GetLength(), Vector.Add(Vector), Vector.Belongs(Segment) и Segment.Contains(Vector) не вместо, 
а вместе с соответствующими методами класса Geometry.

Сделайте это! Каждый из этих методов должен вызывать уже существующий метод класса Geometry, чтобы не дублировать код.

Вся функциональность предыдущего этапа должна остаться!
 */

using System;

namespace GeometryTasks
{
    public class Vector
    {
        public double X;

        public double Y;

        public double GetLength()
        {
            return Geometry.GetLength(this);
        }

        public Vector Add(Vector vector)
        {
            return Geometry.Add(this, vector);
        }

        public bool Belongs(Segment segment)
        {
            return Geometry.IsVectorInSegment(this, segment);
        }
    }

    public class Segment
    {
        public Vector Begin;

        public Vector End;

        public double GetLength()
        {
            return Geometry.GetLength(this);
        }

        public bool Contains(Vector vector)
        {
            return Geometry.IsVectorInSegment(vector, this);
        }
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