using System;


namespace Oefening_6._6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int startwaarde = 20;
            int temp = startwaarde;
            int eindwaarde = 10;
            while (temp >= eindwaarde)
            {
                Console.WriteLine(temp);
                temp--;
            }
            Console.ReadLine();
        }
    }
}
