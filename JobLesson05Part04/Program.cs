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
            
            string dirName = @"F:\CategoryForTree";
            //static string TreeOfCategory(string dirName)
            //{
                if (Directory.Exists(dirName))
                {
                    Console.WriteLine("Подкаталоги:");
                    File.AppendAllText("Structure.txt", Environment.NewLine + "Подкаталоги:");
                    string[] dirs = Directory.GetDirectories(dirName);
                    foreach (string s in dirs)
                    {
                        Console.WriteLine(s);
                        File.AppendAllText("Structure.txt", Environment.NewLine + s);
                    }
                    Console.WriteLine();
                    Console.WriteLine("Файлы:");
                    File.AppendAllText("Structure.txt", Environment.NewLine + Environment.NewLine + "Файлы:");
                    string[] files = Directory.GetFiles(dirName);
                    foreach (string s in files)
                    {
                        Console.WriteLine(s);
                        File.AppendAllText("Structure.txt", Environment.NewLine + s);
                    }
                }
            //    return TreeOfCategory(dirName);
            //}
        }
    }
}
