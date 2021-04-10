/*
Вася решил, что изучать рекурсию нужно на простых примерах и начал c программы, 
печатающей все элементы массива в обратном порядке.

Как это сделать рекурсивно? Очень просто: сначала решить задачу, для всего массива, 
кроме первого элемента, а потом вывести первый элемент.

Идея проста, но в реализации что-то пошло не так. Видимо, Вася упустил какую-то важную деталь.

Найдите ошибку Васи и помогите ему исправить программу. Естественно, программа 
должна остаться рекурсивной, ведь именно в этом смысл упражнения!
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Ispravit_rekursiyu
{
    class Program
    {
        public static void WriteReversed(char[] items, int startIndex = 0)
        {
            // Выводим в обратном порядке все элементы с индексом больше startIndex
            if (items.Length > 0)
            {
                if (startIndex + 1 < items.Length)
                    WriteReversed(items, startIndex + 1);
                // а потом выводим сам элемент startIndex
                Console.Write(items[startIndex]);
            }
        }

        static void Main(string[] args)
        {
            WriteReversed(new char[] { '1', '2', '3' });
            Console.WriteLine();
            WriteReversed(new char[] { '1', '2' });
            Console.WriteLine();
            WriteReversed(new char[] { '1' });
            Console.WriteLine();
            WriteReversed(new char[] { });
            Console.WriteLine();
            WriteReversed(new char[] { '1', '1', '2', '2', '3', '3' });
            Console.WriteLine();
            WriteReversed(new char[] { '1', '2', '3', '4' });
            Console.WriteLine();
            WriteReversed(new char[] { 'a', 'b', 'c', 'd' });

            Console.ReadKey();
        }
    }
}
