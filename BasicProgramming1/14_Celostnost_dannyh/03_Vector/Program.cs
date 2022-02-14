/*
Добавьте конструктор в класс Vector.
Сделайте так, чтобы:

поля этого класса инициализировались в конструкторе.
поле Length (длина вектора), стало вычисляемым свойством.
*/

using System;

namespace _03_Vector
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Check();
            Console.ReadKey();
        }

        public static void Check()
        {
            Vector vector = new Vector(3, 4);
            Console.WriteLine(vector.ToString());

            vector.X = 0;
            vector.Y = -1;
            Console.WriteLine(vector.ToString());

            vector = new Vector(9, 40);
            Console.WriteLine(vector.ToString());

            Console.WriteLine(new Vector(0, 0).ToString());
        }

        public class Vector
        {
            public double X;
            public double Y;

            public double Length => Math.Sqrt(X * X + Y * Y);

            public Vector(double x, double y)
            {
                X = x;
                Y = y;
            }

            public override string ToString()
            {
                return string.Format("({0}, {1}) with length: {2}", X, Y, Length);
            }
        }
    }
}