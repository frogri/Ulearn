using System;
using System.Collections.Generic;
using System.Linq;

namespace PocketGoogle
{
    public class Indexer : IIndexer
    {
        private readonly Dictionary<int, string> allText = new Dictionary<int, string>();
        private readonly Dictionary<int, Dictionary<int, string>> allSplittedText = new Dictionary<int, Dictionary<int, string>>();
        
        /// <summary>
        ///     Индексирует все слова в документе
        /// </summary>
        /// <param name="id">Id документа</param>
        /// <param name="documentText">Текст документа</param>
        public void Add(int id, string documentText)
        {
            allText.Add(id, documentText); // key - id документа, value - текст документа

            var separators = new[] { ' ', '.', ',', '!', '?', ':', '-', '\r', '\n' };
            var array = documentText.Split(separators);

            var dictionary = new Dictionary<int, string>(); // key - индекс слова в тексте, value - само слово

            // dictionary = array.Select((v, i) => new { Key = i, Value = v }).ToDictionary(o => o.Key, o => o.Value);
            for (var i = 0; i < array.Length; i++)
                dictionary.Add(i, array[i]);

            allSplittedText.Add(id, dictionary); // key - id документа, value - словарь с индексированными словами
        }

        /// <summary>
        ///     Ищет по слову все id документов, где оно встречается
        /// </summary>
        /// <param name="word">Ключевое слово для поиска</param>
        /// <returns>Список id документов</returns>
        public List<int> GetIds(string word)
        {
            var ids = new List<int>();

            if (string.IsNullOrEmpty(word))
                return ids;

            foreach (var dictionary in allSplittedText)
            {
                if (dictionary.Value.ContainsValue(word))
                    ids.Add(dictionary.Key);
            }

            //foreach (var pair in allText)
            //{
            //    if (pair.Value.Contains(word))
            //        ids.Add(pair.Key);
            //}

            return ids;
        }

        /// <summary>
        ///     По слову и id документа ищет все позиции, в которых слово начинается
        /// </summary>
        /// <param name="id">Id документа</param>
        /// <param name="word">Ключевое слово для поиска</param>
        /// <returns>Список позиций, в которых находится слово</returns>
        public List<int> GetPositions(int id, string word)
        {
            var positions = new List<int>();

            if (allSplittedText.ContainsKey(id))
            {
                if (allSplittedText[id].Values.Contains(word))
                {
                    positions = AllIndexesOf(allText[id], word);
                }

                //foreach (var dictionary in dict)
                //{
                //    if (dictionary.ContainsValue(word))
                //        positions = AllIndexesOf(allText[id], word);
                //}
                //if (allSplittedText.Values.)
                //{
                //}

                //positions = AllIndexesOf(allText[id], word);
            }

            return positions;
        }

        /// <summary>
        ///     Удаляет документ из индекса, после чего слова в нем искаться больше не будут
        /// </summary>
        /// <param name="id">Id документа для удаления</param>
        public void Remove(int id)
        {
            if (allText.ContainsKey(id))
                allText.Remove(id);
            
            if (allSplittedText.ContainsKey(id))
                allSplittedText.Remove(id);
        }

        private List<int> AllIndexesOf(string str, string word)
        {
            //if (string.IsNullOrEmpty(word))
            //    throw new ArgumentException("the string to find may not be empty", "value");

            var indexes = new List<int>();
            for (var index = 0;; index += word.Length)
            {
                index = str.IndexOf(word, index, StringComparison.Ordinal);
                if (index == -1)
                    return indexes;
                indexes.Add(index);
            }
        }
    }
}