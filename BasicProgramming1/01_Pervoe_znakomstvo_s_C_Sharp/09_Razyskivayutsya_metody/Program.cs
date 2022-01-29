// Напишите тело метода так, чтобы он возвращал вторую половину строки text, 
// из которой затем удалены пробелы.Можете считать, что text всегда четной длины.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Razyskivayutsya_metody
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetLastHalf("I love CSharp!"));
            Console.WriteLine(GetLastHalf("1234567890"));
            Console.WriteLine(GetLastHalf("до ре ми фа соль ля си"));

            Console.ReadKey();
        }

        static string GetLastHalf(string text)
        {
            /*
            //вычисляем половину длины строки
            int lengthHalf = text.Length/2;
            //извлекаем подстроку из заданной строки с указанной стартовой позиции
            string lastHalf = text.Substring(lengthHalf);
            //Метод String.Replace - заменяем знак пробела " " на "".
            lastHalf = lastHalf.Replace(" ", "");
            return lastHalf;
            */
            string lastHalf;
            return lastHalf = text.Substring(text.Length / 2).Replace(" ", "");
        }
    }
}
