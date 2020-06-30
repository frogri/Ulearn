/*
В отпуске Вася не тратил время зря, а заводил новые знакомства. 
Он знакомился с другими крутыми программистами, отдыхающими с ним в одном отеле, и записывал их email-ы.

В его дневнике получилось много записей вида <name>:<email>.

Чтобы искать записи было быстрее, он решил сделать словарь, 
в котором по двум первым буквам имени можно найти все записи его дневника.

Вася уже написал функцию GetContacts, которая считывает его каракули из блокнота. 
Помогите ему сделать все остальное!



Разбить запись на имя и email вам поможет уже знакомый метод Split у строки
Проверяйте наличие ключа в словаре перед добавлением
Не забывайте про крайние случаи!
Может так получиться, что в имени будет меньше двух букв.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poleznye_znakomstva
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> contacts = new List<string>
            {
                "Иван Крылов:ivan1@mail.ru",
                "Степан Вокс:stepan1@mail.ru",
                "Дарья Зорина:darja@mail.ru",
                "Анна Клишина:anna1@mail.ru",
                "Александр Волков:aleksandr@mail.ru",
                "Степан Дамин:stepan2@mail.ru",
                "Иван Семенов:ivan2@mail.ru",
                "Иван Чирков:ivan3@mail.ru",
                "Анна Завалишина:anna2@mail.ru",
                "Анна Кряквоцева:anna3@mail.ru",
                "Анна Молина:anna4@mail.ru",
                "a:anna5@mail.ru",
                ":anna5@mail.ru"
            };

            OptimizeContacts(contacts);

            Console.ReadKey();
        }

        //TODO: дописать метод
        private static Dictionary<string, List<string>> OptimizeContacts(List<string> contacts)
        {
            var dictionary = new Dictionary<string, List<string>>();

            //требуется извлечь первые два символа из имени и поместить их в ключ словаря, а элемент списка будет значением словаря
            foreach (var contact in contacts)
            {
                var nameAndMail = contact.Split(':');
                string name = nameAndMail[0];

                if (name.Length > 0)
                {
                    //извлекаем подстроку из имени в зависимости от длины имени
                    var key = name.Substring(0, (name.Length == 1) ? 1 : 2);

                    if (!dictionary.ContainsKey(key))
                        dictionary[key] = new List<string>();

                    dictionary[key].Add(contact);
                }
                else
                    Console.WriteLine($"В строке <{contact}> осутствует имя");
            }
            return dictionary;
        }
    }
}
