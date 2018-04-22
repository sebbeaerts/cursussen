using System;

namespace Oefening_6._6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int basis = 2;
            int exponent = 1;
            int grenswaarde = 1000;
            double result = Math.Pow(basis, exponent);


            while (result<grenswaarde)
            {

                Console.WriteLine("base: " + basis + ", exponent: " + exponent + ", result: " + result);
                exponent++;
                result = Math.Pow(basis, exponent);
            }     
            //
            Console.ReadLine();
        }
    }
}
