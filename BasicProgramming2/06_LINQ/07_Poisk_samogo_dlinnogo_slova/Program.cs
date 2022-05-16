/*
Дан список слов, нужно найти самое длинное слово из этого списка, 
а из всех самых длинных — лексикографически первое слово.

Решите эту задачу в одно выражение.

Не используйте методы сортировки — сложность сортировки O(N * log(N)), 
однако эту задачу можно решить за O(N).

Подсказки:
1. Вспомните про кортежи
2. Вспомните про особенности сравнения кортежей
*/

using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace _07_Poisk_samogo_dlinnogo_slova
{
    internal class Program
    {
        public static void Main()
        {
            var result = GetLongest(new[] { "azaz", "as", "sdsd" });
            Assert.AreEqual("azaz", result);

            result = GetLongest(new[] { "zzzz", "as", "sdsd" });
            Assert.AreEqual("sdsd", result);

            result = GetLongest(new[] { "as", "12345", "as", "sds" });
            Assert.AreEqual("12345", result);
        }

        public static string GetLongest(IEnumerable<string> words)
        {
            // Почему отрицательное выражение даёт лексикографическую сортировку?
            // Сортируем длину по убыванию, а лексикографически по возрастанию. Потому перед длиной минус.
            return words.Min(word => Tuple.Create(-word.Length, word))
                .Item2;
        }
    }
}