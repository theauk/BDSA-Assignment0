using System;

namespace LeapYear
{
    public class Program
    {
        public static void Main(string[] args)
        {
            GetIsLeapYear();
        }

        public static void GetIsLeapYear() 
        {
            int userInt = GetUserInput();
            PrintIsLeapYear(userInt);
        }

        public static int GetUserInput()
        {
            var userInput = Console.ReadLine();
            return Convert.ToInt32(userInput);
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
