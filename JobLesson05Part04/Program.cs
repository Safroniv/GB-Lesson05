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
        //    {return number;}
        //    return GetFibonacci(number - 1) + GetFibonacci(number - 2);
        //}
        static void Main()
        {            
            Console.WriteLine("Структура категорий и файлов в: F:\\CategoryForTree\n");
            File.AppendAllText("Structure.txt", "Структура категорий и файлов в: F:\\CategoryForTree\n");
            TreeOfCategory();
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

