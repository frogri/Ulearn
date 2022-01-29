/*
Вы решили помочь Васе с разработкой его игры и взяли на себя красивый вывод сообщений в игре.
Напишите функцию, которая принимает на вход строку текста и печатает ее на экран в рамочке 
из символов +, - и |. Для красоты текст должен отделяться от рамки слева и справа пробелом.
Например, текст Hello world должен выводиться так:

+-------------+
| Hello world |
+-------------+

Разбейте код на три части — верх рамки, середина и низ рамки
Верх и низ рамки одинаковый, можно один раз сформировать строку и вывести ее дважды — в начале и в конце
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ramochka
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteTextWithBorder("Menu:");
            WriteTextWithBorder("");
            WriteTextWithBorder(" ");
            WriteTextWithBorder("Game Over!");
            WriteTextWithBorder("Select level:");

            Console.ReadKey();
        }

        private static void WriteTextWithBorder(string text)
        {
            string str = null;
            for (int i = 0; i < (text.Length + 2); i++)
            {
                str = str + "-";
            }
            Console.WriteLine($"+{str}+");
            Console.WriteLine($"| {text} |");
            Console.WriteLine($"+{str}+");
        }

    }
}
