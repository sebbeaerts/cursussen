using System;


namespace Oefening_18._8._1
{
    class Personeelslid
    {
        public string Naam { get; private set; }
        Adres adres = new Adres();
    }

    class Adres
    {
        public string Straat { get; private set; }
        public int Huisnummer { get; private set; }
        public int Postcode { get; private set; }
        public string Gemeente { get; private set; }
    }

    class Manager : Personeelslid
    {
        Auto auto1 = new Auto();
    }

    class Auto
    {
        public string Merk { get; private set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Manager manager1 = new Manager();
        }
    }
}
