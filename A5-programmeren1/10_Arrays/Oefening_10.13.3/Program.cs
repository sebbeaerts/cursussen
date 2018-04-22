using System;


namespace Oefening_10._13._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 10;
            int[] array = new int[count];

            for(int i = 0; i < count; i++)
            {
                array[i] = count - i;
            }

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("element " + (i + 1) + " (index " + i + "): " + array[i]);
            }
            //
            Console.ReadLine();
        }
    }
}
