/*
 * Сделайте так, чтобы код заработал!
 * Для этого сделайте класс SuperBeautyImageFilter не статическим.
 */

using System;
using System.Globalization;

namespace _05_Refaktoring_staticheskogo_klassa
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var filter = new SuperBeautyImageFilter();
            filter.ImageName = "Paris.jpg";
            filter.GaussianParameter = 0.4;
            filter.Run();

            Console.ReadKey();
        }

        public class SuperBeautyImageFilter
        {
            public string ImageName;
            public double GaussianParameter;

            public void Run()
            {
                Console.WriteLine("Processing {0} with parameter {1}",
                                  ImageName,
                                  GaussianParameter.ToString(CultureInfo.InvariantCulture));
                //do something useful
            }
        }
    }
}