using System;

namespace LeapYear
{
    public class Program
    {
        public static void Main(string[] args)
        {
        }

        public static bool IsLeapYear(int year) 
        {

            if (year % 4 == 0) 
            {
                if (year % 100 == 0) 
                {
                    return year % 400 == 0;

                } else 
                {
                    return true;
                }
                
            } else 
            {
                return false;
            }
        }
    }
}
