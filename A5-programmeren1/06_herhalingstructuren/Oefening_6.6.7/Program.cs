using System;

namespace Oefening_6._6._7
{
    class Program
    {
        static void Main(string[] args)
        {
            //uitbreiding van oefening 6.6.6

            int input = Convert.ToInt32(Console.ReadLine());
            int result = input;
            string inputTeken = Console.ReadLine();


            while (inputTeken != "=")
            {
                input = Convert.ToInt32(Console.ReadLine());

                if(inputTeken == "+")
                {
                    result = result + input;
                }
                else if (inputTeken == "-")
                {
                    result = result + input;
                }

                inputTeken = Console.ReadLine();
            }
            Console.WriteLine(result);
            //
            Console.ReadLine();
        }
    }
}
