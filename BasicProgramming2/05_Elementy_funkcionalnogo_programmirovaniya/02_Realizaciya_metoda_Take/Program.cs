// Реализуйте метод Take с использованием yield return,
// который принимает на вход последовательность source и число count,
// а возвращает последовательность только из первых count элементов source.

// Если source содержит меньше count элементов, то вернуть нужно все элементы source.
// Подсказки
// 1. Take считается недостаточно ленивым даже если он извлекает из source всего один лишний элемент.
// 2. foreach в начале каждой итерации извлекает из source очередной элемент, чтобы сложить его в переменную цикла.

using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace _02_Realizaciya_metoda_Take
{
    internal class Program
    {
        public static void Main()
        {
            Func<int[], int, string> take = (source, count) => string.Join(" ", Take(source, count));

            Assert.AreEqual("1 2", take(new[] { 1, 2, 3, 4 }, 2));
            Assert.AreEqual("4", take(new[] { 4 }, 1));
            Assert.AreEqual("", take(new[] { 5 }, 0));

            var num = new Random().Next(0, 1000);
            Assert.AreEqual(num.ToString(), take(new[] { num }, 100500));

            //CheckLazyness();
            Console.WriteLine("OK");
        }

        private static IEnumerable<T> Take<T>(IEnumerable<T> source, int count)
        {
            if (count == 0)
                yield break;

            var i = 0;

            foreach (var item in source)
            {
                i++;
                yield return item;

                if (i >= count)
                    yield break;
            }
        }
    }
}
