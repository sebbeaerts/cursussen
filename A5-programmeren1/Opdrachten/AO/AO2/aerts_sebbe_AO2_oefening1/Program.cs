using System;


namespace aerts_sebbe_AO2_oefening1
{
    class Bibliotheek
    {
        private int _Count = 0;

        private Boek[] _Items = new Boek[0];
        public Boek Item(int index)
        {
            return _Items[index];
        }

        public int GetCount()
        {
            return _Count;
        }
        public void Add (Boek boek)
        {
            _Count++;
            Array.Resize(ref _Items, GetCount());
            _Items[GetCount() - 1] = boek;
        }

        private Adres _Adres;
        public void SetAdres(Adres value)
        {
            _Adres = value;
        }
        public Adres GetAdres()
        {
            return _Adres;
        }
    }
    class Auteur : Adres
    {
        public Auteur(string naam, string voornaam, string straat, int nummer, int postcode, string gemeente) : base(straat, nummer, postcode, gemeente)
        {
            this.Naam = naam;
            this.Voornaam = voornaam;
        }

        public string Naam { get; set; }
        public string Voornaam { get; set; }
    }

    class Lid : Adres
    {
        public Lid(int lidnummer, string naam, string voornaam, string straat, int nummer, int postcode, string gemeente) : base(straat, nummer, postcode, gemeente)
        {
            this.Lidnummer = lidnummer;
            this.Naam = naam;
            this.Voornaam = voornaam;
        }

        public int Lidnummer { get; set; }
        public string Naam { get; set; }
        public string Voornaam { get; set; }
    }

    class Adres
    {
        public Adres(string straat, int nummer, int postcode, string gemeente)
        {
            this.Straat = straat;
            this.Nummer = nummer;
            this.Postcode = postcode;
            this.Gemeente = gemeente;
        }

        public string Straat { get; set; }
        public int Nummer { get; set; }
        public int Postcode { get; set; }
        public string Gemeente { get; set; }
    }

    class Boek : Auteur
    {
        public Boek(int isbnummer, string titel, string naam, string voornaam, string straat, int nummer, int postcode, string gemeente) : base(naam, voornaam, straat, nummer, postcode, gemeente)
        {
            this.ISBnummer = isbnummer;
            this.Titel = titel;
        }

        public int ISBnummer { get; set; }
        public string Titel { get; set; }

        private Lid _Lid;
        public void SetLid(Lid value)
        {
            _Lid = value;
        }
        public Lid GetLid()
        {
            return _Lid;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Boek b1 = new Boek(15572022, "De schaduw", "Aerts", "Sebbe", "Lodewijk dosfelstraat", 1, 9100, "Sint-Niklaas");
            Boek b2 = new Boek(15572025, "De moord", "Aerts", "Sebbe", "Lodewijk dosfelstraat", 1, 9100, "Sint-Niklaas");
            //
            Adres adresbib = new Adres("Lodewijk dosfelstraat", 1, 9100, "Sint-Niklaas");

            Bibliotheek bib = new Bibliotheek();
            bib.SetAdres(adresbib);
            //
            Console.WriteLine(bib.GetAdres().Straat);
            Console.WriteLine(bib.GetAdres().Nummer);
            Console.WriteLine(bib.GetAdres().Postcode);
            Console.WriteLine(bib.GetAdres().Gemeente);
            //

            Console.WriteLine(bib.GetCount());
            //
            bib.Add(b1);
            bib.Add(b2);
            Console.WriteLine(bib.GetCount());
            Console.WriteLine(bib.Item(0).Titel);
            Console.WriteLine(bib.Item(1).Titel);

            //
            Console.ReadLine();
        }
    }
}
