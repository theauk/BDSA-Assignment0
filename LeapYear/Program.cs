using System;

namespace LeapYear
{
    public class Program
    {
        public static void Main(string[] args)
        {
            GetIsLeapYear(GetUserInput());
        }

        public static string GetUserInput()
        {
            return Console.ReadLine();
        }

        public static void GetIsLeapYear(string userInput)
        {
            bool isValidInput = ValidateUserInput(userInput);

            if (isValidInput)
            {
                PrintIsLeapYear(Convert.ToInt32(userInput));
            }
        }

        public static bool ValidateUserInput(string userInput)
        {
            try
            {
                int userInt = Convert.ToInt32(userInput);
                if (userInt < 1582)
                {
                    Console.WriteLine("Please input an integer larger than 1581");
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Please input an integer");
                return false;
            }
        }

        public static void PrintIsLeapYear(int year)
        {
            if (IsLeapYear(year))
            {
                Console.WriteLine("yay");
            }
            else
            {
                Console.WriteLine("nay");
            }
        }

        public static bool IsLeapYear(int year)
        {

            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    return year % 400 == 0;

                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
