using System;


namespace Voorbeeld
{
    class Program
    {
        static void Main(string[] args)
        {

            Stoel stoel1 = new Stoel("rood",4);
            Console.WriteLine(stoel1.GetKleur());
            Console.WriteLine(stoel1.GetAantalPoten());

            Stoel stoel2 = new Stoel();
            stoel2.kleur = "geel";
            //
            Console.ReadLine();
        }
    }

    class Stoel
    {
        //fields
        private string _Kleur;
        private int _AantalPoten;

        //constructor
        public Stoel(string kleur, int aantalPoten)
        {
            _Kleur = kleur;
            _AantalPoten = aantalPoten;
        }

        //getters
        public string GetKleur()
        {
            return _Kleur;
        }

        public int GetAantalPoten()
        {
            return _AantalPoten;
        }

        //setters
        public void SetKleur(string kleur)
        {
            _Kleur = kleur;
        }

        public void SetAantalPoten(int aantalPoten)
        {
            _AantalPoten = aantalPoten;
        }
    }
}
