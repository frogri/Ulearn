using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace PocketGoogle
{
    public class Indexer : IIndexer
    {
        // key - слово в документе, value - словарь (key - id документа, value - стартовые индексы слова в документе)
        private readonly IDictionary<string, Dictionary<int, List<int>>> documents;

        public Indexer()
        {
            documents = new Dictionary<string, Dictionary<int, List<int>>>();  
        }

        public void Add(int id, string documentText)
        {
            // разбиваем строку на слова
            var matches = Regex.Matches(documentText, @"[\wа-яА-Я]+");

            foreach (Match match in matches)
            {
                if (!documents.ContainsKey(match.Value))
                    documents[match.Value] = new Dictionary<int, List<int>>();

                if (!documents[match.Value].ContainsKey(id))
                    documents[match.Value][id] = new List<int>();

                documents[match.Value][id].Add(match.Index);
            }
        }

        public List<int> GetIds(string word)
        {
            if (!documents.TryGetValue(word, out var value))
                return new List<int>();

            return value.Keys.ToList();
        }

        public List<int> GetPositions(int id, string word)
        {
            if (!documents.TryGetValue(word, out var value) || !value.ContainsKey(id))
                return new List<int>();

            return value[id];
        }

        public void Remove(int id)
        {
            var documentsToRemove = documents.Where(item => item.Value.ContainsKey(id));

            foreach (var documentToRemove in documentsToRemove)
                documents[documentToRemove.Key].Remove(id);
        }
    }
}