/*
Формула для вкладов с капитализацией
В данном случае расчет процентов будет выглядеть следующим образом:

Д = С * (1 + Pп/m)^T,

где:
Д — будущая стоимость, 
С — текущая стоимость (сколько положите на депозит),
Pп — номинальная годовая ставка процента,
m — количество периодов начисления процентов (при полугодовом начислении m=2, при начислении процентов раз в квартал m=4, при ежемесячном начислении m=12),
Т - количество месяцев, на которые открыт вклад

Например, если годовая ставка равна 8%, а проценты начисляются каждый месяц, то за год сумма вклада вырастет до:
30,000* (1+0,08/12)^12 = 30,000*(1,0067)^12= 32,490

за три года:
30,000* (1+0,08/12)^36 = 30,000*(1,0067)^36= 38,106
 */

using System;
using System.Globalization;

namespace Practice_03_Percent
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Введите через пробел три числа: \n\tисходную сумму вклада, \n\tпроцентную ставку (в процентах), \n\tсрок вклада в месяцах\n");
            var input = Console.ReadLine();

            var result = Calculate(input);
            Console.WriteLine($"Сумма на вкладе составит {Math.Round(result, 2)} руб.");

            Console.ReadKey();
        }

        private static double Calculate(string inputData)
        {
            var inputArray = inputData.Split(' ');

            var sum = double.Parse(inputArray[0], CultureInfo.InvariantCulture);
            var interest = double.Parse(inputArray[1], CultureInfo.InvariantCulture) / 100;
            var monthCount = Convert.ToInt16(inputArray[2]);

            return sum * Math.Pow(1 + interest / 12, monthCount);
        }
    }
}