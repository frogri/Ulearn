/*
Ленивые методы полезны тем, что они могу генерировать последовательности до тех пор пока нам это необходимо. 
В данном упражнении реализуйте функцию, которая лениво генерирует циклическую последовательность через yield return.

Пример: При поочередном вызове метода GenerateCycle(3) должна возвращаться последовательность { 0, 1, 2, 0, 1, 2, 0, 1...}
 */

using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_Generaciya_posledovatelnosti
{
    public class Program
    {
        public static void Main(string[] args)
        {
            foreach (var number in GenerateCycle(4).Take(8))
                Console.WriteLine(number);

            Console.ReadKey();
        }

        public static IEnumerable<int> GenerateCycle(int maxValue)
        {
            var current = 0;

            while (true)
            {
                yield return current;

                current++;
                current = current < maxValue ? current : 0;
            }
        }
    }
}
