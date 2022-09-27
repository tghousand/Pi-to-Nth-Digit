using System;
using System.Linq;
/*
 * Displays Pi up to 14 decimal places
 * Tyler Housand
 * 9/27/2022
 */


namespace Pi_to_Nth_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            String inputValue;
            int numberOfDigits;
            Boolean acceptableNumber = false;

            do{
                Console.Write("Enter a number between 1 and 14: ");
                inputValue = Console.ReadLine();
                acceptableNumber = DigitChecker(inputValue);
            } while (acceptableNumber == false);
            numberOfDigits = int.Parse(inputValue);
            Console.WriteLine(Math.Round(Math.PI, numberOfDigits));  
        }


        //checks if the user input is a valid number
        public static bool DigitChecker(string inputValue)
        {
            int x;
            bool isAcceptableDigit = int.TryParse(inputValue, out x);
            if (isAcceptableDigit == true){
                if (1 <= x && x <= 14)
                {
                    return true;
                }else{
                    Console.WriteLine("Invalid Input. Please try again.");
                    return false;
                }
            }else{
                Console.WriteLine("Invalid Input. Please try again.");
                return false;
            }
        }


    }
}
