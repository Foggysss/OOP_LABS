using System;
using System.ComponentModel.DataAnnotations;
using Task2;
class Program
{
    static void Main(string[] args)
    {
        Task2.DoTask work = new Task2.DoTask();
        work.DoTask2();
        Console.Read();
    }
}
