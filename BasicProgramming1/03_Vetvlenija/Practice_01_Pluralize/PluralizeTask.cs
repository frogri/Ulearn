//Напишите метод, склоняющий существительное «рублей» следующее за указанным числительным.
//Например, для аргумента 10, метод должен вернуть «рублей», для 1 — вернуть «рубль», для 2 — «рубля».
//Для проверки своего решения запустите скачанный проект.

using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Pluralize
{
    public static class PluralizeTask
    {
        public static string PluralizeRubles(int count)
        {
            // Напишите функцию склонения слова "рублей" в зависимости от предшествующего числительного count.
            string countToString = count.ToString();
            //берем последний символ строки
            char lastChar = countToString.Last();

            //если строка состоит из одного символа
            if (countToString.Length == 1)
                return LastCharSearching(lastChar);

            //берем предпоследний символ
            char nextToLastChar = countToString.ElementAt(countToString.Length - 2);
            if (nextToLastChar != '1')
                return LastCharSearching(lastChar);
            return "рублей";
        }

        public static string LastCharSearching(char lastChar)
        {
            if (lastChar == '1')
                return "рубль";
            else if (lastChar == '2' || lastChar == '3' || lastChar == '4')
                return "рубля";
            else
                return "рублей";
        }
    }
}