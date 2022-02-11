using System;
using System.Windows.Forms;

namespace Practice_01_Zemlja_i_digger
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            Game.CreateMap();
            Application.Run(new DiggerWindow());
        }
    }
}