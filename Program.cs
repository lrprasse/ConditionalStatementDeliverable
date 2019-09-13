using System;

namespace ConditionalStatementDeliverable
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("What percent grade do you expect to get in ISM 4300? ");
                string input = Console.ReadLine();
                int grade = int.Parse(input);
                int difference = 0;

                if (grade > 97)
                {
                    Console.WriteLine("Your letter grade is: A+");
                }
                else if (grade > 91)
                {
                    Console.WriteLine("Your letter grade is: A");
                }
                else if (grade > 89)
                {
                    Console.WriteLine("Your letter grade is: A-");
                }
                else if (grade > 87)
                {
                    Console.WriteLine("Your letter grade is: B+");
                    difference = 90 - grade;
                    switch (difference)
                    {
                        case 1:
                            Console.WriteLine("You're only 1 point away from the next letter grade!");
                            break;
                        case 2:
                            Console.WriteLine("You're only 2 points away from the next letter grade!");
                            break;
                    }
                }
                else if (grade > 81)
                {
                    Console.WriteLine("Your letter grade is: B");
                }
                else if (grade > 79)
                {
                    Console.WriteLine("Your letter grade is: B-");
                }
                else if (grade > 77)
                {
                    Console.WriteLine("Your letter grade is: C+");
                    difference = 80 - grade;
                    switch (difference)
                    {
                        case 1:
                            Console.WriteLine("You're only 1 point away from an B-!");
                            break;
                        case 2:
                            Console.WriteLine("You're only 2 points away from an B-!");
                            break;
                    }
                }
                else if (grade > 71)
                {
                    Console.WriteLine("Your letter grade is: C");
                    difference = 78 - grade;
                }
                else if (grade > 69)
                {
                    Console.WriteLine("Your letter grade is: C-");
                }
                else if (grade > 67)
                {
                    Console.WriteLine("Your letter grade is: D+");
                    difference = 70 - grade;
                    switch (difference)
                    {
                        case 1:
                            Console.WriteLine("You're only 1 point away from the next letter grade!");
                            break;
                        case 2:
                            Console.WriteLine("You're only 2 points away from the next letter grade!");
                            break;
                    }
                }
                else if (grade > 61)
                {
                    Console.WriteLine("Your letter grade is: D");
                }
                else if (grade > 59)
                {
                    Console.WriteLine("Your letter grade is: D-");
                }
                else
                {
                    Console.WriteLine("Your letter grade is: F");
                    difference = 60 - grade;
                    Console.WriteLine("You are " + difference + " point(s) away from a passing grade!");
                }

            }
            catch
            {
                Console.WriteLine("There was a mistake! Please restart the program and enter" +
                    "your grade in a percent integer.");
            }
        }
    }
}
