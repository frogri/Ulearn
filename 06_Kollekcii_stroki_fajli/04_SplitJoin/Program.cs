/*
Васе для презентации необходима таблица с информацией о 20 самых населенных стран. 
Вася нашел и скопировал описание стран с какого-то сайта и хочет вставить эти данные в электронную-таблицу.

Вот если бы все данные в одной строке отделялись друг от друга знаком табуляции, 
то при вставке в таблицу они бы автоматически разнеслись по разным ячейкам. 
Но, к сожалению, скопированные им данные разделяются абы как.

Помогите Васе заменить все встречающиеся в скопированном тексте разделители — пробелы, двоеточия, тире и т.п. 
на символ табуляции \t так, чтобы все данные отделялись друг от друга единственным символом табуляции.
 */

using System;
using System.IO;

namespace _04_SplitJoin
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var path = Path.Combine(AppDomain.CurrentDomain.SetupInformation.ApplicationBase, @"..\..\citiesPopulation.txt");
            var content = File.ReadAllText(path);

            Console.WriteLine(ReplaceIncorrectSeparators(content));
            Console.ReadKey();
        }

        public static string ReplaceIncorrectSeparators(string text)
        {
            var separators = new[] { ':', ';', '-', ',', ' ' };
            return string.Join("\t", text.Split(separators, StringSplitOptions.RemoveEmptyEntries));
        }
    }
}