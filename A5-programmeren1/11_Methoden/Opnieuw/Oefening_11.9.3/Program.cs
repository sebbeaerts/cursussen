using System;


namespace Oefening_11._9._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int waarde1 = 15;
            string teken = "*";
            int waarde2 = 20;

            int result = GetResult(waarde1, teken, waarde2);
            Console.WriteLine(result);
            //
            Console.ReadLine();
        }

        static int GetResult(int waarde1, string teken, int waarde2)
        {
            int result = 0;

            switch(teken)
            {
                case "+": result = waarde1 + waarde2; break;
                case "-": result = waarde1 - waarde2; break;
                case "*": result = waarde1 * waarde2; break;
            }

            return result;
        }
    }
}
