using System;
using System.Collections.Generic;
using System.Linq;

namespace Test
{
    internal class Program
    {
        static IEnumerable<int> GetSequence()
        {
            for (var i = 0; i < 2; ++i)
            {
                Console.WriteLine("s");
                yield return i;
            }
        }

        static void Main(string[] args)
        {
            foreach (var element in GetSequence().ToList().Take(1))
                Console.WriteLine("f");

            Console.ReadKey();
        }
    }
}
