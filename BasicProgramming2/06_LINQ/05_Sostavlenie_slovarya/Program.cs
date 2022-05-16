/*
Текст задан массивом строк. 
Вам нужно составить лексикографически упорядоченный список всех встречающихся в этом тексте слов.

Слова нужно сравнивать регистронезависимо, а выводить в нижнем регистре.
*/

using System;
using System.Linq;

namespace _05_Sostavlenie_slovarya
{
    internal class Program
    {
        public static void Main()
        {
            var vocabulary = GetSortedWords("Hello, hello, hello, how low",
                                            string.Empty,
                                            "With the lights out, it's less dangerous",
                                            "Here we are now; entertain us",
                                            "I feel stupid and contagious",
                                            "Here we are now; entertain us",
                                            "A mulatto, an albino, a mosquito, my libido...",
                                            "Yeah, hey");
            foreach (var word in vocabulary)
                Console.WriteLine(word);

            Console.ReadKey();
        }

        public static string[] GetSortedWords(params string[] textLines)
        {
            return textLines
                .SelectMany(line => line.Split(',', ';', ' ', '.', '\''))
                .Where(word => !string.IsNullOrWhiteSpace(word))
                .Select(word => word.ToLower())
                .Distinct()
                .OrderBy(word => word)
                .ToArray();
        }
    }
}