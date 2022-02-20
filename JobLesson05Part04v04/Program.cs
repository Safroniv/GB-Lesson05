using System;
using System.IO;

namespace JobLesson05Part04v04
{
    internal class Program
    {
        static void Main()
        {
 
            Console.WriteLine("Структура категорий и файлов в: F:\\CategoryForTree\n\n");
            File.AppendAllText("Structure.txt", "Структура категорий и файлов в: F:\\CategoryForTree\n"+ Environment.NewLine);
            TreeOfCategory();
        }
        //структура через if
        static string TreeOfCategory()
        {
            string structDirName = @"F:\CategoryForTree";
            string[] dirs = Directory.GetDirectories(structDirName);
            if (Directory.Exists(structDirName))
            {

                for (int i = 0; i < dirs.Length; i++)
                {
                    Console.WriteLine("|-"+dirs[i]);
                    File.AppendAllText("Structure.txt", Environment.NewLine + "|-" + dirs[i]);

                    if (Directory.Exists(dirs[i]))
                    {
                        string[] subDirs = Directory.GetDirectories(dirs[i]);
                        for (int j = 0; j < subDirs.Length; j++)
                        {
                            Console.WriteLine("||-" + subDirs[j]);
                            File.AppendAllText("Structure.txt", Environment.NewLine + "||-" + subDirs[j]);
                            if (Directory.Exists(subDirs[j]))
                            {
                                string[] subSubDirsFiles = Directory.GetFileSystemEntries(subDirs[j]);
                                for (int l = 0; l < subSubDirsFiles.Length; l++)
                                {
                                    Console.WriteLine("|||-" + subSubDirsFiles[l]);
                                    File.AppendAllText("Structure.txt", Environment.NewLine + "|||-" + subSubDirsFiles[l]);
                                }
                                                                
                            }
                        }
                        string[] files2 = Directory.GetFiles(dirs[i]);
                        for (int k = 0; k < files2.Length; k++)
                        {
                            Console.WriteLine("||-" + files2[k]);
                            File.AppendAllText("Structure.txt", Environment.NewLine + "||-" + files2[k]);

                        }
                    }
                }
                string[] files = Directory.GetFiles(structDirName);
                for (int i = 0; i < files.Length; i++)
                {
                    Console.WriteLine("|-" + files[i]);
                    File.AppendAllText("Structure.txt", Environment.NewLine + "|-" + files[i]);

                }

            }
            return structDirName;
        }
    }
}


