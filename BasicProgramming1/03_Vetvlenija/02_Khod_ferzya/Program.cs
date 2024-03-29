﻿/*
Вася решил научить своего младшего брата играть в шахматы. 
Но вот беда, брат еще слишком мал и никак не может запомнить как ходит ферзь. 
Как настоящий программист, Вася решил автоматизировать ручной труд по обучению начинающих шахматистов.
Помогите ему написать программу, которая по шахматному ходу определяет корректный ли это ход ферзя. 
Координаты исходной и конечной позиции хода передаются строкой в обычной шахматной нотации, например, "a1".
Как обычно, постарайтесь поразить Васю красотой и простотой получившегося кода!

Символы строки имеют тип данных char. Это числовой тип данных. Значение — код символа в таблице Unicode.
Символы латинского алфавита и цифр идут в таблице Unicode подряд. Поэтому, например, 'c' - 'a' == 2, а '5' - '8' == -3
Math.Abs вычисляет модуль своего аргумента
Имейте в виду, что остаться на месте — это некорректный ход
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Khod_ferzya
{
    class Program
    {
        public static void Main()
        {
            TestMove("a1", "d4");
            TestMove("f4", "e7");
            TestMove("a1", "a4");
            //FinalTesting(); // Тестирование решения на секретных тестах

            Console.ReadKey();
        }

        public static void TestMove(string from, string to)
        {
            Console.WriteLine("{0}-{1} {2}", from, to, IsCorrectMove(from, to));
        }

        public static bool IsCorrectMove(string from, string to)
        {
            var dx = Math.Abs(to[0] - from[0]); //смещение фигуры по горизонтали
            var dy = Math.Abs(to[1] - from[1]); //смещение фигуры по вертикали

            //при движении по диагонали смещение по горизонтали д.б. равно смещению по вертикали
            //при движении по горизонтали смещение по вертикали должно быть равно нулю и наоборот
            return (dx != 0 && dy != 0 && dx == dy) || (dx == 0 && dy > 0) || (dy == 0 && dx > 0);
        }
    }
}
