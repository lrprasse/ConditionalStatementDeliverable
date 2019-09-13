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
                }
                else if (grade > 71)
                {
                    Console.WriteLine("Your letter grade is: C");
                }
                else if (grade > 69)
                {
                    Console.WriteLine("Your letter grade is: C-");
                }
                else if (grade > 67)
                {
                    Console.WriteLine("Your letter grade is: D+");
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
