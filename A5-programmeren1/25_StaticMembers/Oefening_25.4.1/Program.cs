using System;


namespace Oefening_25._4._1
{
    class Calculation
    {
        public static int getSum(int n1, int n2)
        {
            return n1 + n2;
        }

        public static int getProduct(int n1, int n2)
        {
            return n1 * n2;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calculation.getSum(10,20));
            Console.WriteLine(Calculation.getProduct(10, 20));
            Console.WriteLine(Calculation.getSum(5, 7));
            Console.WriteLine(Calculation.getProduct(5, 7));
            //
            Console.ReadLine();
        }
    }
}
