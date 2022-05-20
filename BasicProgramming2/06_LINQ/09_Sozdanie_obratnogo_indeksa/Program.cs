/*
Обратный индекс — это структура данных, 
часто использующаяся в задачах полнотекстового поиска нужного документа в большой базе документов.

По своей сути обратный индекс напоминает индекс в конце бумажных энциклопедий, 
где для каждого ключевого слова указан список страниц, где оно встречается.

Вам требуется по списку документов построить обратный индекс.

Документ определен в классе Document.

Обратный индекс в нашем случае — это словарь ILookup<string, int>, 
ключом в котором является слово, а значениями — идентификаторы всех документов, содержащих это слово.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using NUnit.Framework;

namespace _09_Sozdanie_obratnogo_indeksa
{
    public class Document
    {
        public int Id;
        public string Text;
    }

    public class Program
    {
        public static void Main()
        {
            Document[] documents =
            {
                new Document { Id = 1, Text = "Hello world!" },
                new Document { Id = 2, Text = "World, world, world... Just words..." },
                new Document { Id = 3, Text = "Words — power" },
                new Document { Id = 4, Text = string.Empty }
            };

            var index = BuildInvertedIndex(documents);

            Assert.That(index["world"], Is.EquivalentTo(new[] { 1, 2 }));
            Assert.That(index["words"], Is.EquivalentTo(new[] { 2, 3 }));
            Assert.That(index["power"], Is.EquivalentTo(new[] { 3 }));
            Assert.That(index["cthulhu"], Is.Empty);
            Assert.That(index[""], Is.Empty);
        }

        public static ILookup<string, int> BuildInvertedIndex(Document[] documents)
        {
            // решение без LINQ
            var dict = new Dictionary<string, List<int>>();

            foreach (var document in documents)
            {
                var splitted = Regex.Split(document.Text.ToLower(), @"\W+").Where(word => word != string.Empty).Distinct();

                foreach (var word in splitted)
                {
                    var indexes = new List<int> { document.Id };

                    if (!dict.ContainsKey(word))
                    {
                        dict[word] = indexes;
                        continue;
                    }

                    dict[word].AddRange(indexes);
                }
            }

            // Метод SelectMany() в качестве первого параметра принимает последовательность,
            // которую надо проецировать, а в качестве второго параметра - функцию преобразования,
            // которая применяется к каждому элементу. 
            var result = documents.SelectMany(doc => Regex.Split(doc.Text.ToLower(), @"\W+")
                                             .Where(word => word != string.Empty)
                                             .Distinct(),
                                         (doc, word) => new { doc.Id, word })
                .ToLookup(arg => arg.word, arg => arg.Id);

            // с использованием Tuple
            var result1 = documents.SelectMany(doc => Regex.Split(doc.Text.ToLower(), @"\W+")
                                             .Where(word => word != string.Empty)
                                             .Distinct(),
                                         (doc, word) => Tuple.Create(word, doc.Id))
                .ToLookup(tuple => tuple.Item1, tuple => tuple.Item2);

            // с одним аргументом для метода SelectMany (с использованием Select)
            var result2 = documents.SelectMany(document => Regex.Split(document.Text.ToLower(), @"\W+")
                                                   .Where(word => word != string.Empty)
                                                   .Distinct()
                                                   .Select(word => new { document.Id, word }))
                .ToLookup(arg => arg.word, arg => arg.Id);

            return result;
        }
    }
}