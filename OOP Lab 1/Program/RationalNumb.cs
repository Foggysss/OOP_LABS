using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Task1;
public class RationalNumb
{
    public int Numerator { get; }
    public int Denominator { get; }

    public RationalNumb(int numerator, int denominator)
    {
        if (denominator == 0)
            throw new ArgumentException("Denominator cannot be zero.");

        int gcd = GreatestCommonDivisor(Math.Abs(numerator), Math.Abs(denominator));
        Numerator = numerator / gcd;
        Denominator = denominator / gcd;

        if (Denominator < 0)
        {
            Numerator *= -1;
            Denominator *= -1;
        }
    }

    public override string ToString()
    {
        if (Numerator == Denominator)
        {
            return $"1";
        }
        if (Denominator == 1)
        {
            return $"{Numerator}";
        }

        return $"{Numerator}/{Denominator}";
    }

    public static RationalNumb operator +(RationalNumb r1, RationalNumb r2)
    {
        int num = r1.Numerator * r2.Denominator + r2.Numerator * r1.Denominator;
        int denom = r1.Denominator * r2.Denominator;
        return new RationalNumb(num, denom);
    }

    public static RationalNumb operator -(RationalNumb r1, RationalNumb r2)
    {   
        int num = r1.Numerator * r2.Denominator - r2.Numerator * r1.Denominator;
        int denom = r1.Denominator * r2.Denominator;
        return new RationalNumb(num, denom);
    }

    public static RationalNumb operator *(RationalNumb r1, RationalNumb r2)
    {
        int num = r1.Numerator * r2.Numerator;
        int denom = r1.Denominator * r2.Denominator;
        return new RationalNumb(num, denom);
    }

    public static RationalNumb operator /(RationalNumb r1, RationalNumb r2)
    {
        if (r2.Numerator == 0)
            throw new DivideByZeroException("Cannot divide by zero.");

        int num = r1.Numerator * r2.Denominator;
        int denom = r1.Denominator * r2.Numerator;
        return new RationalNumb(num, denom);
    }


    public static RationalNumb operator -(RationalNumb r)
    {
        return new RationalNumb(-r.Numerator, r.Denominator);
    }

    public static bool operator ==(RationalNumb r1, RationalNumb r2)
    {
        return r1.Numerator == r2.Numerator && r1.Denominator == r2.Denominator;
    }

    public static bool operator !=(RationalNumb r1, RationalNumb r2)
    {
        return !(r1 == r2);
    }

    public static bool operator <(RationalNumb r1, RationalNumb r2)
    {
        return r1.Numerator * r2.Denominator < r2.Numerator * r1.Denominator;
    }

    public static bool operator >(RationalNumb r1, RationalNumb r2)
    {
        return !(r1 < r2) && r1 != r2;
    }

    public static bool operator <=(RationalNumb r1, RationalNumb r2)
    {
        return !(r1 > r2);
    }

    public static bool operator >=(RationalNumb r1, RationalNumb r2)
    {
        return !(r1 < r2);
    }


    private static int GreatestCommonDivisor(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
}
