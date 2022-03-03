using System;
using System.Diagnostics;
using System.Text;
using NUnit.Framework;

namespace StructBenchmarking
{
    public class Benchmark : IBenchmark
    {
        public double MeasureDurationInMs(ITask task, int repetitionCount)
        {
            task.Run();

            GC.Collect();                   // Эти две строчки нужны, чтобы уменьшить вероятность того,
            GC.WaitForPendingFinalizers();  // что Garbadge Collector вызовется в середине измерений
                                            // и как-то повлияет на них.

            var watch = new Stopwatch();
            watch.Start();

            for (var i = 0; i < repetitionCount; i++)
                task.Run();

            watch.Stop();

            var result = watch.Elapsed.TotalMilliseconds / repetitionCount;

            return result;
        }
    }

    [TestFixture]
    public class RealBenchmarkUsageSample
    {
        [Test]
        public void StringConstructorFasterThanStringBuilder()
        {
            var watch = new Stopwatch();
            watch.Start();

            var benchmark = new Benchmark();

            var durationBuilder = benchmark.MeasureDurationInMs(new StringBuilderCreator(), 50000);
            var durationConstructor = benchmark.MeasureDurationInMs(new StringConstructorCreator(), 50000);

            Assert.Less(durationConstructor, durationBuilder);

            watch.Stop();
            var duration = watch.Elapsed.TotalMilliseconds;
        }
    }

    public class StringBuilderCreator : ITask
    {
        public void Run()
        {
            var builder = new StringBuilder();
            builder.Append('a', 10000);
        }
    }

    public class StringConstructorCreator : ITask
    {
        public void Run()
        {
            var str = new string('a', 10000);
        }
    }
}