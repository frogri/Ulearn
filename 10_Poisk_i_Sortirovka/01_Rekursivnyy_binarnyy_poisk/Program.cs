/*
 * В этой задаче вам нужно дописать рекурсивную версию бинарного поиска,
 * который находит левую границу, то есть индекс максимального элемента
 * меньшего value или -1, если такого элемента нет.
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Rekursivnyy_binarnyy_poisk
{
    class Program
    {
        private static int FindLeftBorder(long[] arr, long value)
        {
            return BinSearchLeftBorder(arr, value, -1, arr.Length);
        }

        // todo: доделать метод
        public static int BinSearchLeftBorder(long[] array, long value, int left, int right)
        {
            //return -10;
            if (array.Length == 0 || array[0] >= value) return left;

            while (left < right)
            {
                var m = (left + right) / 2;
                if (array[m] < value)
                    return BinSearchLeftBorder(array, value, m + 1, right - m);
                return BinSearchLeftBorder(array, value, left, m);
            }

            if (array[right] == value)
                return right;
            return -1;

            //var m = (left + right) / 2;
            //if (array[m] < value)
            //    return BinSearchLeftBorder(array, value, m + 1, right);
            //return BinSearchLeftBorder(array, value, left, m);

            //while (left < right)
            //{
            //    var middle = (right + left) / 2;
            //    if (value <= array[middle])
            //        right = middle;
            //    else left = middle + 1;
            //}
            //if (array[right] == value)
            //    return right;
            //return -1;
        }

        static void Main(string[] args)
        {
            //Console.WriteLine(FindLeftBorder(new long[] { 1, 2, 3 }, 0));
            //Console.WriteLine(FindLeftBorder(new long[] { 1, 2, 3 }, 1));
            Console.WriteLine(FindLeftBorder(new long[] { 1, 2, 3 }, 2));
            Console.WriteLine(FindLeftBorder(new long[] { 1, 2, 3 }, 3));
            Console.WriteLine(FindLeftBorder(new long[] { 1, 2, 3 }, 4));
            Console.WriteLine(FindLeftBorder(new long[] { }, 1));
            Console.WriteLine(FindLeftBorder(new long[] { 1 }, 0));
            Console.WriteLine(FindLeftBorder(new long[] { 1 }, 1));
            Console.WriteLine(FindLeftBorder(new long[] { 1 }, 2));
            Console.WriteLine(FindLeftBorder(new long[] { 1, 1 }, 0));
            Console.WriteLine(FindLeftBorder(new long[] { 1, 1 }, 1));
            Console.WriteLine(FindLeftBorder(new long[] { 1, 1 }, 2));
            Console.WriteLine(FindLeftBorder(new long[] { 1, 2, 2, 3 }, 2));
            Console.WriteLine(FindLeftBorder(new long[] { 1, 2, 2, 2, 3 }, 2));
            Console.WriteLine(FindLeftBorder(new long[] { 1, 1, 1, 2, 3 }, 2));

            Console.ReadKey();
        }
    }
}
