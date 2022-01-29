// Разделять текст на предложения, а предложения на слова.
// a. Считайте, что слова состоят только из букв (используйте метод char.IsLetter) или символа апострофа ' и отделены друг от друга любыми другими символами.
// b. Предложения состоят из слов и отделены друг от друга одним из следующих символов .!?;:()
// Приводить символы каждого слова в нижний регистр.
// Пропускать предложения, в которых не оказалось слов.
// Метод должен возвращать список предложений, где каждое предложение — это список из одного или более слов в нижнем регистре. */

using System;
using System.Collections.Generic;

namespace TextAnalysis
{
    internal static class SentencesParserTask
    {
        public static List<List<string>> ParseSentences(string text)
        {
            var sentencesList = new List<List<string>>();
            var sentencesDelimiters = new[]
            {
                '.',
                '!',
                '?',
                ';',
                ':',
                '(',
                ')'
            };
            
            var array = text.ToLower().Split(sentencesDelimiters);

            foreach (var str in array)
            {
                var wordsList = FillWordsList(str);

                if (wordsList.Count > 0)
                    sentencesList.Add(wordsList);
            }

            return sentencesList;
        }

        private static List<string> FillWordsList(string str)
        {
            var wordsList = new List<string>();
            var delimiters = new List<char>();

            foreach (var symbol in str)
            {
                if (!char.IsLetter(symbol) && !symbol.Equals('\''))
                    delimiters.Add(symbol);
            }

            var words = str.Split(delimiters.ToArray(), StringSplitOptions.RemoveEmptyEntries);

            if (words.Length != 0)
                wordsList.AddRange(words);

            return wordsList;
        }
    }
}