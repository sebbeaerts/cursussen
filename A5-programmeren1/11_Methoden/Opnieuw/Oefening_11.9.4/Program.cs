using System;


namespace Oefening_11._9._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsLeapYear(1900) == false);
            Console.WriteLine(IsLeapYear(2000) == true);
            //
            Console.WriteLine(GetDaysFebruary(1900) == 28);
            Console.WriteLine(GetDaysFebruary(2000) == 29);
            //
            Console.WriteLine(GetDays(1, 1900) == 31);
            Console.WriteLine(GetDays(2, 2000) == 29);
            //
            Console.ReadLine();
        }

        static int GetDays(int month, int year)
        {
            int result = 0;

            switch(month)
            {
                case 1: result = 31; break;
                case 2: result = GetDaysFebruary(year); break;
                case 3: result = 31; break;
                case 4: result = 30; break;
                case 5: result = 31; break;
                case 6: result = 30; break;
                case 7: result = 31; break;
                case 8: result = 31; break;
                case 9: result = 30; break;
                case 10: result = 31; break;
                case 11: result = 30; break;
                case 12: result = 31; break;
            }

            return result;
        }

        static int GetDaysFebruary(int year)
        {
            int result = 28;

            if (IsLeapYear(year))
            {
                result = 29;
            }

            return result;
        }

        static bool IsLeapYear(int year)
        {
            bool result = false;

            if(((year%4 == 0) && (year%100 != 0)) || (year%400 == 0))
            {
                result = true;
            }

            return result;
        }
    }
}
