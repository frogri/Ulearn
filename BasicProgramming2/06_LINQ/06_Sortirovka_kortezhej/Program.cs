/*
Еще одно полезное свойство кортежей — они реализуют интерфейс IComparable, 
сравнивающий кортежи по компонентам. То есть Tuple.Create(1, 2) будет меньше Tuple.Create(2, 1). 
Этот интерфейс по умолчанию используется в методах сортировки и поиска минимума и максимума.

Используя этот факт, решите следующую задачу.

Дан текст, нужно составить список всех встречающихся в тексте слов, 
упорядоченный сначала по возрастанию длины слова, а потом лексикографически.

Запрещено использовать ThenBy и ThenByDescending.

Подсказки:
1. Regex.Split — позволяет задать регулярное выражение для разделителей слов и получить список слов.
2. Regex.Split(s, @"\W+") разбивает текст на слова
3. Пустая строка не является корректным словом
4. keySelector в OrderBy должен возвращать ключ сортировки. Этот ключ может быть кортежем.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using NUnit.Framework;

namespace _06_Sortirovka_kortezhej
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var sorted = GetSortedWords("A box of biscuits, a box of mixed biscuits, and a biscuit mixer.");
            Assert.AreEqual(new[] { "a", "of", "and", "box", "mixed", "mixer", "biscuit", "biscuits" }, sorted);

            sorted = GetSortedWords("");
            Assert.AreEqual(0, sorted.Count);

            sorted = GetSortedWords("Each Easter Eddie eats eighty Easter eggs.");
            Assert.AreEqual(new[] { "each", "eats", "eggs", "eddie", "easter", "eighty" }, sorted);

            Console.ReadKey();
        }

        public static List<string> GetSortedWords(string text)
        {
            return Regex.Split(text.ToLower(), @"\W+")
                .Where(word => !string.IsNullOrWhiteSpace(word))
                .Distinct()
                .OrderBy(word => Tuple.Create(word.Length, word))
                .ToList();
        }
    }
}