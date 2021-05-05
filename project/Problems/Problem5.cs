//What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?

using System;
using System.Collections.Generic;
using System.Text;

namespace project.Problems
{
    public static class Problem5
    {
        public static void Execute()
        {
            int i = 1;
            int theNumber = 0;

            while(true)
            {
                bool isTheNumber = true;
                for (int j = 1; j <= 20; j++)
                {
                    bool flag = true;
                    if (i % j != 0)
                    {
                        flag = false;
                        isTheNumber = false;
                        break;
                    }
                }
                
                if (isTheNumber == true)
                {
                    theNumber = i;
                    break;
                }

                i++;
            }

            Console.WriteLine($"The number is: {theNumber}");
            Console.ReadLine();
        }
    }
}
