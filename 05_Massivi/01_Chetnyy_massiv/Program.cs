/*
Напишите метод, который создает массив длинной count элементов, 
содержащий последовательные четные числа в порядке возрастания.

Например, GetFirstEvenNumbers(3) должен вернуть массив 2, 4, 6

Сначала создайте массив нужного размера. Потом с помощью цикла заполните его.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chetnyy_massiv
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintArray(GetFirstEvenNumbers(3));
            PrintArray(GetFirstEvenNumbers(5));
            PrintArray(GetFirstEvenNumbers(30));
            PrintArray(GetFirstEvenNumbers(0));
            PrintArray(GetFirstEvenNumbers(1));

            Console.ReadKey();
        }

        public static int[] GetFirstEvenNumbers(int count)
        {
            int[] array = new int[count];
            for (int i = 1; i <= count; i++)
                array[i - 1] = i * 2;
            return array;
        }

        public static void PrintArray(int[] array)
        {
            foreach (var i in array)
                Console.Write(i + " ");
            Console.WriteLine();
        }
    }
}
