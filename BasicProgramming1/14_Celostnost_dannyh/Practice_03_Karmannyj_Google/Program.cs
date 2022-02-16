using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace PocketGoogle
{
    internal static class Program
    {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var dictionary = new Dictionary<int, string>();
            var indexer = new Indexer();

            var directoryInfo = new DirectoryInfo("Texts");
            foreach (var file in directoryInfo.GetFiles("*.txt"))
            {
                var parts = file.Name.Split('.');
                var id = int.Parse(parts[0]);
                var text = File.ReadAllText(file.FullName).Replace("\r", "");
                //var text = File.ReadAllText("E:\\Visual Studio Projects\\Ulearn\\BasicProgramming1\\14_Celostnost_dannyh\\Practice_03_Karmannyj_Google\\bin\\Debug\\Texts\\99.txt").Replace("\r", "");
                dictionary[id] = text;
                indexer.Add(id, text);

                //indexer.Remove(id);
                //indexer.Add(id, text);
                //break;
            }

            Application.Run(new PocketGoogleWindow(indexer, dictionary));
        }
    }
}