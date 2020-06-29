/*
 Чтобы освоиться с массивами, вы с Васей решили потренироваться на простых алгоритмах. 
 Вася написал метод поиска минимума в массиве:

 static double Min(double[] array)
 {
    var min = double.MaxValue;
    foreach (var item in array)
        if (item < min) min = item;
    return min;
 }

А вам выпала задача посложнее — написать метод поиска индекса максимального элемента. 
То есть такого числа i, что array[i] — это максимальное из чисел в массиве.
Если в массиве максимальный элемент встречается несколько раз, вывести нужно минимальный индекс.
Если массив пуст, вывести нужно -1.


За основу можно взять код поиска минимума.
Вам понадобятся индексы. Поэтому нужно использовать for, а не foreach
Кроме самого значения минимума нужно запоминать в отдельной переменной ещё и его индекс
Помните, что массив может быть пустым
Длину массива можно получить так: array.Length
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indeks_maksimuma
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = new[] { 1.0, 2.0, 7.0, -1.7, 0 };

            Console.WriteLine(MaxIndex(array));

            Console.ReadKey();
        }

        /// <summary>
        /// выводит индекс максимального элемента
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static int MaxIndex(double[] array)
        {
            if (array.Length > 0)
            {
                var max = double.MinValue;
                foreach (var item in array)
                    if (item > max) max = item;

                return Array.IndexOf(array, max);
            }
            else return -1;
        }
    }
}
