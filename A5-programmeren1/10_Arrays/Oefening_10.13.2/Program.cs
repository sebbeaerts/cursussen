using System;


namespace Oefening_10._13._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Count: ");
            int count = Convert.ToInt32(Console.ReadLine());

            int[] values = new int[count];

            for(int i = 0; i < count; i++)
            {
                Console.Write("Value " + (i + 1) + ": ");
                values[i] = Convert.ToInt32(Console.ReadLine());
            }

            int temp = values[0];

            for (int i = 0; i < (count-1); i++)
            {
                if(temp < values[i + 1])
                {
                    temp = values[i + 1];
                }
            }

            int index = Array.IndexOf(values, temp);
            int element = index + 1;

            Console.WriteLine("Highest Value : " + temp + " (element " + element + " at index " + index + ")");
            //
            Console.ReadLine();
        }
    }
}
