using System;


namespace Oefening_10._13._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 10;
            int[] array = new int[count];

            for (int i = 0; i < count; i++)
            {
                array[i] = (i + 1);
            }

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("element " + (i + 1) + " (index " + i + "): " + array[i]);
            }

            Console.WriteLine("----------------------------------------------");

            for (int i = 0; i < (count/2); i++)
            {
                int temp = array[(count - 1 - i)];
                array[(count - 1 - i)] = array[i];
                array[i] = temp;
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
