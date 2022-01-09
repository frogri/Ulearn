/*
 * И снова сделайте так, чтобы код заработал!
 *
 * Создайте метод расширения класса String, преобразующий строку в int.
 * Метод расширения должен быть определен в статическом классе, а перед его первым аргументом должно быть ключевое слово this
 */

using System;

namespace _03_Sozdanie_metodov_rasshireniya
{
    internal class Program
    {
        public static void Main()
        {
            var arg1 = "100500";
            Console.Write(arg1.ToInt() + "42".ToInt()); // 100542

            Console.ReadKey();
        }
    }

    public static class StringExtension
    {
        public static int ToInt(this string str)
        {
            return Convert.ToInt32(str);
        }
    }
}