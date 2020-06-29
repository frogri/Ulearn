/*
 Вася этим летом отдыхал на море и встретил таинственную незнакомку, 
 которая передала ему крайне странную записку.

Вася долго лежал на пляже, пытаясь понять, что бы это значило. 
Дошло до того, что он перегрелся на солнце и у него закружилась голова, 
но как раз благодаря этому он и понял как разгадать шифр:
Нужно выписать все слова, начинающиеся с большой буквы, в порядке обратном тому, 
как они встречались в тексте.


Для разбиения строки на слова можно использовать функцию text.Split(' ')
Вы можете проверить, является ли символ заглавным с помощью Char.IsUpper
Используйте List<string>, чтобы сохранить все найденные в тексте слова с большой буквы
У списка есть метод Reverse(), переворачивающий список
Склеить отдельные слова в текст можно ещё одним циклом, а можно специальным методом string.Join(" ", words.ToArray())
Имейте в виду, "".Split(' ') возвращает пустую строку! Обращение к нулевому символу пустой строки приведёт к ошибке ArgumentOutOfRangeException.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shifr_neznakomki
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] codedMessage = new string[12]
            {
                "решИла нЕ Упрощать и зашифРОВАтЬ Все послаНИЕ",
                "дАже не Старайся нИЧЕГО у тЕбя нЕ получится с расшифРОВкой",
                "Сдавайся НЕ твоего ума Ты не споСОбЕн Но может быть",
                "если особенно упорно подойдешь к делу",
                "",
                "будет Трудно конечнО",
                "Код ведЬ не из простых",
                "очень ХОРОШИЙ код",
                "то у тебя все получится",
                "и я буДу Писать тЕбЕ еще",
                "",
                "чао"
            };

            Console.WriteLine(DecodeMessage(codedMessage));

            Console.ReadKey();
        }

        private static string DecodeMessage(string[] lines)
        {
            List<string> list = new List<string>();

            foreach (string line in lines)
            {
                if (line.Length > 0)
                {
                    foreach (string word in line.Split(' '))
                    {
                        if (char.IsUpper(word, 0))
                            list.Add(word);
                    }
                }
            }

            list.Reverse();
            return String.Join(" ", list);
        }
    }
}
