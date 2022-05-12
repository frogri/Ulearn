/*
Вам дан список всех классов в школе. Нужно получить список всех учащихся всех классов.
Учебный класс определен так (class Classroom).

Напишите решение этой задачи с помощью LINQ в одно выражение.
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_Objedinenie_kollekcij
{
    public class Classroom
    {
        public List<string> Students = new List<string>();
    }

    internal class Program
    {
        public static void Main()
        {
            Classroom[] classes =
            {
                new Classroom { Students = { "Pavel", "Ivan", "Petr" } },
                new Classroom { Students = { "Anna", "Ilya", "Vladimir" } },
                new Classroom { Students = { "Bulat", "Alex", "Galina" } }
            };

            var allStudents = GetAllStudents(classes);
            Array.Sort(allStudents);
            Console.WriteLine(string.Join(" ", allStudents));

            Console.ReadKey();
        }

        public static string[] GetAllStudents(Classroom[] classes)
        {
            return classes.SelectMany(classroom => classroom.Students).ToArray();
        }
    }
}