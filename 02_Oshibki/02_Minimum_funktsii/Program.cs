// Эта задача потребует знания конструкции if-else. 
// Если вы с ней знакомы из других языков программирования, это не составит проблем.
// Если не знакомы совсем, то лучше пропустить эту задачу и сначала пройти следующий модуль.
// Реализуйте метод GetMinX для нахождения такого числа x, при котором кривая, 
// заданная уравнением y(x) = ax ^ 2 + bx + c, принимает минимальное значение.

// Метод должен принимать неотрицательный коэффициент a, 
// а также произвольные коэффициенты b и c, и, если решение существует, 
// возвращать строковое представление искомого x, а иначе — строку Impossible.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Ulearn_001_basic_002_errors_0001
{
    class Program
    {
        private static string GetMinX(int a, int b, int c)
        {
            if (a > 0)
                return ((double)(-b) / (2 * a)).ToString();
            else if (a == 0 && b == 0)
                return "Possible";
            else return "Imposssible";
        }

        public static void Main()
        {
            Console.WriteLine(GetMinX(1, 2, 3));
            Console.WriteLine(GetMinX(0, 3, 2));
            Console.WriteLine(GetMinX(1, -2, -3));
            Console.WriteLine(GetMinX(5, 2, 1));
            Console.WriteLine(GetMinX(4, 3, 2));
            Console.WriteLine(GetMinX(0, 4, 5));

            // А в этих случаях решение существует:
            Console.WriteLine(GetMinX(0, 0, 2) != "Impossible");
            Console.WriteLine(GetMinX(0, 0, 0) != "Impossible");

            Console.ReadLine();
        }
    }
}

/*
Приравняв производную к нулю y'(x) = 0, легко найти формулу для искомого x = - b / 2a

Не забывайте про разницу double и int: деление int-ов целочисленное, 
при делении double на 0 не возникает ошибки, вместо этого double принимает значение Infinity.

Помните, что в ваш метод могут передать некорректные значения

Для проверки граничных случаев можно использовать if

Можете самостоятельно познакомиться с тернарным оператором ?: — он позволит 
обойтись без if в этой задаче

Проверьте, не опечатались ли вы в строке Impossible
*/