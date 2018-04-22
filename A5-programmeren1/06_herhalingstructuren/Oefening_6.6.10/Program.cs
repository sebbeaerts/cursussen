using System;

namespace Oefening_6._6._10
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = Convert.ToInt32(Console.ReadLine());
            int temp = input;
            int rest = 0;

            string result = "";

            while (temp > 0)
            {
                rest = temp % 2;
                temp = temp / 2;
                result = rest + result;
                
            }
            Console.WriteLine(result);
            //
            Console.ReadLine();
        }
    }
}
