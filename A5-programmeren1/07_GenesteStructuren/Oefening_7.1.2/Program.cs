using System;


namespace Oefening_7._1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Value ?");
            int value1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Value ?");
            int value2 = Convert.ToInt32(Console.ReadLine());

            if (value1 > value2)
            {
                int temp = value1;
                value1 = value2;
                value2 = temp;
            }

            Console.WriteLine("Row: ");

            for(int i = value1+1; i < value2; i++)
            {
                Console.WriteLine(i);
            }
            //
            Console.ReadLine();

            /*Oplossing met de klas
             *             
            Console.WriteLine("Value ?");
            int value1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Value ?");
            int value2 = Convert.ToInt32(Console.ReadLine());

            //vermijd berekeningen in nest structuren door een andere variabele te maken. zo voorkom je de berekening in de for lus ==> for(int i = (value1 + 1); i < value2; i++){}.
            int temp1 = value1 + 1;
            int temp2 = value2 - 1;

            if (value1 > value2)
            {
                temp1 = value2 + 1;
                temp2 = value1 - 1;
            }

            Console.WriteLine("Row: ");

            for(int i = temp1; i < temp2; i++)
            {
                Console.WriteLine(i);
            }
            //
            Console.ReadLine();
            */

        }
    }
}
