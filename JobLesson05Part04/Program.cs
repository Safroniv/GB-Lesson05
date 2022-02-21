using System;
using System.IO;

namespace JobLesson05Part04
{
    internal class Program
    {
        //Урок 5 Задание 4
        //(*) Сохранить дерево каталогов и файлов по заданному пути в текстовый файл — с рекурсией и без.
        static void Main()
        {
            Console.WriteLine("Структура категорий и файлов в: F:\\CategoryForTree\n");
            File.AppendAllText("Structure.txt", Environment.NewLine + "Структура категорий и файлов в: F:\\CategoryForTree" + Environment.NewLine);
            string path = @"F:\CategoryForTree";
            string[] dirs = Directory.GetDirectories(path);
            for (int i = 0; i < dirs.Length; i++)
            {
                Console.WriteLine("|" + dirs[i]);
                File.AppendAllText("Structure.txt", Environment.NewLine + "|" + dirs[i]);
            }
            TreeOfCategory(path);
        }

        static string TreeOfCategory(string path)
        {
            string structDirName = path;
            string[] dirs = Directory.GetDirectories(structDirName);
            for (int i = 0; i < dirs.Length; i++)
            {
                if (Directory.Exists(dirs[i]))
                {
                    string[] subDirs = Directory.GetFileSystemEntries(TreeOfCategory(dirs[i]));
                    for (int j = 0; j < subDirs.Length; j++)
                    {
                        Console.WriteLine("||" + subDirs[j]);
                        File.AppendAllText("Structure.txt", Environment.NewLine + "||" + subDirs[j]);
                    }
                }
            }
            return structDirName;
        }
    }
}

