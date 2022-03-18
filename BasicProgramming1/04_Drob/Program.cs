/*Проведите рефакторинг класса Ratio. В результате:

Numerator, Denominator и Value должны остаться полями класса Ratio.
После создания объекта Ratio не должно быть возможности его изменить, 
то есть поменять поля Numerator, Denominator или Value.

После создания объекта Ratio знаменатель всегда должен быть больше нуля. 
Бросайте исключение ArgumentException при попытке установить неверное значение знаменателя.
*/

using System;
using System.Globalization;

namespace _04_Drob
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Check(10, 3);
            Check(5, 0);
            Console.ReadKey();
        }

        public static void Check(int num, int den)
        {
            var ratio = new Ratio(num, den);
            Console.WriteLine("{0}/{1} = {2}",
                              ratio.Numerator, ratio.Denominator,
                              ratio.Value.ToString(CultureInfo.InvariantCulture));
        }

        public class Ratio
        {
            public readonly int Numerator; // числитель
            public readonly int Denominator; // знаменатель
            public readonly double Value;    // значение дроби Numerator / Denominator

            public Ratio(int num, int den)
            {
                Numerator = num;
                Denominator = den;
                
                if (Denominator <= 0)
                    throw new ArgumentException();
                
                Value = (double)Numerator / Denominator;
            }
        }
    }
}