namespace IterationStatements
{
    public class Program
    {       
        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            M1_NumSequence();
            M2_SkipSequence();
            M3_EqualityTest();
            M4_EvenTest();
            M5_PositiveTest();
            M6_VotingTest();
            M7_InRangeTest();
            M8_MultTable();
        }

        //LukeWarm Section: Create methods below

        static void M1_NumSequence() 
        {
            //Write a method that will print to the console all numbers 1000 through - 1000
            Console.WriteLine();
            Console.WriteLine("--- METHOD #1: Numbers 1000 thru -1000 ---");
            for (int i = 1000; i >= -1000; i--)
            {
                Console.Write($"{i}, ");
            }
            Console.WriteLine("The End");
        }

        static void M2_SkipSequence() 
        {
            //Write a method that will print to the console numbers 3 through 999 by 3 each time
            Console.WriteLine();
            Console.WriteLine("--- METHOD #2: Numbers 3 thru 999 by 3's ---");
            for (int i = 3; i <= 999; i += 3)
            {
                Console.Write($"{i}, ");
            }
            Console.WriteLine("The End");
        }

        static void M3_EqualityTest() 
        {
            //Write a method to accept two integers as parameterss and check whether they are equal or not        
            Console.WriteLine();
            Console.WriteLine("--- METHOD #3: Testing the equality of two numbers ---");

            int firstInt = CollectInteger("Enter the first integer...");
            int secondInt = CollectInteger("Enter the second integer...");

            Console.WriteLine();
            Console.WriteLine($"The integers {firstInt} and {secondInt} are{(firstInt==secondInt ? "" : " not")} equal.");
        }

        static void M4_EvenTest() 
        {
            //Write a method to check whether a given number is even or odd        
            //Mathematically, only integers can be considered "even" or "odd", so I'm limiting input to integers
            Console.WriteLine();
            Console.WriteLine("--- METHOD #4: Testing the even/oddness of a number ---");

            int firstInt = CollectInteger("Enter an integer...");

            Console.WriteLine();
            Console.WriteLine($"The integer {firstInt} is {(firstInt % 2 == 0 ? "even" : " odd")}.");
        }

        static void M5_PositiveTest() 
        {
            //Write a method to check whether a given number is positive or negative        
            //Hint: Use Parse or the safer TryParse() for an extra challenge
            Console.WriteLine();
            Console.WriteLine("--- METHOD #5: Testing the positivity of a number ---");

            decimal firstDec = CollectDecimal("Enter a number...");

            Console.WriteLine();
            switch (firstDec)
            {
                case 0:
                    Console.WriteLine($"The value 0 is considered neither positive nor negative.");
                    break;
                case < 0:
                    Console.WriteLine($"The number {firstDec} is negative.");
                    break;
                default:
                    Console.WriteLine($"The number {firstDec} is positive.");
                    break;
            }
        }

        static void M6_VotingTest() 
        {
            //Write a method to read the age of a candidate and determine whether they can vote.
            Console.WriteLine();
            Console.WriteLine("--- METHOD #6: Checking a voter's age ---");

            int userAge = CollectInteger("Enter your age (in whole years)...");

            Console.WriteLine();
            Console.WriteLine($"You are {(userAge >= 18 ? "welcome" : "not yet ready")} to vote.");
        }

        //Heatin Up Section:

        static void M7_InRangeTest() 
        {
            //Write a method to check if an integer(from the user) is in the range -10 to 10
            Console.WriteLine();
            Console.WriteLine("--- METHOD #7: Checking a numeric range ---");

            int userInput = CollectInteger("Enter an integer...");

            Console.WriteLine();
            Console.WriteLine($"The value {userInput} {(userInput >= -10 && userInput <= 10 ? "is" : "is not")} within the range [-10,10].");
        }

        static void M8_MultTable() 
        {
            //Write a method to display the multiplication table(from 1 to 12) of a given integer
            Console.WriteLine();
            Console.WriteLine("--- METHOD #8: Displaying a multiplication table ---");

            int userInput = CollectInteger("Enter an integer...");

            Console.WriteLine();
            for (int i=1; i<=12; i++)
            {
                Console.WriteLine($"{userInput} x {i} = {userInput*i}");
            }
        }

        static int CollectInteger(string userPrompt)
        {
            string userEntry;
            int convertedInt;

            do
            {
                Console.WriteLine(userPrompt);
                userEntry = Console.ReadLine();
            } while (!int.TryParse(userEntry, out convertedInt));

            return convertedInt;
        }

        static decimal CollectDecimal(string userPrompt)
        {
            string userEntry;
            decimal convertedDec;

            do
            {
                Console.WriteLine(userPrompt);
                userEntry = Console.ReadLine();
            } while (!decimal.TryParse(userEntry, out convertedDec));

            return convertedDec;
        }

    }
}
