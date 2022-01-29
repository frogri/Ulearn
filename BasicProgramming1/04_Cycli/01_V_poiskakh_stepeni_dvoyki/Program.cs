/*
Найдите минимальную степень двойки, превосходящую заданное число.
Более формально: для заданного числа nn найдите x > n, такой, что x = 2^k для некоторого натурального k.
Решите эту задачу с помощью цикла while.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        private static int GetMinPowerOfTwoLargerThan(int number)
        {
            int result = 1;
            while (result <= number)
            {
                result *= 2;
            }
            return result;

            //{
            //    int powerOfTwo = 1;
            //    while (powerOfTwo <= number)
            //    {
            //        powerOfTwo *= 2;
            //    }
            //    return powerOfTwo;
            //}
        }

        public static void Main()
        {
            Console.WriteLine(GetMinPowerOfTwoLargerThan(2)); // => 4
            Console.WriteLine(GetMinPowerOfTwoLargerThan(15)); // => 16
            Console.WriteLine(GetMinPowerOfTwoLargerThan(-2)); // => 1
            Console.WriteLine(GetMinPowerOfTwoLargerThan(-100));
            Console.WriteLine(GetMinPowerOfTwoLargerThan(100));
            Console.ReadLine();
        }
    }
}
