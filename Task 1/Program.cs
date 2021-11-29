using System;

namespace Task_1
{
    class Program
    {
        //Drop unused args
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter two numbers: ");
            var input = Console.ReadLine().Split(' ');

            var firstNumber = int.Parse(input[0]);
            var secondNumber = int.Parse(input[1]);

            //The name of class and method are not clear
            // Possible renaming: Task1.PrintNumbersWith2Twos
            // It also does not sound great, but clarifies at least what does it do.
            NumbersLists.AddToLists(firstNumber, secondNumber);
            
        }
    }
}
