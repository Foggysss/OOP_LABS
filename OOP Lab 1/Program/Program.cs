using System;
using System.ComponentModel.DataAnnotations;
using Task1;
class Program
{
    static void Main(string[] args)
    {
        Task1.Task work = new Task1.Task();
        work.DoTask1();
        Console.Read();
    }
}