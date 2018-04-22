using System;


namespace Oefening_11._9._4
{
    class Program
    {
        static void Main(string[] args)
        {
            //testcode
            //return waarde gelijkstellen aan de juiste waarde zodat je onmiddelijk ziet dat de return waarde juist is.
            Console.WriteLine("----------------IsLeapYear----------------------");
            Console.WriteLine(IsLeapYear(1900) == false);
            Console.WriteLine(IsLeapYear(1984) == true);
            Console.WriteLine(IsLeapYear(1966) == false);
            Console.WriteLine(IsLeapYear(1955) == false);
            Console.WriteLine(IsLeapYear(2001) == false);
            Console.WriteLine(IsLeapYear(1999) == false);
            Console.WriteLine(IsLeapYear(2000) == true);
            //
            Console.WriteLine("----------------GetDaysFebruary-----------------");
            //
            Console.WriteLine(GetDaysFebruary(1900) == 28);
            Console.WriteLine(GetDaysFebruary(1984) == 29);
            Console.WriteLine(GetDaysFebruary(1966) == 28);
            Console.WriteLine(GetDaysFebruary(1955) == 28);
            Console.WriteLine(GetDaysFebruary(2001) == 28);
            Console.WriteLine(GetDaysFebruary(1999) == 28);
            Console.WriteLine(GetDaysFebruary(2000) == 29);
            //
            Console.WriteLine("----------------GetDays-------------------------");
            //
            Console.WriteLine(GetDays(1, 1900) == 31);
            Console.WriteLine(GetDays(2, 1984) == 29);
            Console.WriteLine(GetDays(4, 1966) == 30);
            Console.WriteLine(GetDays(2, 1955) == 28);
            Console.WriteLine(GetDays(12, 2001) == 31);
            Console.WriteLine(GetDays(8, 1999) == 31);
            Console.WriteLine(GetDays(7, 2000) == 31);
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
