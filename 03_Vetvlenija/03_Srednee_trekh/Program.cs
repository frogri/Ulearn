﻿/*
Вы с Васей и Петей решили выбрать самые лучшие фотографии котиков в интернете. 
Для этого каждую фотографию каждый из вас оценил по стобалльной шкале. 
Естественно, тут же встал вопрос о том, как из трех оценок получить одну финальную.
Вы опасаетесь, что каждый из вас сильно завысит оценку фотографиям своего котика. 
Поэтому было решено в качестве финальной оценки брать не среднее арифметическое, 
а медиану, то есть просто откинуть максимальную и минимальную оценки.
Вася начал писать код выбора средней оценки из трех, но запутался в if-ах, 
и поэтому перепоручил эту задачу вам.
Попробуйте не просто решить задачу, но и минимизировать количество проверок 
и максимально упростить условия проверок.

Не запутайтесь в if-ах. Придумайте какую-нибудь систему и придерживайтесь ее.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Srednee_trekh
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MiddleOf(5, 0, 100)); // => 5
            Console.WriteLine(MiddleOf(12, 12, 11)); // => 12
            Console.WriteLine(MiddleOf(1, 1, 1)); // => 1
            Console.WriteLine(MiddleOf(2, 3, 2));
            Console.WriteLine(MiddleOf(8, 8, 8));
            Console.WriteLine(MiddleOf(5, 0, 1));

            //FinalTesting(); // Тестирование решения на секретных тестах
            Console.ReadKey();
        }

        public static int MiddleOf(int a, int b, int c)
        {
            //TODO: Слишком длинная строка
            if ((a > b && a < c) || (a < b && a > c) || (a == b && a == c) || (a == b && a != c) || (a == c && a != b)) return a;
            else if ((b > a && b < c) || (b < a && b > c) || (b == c && b != a)) return b;
            else return c;
        }
    }
}
