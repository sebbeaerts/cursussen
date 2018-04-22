using System;


namespace Oefening_6._6._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int getal = 15;
            int temp = getal;
            int value = 0;

            for(int i = getal-1; i > 0 ; i--)
            {
                value = temp * i;
                Console.WriteLine(value);
                temp = value;
            }
            Console.WriteLine(getal + "! = " + value);
            //
            Console.ReadLine();
        }
    }
}
