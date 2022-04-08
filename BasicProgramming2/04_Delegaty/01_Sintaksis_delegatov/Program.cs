/*
Наша программа умеет общаться с пользователем, 
но конкретный способ общения задается параметром tellUser. 
Так с помощью делегатов можно обобщать код.

Осталось только дописать определение типа TellUser так, 
чтобы код скомпилировался. 
Эта простая задача поможет вам запомнить синтаксис определения делегата.
 */

using System;

namespace _01_Sintaksis_delegatov
{
    public delegate void TellUser(string str);

    public class Program
    {
        public static void Main()
        {
            Run(Console.WriteLine);

            Console.ReadKey();
        }

        static void Run(TellUser tellUser)
        {
            tellUser("hi!");
            tellUser("how r u?");
        }
    }
}