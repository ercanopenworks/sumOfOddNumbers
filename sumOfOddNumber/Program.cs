using System;

namespace sumOfOddNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many numbers do you want to enter : ");
            int numberCount = Convert.ToInt32(Console.ReadLine());
            int numberSum = 0;
            int number = 1;
            for (int i = 0; i < numberCount; i++)
            {
                Console.WriteLine(number);
                numberSum += number;
                number += 2;

            }

            Console.WriteLine($"Sum of numbers you were given : {numberSum.ToString()}");
            Console.ReadLine();
        }
    }
}
