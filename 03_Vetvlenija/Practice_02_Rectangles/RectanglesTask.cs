using System;

namespace Rectangles
{
    public static class RectanglesTask
    {
        // Пересекаются ли два прямоугольника (пересечение только по границе также считается пересечением)
        // так можно обратиться к координатам левого верхнего угла первого прямоугольника: r1.Left, r1.Top
        public static bool AreIntersected(Rectangle r1, Rectangle r2)
        {
            //Прямоугольники НЕ пересекаются:
            // - если левый край первого лежит правее правого края второго
            if (r1.Left > r2.Right)
                return false;

            // - или левый край второго лежит правее правого края первого
            if (r1.Right < r2.Left)
                return false;

            // - или верхний край первого лежит ниже нижнего края второго
            if (r1.Top > r2.Bottom)
                return false;

            // - или верхний край второго лежит ниже нижнего края первого
            if (r1.Bottom < r2.Top)
                return false;

            return true;
        }

        // Площадь пересечения прямоугольников
        public static int IntersectionSquare(Rectangle r1, Rectangle r2)
        {
            if (!AreIntersected(r1, r2))
                return 0;

            int leftX = Math.Max(r1.Left, r2.Left);
            int rightX = Math.Min(r1.Right, r2.Right);
            int topY = Math.Max(r1.Top, r2.Top);
            int bottomY = Math.Min(r1.Bottom, r2.Bottom);

            int width = rightX - leftX;
            int height = bottomY - topY;

            return width * height;
        }

        // Если один из прямоугольников целиком находится внутри другого — вернуть номер (с нуля) внутреннего.
        // Иначе вернуть -1
        // Если прямоугольники совпадают, можно вернуть номер любого из них.
        public static int IndexOfInnerRectangle(Rectangle r1, Rectangle r2)
        {
            if (r1.Left <= r2.Left && r1.Right >= r2.Right && r1.Top <= r2.Top && r1.Bottom >= r2.Bottom)
                return 1;

            if (r2.Left <= r1.Left && r2.Right >= r1.Right && r2.Top <= r1.Top && r2.Bottom >= r1.Bottom)
                return 0;

            return -1;
        }
    }
}