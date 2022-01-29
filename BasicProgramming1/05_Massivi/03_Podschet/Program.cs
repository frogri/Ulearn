/*
На этот раз вы с Васей наперегонки решаете одну задачу — 
найти количество вхождений заданного числа в массив чисел.

Например, в массиве 1, 2, 1, 1 число 1 встречается 3 раза.


Используйте foreach в связке с if.
Введите вспомогательную переменную для хранения количества уже найденных вхождений itemToFind
В этой задаче индексы не нужны, поэтому подойдёт foreach
Заведите ещё одну переменную, чтобы в ней считать ответ
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podschet
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new[] { 1, 3, 6, 2, 2, 8, 1, 1, 1, 9, 0 };
            Console.WriteLine(GetElementCount(array, 1));

            Console.ReadKey();
        }

        /// <summary>
        /// находит количество вхождений заданного числа в массив чисел
        /// </summary>
        /// <param name="items">массив чисел</param>
        /// <param name="itemToCount">число, количество вхождений которого в массив необходимо определить</param>
        /// <returns></returns>
        public static int GetElementCount(int[] items, int itemToCount)
        {
            int itemToFind = 0;
            foreach (var e in items)
            {
                if (e == itemToCount)
                    itemToFind++;
            }
            return itemToFind;
        }
    }
}
