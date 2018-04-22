using System;


namespace Oefening_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hoeveel hamburger ?");
            int aantalHamburger = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hoeveel komkommers ?");
            int aantalKomkommers = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hoeveel scheppen ijs ?");
            int scheppenIjs = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hoeveel chocoladerepen ?");
            int aantalChocoladerepen = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hoeveel koekjes ?");
            int aantalKoekjes = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hoeveel stukken taart ?");
            int stukkenTaart = Convert.ToInt32(Console.ReadLine());

            int totaalCal = 0;

            int calHamburger = 270;
            int totaalCalHamburger = aantalHamburger * calHamburger;
            totaalCal += totaalCalHamburger;

            int calKomkommer = 8;
            int totaalCalKomkommer = aantalKomkommers * calKomkommer;
            totaalCal += totaalCalKomkommer;

            int calIjs = 88;
            int totaalCalIjs = scheppenIjs * calIjs;
            totaalCal += calIjs;

            int calChocoladereep = 218;
            int totaalCalChocoladereep = aantalChocoladerepen * calChocoladereep;
            totaalCal += totaalCalChocoladereep;

            int calKoekje = 70;
            int totaalCalkoekje = aantalKoekjes * calKoekje;
            totaalCal += totaalCalkoekje;

            int calStukTaart = 340;
            int totaalCalStukTaart = stukkenTaart * calStukTaart;
            totaalCal += totaalCalStukTaart;

            

            if (totaalCal < 1800)
            {
                int calTeWeinig = 1800 - totaalCal;
                Console.WriteLine("U hebt te weinig caloriën binnen! --> " + calTeWeinig + " cal te weinig.");
            }
            else if (totaalCal > 2100)
            {
                int calTeVeel = totaalCal - 2100;
                Console.WriteLine("U hebt te veel caloriën binnen! --> " + calTeVeel + " cal te veel.");
            }
            else
            {
                Console.WriteLine("U hebt genoeg caloriën (" + totaalCal + ") binnen!");
            }

            Console.ReadLine();
        }
    }
}
