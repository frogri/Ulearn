/*
Так получилось, что вы пишете духовную операционную систему "Оконце, версия 0.99", 
и модуль к этой системе, отвечающий за составление медиа-альбомов пользователя.

По данному вам списку файлов составьте список всех директорий, 
которые содержат файлы с расширением .mp3 и .wav.

Каждую директорию нужно вернуть только один раз, порядок значения не имеет.
 */

using System;
using System.Collections.Generic;
using System.IO;

namespace _04_Spisok_direktorij
{
    internal class Program
    {
        public static List<DirectoryInfo> GetAlbums(List<FileInfo> files)
        {
            var albums = new List<DirectoryInfo>();

            foreach (var file in files)
            {
                if (!file.Extension.Equals(".mp3") && !file.Extension.Equals(".wav"))
                    continue;

                if (!albums.Exists(item => item.FullName == file.DirectoryName))
                    albums.Add(file.Directory);
            }

            return albums;
        }

        private static void Main(string[] args)
        {
            var files = new List<FileInfo>();
            var path = Path.Combine(Environment.CurrentDirectory, "..\\..\\Files");

            var dirInfo = new DirectoryInfo(path);
            foreach (var directory in dirInfo.GetDirectories()) files.AddRange(directory.GetFiles());

            GetAlbums(files);

            Console.ReadKey();
        }

        //public static List<DirectoryInfo> GetAlbums(List<FileInfo> files)
        //{
        //    var albums = new List<DirectoryInfo>();
        //    var mediaFiles = files.Where(info => info.Extension.Equals(".mp3") || info.Extension.Equals(".wav"));

        //    foreach (var file in mediaFiles)
        //    {
        //        if (!albums.Exists(item => item.FullName == file.DirectoryName))
        //            albums.Add(file.Directory);
        //    }

        //    return albums;
        //}
    }
}