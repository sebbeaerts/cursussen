using System;


namespace Oefening3
{
    class Program
    {
        static void Main(string[] args)
        {
            string ster = "*";
            string spatie = " ";

            //geen i, j, k gebruiken --> gebruik namen zodat het duidelijker is.
            for (int aantalBlokkenVerticaal = 0; aantalBlokkenVerticaal < 2; aantalBlokkenVerticaal++)
            {
                for (int aantalBlokkenHorizontaal = 0; aantalBlokkenHorizontaal < 2; aantalBlokkenHorizontaal++)
                {
                    for (int aantalSterren = 0; aantalSterren < 3; aantalSterren++)
                    {
                        Console.Write(ster);
                    }

                    for (int aantalSterren = 0; aantalSterren < 3; aantalSterren++)
                    {
                        Console.Write(spatie);
                    }
                }
            }
        }
    }
}
