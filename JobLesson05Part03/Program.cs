using System;
using System.IO;


namespace JobLesson05Part03
{
    internal class Program
    {
        //Урок 5 Задание 3
        //Ввести с клавиатуры произвольный набор чисел(0...255) и записать их в бинарный файл.
        
        static void Main()
        {
            Console.WriteLine("Введите количество чисел");
            byte n = byte.Parse(Console.ReadLine());
            byte[] arrayBytes = new byte[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Введите {0}-й элемент", i + 1);
                arrayBytes[i] = byte.Parse(Console.ReadLine());
            }
            File.WriteAllBytes("bytes.bin", arrayBytes);
        }
    }
}
