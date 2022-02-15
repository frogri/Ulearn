using System;
using System.Collections.Generic;
using System.Linq;

namespace PocketGoogle
{
    public class Indexer : IIndexer
    {
        public void Add(int id, string documentText)
        {
            var separators = new[] { ' ', '.', ',', '!', '?', ':', '-', '\r', '\n' };
            var array = documentText.Split(separators);

            //var result = array.Where(s => !string.IsNullOrEmpty(s)).ToDictionary(id, item);

            throw new NotImplementedException();
        }

        public List<int> GetIds(string word)
        {
            throw new NotImplementedException();
        }

        public List<int> GetPositions(int id, string word)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }
    }
}