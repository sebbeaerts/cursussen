using System;


namespace Oefening2
{
    class Program
    {
        static void Main(string[] args)
        {
            string karakter = "*";
            string patroon = "";

            for(int i = 0; i<5; i++)
            {
                patroon += karakter;
                Console.Write(" " + patroon);
            }
            //
            Console.ReadLine();
        }
    }
}
