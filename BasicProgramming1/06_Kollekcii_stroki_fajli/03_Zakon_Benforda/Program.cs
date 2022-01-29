/*
Вчера Вася узнал про удивительный закон Бенфорда и хочет проверить его действие. 
Для этого он взял текст с актуальными данными по самым высоким зданиям в мире и хочет получить статистику: 
сколько раз каждая цифра стоит на месте старшего разряда в числах из его текста.

Метод GetBenfordStatistics должен вернуть массив чисел, в котором на i-ой позиции находится статистика для цифры i.
 */

using System;
using System.IO;

namespace _03_Zakon_Benforda
{
    public class Program
    {
        public static void Main()
        {
            var path = Path.Combine(AppDomain.CurrentDomain.SetupInformation.ApplicationBase, @"..\..\tallestBuildings.txt");
            var content = File.ReadAllText(path);

            PrintNumbers(GetBenfordStatistics("1"));
            PrintNumbers(GetBenfordStatistics("abc"));
            PrintNumbers(GetBenfordStatistics("123 456 789"));
            PrintNumbers(GetBenfordStatistics("abc 123 def 456 gf 789 i"));
            PrintNumbers(GetBenfordStatistics(content));

            Console.ReadKey();
        }

        public static int[] GetBenfordStatistics(string text)
        {
            var array = text.Replace("\r\n", " ").Split(' ');

            var statistics = new int[10];
            foreach (var word in array)
            {
                if (char.IsDigit(word[0]))
                    statistics[word[0] - '0']++;
            }

            return statistics;
        }

        private static void PrintNumbers(int[] array)
        {
            Console.Write(string.Join(",", array));
            Console.WriteLine();
        }
    }
}