// Задача-загадка.Задания нет — так и задумано.Не бойтесь экспериментировать.
// Запустите код на выполнение и внимательно изучите ошибки.Ориентируясь на текст ошибок 
// попробуйте сами понять, что нужно сделать.
// Эта задача требует смекалки и упорства!

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sdelay_to_ne_znayu_chto
{
    class Program
    {
        static void Main(string[] args)
        {
            //текст программы
        }

        static string Decode(string i)
        {
            i = i.Replace(".", "");
            i = Convert.ToString(int.Parse(i) % 1024);
            return i;
        }
    }
}
