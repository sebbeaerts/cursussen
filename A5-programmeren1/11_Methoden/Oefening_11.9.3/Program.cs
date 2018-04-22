using System;


namespace Oefening_11._9._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int value1 = 20;
            int value2 = 10;
            int result = 0;

            result = GetResult(value1, "+", value2);
            Console.WriteLine(result);
            result = GetResult(value1, "-", value2);
            Console.WriteLine(result);
            result = GetResult(value1, "*", value2);
            Console.WriteLine(result);
            result = GetResult(value1, "/", value2);
            Console.WriteLine(result);
            //
            Console.ReadLine();
        }

        static int GetResult(int value1, string teken, int value2)
        {
            int result = 0;

            switch (teken)
            {
                case "+": result = value1 + value2; break;
                case "-": result = value1 - value2; break;
                case "*": result = value1 * value2; break;
                case "/": result = value1 / value2; break;
            }
            
            
            return result;
        }
    }
}
