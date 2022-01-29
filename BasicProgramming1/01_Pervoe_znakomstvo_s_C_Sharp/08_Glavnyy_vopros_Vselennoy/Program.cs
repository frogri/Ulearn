// Многие знают, что ответ на главный вопрос жизни, вселенной и всего такого — 42. 
// Но Вася хочет большего! Он желает знать квадрат этого числа!
// Вы разделили с Васей работу — он написал главный метод Main, 
// а вам осталось лишь дописать методы Print и GetSquare.
// Создайте два метода Print и GetSquare, так, чтобы код снизу заработал.
// Если забыли синтаксис определения методов — подсмотрите в видеолекции или в предыдущие задачи.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glavnyy_vopros_Vselennoy
{
    class Program
    {
        static void Main(string[] args)
        {
            Print(GetSquare(42));
        }

        public static int GetSquare(int number)
        {
            int numberSquare;
            return numberSquare = (int)Math.Pow(number, 2);
        }

        public static void Print(int numberSquare)
        {
            Console.WriteLine(numberSquare);
            Console.ReadLine();
        }

    }
}
