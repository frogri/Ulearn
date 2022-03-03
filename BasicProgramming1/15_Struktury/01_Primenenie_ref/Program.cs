/*
В этой задаче демонстрируется один из редких случаев, когда уместно использовать ref.

SkipSpaces пропускает все пробельные символы в text, начиная с позиции pos. В конце pos оказывается установлен в первый непробельный символ.

ReadNumber пропускает все цифры в text, начиная с позиции pos, а затем возвращает все пропущенные символы. 
В конце pos оказывается установлен в первый символ не цифру.

Допишите функцию, которая читает все числа из строки и выводит их, разделяя единственным пробелом.
*/

using System;

namespace _01_Primenenie_ref
{
    public class Program
    {
        private static void Main(string[] args)
        {
            WriteAllNumbersFromText("1 2 3 ");
            WriteAllNumbersFromText("4");
            WriteAllNumbersFromText("567890 ");
            WriteAllNumbersFromText(" ");
            WriteAllNumbersFromText("10 20 30");
            Console.ReadKey();
        }

        /// <summary>
        /// Пропускает все пробельные символы в text, начиная с позиции pos. В конце pos оказывается установлен в первый непробельный символ.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="pos"></param>
        public static void SkipSpaces(string text, ref int pos)
        {
            while (pos < text.Length && char.IsWhiteSpace(text[pos]))
                pos++;
        }

        /// <summary>
        /// Пропускает все цифры в text, начиная с позиции pos, а затем возвращает все пропущенные символы. В конце pos оказывается установлен в первый символ не цифру.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="pos"></param>
        /// <returns></returns>
        public static string ReadNumber(string text, ref int pos)
        {
            var start = pos;
            while (pos < text.Length && char.IsDigit(text[pos]))
                pos++;
            return text.Substring(start, pos - start);
        }

        /// <summary>
        /// Читает все числа из строки и выводит их, разделяя единственным пробелом
        /// </summary>
        /// <param name="text"></param>
        public static void WriteAllNumbersFromText(string text)
        {
            var pos = 0;

            while (true)
            {
                SkipSpaces(text, ref pos);
                var num = ReadNumber(text, ref pos);
                if (num == string.Empty) 
                    break;
                Console.Write(num + " ");
            }

            Console.WriteLine();
        }
    }
}