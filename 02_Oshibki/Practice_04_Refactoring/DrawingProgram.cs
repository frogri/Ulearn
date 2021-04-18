using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace RefactorMe
{
    public class Drawer
    {
        private static float x;
        private static float y;
        private static Graphics graphic;

        public static void Initialize(Graphics newGraphic)
        {
            graphic = newGraphic;
            graphic.SmoothingMode = SmoothingMode.None;
            graphic.Clear(Color.Black);
        }

        public static void SetPosition(float x0, float y0)
        {
            x = x0;
            y = y0;
        }

        /// <summary>
        /// Делает шаг длиной length в направлении angle и рисует пройденную траекторию
        /// </summary>
        /// <param name="pen"></param>
        /// <param name="length"></param>
        /// <param name="angle"></param>
        public static void DrawLine(Pen pen, double length, double angle)
        {
            var x1 = (float)(x + length * Math.Cos(angle));
            var y1 = (float)(y + length * Math.Sin(angle));
            graphic.DrawLine(pen, x, y, x1, y1);
            x = x1;
            y = y1;
        }

        public static void Change(double length, double angle)
        {
            x = (float)(x + length * Math.Cos(angle));
            y = (float)(y + length * Math.Sin(angle));
        }
    }

    public class ImpossibleSquare
    {
        private const double Coefficient1 = 0.375f;
        private const double Coefficient2 = 0.04f;
        public static void Draw(int width, int height, double turnAngle, Graphics graphic)
        {
            // turnAngle пока не используется, но будет использоваться в будущем
            Drawer.Initialize(graphic);

            var shortSideLength = Math.Min(width, height);

            var diagonalLength = Math.Sqrt(2) * (shortSideLength * Coefficient1 + shortSideLength * Coefficient2) / 2;
            var x0 = (float)(diagonalLength * Math.Cos(Math.PI / 4 + Math.PI)) + width / 2f;
            var y0 = (float)(diagonalLength * Math.Sin(Math.PI / 4 + Math.PI)) + height / 2f;

            Drawer.SetPosition(x0, y0);

            DrawSide1(shortSideLength);
            DrawSide2(shortSideLength);
            DrawSide3(shortSideLength);
            DrawSide4(shortSideLength);
        }

        /// <summary>
        /// Рисуем 1-ую сторону
        /// </summary>
        private static void DrawSide1(int length)
        {
            Drawer.DrawLine(Pens.Yellow, length * Coefficient1, 0);
            Drawer.DrawLine(Pens.Yellow, length * Coefficient2 * Math.Sqrt(2), Math.PI / 4);
            Drawer.DrawLine(Pens.Yellow, length * Coefficient1, Math.PI);
            Drawer.DrawLine(Pens.Yellow, length * Coefficient1 - length * Coefficient2, Math.PI / 2);

            Drawer.Change(length * Coefficient2, -Math.PI);
            Drawer.Change(length * Coefficient2 * Math.Sqrt(2), 3 * Math.PI / 4);
        }

        /// <summary>
        /// Рисуем 2-ую сторону
        /// </summary>
        private static void DrawSide2(int length)
        {
            Drawer.DrawLine(Pens.Yellow, length * Coefficient1, -Math.PI / 2);
            Drawer.DrawLine(Pens.Yellow, length * Coefficient2 * Math.Sqrt(2), -Math.PI / 2 + Math.PI / 4);
            Drawer.DrawLine(Pens.Yellow, length * Coefficient1, -Math.PI / 2 + Math.PI);
            Drawer.DrawLine(Pens.Yellow, length * Coefficient1 - length * Coefficient2, -Math.PI / 2 + Math.PI / 2);

            Drawer.Change(length * Coefficient2, -Math.PI / 2 - Math.PI);
            Drawer.Change(length * Coefficient2 * Math.Sqrt(2), -Math.PI / 2 + 3 * Math.PI / 4);
        }

        /// <summary>
        /// Рисуем 3-ю сторону
        /// </summary>
        private static void DrawSide3(int length)
        {
            Drawer.DrawLine(Pens.Yellow, length * Coefficient1, Math.PI);
            Drawer.DrawLine(Pens.Yellow, length * Coefficient2 * Math.Sqrt(2), Math.PI + Math.PI / 4);
            Drawer.DrawLine(Pens.Yellow, length * Coefficient1, Math.PI + Math.PI);
            Drawer.DrawLine(Pens.Yellow, length * Coefficient1 - length * Coefficient2, Math.PI + Math.PI / 2);

            Drawer.Change(length * Coefficient2, Math.PI - Math.PI);
            Drawer.Change(length * Coefficient2 * Math.Sqrt(2), Math.PI + 3 * Math.PI / 4);
        }

        /// <summary>
        /// Рисуем 3-ю сторону
        /// </summary>
        private static void DrawSide4(int length)
        {
            Drawer.DrawLine(Pens.Yellow, length * Coefficient1, Math.PI / 2);
            Drawer.DrawLine(Pens.Yellow, length * Coefficient2 * Math.Sqrt(2), Math.PI / 2 + Math.PI / 4);
            Drawer.DrawLine(Pens.Yellow, length * Coefficient1, Math.PI / 2 + Math.PI);
            Drawer.DrawLine(Pens.Yellow, length * Coefficient1 - length * Coefficient2, Math.PI / 2 + Math.PI / 2);

            Drawer.Change(length * Coefficient2, Math.PI / 2 - Math.PI);
            Drawer.Change(length * Coefficient2 * Math.Sqrt(2), Math.PI / 2 + 3 * Math.PI / 4);
        }
    }
}