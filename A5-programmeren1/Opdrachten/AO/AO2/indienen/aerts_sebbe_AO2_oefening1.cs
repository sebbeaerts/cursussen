using System;


namespace Bibliotheek
{
    class Program
    {
        class Bibliotheek
        {
            private string _Naam;
            private Adres _Adres;
            
            public Bibliotheek(string naam, Adres adres)
            {
                this._Naam = naam;
                this._Adres = adres;
            }

            public string Naam { get { return _Naam; } }
            public Adres Adres { get { return _Adres; } }

            private int _Count = 0;
            private int _Teller = 0;

            private Boek[] _Boeken = new Boek[0];
            private Lid[] _Leden = new Lid[0];

            public Boek Item(int index)
            {
                return _Boeken[index];
            }
            public Lid Person(int index)
            {
                return _Leden[index];
            }

            public int GetCount()
            {
                return _Count;
            }
            public int GetTeller()
            {
                return _Teller;
            }

            public void Add(Boek boek)
            {
                _Count++;
                Array.Resize(ref _Boeken, GetCount());
                _Boeken[GetCount() - 1] = boek;
            }

            public void Add(Lid lid)
            {
                _Teller++;
                Array.Resize(ref _Leden, GetTeller());
                _Leden[GetTeller() - 1] = lid;
            }

            //Extra
            //
            public void PrintLeden()
            {
                Console.WriteLine("Lijst van alle leden:\n\r");
                Console.WriteLine("{0,-5}{1,10}{2,15}{3,20}","Lidnummer:","Naam:","Voornaam:","Gemeente:");
                foreach (Lid lid in _Leden)
                {
                    Console.WriteLine("{0,-5}{1,15}{2,15}{3,20}", lid.Lidnummer, lid.Naam, lid.Voornaam, lid.Adres.Gemeente);
                }
            }

            public void UitgeleendeBoeken()
            {
                Console.WriteLine("Lijst van alle uitgeleende boeken:\n\r");
                Console.WriteLine("{0,-5}{1,20}{2,30}", "Titel:", "Auteur:", "Uitgeleend door:");
                foreach (Boek boek in _Boeken)
                {
                    if(boek.IsUitgeleend())
                    {
                        Console.WriteLine("{0,-5}{1,20}{2,30}", boek.Titel, boek.Auteur.Naam, boek.UitgeleendDoor());
                    }
                }
            }

            public void ToonAlleBoeken()
            {
                Console.WriteLine("Lijst van alle boeken in de bib:\n\r");
                Console.WriteLine("{0,-5}{1,13}{2,20}", "Boeknummer:", "Titel:", "Auteur:");
                foreach (Boek boek in _Boeken)
                {
                    Console.WriteLine("{0,-5}{1,25}{2,25}", boek.Boeknummer, boek.Titel, boek.Auteur.Naam);
                }
            }
            //
        }
        class Auteur
        {
            //fields
            private string _Naam;
            private string _Voornaam;
            private Adres _Adres;

            //constructor
            public Auteur(string naam, string voornaam, Adres adres)
            {
                this._Naam = naam;
                this._Voornaam = voornaam;
                this._Adres = adres;
            }

            //properties
            public string Naam { get { return _Naam; } }
            public string Voornaam { get { return _Voornaam; } }
            public Adres Adres { get { return _Adres; } }
        }
        class Lid
        {
            //fields
            private int _Lidnummer;
            private string _Naam;
            private string _Voornaam;
            private Adres _Adres;

            //constructor
            public Lid(int lidnummer, string naam, string voornaam, Adres adres)
            {
                this._Lidnummer = lidnummer;
                this._Naam = naam;
                this._Voornaam = voornaam;
                this._Adres = adres;
            }

            public int Lidnummer { get { return _Lidnummer; } }
            public string Naam { get { return _Naam; } }
            public string Voornaam { get { return _Voornaam; } }
            public Adres Adres { get { return _Adres; }}
        }

        class Adres
        {
            //fields
            private string _Straat;
            private int _Nummer;
            private int _Postcode;
            private string _Gemeente;

            //constructor
            public Adres(string straat, int nummer, int postcode, string gemeente)
            {
                this._Straat = straat;
                this._Nummer = nummer;
                this._Postcode = postcode;
                this._Gemeente = gemeente;
            }

            //properties
            public string Straat { get { return _Straat; } }
            public int Nummer { get { return _Nummer; } }
            public int Postcode { get { return _Postcode; } }
            public string Gemeente { get { return _Gemeente; } }
        }

        class Boek
        {
            //fields
            private int _Boeknummer;
            private string _Titel;
            private Auteur _Auteur;

