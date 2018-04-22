using System;


namespace Oefening_10._13._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 5;
            int[] values = new int[count];

            for (int i = 0; i < count; i++)
            {
                Console.Write("Value " + (i+1) + ": ");
                values[i] = Convert.ToInt32(Console.ReadLine());
            }

            //positieve tellers worden het meest gebruikt maar naar gelang de complexiteit gaat de voorkeur naar negatief in dit geval.

            for (int i = (count-1); i >= 0 ; i--)
            {
                Console.WriteLine("Element " + (i+1) + " (at index " + i + "): " + values[i]);
            }

            Console.WriteLine();

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Element " + (count - 1) + " (at index " + (count - 1 - i) + "): " + values[(count - 1 - i)]);
            }
            //
            Console.ReadLine();
        }
    }
}
