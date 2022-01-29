/*
Помогите Васе написать метод, который принимает массив int[], 
возводит все его элементы в заданную степень и возвращает массив с результатом этой операции.

Исходный массив при этом должен остаться неизменным.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07_Vozvesti_massiv_v_stepenj
{
    public class Program
    {
        public static void Main()
        {
            var arrayToPower = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            // Метод PrintArray уже написан за вас
            PrintArray(GetPoweredArray(arrayToPower, 1));

            // если вы будете менять исходный массив, то следующие два теста сработают неверно:
            PrintArray(GetPoweredArray(arrayToPower, 2));
            PrintArray(GetPoweredArray(arrayToPower, 3));

            // не забывайте про частные случаи:
            PrintArray(GetPoweredArray(new int[0], 1));
            PrintArray(GetPoweredArray(new[] { 42 }, 0));

            Console.ReadKey();
        }

        private static void PrintArray(int[] poweredArray)
        {
            foreach (var item in poweredArray)
                Console.Write($"{item} ");

            Console.WriteLine();
        }

        private static int[] GetPoweredArray(int[] arr, int power)
        {
            var result = new int[arr.Length];

            for (var i = 0; i < arr.Length; i++)
                result[i] = (int)Math.Pow(arr[i], power);

            return result;
        }
    }
}
