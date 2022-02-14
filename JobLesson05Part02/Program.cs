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
            //без секунд:
            File.AppendAllText("startup.txt", Environment.NewLine + DateTime.Now.ToShortTimeString());
            //или с секундами:
            File.AppendAllText("startup.txt", Environment.NewLine + DateTime.Now.ToLongTimeString());
            //или обе строки без секунд и с секундами:
            File.AppendAllLines("startup.txt", new[] { Environment.NewLine + DateTime.Now.ToShortTimeString(), DateTime.Now.ToLongTimeString() }); 
        }
    }
}
