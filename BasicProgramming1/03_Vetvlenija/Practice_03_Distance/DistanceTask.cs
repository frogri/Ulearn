using System;

namespace DistanceTask
{
    public static class DistanceTask
    {
        // Расстояние от точки P(x, y) до отрезка AB с координатами A(ax, ay), B(bx, by)
        public static double GetDistanceToSegment(double ax, double ay, double bx, double by, double x, double y)
        {
            var distance = double.NaN;

            // длины отрезков
            var lengthAB = Math.Round(Math.Abs(Math.Sqrt(Math.Pow(ax - bx, 2) + Math.Pow(ay - by, 2))), 3);
            var lengthPA = Math.Round(Math.Abs(Math.Sqrt(Math.Pow(x - ax, 2) + Math.Pow(y - ay, 2))), 3);
            var lengthPB = Math.Round(Math.Abs(Math.Sqrt(Math.Pow(x - bx, 2) + Math.Pow(y - by, 2))), 3);

            // 1) Если РА или РВ равен 0, то точка Р совпадает с одной из точек А или В.
            // Следовательно, расстояние равно нулю
            if (IsDoubleZero(lengthPA) || IsDoubleZero(lengthPB))
                return 0.0;

            // 2) Если длина АВ равна 0, то точки А и В совпадают.
            // Следовательно, расстоянием до АВ будет либо РА, либо РВ (так как в этом случае РА = РВ) 
            if (IsDoubleZero(lengthAB))
                return lengthPA;

            //// 3) Если сторона AB является самой длинной стороной треугольника или треугольник равносторонний,
            //// то высота, опущенная из точки P на отрезок AB пересекает отрезок AB.
            //// В этом случае расстоянием от P до отрезка будет равно высоте треугольника,
            //// опущенной из точки P на основание AB.
            //if (lengthAB >= lengthPA && lengthAB >= lengthPB)
            //{
            //    var p = (lengthAB + lengthPA + lengthPB) / 2;   // полупериметр
            //    distance = (2 / lengthAB) * Math.Sqrt(p * (p - lengthAB) * (p - lengthPA) * (p - lengthPB));
            //    return distance;
            //}

            //// 4) Если сторона AB не является самой длинной стороной треугольника,
            //// то высота, опущенная из точки P на отрезок AB не будет пересекать отрезок AB.
            //// Либо этот треугольник является прямоугольным, где АВ - один из катетов.
            //// В этом случае расстоянием до отрезка АВ будет кратчайшая из сторон РА или РВ.
            //if (lengthAB <= lengthPA || lengthAB <= lengthPB)
            //    return lengthPA < lengthPB ? lengthPA : lengthPB;



            // в итоге помог способ со скалярным произведением вектора.
            // Если оно отрицательное, значит высота не падает на основание и расстоянием будет являться
            // минимальное расстояние от точки до концов отрезка, удачи)






            return distance;
        }

        private static bool IsDoubleZero(double number)
        {
            return Math.Abs(number) < 0.01;
        }

        private static bool AreDoubleEqual(double number1, double number2)
        {
            return Math.Abs(number1 - number2) < 0.01;
        }
    }
}