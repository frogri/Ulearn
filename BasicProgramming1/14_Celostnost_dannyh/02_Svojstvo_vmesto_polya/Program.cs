// Превратите поле Title в свойство самостоятельно. Это совсем не сложно!

using System;

namespace _02_Svojstvo_vmesto_polya
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Check();
            Console.ReadKey();
        }

        public static void Check()
        {
            var book = new Book();
            book.Title = "Structure and interpretation of computer programs";
            Console.WriteLine(book.Title);
        }

        public class Book
        {
            public string Title { get; set; }
        }
    }
}