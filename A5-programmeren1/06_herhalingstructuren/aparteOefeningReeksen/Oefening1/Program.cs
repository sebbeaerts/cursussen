using System;


namespace Oefening1
{
    class Program
    {
        static void Main(string[] args)
        {

            int input = Convert.ToInt32(Console.ReadLine());

            double beginGetal = 1;
            double result = 0;
            double macht = 2;

            Console.Write(beginGetal);

            while (result < input)
            {
                beginGetal++;
                result = Math.Pow(beginGetal, macht);
                Console.Write(", " + result);
            }
            Console.ReadLine();

        }
    }
}
