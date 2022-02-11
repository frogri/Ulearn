/*Реализуйте метод Combine, который возвращает массив, собранный из переданных массивов.
Для того, чтобы создать новый массив, используйте статический метод Array.CreateInstance, принимающий тип элемента массива.
Для того, чтобы узнать тип элементов в переданном массиве, используйте myArray.GetType().GetElementType().
Проверьте, что типы элементов совпадают во всех переданных массивах!
Если результирующий массив создать нельзя, возвращайте null.*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_Sklejka_massivov
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var ints = new[] { 1, 2 };
            var strings = new[] { "A", "B" };

            Print(Combine(ints, ints));
            Print(Combine(ints, ints, ints));
            Print(Combine(ints));
            Print(Combine());
            Print(Combine(strings, strings));
            Print(Combine(ints, strings));

            Console.ReadKey();
        }

        private static Array Combine(params Array[] arrays)
        {
            if (arrays.Length == 0)
                return null;

            if (arrays.Length == 1)
                return arrays[0];

            var types = new List<Type>();
            var length = 0;

            foreach (var array in arrays)
            {
                types.Add(array.GetType().GetElementType());
                length += array.Length;
            }

            if (!AreTypesEquals(types))
                return null;

            return ConcatArrays(types, arrays, length);
        }

        private static bool AreTypesEquals(List<Type> types)
        {
            for (var i = 0; i < types.Count - 1; i++)
            {
                if (types.ElementAt(i) != types.ElementAt(i + 1))
                    return false;
            }

            return true;
        }

        private static Array ConcatArrays(IList<Type> types, Array[] arrays, int length)
        {
            var result = Array.CreateInstance(arrays[0].GetType().GetElementType(), length);
            var offset = 0;

            foreach (var array in arrays)
            {
                array.CopyTo(result, offset);
                offset += array.Length;
            }

            return result;
        }

        private static void Print(Array array)
        {
            if (array == null)
            {
                Console.WriteLine("null");
                return;
            }

            for (int i = 0; i < array.Length; i++)
                Console.Write("{0} ", array.GetValue(i));
            Console.WriteLine();
        }
    }
}