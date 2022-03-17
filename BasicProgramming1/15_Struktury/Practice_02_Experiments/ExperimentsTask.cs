using System.Collections.Generic;

namespace StructBenchmarking
{
    public class Experiments
    {
        public static ChartData BuildChartDataForArrayCreation(IBenchmark benchmark, int repetitionsCount)
        {
            var structuresTimes = new List<ExperimentResult>();
            var classesTimes = new List<ExperimentResult>();

            foreach (var size in Constants.FieldCounts)
            {
                var averageTimeStructures = benchmark.MeasureDurationInMs(new StructArrayCreationTask(size), repetitionsCount);
                structuresTimes.Add(new ExperimentResult(size, averageTimeStructures));
                
                var averageTimeClasses = benchmark.MeasureDurationInMs(new ClassArrayCreationTask(size), repetitionsCount);
                classesTimes.Add(new ExperimentResult(size, averageTimeClasses));
            }

            return new ChartData
            {
                Title = "Create array",
                ClassPoints = classesTimes,
                StructPoints = structuresTimes,
            };
        }

        public static ChartData BuildChartDataForMethodCall(IBenchmark benchmark, int repetitionsCount)
        {
            var structuresTimes = new List<ExperimentResult>();
            var classesTimes = new List<ExperimentResult>();

            foreach (var size in Constants.FieldCounts)
            {
                var averageTimeStructures = benchmark.MeasureDurationInMs(new MethodCallWithStructArgumentTask(size), repetitionsCount);
                structuresTimes.Add(new ExperimentResult(size, averageTimeStructures));
                
                var averageTimeClasses = benchmark.MeasureDurationInMs(new MethodCallWithClassArgumentTask(size), repetitionsCount);
                classesTimes.Add(new ExperimentResult(size, averageTimeClasses));
            }

            return new ChartData
            {
                Title = "Call method with argument",
                ClassPoints = classesTimes,
                StructPoints = structuresTimes,
            };
        }
    }
}