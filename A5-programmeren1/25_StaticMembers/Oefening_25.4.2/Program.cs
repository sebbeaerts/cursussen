using System;


namespace Oefening_25._4._2
{
    class Rechthoek
    {
        public Rechthoek(int hoogte, int breedte)
        {
            this.Hoogte = hoogte;
            this.Breedte = breedte;
        }

        public int Hoogte { get; set; }
        public int Breedte { get; set; }

        public int Oppervlakte()
        {
            return Hoogte * Breedte;
        }

        public static bool IsGroterDan(Rechthoek rechthoek)
        {
            bool result = false;
            if(recht)
            return result;
        }

        public static bool IsGrootste(Rechthoek rechthoek)
        {
            bool result = false;
            if (recht)
                return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rechthoek rechthoek1 = new Rechthoek(20, 30);
            Rechthoek rechthoek2 = new Rechthoek(10, 20);
            //
            Console.WriteLine(rechthoek1.Oppervlakte());
            Console.WriteLine(rechthoek2.Oppervlakte());
            //
            Console.WriteLine(rechthoek1.IsGroterDan(rechthoek2)==true);
            Console.WriteLine(rechthoek2.IsGroterDan(rechthoek1)==false);
            //
            Console.WriteLine(Rechthoek.IsGrootste(rechthoek1,rechthoek2)==rechthoek1);
            //
            Console.ReadLine();
        }
    }
}
