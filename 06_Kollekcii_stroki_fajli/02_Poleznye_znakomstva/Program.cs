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
        }

        //TODO: дописать
        private static Dictionary<string, List<string>> OptimizeContacts(List<string> contacts)
        {
            var dictionary = new Dictionary<string, List<string>>();



            return dictionary;
        }
    }
}
