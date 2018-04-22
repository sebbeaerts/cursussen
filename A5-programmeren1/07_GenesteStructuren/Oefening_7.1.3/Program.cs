using System;


namespace Oefening_7._1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Value ?");

            int input = Convert.ToInt32(Console.ReadLine());
            int temp = input;

            Console.WriteLine("Row: ");

            while (temp > 1)
            {
                if(temp % 2 == 0)
                {
                    temp = temp / 2;
                }
                else
                {
                    temp = (temp * 3) + 1;
                }
                Console.WriteLine(temp);
            }
            //
            Console.ReadLine();
        }
    }
}
