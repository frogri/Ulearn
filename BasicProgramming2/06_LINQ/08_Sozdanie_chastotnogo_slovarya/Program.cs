/*
Частотным словарём текста называют список пар: 
для каждого слова количество раз, которое оно встретилось в тексте.

В этой задаче нужно по тексту вернуть не весь частотный словарь, 
а только count слов, встретившихся в тексте больше всего раз. 
Среди слов, встречающихся одинаково часто, 
при выводе отдавать предпочтение лексикографически меньшим словам. 
Например, если все слова в тексте встретились только по одному разу, 
то вывести нужно count лексикографически первых слов.

При этом слова сравнивайте без учёта регистра, а возвращайте в нижнем регистре.

Напомним сигнатуры некоторых LINQ-методов, которые могут понадобиться в этом упражнении:
IEnumerable<IGrouping<K, T>>    GroupBy(this IEnumerable<T> items, Func<T, K> keySelector)
IOrderedEnumerable<T>           OrderBy(this IEnumerable<T> items, Func<T, K> keySelector)
IOrderedEnumerable<T> OrderByDescending(this IEnumerable<T> items, Func<T, K> keySelector)
IOrderedEnumerable<T>            ThenBy(this IOrderedEnumerable<T> items, Func<T, K> keySelector)
IOrderedEnumerable<T>  ThenByDescending(this IOrderedEnumerable<T> items, Func<T, K> keySelector)
IEnumerable<T>                     Take(this IEnumerable<T> items, int count)
*/

using System;
using System.Linq;
using System.Text.RegularExpressions;
using NUnit.Framework;

namespace _08_Sozdanie_chastotnogo_slovarya
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var result = GetMostFrequentWords("A box of biscuits, a box of mixed biscuits, and a biscuit mixer.", 2);
            Assert.AreEqual(2, result.Length);
            Assert.AreEqual(Tuple.Create("a", 3), result[0]);
            Assert.AreEqual(Tuple.Create("biscuits", 2), result[1]);

            result = GetMostFrequentWords(string.Empty, 100);
            Assert.AreEqual(0, result.Length);

            result = GetMostFrequentWords("Each Easter Eddie eats eighty Easter eggs.", 3);
            Assert.AreEqual(3, result.Length);
            Assert.AreEqual(Tuple.Create("easter", 2), result[0]);
            Assert.AreEqual(Tuple.Create("each", 1), result[1]);
            Assert.AreEqual(Tuple.Create("eats", 1), result[2]);
        }

        public static Tuple<string, int>[] GetMostFrequentWords(string text, int count)
        {
            return Regex.Split(text, @"\W+")
                .Where(word => word != string.Empty) // разделили текст на слова
                .GroupBy(word => word.ToLower())     // разбиваем слова на группы
                .OrderByDescending(group => group.Count())  // сортируем по количеству повторений слова в тексте
                .ThenBy(group => group.Key) // дополнительно сортируем слова лексикографически (требуется, если кол-во повторений слов в тексте совпадает) 
                .Select(group => Tuple.Create(group.Key, group.Count()))    // создаем новую форму Tuple, ожидаемый на выходе из метода
                .Take(count)    // вернуть из IEnumerable элементы в кол-ве count
                .ToArray();
        }
    }
}