//Напишите здесь код, который заставит работать методы segment.GetColor и segment.SetColor

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeometryTasks;

namespace GeometryPainting
{
    public static class SegmentExtension
    {
        private static readonly Dictionary<Segment, Color> ColorCollection =
            new Dictionary<Segment, Color>();

        public static void SetColor(this Segment segment, Color fromArgb)
        {
            ColorCollection.Add(segment, fromArgb);
        }

        public static Color GetColor(this Segment segment)
        {
            foreach (var item in ColorCollection)
            {
                if (Math.Abs(item.Key.Begin.X - segment.Begin.X) < 0.01
                    && Math.Abs(item.Key.Begin.Y - segment.Begin.Y) < 0.01
                    && Math.Abs(item.Key.End.X - segment.End.X) < 0.01
                    && Math.Abs(item.Key.End.Y - segment.End.Y) < 0.01)
                {
                    return item.Value;
                }
            }

            return Color.Black;
        }
    }
}