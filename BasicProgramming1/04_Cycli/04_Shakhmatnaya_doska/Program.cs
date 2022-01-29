/*
 * Стали известны подробности про новую игру Васи. 
 * Оказывается ее действия разворачиваются на шахматных досках нестандартного размера.
У Васи уже написан код, генерирующий стандартную шахматную доску размера 8х8. 
Помогите Васе переделать этот код так, чтобы он умел выводить доску любого заданного размера.
Например, доска размера пять должна выводиться так:

#.#.#  
.#.#.  
#.#.#  
.#.#.  
#.#.#

Белая клетка обозначается точкой, черная — шарпом.


*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shakhmatnaya_doska
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteBoard(8);
            WriteBoard(1);
            WriteBoard(2);
            WriteBoard(3);
            WriteBoard(10);

            Console.ReadKey();
        }

        private static void RowIsEven(int lengthOfRow)
        {
            string rowEven = ""; //четная строка
                                 //определяем четность или нечетность символа в строке
            for (int j = 0; j < lengthOfRow; j++)
            {
                if (j % 2 == 0)
                    rowEven += "#";
                else rowEven += ".";
            }
            Console.WriteLine(rowEven);
            rowEven = "";
        }

        private static void RowIsOdd(int lengthOfRow)
        {
            string rowOdd = ""; //нечетная строка
                                //определяем четность или нечетность символа в строке
            for (int j = 0; j < lengthOfRow; j++)
            {
                if (j % 2 == 0)
                    rowOdd += ".";
                else rowOdd += "#";
            }
            Console.WriteLine(rowOdd);
            rowOdd = "";
        }

        private static void ParityDetection(int numberOfRow, int lengthOfRow)
        {
            //определяем четность или нечетность номера строки
            for (int i = 0; i < numberOfRow; i++)
            {
                //четные строки начинаются с '#'
                if (i % 2 == 0)
                    RowIsEven(lengthOfRow);
                //нечетные строки начинаются с '.'
                else RowIsOdd(lengthOfRow);
            }
        }

        private static void WriteBoard(int size)
        {
            ParityDetection(size, size);
            Console.WriteLine();
        }
    }
}
