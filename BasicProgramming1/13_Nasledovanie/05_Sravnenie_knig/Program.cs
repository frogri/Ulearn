/*Вы пишете учетную систему для книжного магазина,
 и вам необходимо научиться сравнивать между собой записи о книгах, 
чтобы продавцам было удобно искать нужную.

Каждая книга имеет название Title и номер тематического раздела Theme.

Реализуйте интерфейс IComparable у класса Book. 
Логику сравнения восстановите по тестам, которые вы увидите при первом запуске.
 */

using System;

namespace _05_Sravnenie_knig
{
    public class Program
    {
        public static void Main(string[] args)
        {

        }

        public class Book : IComparable
        {
            public string Title;

            public int Theme;

            public int CompareTo(object obj)
            {
                var anotherBook = (Book)obj;

                if (Theme.CompareTo(anotherBook.Theme) != 0)
                    return Theme.CompareTo(anotherBook.Theme);

                return Title.CompareTo(anotherBook.Title);
            }
        }
    }
}