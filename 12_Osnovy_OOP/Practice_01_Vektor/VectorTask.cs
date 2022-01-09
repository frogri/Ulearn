/*
Создайте новый проект в Visual Studio. Выберите в качестве типа проекта Class Library.
В этом проекте создайте два класса, Vector и Geometry, в пространстве имен GeometryTasks.
В классе Vector должно быть два публичных поля, X и Y, типа double.

В классе Geometry должно быть два статических метода: GetLength, 
который возвращает длину переданного вектора, и Add, который возвращает сумму двух переданных векторов.

Оба класса разместите в одном файле. Вообще-то так обычно делать не стоит, 
но так удобнее для нашей автоматической проверки выполнения задания.
 */

using System;

namespace GeometryTasks
{
    public class Vector
    {
        public double X;

        public double Y;
    }

    public class Geometry
    {
        public static double GetLength(Vector vector)
        {
            return Math.Sqrt(vector.X * vector.X + vector.Y * vector.Y);
        }

        public static Vector Add(Vector vector1, Vector vector2)
        {
            var result = new Vector { X = vector1.X + vector2.X, Y = vector1.Y + vector2.Y };

            return result;
        }
    }
}