﻿using System;
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

            ReadAllFiles(dictionary, indexer);

            Application.Run(new PocketGoogleWindow(indexer, dictionary));
        }

        private static void ReadAllFiles(IDictionary<int, string> dictionary, IIndexer indexer)
        {
            var directoryInfo = new DirectoryInfo("Texts");
            foreach (var file in directoryInfo.GetFiles("*.txt"))
            {
                var parts = file.Name.Split('.');
                var id = int.Parse(parts[0]);
                var text = File.ReadAllText(file.FullName).Replace("\r", string.Empty);

                dictionary[id] = text;
                indexer.Add(id, text);
            }
        }
    }
}