using System;

namespace DecisionMaking
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello what is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("Hello " + name +" please input a whole number between 1 and 100.");
            string input = Console.ReadLine();
            int number = int.Parse(input);

            if (number < 1 || number > 100)
            {
                Console.WriteLine(name + " you know that number is not between 1 and 100");
                Console.WriteLine("Please try again");
            }
            else if (number >= 1 && number <= 100)
            {
                if (number % 2 == 0 && number >= 2 && number <= 25)
                {
                    Console.WriteLine("The number " + number + " is even and less than 25");
                }
                else if (number % 2 == 0 && number <= 60 && number >= 26)
                {
                    Console.WriteLine("The number is even");
                }
                else if (number % 2 == 0 && number > 60)
                {
                    Console.WriteLine("The number " + number + " is even");
                }
                if (number % 2 == 1 && number >= 2 && number <= 25)
                {
                    Console.WriteLine("The number " + number + " is odd");
                }
            }
        }
    }
}
