using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Task2;

public class DoTask
{
    public async void DoTask2()
    {
        IDateTimePrinter europeanDateTimePrinter = new EuropeanDateTimePrinter();
        IDateTimePrinter americanDateTimePrinter = new AmericanDateTimePrinter();

        IDateTimePrinter decoratedEuropeanDateTime = new SuffixDecorator(new PrefixDecorator(europeanDateTimePrinter, "111 "), "TIME");
        IDateTimePrinter decoratedAmericanDateTime = new SuffixDecorator(new PrefixDecorator(americanDateTimePrinter, "111 "), "TIME");
        IDateTimePrinter sample = new PrefixDecorator(decoratedAmericanDateTime, "222");

        while (true) {
            Console.WriteLine("Decorated European DateTime: " + decoratedEuropeanDateTime.Print());
            Console.WriteLine("Decorated American DateTime: " + decoratedAmericanDateTime.Print());
            Console.WriteLine(sample.Print());
            await Task.Delay(1000);
            Console.Clear();
        }
    }
}
