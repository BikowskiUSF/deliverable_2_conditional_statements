using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deliverable_2_conditional_statements
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    // Ask the user for their expected grade in ISM 4300
                    Console.WriteLine("What grade do you expect to get in ISM 4300?");
                    int grade = Convert.ToInt32(Console.ReadLine());

                    // Conditional statements to figure out the letter grade
                    if (grade >= 90)
                    {
                        Console.WriteLine("Your letter grade is A.");
                    }
                    else if (grade >= 80)
                    {
                        Console.WriteLine("Your letter grade is B.");
                    }
                    else if (grade >= 70)
                    {
                        Console.WriteLine("Your letter grade is C.");
                    }
                    else if (grade >= 60)
                    {
                        Console.WriteLine("Your letter grade is D.");
                    }
                    else
                    {
                        Console.WriteLine("Your letter grade is F.");
                    }

                    // Loop is exited once input is valid
                    break;
                }
                catch (FormatException)
                {
                    // Error message for an invalid input
                    Console.WriteLine("Invalid input. Please enter a numeric value.");
                }

            }
                Console.ReadLine();
        }
    }
}