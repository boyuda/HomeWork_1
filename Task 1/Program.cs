using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter two numbers: ");
            var input = Console.ReadLine().Split(' ');

            var firstNumber = int.Parse(input[0]);
            var secondNumber = int.Parse(input[1]);

            NumbersLists.AddToLists(firstNumber, secondNumber);
            
        }
    }
}
