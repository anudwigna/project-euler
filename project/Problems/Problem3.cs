//What is the largest prime factor of the number 600851475143 ?

using System;

public class Problem3
{
    public static void Execute()
    {
        long n = 600851475143;
        long maxPrime = -1;
        while(n % 2 == 0)
        {
            maxPrime = 2;
            n >>= 1;
        }

        for (int i = 3; i <= Math.Sqrt(n); i += 2) 
        { 
            while (n % i == 0) 
            { 
                maxPrime = i; 
                n = n / i; 
            } 
        } 

        if (n > 2) 
            maxPrime = n; 
        
        Console.WriteLine($"The largest prime factor of 600851475143 is {maxPrime}");
    }
}