//Find the largest palindrome made from the product of two 3-digit numbers.

using System;

public static class Problem4
{
    public static void Execute()
    {
        int largestNumber = 999;
        int smallestNumber = 100;
        long largestPalindrome = 0;

        for(int i = largestNumber; i >= smallestNumber; i--)
        {
            for (int j = largestNumber; j >= smallestNumber; j--)
            {
                long _temp = (i * j);
                if (CheckIfPalindrome(_temp.ToString()))
                {
                    if(_temp > largestPalindrome)
                        largestPalindrome = _temp;
                }
            }
        }

        Console.WriteLine($"The largest palindrome made from the product of two 3-digit numbers is {largestPalindrome}");
    }

    public static bool CheckIfPalindrome(string number)
    {
        char[] theArray = number.ToCharArray();
        Array.Reverse(theArray);
        string theString = new String(theArray);
        if (theString == number)
            return true;
        else
            return false;
    }
}