/*
Попробуйте найти в массиве не один элемент, а целый подмассив!
Если подмассив найден в массиве, то вернуть нужно минимальный индекс, 
с которого начинается подмассив в исходном массиве. 
Например, поиск подмассива "3,4" в массиве "1,2,3,4,3,4" должен вернуть 2.

Более строго это можно записать, если обозначить массив array, а подмассив subarray: 
функция должна вернуть такое минимальное k, что array[k+i] == subarray[i] для 
всех i от 0 до subarray.Length-1.
Если подмассив не найден, то вернуть нужно -1.
Считайте, что пустой подмассив содержится в любом массиве, начиная с индекса 0.
Мы помогли вам и написали FindSubarrayStartIndex, оставив нереализованным всего один вспомогательный метод 
ContainsAtIndex:

Ваша задача реализовать метод ContainsAtIndex, который в нем используется.

Подсказки:
Глядя на FindSubarrayStartIndex догадайтесь, каким должен быть метод ContainsAtIndex
Результат ContainsAtIndex используется внутри if, значит должен возвращать тип bool.
Тут опять не обойтись без работы с индексами. Поэтому начинайте с цикла for.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poisk_massiva_v_massive
{
    class Program
    {
        static void Main(string[] args)
        {
            // ответ = 2
            Console.WriteLine(FindSubarrayStartIndex(new[] { 1, 2, 3, 4, 3, 4 }, 
                                                     new[] { 3, 4 }));

            // ответ = 4
            Console.WriteLine(FindSubarrayStartIndex(new[] { 1, 7, 4, 9, 5, 5, 9, 5, 5 },
                                                     new[] { 5, 5 }));

            // ответ = -1
            Console.WriteLine(FindSubarrayStartIndex(new[] { 1, 7, 4, 9, 5, 5, 9, 5, 5 },
                                                     new[] { 8, 8 }));

            Console.ReadKey();
        }

        public static int FindSubarrayStartIndex(int[] array, int[] subArray)
        {
            for (var i = 0; i < array.Length - subArray.Length + 1; i++)
                if (ContainsAtIndex(array, subArray, i))
                    return i;
            return -1;
        }

        public static bool ContainsAtIndex(int[] array, int[] subArray, int index)
        {
            foreach (var item in subArray)
            {
                if (array[index] != item)
                    return false;

                index++;
            }

            return true;
        }
    }
}