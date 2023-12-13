using System.Reflection.Metadata.Ecma335;

namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000

        //Write a method that will print to the console numbers 3 through 999 by 3 each time

        //Write a method to accept two integers as parameterss and check whether they are equal or not
        
        //Write a method to check whether a given number is even or odd
        
        //Write a method to check whether a given number is positive or negative
        
        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        
        //Write a method to display the multiplication table(from 1 to 12) of a given integer


        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            PrintNumbers();
            PrintNumbersBy3();
            EqualOrNot();
            EvenOrOdd();
            PositiveOrNegative();
            VotingOrNot();
            CheckingInteger();
            MultiplicationTable();
        }

        public static void PrintNumbers()
        {
            Console.WriteLine("\tPrinting from 1000 to -1000:\n");
            for(int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
        }

        public static void PrintNumbersBy3()
        {
            Console.WriteLine("\tPrinting to 999 from 3 to 3:\n");
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
        }

        public static void EqualOrNot()
        {
            Console.WriteLine("\tChecking if a number is equal to another number:\n");

            Console.WriteLine("What´s the first number?");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("What´s the second number?");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine((num1 == num2) ? $"{num1} and {num2} are the same number. Congratulations!\n"
                                             : $"{num1} and {num2} are not the same number. Please try again!\n");
        }

        public static void EvenOrOdd()
        {
            Console.WriteLine("\tChecking if a number is even or odd:\n");

            Console.WriteLine("What´s the number?");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine((num % 2 == 0) ? $"{num} is an even number. Even you can do it!\n"
                                             : $"{num} is and odd number. Why are you so Odd?\n");
        }

        public static void PositiveOrNegative()
        {
            Console.WriteLine("\tChecking if a number is positive or negative:\n");

            Console.WriteLine("What´s the number?");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if (num == 0)
                Console.WriteLine("0 is not a positive nor a negative number.");
            else
                Console.WriteLine((num > 0) ? $"{num} is a positive number. Life is good!\n"
                                            : $"{num} is a negative number. Why so sad?\n");
        }

        public static void VotingOrNot()
        {
            Console.WriteLine("\tChecking if you can vote:\n");

            Console.WriteLine("What´s your age?");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine((num >= 18) ? $"You can vote! Be responsible with your power!\n"
                                          : $"You cannot vote! Please return later in life!\n");
        }

        public static void CheckingInteger()
        {
            Console.WriteLine("\tChecking if the number is between -10 and 10:\n");

            Console.WriteLine("What´s the number?");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine((num >= -10 && num <= 10) ? $"{num} is between -10 and 10. You may live another day!\n"
                                                       : $"{num} is not between -10 and 10. Please exit through the door.\n");
        }

        public static void MultiplicationTable()
        {
            Console.WriteLine("\tI´m going to give you the multiplication table of a given number\n");

            Console.WriteLine("What´s the number?");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{num} x {i} = {num * i}");
            }
        }
    }
}
