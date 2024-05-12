using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Task1;
public class Task
{
    public void DoTask1()
    {
        int[] numerator = { 1, 2, 3, 4, 5 };
        int[] denumerator = { 5, 6, 7, 8, 9 };

        foreach (int num in numerator)
        {
            foreach (int denum in denumerator)
            {
                RationalNumb rationNumber = new RationalNumb(num, denum);
                Console.WriteLine(rationNumber.ToString());
            }
        }
        Console.WriteLine("input first rational number");

        string firstRatNumber = Console.ReadLine();
        if (firstRatNumber == null)
        {
            throw new ArgumentException("empty input");
        }

        string[] firstTokens = firstRatNumber.Split("/");
        if (firstTokens.Length != 2)
        {
            if (firstTokens.Length == 1)
            {
                int firstNumerator = int.Parse(firstTokens[0]);
                int firstDenumerator = 1;
            }
            else
            {
                throw new ArgumentException("wrong input");
            }
        }
        else
        {
            int firstNumerator = int.Parse(firstTokens[0]);
            int firstDenumerator = int.Parse(firstTokens[1]);
        }

        Console.WriteLine("input second rational number");

        string secondRatNumber = Console.ReadLine();
        if (secondRatNumber == null)
        {
            throw new ArgumentException("empty input");
        }

        string[] secondTokens = secondRatNumber.Split("/");
        if (secondTokens.Length != 2)
        {
            if (secondTokens.Length == 1)
            {
                int secondNumerator = int.Parse(secondTokens[0]);
                int secondDenumerator = 1;
            }
            else
            {
                throw new ArgumentException("wrong input");
            }
        }
        else
        {
            int secondNumerator = int.Parse(secondTokens[0]);
            int secondDenumerator = int.Parse(secondTokens[1]);
        }
    }
}