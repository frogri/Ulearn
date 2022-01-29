//Вася написал код, прибавляющий к числу единичку, но он опять не работает :(
//Немедленно помогите Васе, иначе он решит, что программирование слишком сложно для него!

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preobrazovanie_stroki_v_chislo
{
    class Program
    {
        static void Main(string[] args)
        {
            string doubleNumber = "894376.243643";
            //Следующий вызов зависит от настроек операционной системы
            //double number = double.Parse(doubleNumber);
            //Следующий вызов не зависит от настроек и всегда ожидает точку в качестве разделителя:
            double number = double.Parse(doubleNumber, CultureInfo.InvariantCulture);
            Console.WriteLine(number + 1);

            Console.ReadKey();
        }
    }
}
