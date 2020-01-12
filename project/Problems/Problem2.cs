//By considering the terms in the Fibonacci sequence 
//whose values do not exceed four million, find the sum of the even-valued terms.

using System;

public class Problem2
{
    public static void Execute()
    {
        int x1 = 1, x2 = 2, _temp = 0, 
        // The first two starting numbers are 1 & 2 and 2 is also an even number.
        sum = x2;
        while(true)
        {
            _temp = 0;
            _temp = x1 + x2;
            if(_temp > 4000000)
                break;
            if(_temp % 2 == 0)
                sum += _temp;
            x1 = x2;
            x2 = _temp;
        }
        Console.WriteLine($"The sum of the even-valued terms is {sum}");
    }
}