            private bool _Uitgeleend = false;
            private DateTime _Uitleendatum;
            private DateTime _UitersteUitleenDatum;
            private DateTime _Ontleendatum = DateTime.Now.Date;
            private int _Uitleenperiode = 21;
            private Lid _Lid;
            private double _Boete = 0.5;

            //constructor
            public Boek(int boeknummer, string titel, Auteur auteur)
            {
                this._Boeknummer = boeknummer;
                this._Titel = titel;
                this._Auteur = auteur;
            }

            //properties
            public int Boeknummer { get { return _Boeknummer; } }
            public string Titel { get { return _Titel; } }
            //public string Auteur { get { return _Auteur.Voornaam + " " + _Auteur.Naam; } }
            public Auteur Auteur { get { return _Auteur; } }

            public bool Uitgeleend { get { return _Uitgeleend; } }
            public DateTime Uitleendatum { get { return _Uitleendatum; } }
            public DateTime Uitgeleendtot { get { return _UitersteUitleenDatum; }}
            public int Uitleenperiode { get { return _Uitleenperiode; } }
            public DateTime Ontleendatum { get { return _Ontleendatum; } /*test only*/set { _Ontleendatum = value; } }
            //
            public string UitgeleendDoor()
            {
                return _Lid.Voornaam + " " + _Lid.Naam;
            }


            public void Uitlenen(Lid lid)
            {
                if (!IsUitgeleend())
                {
                    this._Lid = lid;
                    _Uitleendatum = DateTime.Now.Date;
                    _UitersteUitleenDatum = _Uitleendatum.Date.AddDays(_Uitleenperiode);
                    _Uitgeleend = true;
                }
            }

            public bool IsUitgeleend()
            {
                bool result = false;
                if(_Uitgeleend)
                {
                    result = true;
                }
                return result;
            }

