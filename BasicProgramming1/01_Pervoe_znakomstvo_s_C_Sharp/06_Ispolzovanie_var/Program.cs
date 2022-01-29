//С прибавлением единицы все оказалось просто.Казалось бы прибавление к числу половинки должно быть не сложнее...
//Подумайте, как так получилось, что казалось бы корректная программа не работает.Исправьте первую строчку программы так,
//чтобы она компилировалась и выводила на консоль ожидаемый ответ — 5.5.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Ispolzovanie_var
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 5.0; // ← исправьте эту строку
            a += 0.5;
            Console.WriteLine(a);

            Console.ReadKey();
        }
    }
}
