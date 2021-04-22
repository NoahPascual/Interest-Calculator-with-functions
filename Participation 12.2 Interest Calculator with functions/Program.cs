// Noah Pascual
// MIS 3013- 995
// Participation 12.2 - Interest Calculator with functions

// Instructions:
    //1. Call a function to display the header
    //2. Take only validated inputs(use a function to validate)  from the user for a starting balance(local double variable), the number of years to run(local int variable), and the interest rate(global double variable)
    //3. Pass your local variables as parameters to a void function that uses a loop to output to the console with the balance each year
    //4. Compress and save the folder, and submit to Canvas

using System;
using System.Collections.Generic;    // To get List<> to work.
using System.Linq;                  // To get .Sum to work.

namespace Participation_12._2_Interest_Calculator_with_functions
{
    class Program 
    {
        // Interest Rate Global Double Variable
        static double InterestRate;

        static void Main(string[] args)
        {
            DisplayHeader();

            Console.WriteLine("Please enter your staring balance >>>");
            double startingBalance = ValidateDouble(Console.ReadLine());

            Console.WriteLine("\n\rPlease enter the number of years to run >>>");
            int years = ValidateInt(Console.ReadLine());

            //3. Pass your local variables as parameters to a void function that uses a loop to output to the console with the balance each year
            Console.WriteLine("\n\rPlease enter the interest rate >>>");
            Program.InterestRate = ValidateDouble(Console.ReadLine());

            DisplayBalancePerYear(startingBalance, years, InterestRate);

            Console.ReadKey();
        }

        //1. Call a function to display the header
        static void DisplayHeader()
        {
            string title = "--- Participation 12.2 - Interest Calculator with functions ---";
            Console.SetCursorPosition((Console.WindowWidth - title.Length) / 2, Console.CursorTop);
            Console.WriteLine(title);
        }

        static void DisplayBalancePerYear(double startingBalance, int years, double interestRate)
        {
            double balance;
            for (int i = 0; i < years; i++)
            {
                balance = startingBalance + (startingBalance + interestRate / 100);
                Console.WriteLine($"\nBalance Year {i + 1}: {balance:c}");
                startingBalance = balance;
            }
        }

        // Starting balance (Local double variable) validation.
        static double ValidateDouble(string input)
        {
            bool isNumber = false;
            double validNumber;
            do
            {
                isNumber = double.TryParse(input, out validNumber);

                if (!isNumber)
                {
                    Console.WriteLine("Please enter a valid starting balance >>>");
                }
            } while (!isNumber);

            return validNumber;
        }

        static int ValidateInt(string input)
        {
            bool isNumber = false;
            int validNumber;
            do
            {
                isNumber = Int32.TryParse(input, out validNumber);

                if (!isNumber)
                {
                    Console.WriteLine("Please enter a valid starting balance >>>");
                }
            } while (!isNumber);

            return validNumber;
        }
    }
}
