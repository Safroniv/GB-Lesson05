using System;
using System.IO;


namespace JobLesson05Part02
{
    internal class Program
    {
        //Урок 5 Задание 2
        //Написать программу, которая при старте дописывает текущее время в файл «startup.txt».
        static void Main()
        {
            File.AppendAllText("startup.txt", DateTime.Now.ToShortTimeString());
        }
    }
}
