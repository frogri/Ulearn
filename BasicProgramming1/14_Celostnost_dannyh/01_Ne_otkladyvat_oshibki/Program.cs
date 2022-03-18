/*Если в свойстве Name окажется null, то с ошибкой завершится метод FormatStudent.
Чтобы предотвратить отложенную ошибку, сделайте так, 
чтобы свойству Name нельзя было присвоить null. 

При попытке это сделать бросайте исключение оператором throw new ArgumentException();
*/

using System;

namespace _01_Ne_otkladyvat_oshibki
{
    public class Program
    {
        public static void Main(string[] args)
        {
            WriteStudent();

            Console.ReadKey();
        }

        private static void WriteStudent()
        {
            // ReadName считает неизвестно откуда имя очередного студента
            //var student = new Student { Name = ReadName() };
            var student = new Student { Name = "Mike" };
            Console.WriteLine("student " + FormatStudent(student));
        }

        private static string FormatStudent(Student student)
        {
            return student.Name.ToUpper();
        }

        public class Student
        {
            private string name;

            public string Name
            {
                get
                {
                    return name;
                }
                set
                {
                    name = value ?? throw new ArgumentException();
                }
            }
        }
    }
}