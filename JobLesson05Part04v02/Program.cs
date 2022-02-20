using System;
using System.IO;

namespace JobLesson05Part04v02
{
    internal class Program
    {
        //Получение файлов и категорий 1-ого уровня
        static void Main()
        {
            string dirName = null;
            string name = TreeOfCategory(dirName);
            Console.WriteLine(name);
        }
        static string TreeOfCategory(string dirName)
        {

            string structDirName = @"F:\CategoryForTree";

            if (Directory.Exists(structDirName))
            {
                Console.WriteLine("Подкаталоги:");
                File.AppendAllText("Structure.txt", Environment.NewLine + "Подкаталоги:");
                string[] dirs = Directory.GetDirectories(structDirName);

                foreach (string s in dirs)
                {
                    Console.WriteLine(s);
                    File.AppendAllText("Structure.txt", Environment.NewLine + s);


                }
                Console.WriteLine();
                Console.WriteLine("Файлы:");
                File.AppendAllText("Structure.txt", Environment.NewLine + Environment.NewLine + "Файлы:");
                string[] files = Directory.GetFiles(structDirName);
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                    File.AppendAllText("Structure.txt", Environment.NewLine + s);
                }

            }
            return structDirName;
        }
    }
}
