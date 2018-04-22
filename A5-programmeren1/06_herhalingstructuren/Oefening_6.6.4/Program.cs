using System;


namespace Oefening_6._6._4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*for(int i = 0; i<24; i++)
            {
                for(int j = 0; j<60; j++)
                {
                    for(int k = 0; k<60; k++)
                    {
                        Console.WriteLine(i + "h" + j + "m" + k + "s");
                    }
                }
            }*/

            //verbetering
            for (int uur = 0; uur < 24; uur++)
            {
                for (int minuut = 0; minuut < 60; minuut++)
                {
                    for (int seconde = 0; seconde < 60; seconde++)
                    {
                        if (uur < 10)
                        {
                            Console.Write("0");
                        }
                        Console.Write(uur + "h");
                        if (minuut < 10)
                        {
                            Console.Write("0");
                        }
                        Console.Write(minuut + "m");
                        if (seconde < 10)
                        {
                            Console.Write("0");
                        }
                        Console.WriteLine(seconde + "s");
                    }
                }
            }

            
            Console.ReadLine();
        }
    }
}
