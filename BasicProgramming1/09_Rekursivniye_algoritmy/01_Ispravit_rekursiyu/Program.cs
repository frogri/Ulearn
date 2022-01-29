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

namespace _01_Ispravit_rekursiyu
{
    internal class Program
    {
        public static void WriteReversed(char[] items, int startIndex = 0)
        {
            if (items.Length <= 0)
                return;
            
            // Выводим в обратном порядке все элементы с индексом больше startIndex
            if (startIndex + 1 < items.Length)
                WriteReversed(items, startIndex + 1);

            // а потом выводим сам элемент startIndex
            Console.Write(items[startIndex]);
        }

        private static void Main(string[] args)
        {
            WriteReversed(new[] { '1', '2', '3' });
            Console.WriteLine();
            WriteReversed(new[] { '1', '2' });
            Console.WriteLine();
            WriteReversed(new[] { '1' });
            Console.WriteLine();
            WriteReversed(new char[] { });
            Console.WriteLine();
            WriteReversed(new[] { '1', '1', '2', '2', '3', '3' });
            Console.WriteLine();
            WriteReversed(new[] { '1', '2', '3', '4' });
            Console.WriteLine();
            WriteReversed(new[] { 'a', 'b', 'c', 'd' });

            Console.ReadKey();
        }
    }
}