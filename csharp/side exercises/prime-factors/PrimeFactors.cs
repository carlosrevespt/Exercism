using System;
using System.Linq;
using System.Collections.Generic;

public static class PrimeFactors
{
    public static long[] Factors(long number)
    {
        return GetFactors(number).OrderBy(i => i).ToArray();
    }

    private static IEnumerable<long> GetFactors (long number){
        while (number % 2L == 0){
            yield return 2L;
            number /= 2L;
        }    

		while (number > 1){			
        	long currFactor = PollardRho(number);
			yield return currFactor;
            number /= currFactor;
		}
    }

    private static long PollardRho (long number)
    {
        long x = 2;
        long xFixed = 2;
        long factor = 0;

        while (factor <= 1) {
            x = PolynomialModulo (x, number);
            xFixed = PolynomialModulo (PolynomialModulo (xFixed, number), number);
            factor = GCD (Math.Abs(xFixed-x), number);
        }

        return factor;        
    }

    private static long PolynomialModulo (long param, long mod) => ((param * param + 1) % mod);
        
    private static long GCD(long x, long y) {
        if (x == 0) return y;
        if (y == 0) return x;
        
        x = x % y;

        return GCD (y, x);
    }

}