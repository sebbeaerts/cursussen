using System;


namespace aerts_sebbe_AO1_oefening1
{
    class Program
    {
        static void Main(string[] args)
        {
            //inlezen van aantal getallen.
            Console.Write("HOEVEEL WAARDEN\t: ");
            int count = Convert.ToInt32(Console.ReadLine());

            //aanmaken random rij met count aantal getallen.
            int [] rij = GetRij(count);

            //array rij uitschrijven.
            Console.Write("RIJ\t\t: ");
            ShowRij(rij);
            Console.WriteLine();

            //gemiddelde initialiseren en declareren aan de return van de methode GetGemiddelde().
            int gemiddelde = GetGemiddelde(rij);
            Console.WriteLine("GEMIDDELDE\t: " + gemiddelde);

            //oproepen van de procedure BerekenenAfwijking() met parameters rij en gemiddelde.
            Console.Write("AFWIJKING\t: ");
            BerekenenAfwijking(rij, gemiddelde);

            //
            Console.ReadLine();
        }

        static int [] GetRij(int count)
        {
            Random random = new Random();
            int[] rij = new int[count];

            //count aantal willekeurige getallen toekennen aan de array rij.
            for (int i = 0; i < count; i++)
            {
                rij[i] = random.Next(1, 10);
            }

            return rij;
        }

        static void ShowRij(int [] rij)
        {
            //getallen uitprinten van de array rij.
            for (int i = 0; i < rij.Length; i++)
            {
                Console.Write(rij[i] + " ");
            }
        }

        static int GetGemiddelde(int [] rij)
        {
            int som = 0;
            int result = 0;

            //array rij doorlopen en alle getallen optellen. vervolgens het gemiddelde(result) bepalen door de som te delen door het aantal getallen in de array rij.
            for (int i = 0; i < rij.Length; i++)
            {
                som += rij[i];
            }
            result = (som / rij.Length);

            return result;
        }

        static void BerekenenAfwijking(int [] rij, int gemiddelde)
        {
            int count = rij.Length;
            int[] afwijking = new int [count];

            //hier wordt de afwijking bepaald aan de hand van het gemiddelde of die groter is of niet tov rij[i].
            for (int i = 0; i < rij.Length; i++)
            { 
                if(rij[i] >= gemiddelde)
                {
                    afwijking[i] = (rij[i] - gemiddelde);
                }
                else
                {
                    afwijking[i] = (gemiddelde - rij[i]);
                }
                
            }

            //getallen uitprinten van de array afwijking.
            for (int i = 0; i < afwijking.Length; i++)
            {
                Console.Write(afwijking[i] + " ");
            }
        }
    }
}
