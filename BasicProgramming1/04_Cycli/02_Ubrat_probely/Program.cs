/*
Враги вставили в начало каждого полезного текста целую кучу бесполезных пробельных символов!
Вася смог справиться с ситуацией, когда такой пробел был один, но продвинуться дальше ему не удается. 
Помогите ему с помощью цикла while.

Вам нужен цикл по символам текста до тех пор пока символы пробельные.
Имейте в виду, что все методы работы со строками не меняют исходную строку, а возвращают новую
s.Substring(i) не изменит s, а вернет новую строку, такую же как s, но без i первых символов
Пробельные символы бывают разные. 
Проще всего проверить, является ли символ пробельным, можно спомощью метода char.IsWhiteSpace()
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        public static string RemoveStartSpaces(string text)
        {
            //int num = 0;
            //while (char.IsWhiteSpace(text[num]))
            //{
            //    if (!char.IsWhiteSpace(text[num])) break;
            //    num++;
            //    if (num == text.Length) return text.Replace(text, "");
            //}
            //return text.Substring(num);

            while (char.IsWhiteSpace(text[0]))
            {
                text = text.Substring(1);
                if (text.Length == 0) break;
            }
            return text;

            //while (!char.IsWhiteSpace(text[num])) return text.Substring(++num);
            //{
            //    if (char.IsWhiteSpace(text[num]))
            //        str = text.Substring(++num);
            //}
            //return str;
        }

        public static void Main()
        {
            Console.WriteLine(RemoveStartSpaces("aaafd"));
            Console.WriteLine(RemoveStartSpaces(" b"));
            Console.WriteLine(RemoveStartSpaces(" cd"));
            Console.WriteLine(RemoveStartSpaces(" efg"));
            Console.WriteLine(RemoveStartSpaces(" text"));
            Console.WriteLine(RemoveStartSpaces(" two words"));
            Console.WriteLine(RemoveStartSpaces("  two spaces"));
            Console.WriteLine(RemoveStartSpaces("	tabs"));
            Console.WriteLine(RemoveStartSpaces("		two	tabs"));
            Console.WriteLine(RemoveStartSpaces("                             many spaces"));
            Console.WriteLine(RemoveStartSpaces("               "));
            Console.WriteLine(RemoveStartSpaces("\n\r line breaks are spaces too"));
            Console.ReadLine();
        }
    }
}
