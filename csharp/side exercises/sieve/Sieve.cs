using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

public static class Sieve
{
    public static int[] Primes(int limit)
    {
        if (limit < 2) throw new ArgumentOutOfRangeException();
        
        return getSieve(limit).ToArray();
    }

    private static IEnumerable<int> getSieve(int limit){
        BitArray notPrime = new BitArray(limit + 1);
        int sqrtLimit = (int)Math.Sqrt(limit);

        for (int currNum = 2; currNum < sqrtLimit + 1; currNum++){
            if (!notPrime[currNum]) {
                yield return currNum;
                for (int i = currNum * currNum; i < limit + 1; i += currNum)
                    notPrime[i] = true;                
            }
        }

        for (int currNum = sqrtLimit + 1; currNum < limit + 1; currNum++){
            if (!notPrime[currNum]) yield return currNum;
        }
        
    }
}