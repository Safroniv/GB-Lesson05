using System;
using System.IO;

namespace JobLesson05Part04
{
    internal class Program
    {
        //Урок 5 Задание 4
        //(*) Сохранить дерево каталогов и файлов по заданному пути в текстовый файл — с рекурсией и без.

        //Для рекурсии пример прошлого задания:
        //int number = 20;
        //Console.WriteLine(GetFibonacci(number));
        //static int GetFibonacci(int number)
        //{
        //    if (number == 0 || number == 1)
        //    {
        //        return number;
        //    }
        //    return GetFibonacci(number - 1) + GetFibonacci(number - 2);
        //}
        static void Main()
        {
            
            Console.WriteLine("Структура категорий и файлов в: F:\\CategoryForTree\n");
            File.AppendAllText("Structure.txt", "Структура категорий и файлов в: F:\\CategoryForTree\n");
            TreeOfCategory(structDirName);

        }



        static string TreeOfCategory(string[] path)
        {
            string structDirName = @"F:\CategoryForTree";
            string[] dirs = Directory.GetDirectories(structDirName);
            for (int i = 0; i < dirs.Length; i++)
            {
                Console.WriteLine("Подкатегория:" + dirs[i]);
                File.AppendAllText("Structure.txt", Environment.NewLine + "Подкатегория:" + dirs[i]);

            }

            return structDirName;
        }
    }
}
//структура через if
//if (Directory.Exists(structDirName))
//{
//    string[] dirs = Directory.GetDirectories(structDirName);
//    for (int i = 0; i < dirs.Length; i++)
//    {
//        Console.WriteLine("Категория:" + dirs[i]);
//        File.AppendAllText("Structure.txt", Environment.NewLine + "Категория:" + dirs[i]);

//        if (Directory.Exists(dirs[i]))
//        {
//            string[] subDirs = Directory.GetFileSystemEntries(dirs[i]);
//            for (int j = 0; j < subDirs.Length; j++)
//            {
//                Console.WriteLine("Подкатегория или файл:" + subDirs[j]);
//                File.AppendAllText("Structure.txt", Environment.NewLine + "Подкатегория или Файл:" + subDirs[j]);

//            }
//        }
//    }
//    string[] files = Directory.GetFiles(structDirName);
//    for (int i = 0; i < files.Length; i++)
//    {
//        Console.WriteLine("Файлы категории:" + files[i]);
//        File.AppendAllText("Structure.txt", Environment.NewLine + "Файлы категории:" + files[i]);

//    }
//}
//Формирование структуры для вложений до 3-его уровня включительно
//static string TreeOfCategory()
//{
//    string structDirName = @"F:\CategoryForTree";
//    Console.WriteLine("Структура:");
//    File.AppendAllText("Structure.txt", Environment.NewLine + "Подкаталоги:");
//    string[] dirs = Directory.GetDirectories(structDirName);
//    foreach (string s in dirs)
//    {
//        Console.WriteLine("Категория:" + s);
//        File.AppendAllText("Structure.txt", Environment.NewLine + "Категория:" + s);
//        string[] dirs2 = Directory.GetDirectories(s);
//        foreach (string t in dirs2)
//        {
//            Console.WriteLine("Подкатегория:" + t);
//            File.AppendAllText("Structure.txt", Environment.NewLine + "Подкатегория:" + t);
//            string[] dirs3 = Directory.GetDirectories(t);
//            foreach (string x in dirs3)
//            {
//                Console.WriteLine("Подподкатегория:" + x);
//                File.AppendAllText("Structure.txt", Environment.NewLine + "Подподкатегория:" + x);
//                string[] files3 = Directory.GetFiles(x);
//                foreach (string y in files3)
//                {
//                    Console.WriteLine("Файл подподкатегории:" + y);
//                    File.AppendAllText("Structure.txt", Environment.NewLine + "Файл подподкатегории:" + y);
//                }
//            }
//        }
//        string[] files2 = Directory.GetFiles(s);
//        foreach (string u in files2)
//        {
//            Console.WriteLine("Файл подкатегории:" + u);
//            File.AppendAllText("Structure.txt", Environment.NewLine + "Файл подкатегории:" + u);
//        }
//    }
//    Console.WriteLine();
//    string[] files = Directory.GetFiles(structDirName);
//    foreach (string s in files)
//    {
//        Console.WriteLine("Файл категории:" + s);
//        File.AppendAllText("Structure.txt", Environment.NewLine + "Файл категории:" + s);
//    }
//    return structDirName;
//}

