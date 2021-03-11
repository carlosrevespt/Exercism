using System;
using System.Text;

public class PhoneNumber
{
    public static string Clean(string phoneNumber)
    {
        return ValidNumber(phoneNumber);
    }

    private static string ValidNumber(string number)
    {
        StringBuilder numberToCheck = new StringBuilder();

        foreach (char c in number)
            if (char.IsDigit(c))
                numberToCheck.Append(c);

        int numberLength = numberToCheck.Length;

        if (numberLength < 10 || numberLength > 11)
            throw new ArgumentException();

        if (numberLength == 11)
        {
            if (numberToCheck[0] != '1')
            {
                throw new ArgumentException();
            }
            else
            {
                numberToCheck.Remove(0, 1);
            }
        }

        if (numberToCheck[0] < '2' || numberToCheck[3] < '2')
            throw new ArgumentException();

        return numberToCheck.ToString();
    }
}