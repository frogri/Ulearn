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

    public delegate int Adder(int a, int b);

    public class Program
    {
        public static void Main()
        {
            Run(Console.WriteLine);
            Run(Sum);

            Console.ReadKey();
        }

        static void Run(TellUser tellUser)
        {
            tellUser("hi!");
            tellUser("how r u?");
        }

        static void Run(Adder adder)
        {
            adder(1, 2);
            adder(10, 20);
            adder(100, 200);
        }

        static int Sum(int a, int b)
        {
            var res = a + b;
            Console.WriteLine(res);
            return res;
        }
    }
}