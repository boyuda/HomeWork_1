using System;
using System.Collections.Generic;

namespace Task_1
{
    class NumbersLists
    {
        public static List<String> AddToLists(int firstNumber, int secondNumber)
        {
            //Adding all the numbers within the range to the list
            List<string> ternaryNumbers = new List<string>();

            while (firstNumber<=secondNumber)
            {
                ternaryNumbers.Add(TernaryNumberConverter.ToTernary(firstNumber));
                firstNumber++;
            }

            //Searching for a number with exactly two 2's in it
            for (int i = 0; i < ternaryNumbers.Count; i++)
            {

                var counter = 0;
                char[] newStr = ternaryNumbers[i].ToCharArray();

                foreach (var n in newStr)
                {
                   if (n=='2')
                    {
                        counter++;
                    } 
                    
                    if (counter == 2)
                    {
                        Console.WriteLine("Two 2's in number "+ ternaryNumbers[i]);
                        break;
                    }
                }
            }
            return ternaryNumbers;
        }
    }
}
