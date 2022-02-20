using System;
using System.IO;

namespace JobLesson05Part04v03
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Структура категорий и файлов в: F:\\CategoryForTree\n");
            File.AppendAllText("Structure.txt", "Структура категорий и файлов в: F:\\CategoryForTree\n");
            TreeOfCategory();
        }
        //Формирование структуры для вложений до 3-его уровня включительно
        static string TreeOfCategory()
        {
            string structDirName = @"F:\CategoryForTree";
            Console.WriteLine("Структура:");
            File.AppendAllText("Structure.txt", Environment.NewLine + "Подкаталоги:");
            string[] dirs = Directory.GetDirectories(structDirName);
            foreach (string s in dirs)
            {
                Console.WriteLine("Категория:" + s);
                File.AppendAllText("Structure.txt", Environment.NewLine + "Категория:" + s);
                string[] dirs2 = Directory.GetDirectories(s);
                foreach (string t in dirs2)
                {
                    Console.WriteLine("Подкатегория:" + t);
                    File.AppendAllText("Structure.txt", Environment.NewLine + "Подкатегория:" + t);
                    string[] dirs3 = Directory.GetDirectories(t);
                    foreach (string x in dirs3)
                    {
                        Console.WriteLine("Подподкатегория:" + x);
                        File.AppendAllText("Structure.txt", Environment.NewLine + "Подподкатегория:" + x);
                        string[] files3 = Directory.GetFiles(x);
                        foreach (string y in files3)
                        {
                            Console.WriteLine("Файл подподкатегории:" + y);
                            File.AppendAllText("Structure.txt", Environment.NewLine + "Файл подподкатегории:" + y);
                        }
                    }
                }
                string[] files2 = Directory.GetFiles(s);
                foreach (string u in files2)
                {
                    Console.WriteLine("Файл подкатегории:" + u);
                    File.AppendAllText("Structure.txt", Environment.NewLine + "Файл подкатегории:" + u);
                }
            }
            Console.WriteLine();
            string[] files = Directory.GetFiles(structDirName);
            foreach (string s in files)
            {
                Console.WriteLine("Файл категории:" + s);
                File.AppendAllText("Structure.txt", Environment.NewLine + "Файл категории:" + s);
            }
            return structDirName;
        }
    }
}
