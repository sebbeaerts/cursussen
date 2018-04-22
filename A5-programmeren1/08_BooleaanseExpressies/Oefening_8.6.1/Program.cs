using System;


namespace Oefening_8._6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int value1 = Convert.ToInt32(Console.ReadLine());
            int value2 = Convert.ToInt32(Console.ReadLine());

            //hetzelfe als ==> if ((value1 > 0) ^ (value2 > 0)) {}

            if(((value1 > 0) && (value2 < 0)) || ((value1 < 0) && (value2 > 0)))
            {
                int sum = value1 + value2;
                Console.WriteLine(sum);
            }
            //
            Console.ReadLine();
        }
    }
}
