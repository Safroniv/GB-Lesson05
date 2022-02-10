using System;
using System.IO;

namespace JobLesson05Part01
{
    internal class Program
    {
        //Урок 5 Задание 1
        //Ввести с клавиатуры произвольный набор данных и сохранить его в текстовый файл.

        static void Main()
        {
            Console.WriteLine("Здравствуйте, введите данные для сохранения в файл:");
            string inputData = Console.ReadLine();
            string inputInFile = "text.txt";
            File.WriteAllText(inputInFile, inputData);
        }
    }
}