            public string Ontlenen()
            {
                if(IsUitgeleend())
                {
                    if (_Ontleendatum > _UitersteUitleenDatum)
                    {
                        double aantaldagentelaat = Math.Abs(DateTime.Now.Date.Subtract(_UitersteUitleenDatum).TotalDays);
                        double boete = Math.Abs(aantaldagentelaat * _Boete);
                        return "Het boek is te laat binnengebracht.\n\r" +
                            "Einddatum: " + _UitersteUitleenDatum + "\n\r" +
                            "Datum van vandaag: " + _Ontleendatum + "\n\r" +
                            "Aantal dagen te laat: " + aantaldagentelaat + "\n\r" +
                            "Boete: " + boete;
                    }
                    _Uitgeleend = false;
                    this._Lid = null;
                    return "Het boek is correct binnengebracht.";
                }
                return "Het boek is niet uitgeleend.";
            }

        }
        static void Main(string[] args)
        {
            //bibliotheek aanmaken
            Bibliotheek bib1 = new Bibliotheek("de bib", new Adres("Hendrik Heymanplein", 3, 9100, "Sint-Niklaas"));
            //boeken aanmaken + toevoegen aan bib
            bib1.Add(new Boek(1022, "Schermerzone", new Auteur("Vandermeeren", "Hilde", new Adres("collegestraat", 2, 9100, "Sint-Niklaas"))));
            bib1.Add(new Boek(999, "Complexiteit", new Auteur("Delahaye", "Jean-Paul", new Adres("wittemolenstraat", 5, 9140, "Temse"))));
            bib1.Add(new Boek(200, "Mona", new Auteur("Sehlberg", "Dan", new Adres("bakerstreet", 221, 16, "London"))));
            bib1.Add(new Boek(333, "Ctrl Alt Delete", new Auteur("Suarez", "Daniel", new Adres("potterstraat", 88, 9170, "Sint-Gillis-Waas"))));
            bib1.Add(new Boek(101, "Logica voor informatica", new Auteur("Van Benthem", "J.F.A.K.", new Adres("vosdreef", 1, 9170, "Sint-Pauwels"))));
            bib1.Add(new Boek(2, "Cyberbabe", new Auteur("Verleyen", "Karel", new Adres("Gelaagstraat", 55, 9140, "Steendorp"))));

            //leden aanmaken
            Lid lid1 = new Lid(1, "Aerts", "Sebbe", new Adres("Lodewijk dosfelstraat", 1, 9100, "Sint-Niklaas"));
            Lid lid2 = new Lid(32, "Altamimi", "Ayman", new Adres("Lage Bokstraat", 22, 9100, "Brugge"));
            Lid lid3 = new Lid(8, "De Graeve", "Joeri", new Adres("Watermolenstraat", 12, 9100, "Antwerpen"));
            Lid lid4 = new Lid(700, "de man", "Jeroen", new Adres("Pijkedreef", 120, 9100, "Bornem"));
            Lid lid5 = new Lid(120, "De Parade", "Zino", new Adres("Hadewych", 36, 9100, "Puurs"));
            Lid lid6 = new Lid(77, "De Plucker", "Manuela", new Adres("Moortelhoekstraat", 41, 9100, "Eken"));
            Lid lid7 = new Lid(3, "De Schoesitter", "Nicky", new Adres("Arnhoutstraat", 55, 9100, "Roeselare"));
            ////leden toevoegen aan bib
            bib1.Add(lid1);
            bib1.Add(lid2);
            bib1.Add(lid3);
            bib1.Add(lid4);
            bib1.Add(lid5);
            bib1.Add(lid6);
            bib1.Add(lid7);


            //--Unit tests--
            //test class Bibliotheek
            Console.WriteLine(bib1.Naam == "de bib");
            Console.WriteLine("----------------------------------------------------------");
            bib1.ToonAlleBoeken();
            Console.WriteLine("----------------------------------------------------------");
            //test class Adres-Bibliotheek
            Console.WriteLine(bib1.Adres.Straat == "Hendrik Heymanplein");
            Console.WriteLine(bib1.Adres.Nummer == 3);
            Console.WriteLine(bib1.Adres.Postcode == 9100);
            Console.WriteLine(bib1.Adres.Gemeente == "Sint-Niklaas");
            //test class Boek
            bib1.Item(0).Uitlenen(lid1);
            bib1.Item(0).Uitlenen(lid2); /*2x hetzelfde boek uitlenen gaat niet*/
            Console.WriteLine(bib1.Item(0).UitgeleendDoor() == "Sebbe Aerts");
            bib1.Item(2).Uitlenen(lid5);
            bib1.Item(5).Uitlenen(lid5);
            Console.WriteLine(bib1.Item(2).UitgeleendDoor() == "Zino De Parade");
            Console.WriteLine(bib1.Item(5).UitgeleendDoor() == "Zino De Parade");
            Console.WriteLine("----------------------------------------------------------");
            bib1.UitgeleendeBoeken(); /*print alle uitgeleende boeken*/
            Console.WriteLine("----------------------------------------------------------");
            //test ontlenen boek
            //1
            Console.WriteLine(bib1.Item(0).Ontlenen() == "Het boek is correct binnengebracht.");
            //2 -manipulatie van datum om aan te tonen dat bij laat tijdig inbrengen boek een andere ouput krijgt- 
            bib1.Item(2).Ontleendatum = new DateTime(2018, 04, 18);
            string antwoord = bib1.Item(2).Ontlenen();
            Console.WriteLine(antwoord);
            //3 niet uitgeleende boeken kunnen niet ontleent worden
            antwoord = bib1.Item(1).Ontlenen();
            Console.WriteLine(antwoord == "Het boek is niet uitgeleend.");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine((bib1.Item(0).Auteur.Voornaam + " " + bib1.Item(0).Auteur.Naam) == "Hilde Vandermeeren");
            Console.WriteLine(bib1.Item(0).Titel == "Schermerzone");
            Console.WriteLine(bib1.Item(0).Boeknummer == 1022);
            Console.WriteLine("----------------------------------------------------------");
            //test class Lid
            Console.WriteLine(bib1.Person(0).Lidnummer == 1);
            Console.WriteLine(bib1.Person(0).Naam == "Aerts");
            Console.WriteLine(bib1.Person(0).Voornaam == "Sebbe");
            //test class Adres-Lid
            Console.WriteLine(bib1.Person(0).Adres.Straat == "Lodewijk dosfelstraat");
            Console.WriteLine(bib1.Person(0).Adres.Nummer == 1);
            Console.WriteLine(bib1.Person(0).Adres.Postcode == 9100);
            Console.WriteLine(bib1.Person(0).Adres.Gemeente == "Sint-Niklaas");
            //test class Auteur
            Console.WriteLine(bib1.Item(1).Auteur.Naam == "Delahaye");
            Console.WriteLine(bib1.Item(1).Auteur.Voornaam == "Jean-Paul");
            //test class Adres-Auteur
            Console.WriteLine(bib1.Item(1).Auteur.Adres.Straat == "wittemolenstraat");
            Console.WriteLine(bib1.Item(1).Auteur.Adres.Nummer == 5);
            Console.WriteLine(bib1.Item(1).Auteur.Adres.Postcode == 9140);
            Console.WriteLine(bib1.Item(1).Auteur.Adres.Gemeente == "Temse");
            //
            Console.WriteLine("----------------------------------------------------------");
            bib1.ToonAlleBoeken();
            Console.WriteLine("----------------------------------------------------------");
            bib1.UitgeleendeBoeken();
            Console.WriteLine("----------------------------------------------------------");
            bib1.PrintLeden();
            Console.WriteLine("----------------------------------------------------------");
            //
            Console.ReadLine();
        }
    }
}
