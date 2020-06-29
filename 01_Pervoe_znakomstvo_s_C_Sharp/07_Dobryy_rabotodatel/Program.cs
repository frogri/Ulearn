// Вася до завтра должен написать важную подпрограмму для Доброго Работодателя.
// Оставалось дописать всего один метод, когда Вася от переутомления крепчайше заснул.
// Напишите метод, который принимает на вход имя и зарплату и возвращает строку вида: 
// Hello, <Name>, your salary is <Salary>.
// Но так как Работодатель Добр, он всегда округляет зарплату до ближайшего целого числа вверх.
// Во многих редакторах и IDE сочетание клавиш Ctrl + Space показывает контекстную подсказку. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dobryy_rabotodatel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetGreetingMessage("Student", 10.01));
            Console.WriteLine(GetGreetingMessage("Bill Gates", 10000000.5));
            Console.WriteLine(GetGreetingMessage("Steve Jobs", 1));

            Console.ReadKey();
        }


        /// <summary>
        /// возвращает "Hello, <name>, your salary is <salary>"
        /// </summary>
        /// <param name="name">имя работника</param>
        /// <param name="salary">зарплата работника</param>
        /// <returns></returns>
        private static string GetGreetingMessage(string name, double salary)
        {
            /*
            string myString;
            double roundedSalary;
            roundedSalary = Math.Round(salary);

            if (roundedSalary < salary)
            {
                salary = roundedSalary + 1;
            }
            else
            {
                salary = roundedSalary;
            }
            
            myString = "Hello, " + name + ", your salary is " + salary;
            return myString;
            */

            //или так
            return string.Format("Hello, {0}, your salary is {1}", name, Math.Ceiling(salary));
        }
    }
}
