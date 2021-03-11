using System;

public static class ArmstrongNumbers
{
    public static bool IsArmstrongNumber(int number)
    {
        if (number < 10)
            return true;

        int digits = NumOfDigits(number);
        int numbertoCheck = number;
        int sumPowers = 0;

        for (int i = 0; i < digits; i++)
        {
            sumPowers += (int)Math.Pow(numbertoCheck % 10, digits);
            numbertoCheck /= 10;

        }

        return sumPowers == number;
    }

    private static int NumOfDigits(int number)
    {
        if (number < 1000000)
        {
            if (number < 1000)
            {
                return number < 100 ? 2 : 3;
            }
            else
            {
                return number < 10000 ? 4 : (number < 100000 ? 5 : 6);
            }
        }
        else
        {
            if (number < 100000000)
            {
                return number < 10000000 ? 7 : 8;
            }
            else
            {
                return number < 1000000000 ? 9 : 10;
            }
        }
    }
}