using System;


namespace Oefening_7._1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("value ?");
            int input = Convert.ToInt32(Console.ReadLine());
            int temp1 = input;
            int temp2 = 0;

            while (input > 0)
            {
                if (temp1 < temp2)
                {
                    temp1 = temp2;
                }
                Console.WriteLine("value ?");
                input = Convert.ToInt32(Console.ReadLine());
                temp2 = input;
            }
            Console.WriteLine("Highest Value: " + temp1);
            //
            Console.ReadLine();
        }
    }
}
