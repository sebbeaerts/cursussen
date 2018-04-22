using System;


namespace aerts_sebbe_AO1_oefening2
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = GetCount();
            int freqBalls = GetFreqBalls();
            BouwKerstboom(count, freqBalls);
            //
            Console.ReadLine();
        }

        //controle input count
        static int GetControle(int count)
        {
            if (!(count % 2 == 0))
            {
                if (count < 3)
                {
                    Console.WriteLine("Uw getal is te klein. Gelieve een waarde tussen 3 en 11 in te geven!");
                    count = GetCount();
                    return count;
                }
                else if (count > 11)
                {
                    Console.WriteLine("Uw getal is te groot. Gelieve een waarde tussen 3 en 11 in te geven!");
                    count = GetCount();
                    return count;
                }
                return count;
            }
            else
            {
                Console.WriteLine("ERROR: Enkel Oneven nummers worden geaccepteerd! Probeer opnieuw!");
                count = GetCount();
                return count; 
            }

        }

        //input count
        static int GetCount()
        {
            Console.WriteLine("Count ?");
            int count = Convert.ToInt32(Console.ReadLine());
            count = GetControle(count);

            return count;
        }

        //input frequency kerstballen
        static int GetFreqBalls()
        {
            Console.WriteLine("Frequency of balls ?");
            int freqBalls = Convert.ToInt32(Console.ReadLine());

            //controle
            if(freqBalls < 1)
            {
                Console.WriteLine("De frequentie van de kerstballen mag niet onder 1 liggen!");
                freqBalls = GetFreqBalls();
            }

            return freqBalls;
        }

        static void BouwKerstboom(int count, int freqBalls)
        {    
            int rows = count;
            int rowsStam = rows + 1;
            int cols = count + count - 1;
            string[,] kerstboom = new string[rowsStam, cols];

            //bouwen van de boom
            int teller = -1;

            for (int row = 0; row <= rows-1; row++)
            {
                int aantalStars = (2 * row) + 1 ;
                int aantalSpaces = cols - aantalStars;

                //spaties linkerkant array
                for (int space = 0; space <= (aantalSpaces/2)-1; space++)
                {
                    kerstboom[row, space] = " ";
                }
                //sterren, kerstballen en piek midden array
                for(int star = (aantalSpaces/2); star <= (aantalSpaces / 2) - 1 + aantalStars; star++)
                {
                    string bal = "o";

                    //gekende beginbal
                    if (row == 1)
                    {
                        kerstboom[1, (aantalSpaces / 2)] = bal;
                    }

                    //teller begint pas bij tweede rij
                    if (aantalStars > 1)
                    {
                        teller++;
                    }

                    //array vullen met *,o of +
                    if (!(aantalStars == 1))
                    {
                        if (!(teller % freqBalls == 0))
                        {
                            kerstboom[row, star] = "*";
                        }
                        else
                        {
                            kerstboom[row, star] = "o";
                        }
                    }
                    else
                    {
                        kerstboom[row, star] = "+";
                    }

                }
                //spaties rechterkant array
                for (int space = (aantalSpaces/2) + aantalStars; space <= cols-1; space++)
                {
                    kerstboom[row, space] = " ";
                }
            }

            //bouwen van de stam 
            for (int col = 0; col <= cols - 1; col++)
            {
                if(!(col == (cols/2)))
                {
                    kerstboom[rows, col] = " ";
                }
                else
                {
                    kerstboom[rows, col] = "|";
                }
            }

            //tekenen van de boom
            Console.WriteLine("---------------------------------------");

            for (int i = 0; i <= rows; i++)
            {
                for (int j = 0; j <= cols-1; j++)
                {
                    Console.Write(kerstboom[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("---------------------------------------");
        }
    }
}
