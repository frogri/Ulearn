/*
В этом задании нужно реализовать метод в классе SentencesParserTask. Метод должен делать следующее:

Разделять текст на предложения, а предложения на слова.
a. Считайте, что слова состоят только из букв (используйте метод char.IsLetter) или символа апострофа ' и отделены друг от друга любыми другими символами.
b. Предложения состоят из слов и отделены друг от друга одним из следующих символов .!?;:()

Приводить символы каждого слова в нижний регистр.
Пропускать предложения, в которых не оказалось слов.
Метод должен возвращать список предложений, где каждое предложение — это список из одного или более слов в нижнем регистре. */

using System;
using System.IO;
using NUnitLite;

namespace TextAnalysis
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            // Запуск автоматических тестов. Ниже список тестовых наборов, который нужно запустить.
            // Закомментируйте тесты на те задачи, к которым ещё не приступали, чтобы они не мешались в консоли.
            // Все непрошедшие тесты 
            var testsToRun = new string[]
            {
                "TextAnalysis.SentencesParser_Tests",
                //"TextAnalysis.FrequencyAnalysis_Tests",
                //"TextAnalysis.TextGenerator_Tests",
            };
            new AutoRun().Execute(new[]
            {
                "--stoponerror", // Останавливать после первого же непрошедшего теста. Закомментируйте, чтобы увидеть все падающие тесты
                "--noresult",
                "--test=" + string.Join(",", testsToRun)
            });

            var text = File.ReadAllText("HarryPotterText.txt");
            var sentences = SentencesParserTask.ParseSentences(text);
            var frequency = FrequencyAnalysisTask.GetMostFrequentNextWords(sentences);
            //Расскомментируйте этот блок, если хотите выполнить последнюю задачу до первых двух.
            /*
            frequency = new Dictionary<string, string>
            {
                {"harry", "potter"},
                {"potter", "boy" },
                {"boy", "who" },
                {"who", "likes" },
                {"boy who", "survived" },
                {"survived", "attack" },
                {"he", "likes" },
                {"likes", "harry" },
                {"ron", "likes" },
                {"wizard", "harry" },
            };
            */
            while (true)
            {
                Console.Write("Введите первое слово (например, harry): ");
                var beginning = Console.ReadLine();
                if (string.IsNullOrEmpty(beginning)) return;
                var phrase = TextGeneratorTask.ContinuePhrase(frequency, beginning.ToLower(), 10);
                Console.WriteLine(phrase);
            }
        }
    }
}