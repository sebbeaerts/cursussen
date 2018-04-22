using System;

namespace Oefening_6._6._6
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = Convert.ToInt32(Console.ReadLine());
            int result = input;

            while (input != 0) 
            {
                Console.WriteLine("+");
                input = Convert.ToInt32(Console.ReadLine());
                result = result + input;
            }
            Console.WriteLine("=");
            Console.WriteLine(result);
            //
            Console.ReadLine();
        }
    }
}
