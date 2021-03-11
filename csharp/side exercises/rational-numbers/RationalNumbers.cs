using System;
using System.Diagnostics;

public static class RealNumberExtension
{
    public static double Expreal(this int realNumber, RationalNumber r)
    {
        return Math.Pow(realNumber, (double)r.Numerator / (double)r.Denominator);
    }
}

public struct RationalNumber
{
    public RationalNumber(int numerator, int denominator)
    {
        if (denominator == 0) throw new ArgumentException();

        this.Numerator = numerator;
        this.Denominator = denominator;
    }

    public int Numerator { get; private set; }

    public int Denominator { get; private set; }

    public static RationalNumber operator +(RationalNumber r1, RationalNumber r2)
    {
        return new RationalNumber((r1.Numerator * r2.Denominator) + (r2.Numerator * r1.Denominator), (r1.Denominator * r2.Denominator)).Reduce();
    }

    public static RationalNumber operator -(RationalNumber r1, RationalNumber r2)
    {
        return r1 + new RationalNumber(-r2.Numerator, r2.Denominator);
    }

    public static RationalNumber operator *(RationalNumber r1, RationalNumber r2)
    {
        return new RationalNumber(r1.Numerator * r2.Numerator, r1.Denominator * r2.Denominator).Reduce();
    }

    public static RationalNumber operator /(RationalNumber r1, RationalNumber r2)
    {
        return r1 * new RationalNumber(r2.Denominator, r2.Numerator);
    }

    public RationalNumber Abs() => new RationalNumber(Math.Abs(Numerator), Math.Abs(Denominator)).Reduce();

    public RationalNumber Reduce()
    {
        if (Numerator == 0) return new RationalNumber(0, 1);
        int currGcd = gcd(Numerator, Denominator) * (Denominator < 0 ? -1 : 1);
        return new RationalNumber(Numerator / currGcd, Denominator / currGcd);
    }

    public RationalNumber Exprational(int power)
    {
        int num;
        int den;
        if (Numerator == 0)
        {
            if (power < 0) throw new ArgumentException();

            //Assuming the definition 0^0 = 1
            num = (power == 0 ? 1 : 0);
            den = 1;
        }
        else if (Numerator == 1 && Denominator == 1)
        {
            num = 1;
            den = 1;
        }
        else if (power == 0)
        {
            num = 1;
            den = 1;
        }
        else if (power == 1)
        {
            num = Numerator;
            den = Denominator;
        }
        else if (power > 1)
        {
            num = (int)Math.Pow(Numerator, power);
            den = (int)Math.Pow(Denominator, power);
        }
        else
        {
            num = (int)Math.Pow(Denominator, power);
            den = (int)Math.Pow(Numerator, power);
        }

        return new RationalNumber(num, den).Reduce();
    }

    public double Expreal(int baseNumber) => baseNumber.Expreal(this);

    private int gcd(int num, int den)
    {
        num = Math.Abs(num);
        den = Math.Abs(den);

        if (num == den) return num;

        if (num < den)
        {
            int tmp = num;
            num = den;
            den = tmp;
        }

        return den == 0 ? num : gcd(den, num % den);
    }
}