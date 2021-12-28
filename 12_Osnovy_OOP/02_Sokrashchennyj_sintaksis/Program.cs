﻿/*
Ваша команда пишет программу с оконным интерфейсом, и вам надо реализовать инициализацию меню.

Для каждого пункта меню указывается название, горячая клавиша (далее указана в скобках) и список подменю (null, если подменю нет).
На верхнем уровне должно находиться два пункта: File (F) и Edit (E).
Меню File должно содержать команды New (N), Save (S).
Меню Edit (E) должно содержать команды Copy (C) и Paste (V).

Решите задачу в одно выражение с использованием сокращенного синтаксиса создания объектов. 
Используйте переводы строк и отступы, чтобы сделать код более читаемым.
 */

using System;

namespace _02_Sokrashchennyj_sintaksis
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var a = GenerateMenu();

            Console.ReadKey();
        }

        public static MenuItem[] GenerateMenu()
        {
            return new[]
            {
                new MenuItem
                {
                    Caption = "File",
                    HotKey = "F",
                    Items = new[]
                    {
                        new MenuItem { Caption = "New", HotKey = "N" }, new MenuItem { Caption = "Save", HotKey = "S" }
                    }
                },
                new MenuItem
                {
                    Caption = "Edit",
                    HotKey = "E",
                    Items = new[]
                    {
                        new MenuItem { Caption = "Copy", HotKey = "C" }, new MenuItem { Caption = "Paste", HotKey = "V" }
                    }
                }
            };
        }

        public class MenuItem
        {
            public string Caption;
            public string HotKey;
            public MenuItem[] Items;
        }
    }
}