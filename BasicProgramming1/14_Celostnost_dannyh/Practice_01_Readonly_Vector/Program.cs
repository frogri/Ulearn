/*Помните класс ReadOnlyVector из позапрошлой практики?
 Скорее всего, он был написан ужасно, с открытыми полями и всем прочим.

Как правило, такие структуры данных делают read-only.

В пространстве имен ReadOnlyVectorTask сделайте класс ReadOnlyVector 
с двумя публичными readonly-полями X и Y, которые устанавливаются в конструкторе.

ReadOnlyVector должен содержать метод Add(ReadOnlyVector other), 
который возвращает сумму векторов.

При работе с readonly классами часто хочется изготовить вектор "такой же, 
но с другим значением поля X или Y". 
Обеспечьте такую функциональность с помощью методов WithX(double) и WithY(double)
*/

using System;

namespace ReadOnlyVectorTask
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
            var vector = new ReadOnlyVector(3, 4);
            Console.WriteLine(vector);
            Console.WriteLine(vector.WithX(1));
            Console.WriteLine(vector.WithY(2));
            var result = vector.Add(new ReadOnlyVector(2, 6));

            Console.WriteLine(result);
        }

        public class ReadOnlyVector
        {
            public readonly double X;
            public readonly double Y;

            public ReadOnlyVector(double x, double y)
            {
                X = x;
                Y = y;
            }

            public ReadOnlyVector Add(ReadOnlyVector other)
            {
                return new ReadOnlyVector(X + other.X, Y + other.Y);
            }

            public ReadOnlyVector WithX(double newX)
            {
                return new ReadOnlyVector(newX, Y);
            }

            public ReadOnlyVector WithY(double newY)
            {
                return new ReadOnlyVector(X, newY);
            }

            public override string ToString()
            {
                return string.Format("({0}, {1})", X, Y);
            }
        }
    }
}