/*
Незнакомка вернулась!
На рабочем столе своего ноутбука Вася обнаружил огромный файл, начинающийся так:

push Привет! Это снова я! Пока!
pop 5
push Как твои успехи? Плохо?
push qwertyuiop
push 1234567890
pop 26
...


Да, кажется предыдущая программа по расшифровке шифра не понадобится — незнакомка не повторяется...
Вася где-то слышал, что pop и push — это операции работы со стеком. 
Видимо, тут нужно действовать по аналогии — push дописывает указанную строку в конец текста, 
а pop удаляет из конца указанное количество символов.
Попробовав выполнить первые шесть операций, Вася получил текст:


Привет! Это снова я! Как твои успехи?


Видимо, чтобы прочитать второе послание незнакомки, нужно выполнить все операции из файла. 
Но файл слишком большой, тут без программы-декодировщика не обойтись!



Возможно вам понадобятся методы command.IndexOf(' ') для поиска индекса первого пробела 
и command.Substring для взятия подстроки

Массовые операции со строками эффективнее делать с помощью специального класса StringBuilder

Команды Replace, IndexOf, Substring проходят все строку (или StringBuilder). 
Вызывать их на больших строках накладно. 
Строки в команде push короткие, но промежуточная строка может быть большой.
 */

using System;
using System.Text;

namespace _03_Snova_neznakomka
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string[] message =
            {
                "push Привет! Это снова я! Пока!", "pop 5", "push Как твои успехи? Плохо?", "push qwertyuiop", "push 1234567890", "pop 26"
            };

            Console.WriteLine(ApplyCommands(message));
            Console.ReadKey();
        }

        private static string ApplyCommands(string[] commands)
        {
            var builder = new StringBuilder();

            foreach (var messageString in commands)
            {
                var indexOfWhiteSpace = messageString.IndexOf(' ');
                var command = messageString.Substring(0, indexOfWhiteSpace);
                var text = messageString.Substring(indexOfWhiteSpace + 1, messageString.Length - (indexOfWhiteSpace + 1));

                switch (command)
                {
                    case "push":
                        builder.Append(text);
                        break;
                    case "pop":
                        var symbolsToRemove = Convert.ToInt32(text);
                        builder.Remove(builder.Length - symbolsToRemove, symbolsToRemove);
                        break;
                    default:
                        Console.WriteLine("Команда не определена");
                        break;
                }
            }

            return builder.ToString();
        }
    }
}