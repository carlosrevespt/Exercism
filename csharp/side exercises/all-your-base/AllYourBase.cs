using System;
using System.Collections.Generic;

public static class AllYourBase
{
    public static int[] Rebase(int inputBase, int[] inputDigits, int outputBase)
    {
        if (inputBase < 2 || outputBase < 2) throw new ArgumentException();

        if (inputDigits.Length == 0) return new int[] {0};

        if (inputBase == outputBase) return inputDigits;

        if (outputBase == 10) {
            return toBaseTen(inputBase, inputDigits);
            
        } else if (inputBase == 10){
            return fromBaseTen(outputBase, inputDigits);

        } else return fromBaseTen(outputBase, toBaseTen(inputBase, inputDigits));
    }

    private static int[] toBaseTen (int inputBase, int[] digits){
        List<int> result = new List<int>();
        int temp = 0;

        for (int i = 0; i < digits.Length; i++){
            if (digits[i] < 0 || digits[i] > inputBase - 1) throw new ArgumentException();
            temp += (int) (digits[i] * Math.Pow(inputBase, digits.Length - 1 - i));
        }

        if (temp == 0) result.Add(0);

        while (temp > 0){
            result.Insert(0, temp % 10);
            temp /= 10;
        }

        return result.ToArray();
    }

    private static int[] fromBaseTen (int outputBase, int[] digits){
        List<int> result = new List<int>();
        int temp = 0;

        for (int i = 0; i < digits.Length; i++){
            if (digits[i] < 0 || digits[i] > 9) throw new ArgumentException();
            temp = (i == 0 ? digits[i] : temp * 10 + digits[i]);
        }

        if (temp == 0) result.Add(0);

        while (temp > 0){
            result.Insert(0, temp % outputBase);
            temp /= outputBase;
        }

        return result.ToArray();
    }
}