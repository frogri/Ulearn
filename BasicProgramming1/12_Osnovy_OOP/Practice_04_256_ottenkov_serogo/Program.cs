/*
Некто хочет использовать вашу геометрическую библиотеку для рисования. 
Для этого ему необходимо, чтобы у вашего класса Segment появился цвет. 
Однако, вам кажется, что втаскивать цвета в чисто геометрическую сущность - плохая идея.

Скачайте проект, установите в нем reference на вашу библиотеку, 
и после этого сделайте так, чтобы методы GetColor и SetColor появились в вашем классе Segment.

Если цвет не задан, GetColor возвращает Color.Black.
 */

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using GeometryTasks;

namespace GeometryPainting
{
    internal static class Program
    {
        private static List<Segment> CreateSegments()
        {
            var result = new List<Segment>();
            for (var i = 0; i <= 255; i++)
            {
                var segment = new Segment
                {
                    Begin = new Vector {X = 0, Y = i}, 
                    End = new Vector {X = 255, Y = i}
                };

                if (i != 0)
                    segment.SetColor(Color.FromArgb(i, i, i));

                result.Add(segment);
            }

            return result;
        }

        private static void DrawSegments(object sender, PaintEventArgs e)
        {
            var segments = CreateSegments();
            foreach (var segment in segments)
            {
                Pen pen = null;
                pen = new Pen(segment.GetColor());
                e.Graphics.DrawLine(pen,
                                    (float) segment.Begin.X,
                                    (float) segment.Begin.Y,
                                    (float) segment.End.X,
                                    (float) segment.End.Y);
            }
        }


        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var form = new Form();
            form.ClientSize = new Size(255, 255);
            form.Paint += DrawSegments;
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.MaximizeBox = false;
            Application.Run(form);
        }
    }
}