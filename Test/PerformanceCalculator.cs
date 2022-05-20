using System;
using System.Diagnostics;

namespace Test
{
    public static class PerformanceCalculator
    {
        /// <summary>
        ///     Рассчитывает среднее время, затрачиваемое на выполнение метода
        /// </summary>
        /// <typeparam name="T1">Тип аргумента для проверяемого метода</typeparam>
        /// <param name="action">Указатель на проверяемый метод</param>
        /// <param name="actionArgument">Аргумент для проверяемого метода</param>
        /// <param name="iterations">Количество вызовов проверяемого метода</param>
        /// <returns>Возвращает среднее время выполнения метода в мс</returns>
        public static double Performance<T1>(Action<T1> action, T1 actionArgument, int iterations = 1000)
        {
            // warm up 
            action(actionArgument);

            // clean up
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();

            var watch = new Stopwatch();
            watch.Start();
            for (var i = 0; i < iterations; i++)
                action(actionArgument);
            watch.Stop();

            var averageTime = watch.Elapsed.TotalMilliseconds / iterations;
            Console.WriteLine("Average time: {0} ms", averageTime);

            return averageTime;
        }

        public static double Performance<T1, T2>(Func<T1, T2> func, T1 funcArgument, int iterations = 1000)
        {
            // warm up 
            func(funcArgument);

            // clean up
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();

            var watch = new Stopwatch();
            watch.Start();
            for (var i = 0; i < iterations; i++)
                func(funcArgument);
            watch.Stop();

            var averageTime = watch.Elapsed.TotalMilliseconds / iterations;
            Console.WriteLine("Average time: {0} ms", averageTime);

            return averageTime;
        }
    }
}