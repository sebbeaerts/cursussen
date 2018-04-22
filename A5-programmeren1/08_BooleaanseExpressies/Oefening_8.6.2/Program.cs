using System;


namespace Oefening_8._6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Maak een programma dat de som maakt van ingelezen getallen, 
             * zolang een getal wordt ingelezen dat ligt tussen 10 en 20 (10 en 20 exclusief), 
             * groter is dan 100 (exclusief 100) of "kleiner of gelijk is" aan 0.
             * */

            Console.WriteLine("Value ?");
            int input = Convert.ToInt32(Console.ReadLine());
            int temp = input;
            int som = 0;

            while((input > 10 && input < 20) || (input > 100) || (input <= 0))
            {
                som = som + temp;
                Console.WriteLine("Value ?");
                input = Convert.ToInt32(Console.ReadLine());
                temp = input;
                
            }
            Console.WriteLine("Sum: " + som);
            //
            Console.ReadLine();
        }
    }
}
