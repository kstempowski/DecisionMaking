using System;

namespace DecisionMaking
{
    class Program
    {
        static void Main(string[] args)
        {
            //The user will be prompted to enter their name
            Console.WriteLine("Hello what is your name?");
            string name = Console.ReadLine();

            //The user will be prompted to input a whole number integer
            Console.WriteLine("Hello " + name +" please input a whole number between 1 and 100.");
            string input = Console.ReadLine();
            int number = int.Parse(input);

            //This will validate that a number between 1 and 100 is entered
            if (number < 1 || number > 100)
            {
                Console.WriteLine(name + " you know that number is not between 1 and 100");
                Console.WriteLine("Please try again");
            }
            //If a number between 1 and 100 is entered this loop will trigger
            else if (number >= 1 && number <= 100)
            {
                //An even number entered between 2 and 25 will print the number entered and tell
                //the user it is even
                if (number % 2 == 0 && number >= 2 && number <= 25)
                {
                    Console.WriteLine(name +", the number " + number + " is even and less than 25");
                }
                //An even nymber between 26 and 60 will print only that the number is even
                else if (number % 2 == 0 && number <= 60 && number >= 26)
                {
                    Console.WriteLine(name + ", the number is even");
                }
                //An even number entered greater than 60 will print the number entered and tell
                //the user the number is even
                else if (number % 2 == 0 && number > 60)
                {
                    Console.WriteLine(name + ", the number " + number + " is even");
                }
                //Both of the following "if" statements essentially produce the same result of displaying the
                //number entered and telling the user the number is odd. Both lines of code
                //were entered as per the instructions, but as stated in class sometimes certain code can
                //be redundant.
                if (number % 2 == 1 && number >= 2 && number <= 60)
                {
                    Console.WriteLine(name + ", the number " + number + " is odd");
                }
                else if (number %2 == 1 && number > 60)
                {
                    Console.WriteLine(name + ", the number " + number + " is odd");
                }
            }
        }
    }
}
