//Исправьте все ошибки преобразования типов.Читайте и переводите с английского имена переменных, чтобы понять, что от вас требуется.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oshibki_preobrazovaniya_tipov
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = Math.PI;
            int tenThousand = 10000;
            double tenThousandPi = pi * tenThousand;
            int roundedTenThousandPi = (int)Math.Round(tenThousandPi);
            int integerPartOfTenThousandPi = (int)tenThousandPi;
            Console.WriteLine(integerPartOfTenThousandPi);
            Console.WriteLine(roundedTenThousandPi);

            Console.ReadKey();
        }
    }
}
