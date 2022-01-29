/*
Вася нашел в интернете сайт, предсказывающий будущее на картах Таро. 
Он решил перенести сайт в Россию и заработать на доверчивых людях. 
Для этого сайт необходимо русифицировать.
Вася справился с проблемой русификации мастей. 
Но решение длинное, а русифицировать нужно еще много чего. 
Кажется, что эту задачу можно решить немного веселее, с помощью массивов. 
Возможно даже всего в одну строчку кода.
Сделайте это!


Подумайте, как тут можно применить сокращенный синтаксис создания массивов вместо if-ов.
enum можно конвертировать в int!
(int)Suits.Wands равен нулю, (int)Suits.Coins — единице и так далее.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Karty_Taro
{
    class Program
    {
        enum Suits
        {
            Wands,
            Coins,
            Cups,
            Swords
        }

        public static void Main()
        {
            Console.WriteLine(GetSuit(Suits.Wands));
            Console.WriteLine(GetSuit(Suits.Coins));
            Console.WriteLine(GetSuit(Suits.Cups));
            Console.WriteLine(GetSuit(Suits.Swords));

            Console.ReadKey();
        }

        private static string GetSuit(Suits suit)
        {
            return new[] { "жезлов", "монет", "кубков", "мечей" }[(int)suit];
        }
    }
}
