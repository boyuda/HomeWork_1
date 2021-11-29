using System;
using System.Collections.Generic;

namespace Task_1
{
    //Specify protection modifier "internal" 
    class NumbersLists
    {
        public static List<String> AddToLists(int firstNumber, int secondNumber)
        {
            //Adding all the numbers within the range to the list
            List<string> ternaryNumbers = new List<string>();

            while (firstNumber <= secondNumber)
            {
                ternaryNumbers.Add(TernaryNumberConverter.ToTernary(firstNumber));
                firstNumber++;
            }

            //Searching for a number with exactly two 2's in it
            for (int i = 0; i < ternaryNumbers.Count; i++)
            {

                var counter = 0;
                char[] newStr = ternaryNumbers[i].ToCharArray();

                //Do not need to cast to char array 
                // foreach (var n in ternaryNumbers[i]) should work fine
                foreach (var n in newStr)
                {
                    if (n == '2')
                    {
                        counter++;
                    }

                    if (counter == 2)
                    {
                        Console.WriteLine("Two 2's in number " + ternaryNumbers[i]);
                        // This is a mistake - your code will display number even if it has
                        // more than 2 twos, for example: "222222".
                        // Check on big enough numbers.                   
                        break;
                    }
                }
            }
            return ternaryNumbers; //This is not neccessary, your code does not use return value, 
            // keep it void
        }
    }
}
