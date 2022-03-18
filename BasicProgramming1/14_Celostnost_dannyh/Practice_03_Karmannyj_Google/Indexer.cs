using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace PocketGoogle
{
    public class Indexer : IIndexer
    {
        // key - слово в документе, value - словарь (key - id документа, value - стартовые индексы слова в документе)
        private readonly Collector collector = new Collector();

        public Indexer()
        {
            collector.Words = new Dictionary<string, DocsIds>();
        }

        public void Add(int id, string documentText)
        {
            // разбиваем строку на слова
            var matches = Regex.Matches(documentText, @"[\wа-яА-Я]+");

            foreach (Match match in matches)
            {
                var word = match.Value;
                var wordIndex = match.Index;

                if (!collector.Words.ContainsKey(word))
                    collector.Words[word] = new DocsIds();

                if (collector.Words[word].DocumentsIds == null)
                    collector.Words[word].DocumentsIds = new Dictionary<int, WordsPositions>();
                
                if (!collector.Words[word].DocumentsIds.ContainsKey(id))
                    collector.Words[word].DocumentsIds[id] = new WordsPositions();

                if (collector.Words[word].DocumentsIds[id].StartIndexes == null)
                    collector.Words[word].DocumentsIds[id].StartIndexes = new List<int>();
                
                collector.Words[word].DocumentsIds[id].StartIndexes.Add(wordIndex);
            }
        }

        public List<int> GetIds(string word)
        {
            if (!collector.Words.TryGetValue(word, out var foundedWord))
                return new List<int>();

            return foundedWord.DocumentsIds.Keys.ToList();
        }

        public List<int> GetPositions(int id, string word)
        {
            if (!collector.Words.TryGetValue(word, out var foundedWord) || !foundedWord.DocumentsIds.ContainsKey(id))
                return new List<int>();

            return foundedWord.DocumentsIds[id].StartIndexes;
        }

        public void Remove(int id)
        {
            var docsToRemove = collector.Words.Where(item => item.Value.DocumentsIds.ContainsKey(id));

            foreach (var docToRemove in docsToRemove)
                collector.Words[docToRemove.Key].DocumentsIds.Remove(id);
        }

        public class Collector
        {
            public Dictionary<string, DocsIds> Words { get; set; }
        }

        public class DocsIds
        {
            public Dictionary<int, WordsPositions> DocumentsIds { get; set; }
        }

        public class WordsPositions
        {
            public List<int> StartIndexes { get; set; }
        }
    }
}