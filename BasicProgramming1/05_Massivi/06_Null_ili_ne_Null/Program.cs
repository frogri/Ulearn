/*Вася написал метод, проверяющий, что первый элемент переданного массива равен 0.
Вася даже проверил, что ему не передали в качестве массива null. Но что-то все равно не работает.
Исправьте ошибку и разберитесь, почему код не работал.

Подсказки
Нет ли в коде каких-то необычных операторов?
Помимо полного оператора конъюнкции &, есть также сокращенный &&. Чем они отличаются? Это было в теме «Ветвления».*/


using System;

namespace _06_Null_ili_ne_Null
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine(CheckFirstElement(null));
            Console.WriteLine(CheckFirstElement(new int[0]));
            Console.WriteLine(CheckFirstElement(new[] { 1 }));
            Console.WriteLine(CheckFirstElement(new[] { 0 }));

            Console.ReadKey();
        }

        private static bool CheckFirstElement(int[] array)
        {
            return array != null && array.Length != 0 && array[0] == 0;
        }
    }
}
