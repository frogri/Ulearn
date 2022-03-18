using System.Collections.Generic;

namespace PocketGoogle
{
    public interface IIndexer
    {
        /// <summary>
        ///     Добавление документа в индексер
        /// </summary>
        /// <param name="id">Id документа</param>
        /// <param name="documentText">Текст документа</param>
        void Add(int id, string documentText);

        /// <summary>
        ///     Удаляет документ из индекса, после чего слова в нем искаться больше не будут
        /// </summary>
        /// <param name="id">Id документа для удаления</param>
        void Remove(int id);

        /// <summary>
        ///     По слову ищет все id документов, содержащих данное слово
        /// </summary>
        /// <param name="word">Ключевое слово для поиска</param>
        /// <returns>Список id документов</returns>
        List<int> GetIds(string word);

        /// <summary>
        ///     По слову и id документа ищет все позиции, в которых слово начинается
        /// </summary>
        /// <param name="id">Id документа</param>
        /// <param name="word">Ключевое слово для поиска</param>
        /// <returns>Список позиций, в которых находится слово</returns>
        List<int> GetPositions(int id, string word);
    }
}